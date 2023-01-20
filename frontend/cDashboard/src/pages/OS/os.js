import { useState, useEffect } from "react";
import BarC from "../../components/BarC/barc";
import LabelC from "../../components/LabelC/labelc";
import LabelOS from "../../components/LabelOS/labelOS";
import LineC from "../../components/LineC/linec";
import TableC from "../../components/TableC/tablec";
import api from "../../services/api";
import { useSelector } from "react-redux";
import Loading from "../../components/Loading/loading"
import noData from "../../assets/nodatamsg.svg";


export default function Os() {
    const [loading, setLoading] = useState(true);
    const [ordemServicos, setOrdemServicos] = useState([])
    const [responseData, setResponseData] = useState([])


    const filtro = useSelector(state => state.data)

    useEffect(() => {
        console.log(filtro)
        setLoading(true)
    }, [filtro])

    useEffect(() => {
        async function getDadosFiltro() {

            const response = await api.post('OrdemServicos/parametros', {
                CidadeId: 10,
                natureza: filtro.natureza,
                equipe: filtro.equipe,
                Mes: parseInt(filtro.mes),
                Ano: parseInt(filtro.ano)
            })

            setResponseData(response.data);
            console.log(responseData)

            setLoading(false);
        }
        getDadosFiltro()

    }, [filtro])


    useEffect(() => {
        if (responseData.length > 0) {

            if (responseData[0].mes !== null) {
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

                setOrdemServicos([dadosLabel1, dadosLabel2, dadosLabel3, dadosLabel4, dadosLabel5, dadosLabel6])
                
            }
        }
        console.log(ordemServicos)
    }, [responseData])

    if (loading) {
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
                {ordemServicos.map((ordemServico) => {
                    return (
                        <div key={ordemServico.nome} className="twoinone">
                            <LabelOS dados={ordemServico}></LabelOS>
                        </div>
                    )
                })}
            </div>
        </div>
    )

}