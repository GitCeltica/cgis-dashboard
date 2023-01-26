import { useState, useEffect } from "react";
import BarC from "../../components/BarC/barc";
import LabelC from "../../components/LabelC/labelc";
import LineC from "../../components/LineC/linec";
import TableC from "../../components/TableC/tablec";
import api from "../../services/api";
import Loading from "../../components/Loading/loading"
import { useSelector } from "react-redux";
import noData from "../../assets/nodatamsg.svg";


export default function Perdas() {
    const [perdas, setPerdas] = useState([]);
    const [lineData, setLineData] = useState([]);
    const [tableData, setTableData] = useState([]);
    const [loading, setLoading] = useState(true);
    const [responseData, setResponseData] = useState([]);

    const filtro = useSelector(state => state.data);

    useEffect(() => {
        // console.log(filtro);
        setLoading(true)
    }, [filtro])

    useEffect(() => {
        async function getDadosFiltro() {

            const response = await api.post('perdas/Parametros', {
                CidadeId: 10,
                Mes: parseInt(filtro.mes),
                Ano: parseInt(filtro.ano),
                Regiao: filtro.bairro
            })

            setResponseData(response.data);
            console.log(responseData.map(index => {
                return {
                    index: index,
                    valor: index.tempoMedioCorrecao < 0 ? index.tempoMedioCorrecao : null
                }
            }))
            // if(responseData.length === 0){
            //     setTimeout(()=> {
            //         setLoading(false);
            //     }, 30000)
            // }else{
            //     setLoading(false);
            // }
            setLoading(false);

        }
        getDadosFiltro()

    }, [filtro])


    useEffect(() => {

        const orderByMes = responseData.sort((a, b) => (a.mes > b.mes) ? 1 : -1);

        const mesesSigla = ["JAN", "FEV", "MAR", "ABR", "MAI", "JUN", "JUL", "AGO", "SET", "OUT", "NOV", "DEZ"];

        const dadoGrafico1 = {
            name: "NºOS de Vazamento p/km de rede",
            data: ((orderByMes.map(({ mes, vazamentosKMRDA }) => ({ name: mesesSigla[mes - 1], valor: vazamentosKMRDA }))).reduce((a, c) => {
                let x = a.find(e => e.name === c.name)
                if (!x) a.push(Object.assign({}, c))
                else x.valor += c.valor
                return a
            }, [])).map(index => ({
                name: index.name,
                valor: parseFloat(index.valor.toFixed(1))
                //valor: parseFloat(Math.ceil(index.valor))
            })),
        };

        const dadoGrafico2 = {
            name: "NºOS de Vazamento p/ligações",
            data: (orderByMes.map(({ mes, vazamentoLigacoes }) => ({ name: mesesSigla[mes - 1], valor: vazamentoLigacoes })).reduce((a, c) => {
                let x = a.find(e => e.name === c.name)
                if (!x) a.push(Object.assign({}, c))
                else x.valor += c.valor
                return a
            }, [])).map(index => ({
                name: index.name,
                valor: parseFloat(index.valor.toFixed(3))
                //valor: parseFloat(Math.ceil(index.valor))
            }))
        };

        var contadorPorMes  = [... (orderByMes.map(({ mes, tempoMedioCorrecao }) => ({ name: mesesSigla[mes - 1], valor: tempoMedioCorrecao }))).reduce((mp, o) => {
            if (!mp.has(o.name)) mp.set(o.name, { ...o, count: 0 });
            mp.get(o.name).count++;
            return mp;
        }, new Map).values()];

        const dadoGrafico3 = {
            name: "Tempo médio correções OS de vazamento",
            data: (orderByMes.map(({ mes, tempoMedioCorrecao }) => ({ name: mesesSigla[mes - 1], valor: tempoMedioCorrecao }))).reduce((a, c) => {

              let d = contadorPorMes.find(d => d.name === c.name)
                if (c.valor < 0) c.valor = 0;
                let x = a.find(e => e.name === c.name)
                if (!x) a.push(Object.assign({}, c))
                else {
                    x.valor += c.valor / d.count
                }
                return a
            }, []).map(index => ({
                name: index.name,
                valor: parseFloat(index.valor.toFixed(2)),
            })),
            // total: dg3.data.reduce((acc, d) => acc + d.total, 0 )
            total: (orderByMes.map(({ mes, tempoMedioCorrecao }) => ({ name: mesesSigla[mes - 1], valor: tempoMedioCorrecao }))).reduce((a, c) => a + (c.valor < 0 ? 0 : c.valor) / responseData.length, 0)

            // data.data.reduce((acc, d) => acc + d.valor, 0 )
        };

        console.log('dadoGrafico3')
        console.log(dadoGrafico3)
        setPerdas([dadoGrafico1, dadoGrafico2, dadoGrafico3]);

    }, [responseData])

    useEffect(() => {
        if (perdas.length > 1) {

            if (perdas[0].data.length > 0) {

                const line1 = perdas[0].data.map(item => {
                    return {
                        name: item.name,
                        "NºOS de Vazamento p/km de rede": item.valor,
                    };
                });

                const line2 = perdas[1].data.map(item => {
                    return {
                        name: item.name,
                        "NºOS de Vazamento p/ligações": item.valor,
                    };
                });

                const line3 = perdas[2].data.map(item => {
                    return {
                        name: item.name,
                        "Tempo médio correções OS de vazamento": item.valor,
                    };
                });

                setLineData((line1.map((item, i) => Object.assign({}, item, line2[i]))).map((item, i) => Object.assign({}, item, line3[i])));

                const data1 = {
                    name: "NºOS de Vazamento p/km de rede",
                    valor: perdas[0].data.reduce((acc, d) => acc + d.valor, 0)
                }
                const data2 = {
                    name: "NºOS de Vazamento p/ligações",
                    valor: perdas[1].data.reduce((acc, d) => acc + d.valor, 0)
                }
                const data3 = {
                    name: "Tempo médio correções OS de vazamento",
                    valor: perdas[2].total
                }
                const data4 = {
                    name: "Idade média hidrometros",
                    valor: responseData.reduce((acc, d) => acc + d.idadeMediaHidrometros / responseData.length, 0).toFixed(2)
                }
                const data5 = {
                    name: "Infrações confirmadas",
                    valor: responseData.reduce((acc, d) => acc + d.infracoesConfirmadas, 0)
                }

                setTableData([data1, data2, data3, data4, data5])
            }
        }

    }, [perdas])

    //   console.log(perdas)

    if (loading === true) {
        return (
            <Loading />
        )
    }

    if (responseData.length === 0 && loading === false) {
        return (
            <div className="content">
                <h1 className="nodata">
                    <div  >
                        <label>Oops!</label>
                        <label>Dados Indisponíveis</label>
                    </div>
                    <img src={noData} alt="No data" />
                </h1>
            </div>
        )
    }
    return (
        <div className="content">
            <div className="content-top">
                {perdas.map((perda) => {
                    return (
                        <div key={perda.nome} className="twoinone">
                            <LabelC dados={perda}></LabelC>
                            <BarC dados={perda}></BarC>
                        </div>
                    )
                })}
            </div>
            <div className="content-bottom">
                <div className="lc">
                    <LineC dados={lineData}></LineC>
                </div>
                <div className="t">
                    <TableC dados={tableData}></TableC>
                </div>
            </div>
        </div>
    )
}