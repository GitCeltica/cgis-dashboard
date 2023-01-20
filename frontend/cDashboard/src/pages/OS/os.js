import { useState, useEffect } from "react";
import BarC from "../../components/BarC/barc";
import LabelC from "../../components/LabelC/labelc";
import LineC from "../../components/LineC/linec";
import TableC from "../../components/TableC/tablec";
import api from "../../services/api";
import { useSelector } from "react-redux";
import Loading from "../../components/Loading/loading"

export default function Os (){
    const [loading, setLoading] = useState(true);
    const [ordemServico, setOrdemServico] = useState([])
    const [responseData, setResponseData] = useState([])

    
    const filtro = useSelector(state => state.data)

    useEffect(()=>{
        console.log('hello world')
        console.log(filtro)
        setLoading(true)
    }, [filtro])

    useEffect(() => {
        async function getDadosFiltro() {

            const response = await api.post('OrdemServicos/parametros',{
                CidadeId: 10,
                natureza: '',
                equipe: '',
                Mes: 0,
                Ano: 0
            })

            setResponseData(response.data);
            console.log(responseData)

            setLoading(false);
        }
        getDadosFiltro()

    },[])


    useEffect(() => {

    }, [responseData])

    if(loading){
        return(
            <Loading/>
        )
        
    }
    return(
        <div className="content">
        </div>
    )

}