import { useState, useEffect } from "react";
import LabelOS from "../../components/LabelOS/labelOS";
import api from "../../services/api";
import { useSelector } from "react-redux";
import Loading from "../../components/Loading/loading"
import noData from "../../assets/nodatamsg.svg";


export default function Os() {
    const [loading, setLoading] = useState(true);
    const [responseData, setResponseData] = useState([]);
    const [responseData2, setResponseData2] = useState([]);
    const [responseData3, setResponseData3] = useState([]);
    const [responseData4, setResponseData4] = useState([]);
    const [ordemServicosTop, setOrdemServicosTop] = useState([]);
    const [ordemServicosBottom, setOrdemServicosBottom] = useState([]);
    const [bairrosAfetados, setBairrosAfetados] = useState([]);
    const [materiaisGastos, setMateriaisGastos] = useState([]);


    const filtro = useSelector(state => state.data);

    useEffect(() => {
        // console.log(filtro)
        setLoading(true)
    }, [filtro])

    useEffect(() => {
        async function getDadosFiltro() {
            const response = await api.post('ordemServicos/parametros', {
                CidadeId: 10,
                Natureza: filtro.natureza,
                Equipe: filtro.equipe,
                Mes: parseInt(filtro.mes),
                Ano: parseInt(filtro.ano)
            })

            const response2 = await api.post('ordemServicosRanking/RegioesAfetadas/parametros', {
                CidadeId: 10,
                Natureza: filtro.natureza,
                Equipe: filtro.equipe,
                Regiao: '',
                Mes: parseInt(filtro.mes),
                Ano: parseInt(filtro.ano)
            })

            const response3 = await api.post('ordemServicosRanking/MaterialGasto/parametros', {
                CidadeId: 10,
                Natureza: filtro.natureza,
                Equipe: filtro.equipe,
                Regiao: '',
                Mes: parseInt(filtro.mes),
                Ano: parseInt(filtro.ano)
            })

            const response4 = await api.post('ordemServicosRanking/EconomiaTotalGerada/parametros', {
                CidadeId: 10,
                Natureza: filtro.natureza,
                Equipe: filtro.equipe,
                Regiao: '',
                Mes: parseInt(filtro.mes),
                Ano: parseInt(filtro.ano)
            })

            setResponseData(response.data);
            setResponseData2(response2.data);
            setResponseData3(response3.data);
            setResponseData4(response4.data);

            setLoading(false);

        }
        getDadosFiltro()

    }, [filtro])


    useEffect(() => {

        const dadosLabel1 = {
            name: "Quantidade OS",
            data: responseData.reduce((tot, arr) => tot + arr.qtdOS, 0)
        }
        const dadosLabel2 = {
            name: "Quantidade OS no Prazo",
            data: responseData.reduce((tot, arr) => tot + arr.qtdOSPrazo, 0)
        }
        const dadosLabel3 = {
            name: "Quantidade OS Fora do Prazo",
            data: responseData.reduce((tot, arr) => tot + arr.qtdOSForaPrazo, 0)
        }
        const dadosLabel4 = {
            name: "Custo Medio",
            data: responseData.reduce((tot, arr) => tot + arr.custoMedio, 0)
        }
        const dadosLabel5 = {
            name: "Distancia Media",
            data: responseData.reduce((tot, arr) => tot + arr.distanciaMedia, 0)
        }
        const dadosLabel6 = {
            name: "Tempo Medio",
            data: responseData.reduce((tot, arr) => tot + arr.tempoMedio, 0)
        }

        setOrdemServicosTop([dadosLabel1, dadosLabel2, dadosLabel3])
        setOrdemServicosBottom([dadosLabel4, dadosLabel5, dadosLabel6])

    }, [responseData])


    useEffect(() => {

        const top5Bairro = responseData2.reduce((a, c) => {
            let x = a.find(e => e.regiao === c.regiao)
            if (!x) a.push(Object.assign({}, c))
            else x.quantidadeOs += c.quantidadeOs
            return a
        }, []).sort((a, b) => b.quantidadeOs - a.quantidadeOs).slice(0, 5)
        setBairrosAfetados(top5Bairro)
    }, [responseData2])

    useEffect(() => {

        const top5Materiais = responseData3.reduce((a, c) => {
            let x = a.find(e => e.material === c.material)
            if (!x) a.push(Object.assign({}, c))
            else x.quantidadeMaterial += c.quantidadeMaterial
            return a
        }, []).sort((a, b) => b.quantidadeMaterial - a.quantidadeMaterial).slice(0, 5)
        setMateriaisGastos(top5Materiais)
    }, [responseData3])


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
                {ordemServicosTop.map((ordemServicoTop) => {
                    return (
                        <div key={ordemServicoTop.nome} className="twoinone">
                            <LabelOS dados={ordemServicoTop}></LabelOS>
                        </div>
                    )
                })}
            </div>
            <div className="content-top" >
                {ordemServicosBottom.map((ordemServicosBottom) => {
                    return (
                        <div key={ordemServicosBottom.nome} className="twoinone">
                            <LabelOS dados={ordemServicosBottom}></LabelOS>
                        </div>
                    )
                })}
            </div>
            <div className="content-top" >
                <div className="twoinone">
                    <div className="labelos">
                        <span className="valor">Bairros mais afetados</span>
                        <br></br><br></br>
                        {bairrosAfetados.map((bairroAfetado) => {
                            return (
                                <div key={bairroAfetado.index}>
                                    <span>{bairrosAfetados.indexOf(bairroAfetado) + 1}-{bairroAfetado.regiao}→{bairroAfetado.quantidadeOs}x</span>
                                </div>
                            )
                        })}

                    </div>
                </div>
                <div className="twoinone">
                    <div className="labelos">
                        <span className="valor">Top 5 Materias gastos</span>
                        <br></br><br></br>
                        {materiaisGastos.map((materialGasto) => {
                            return (
                                <div key={materialGasto.material}>
                                    <span>{materiaisGastos.indexOf(materialGasto) + 1}-{materialGasto.material}→{materialGasto.quantidadeMaterial}Und</span>
                                </div>
                            )
                        })}

                    </div>
                </div>
                <div className="twoinone">
                    <div className="labelos">
                        <label>Economia gerada através do uso da plataformacGIS Saneamento OS Online</label>
                        <div>
                            <span className="valor">{((responseData4).toLocaleString('pt-br', { style: 'currency', currency: 'BRL' }))}</span>
                        </div>
                    </div>
                </div>


            </div>
        </div>
    )

}