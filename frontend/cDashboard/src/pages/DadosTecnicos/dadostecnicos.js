import { useState, useEffect } from "react";
import BarC from "../../components/BarC/barc";
import LabelC from "../../components/LabelC/labelc";
import LineC from "../../components/LineC/linec";
import TableC from "../../components/TableC/tablec";
import LabelDadosTecnicos from '../../components/LabelDadosTecnicos'
import BarDadosTecnicos from "../../components/BarDadosTecnicos";
import api from "../../services/api";
import { useSelector } from "react-redux";
import Loading from "../../components/Loading/loading"

export default function DadosTecnicos (){
    const [loading, setLoading] = useState(true);
    const [dadosTecnicos, setDadosTecnicos] = useState([])
    const [dadosTecnicosEsgoto, setDadosTecnicosEsgoto] = useState([])
    const [responseData, setResponseData] = useState([])

    const filtro = useSelector(state => state.data)

    useEffect(()=>{
        console.log(filtro)
        setLoading(true)
    }, [filtro])

    useEffect(() => {
        async function getDadosFiltro() {
            //2021 mes 3
            console.log(filtro)
            const response = await api.post('dadostecnicos/parametros',{
                CidadeId: 10,
                Mes: parseInt(filtro.mes),
                Ano: parseInt(filtro.ano),
                // Mes: 0,
                // Ano: 2021,
                Regiao: ''
            })

            setResponseData(response.data);
            //console.log(response.data)

            setLoading(false);
        }
        getDadosFiltro()

    },[filtro])


    useEffect(()=>{
        const orderByMes = responseData.sort((a, b) => (a.mes > b.mes) ? 1 : -1);
        const mesesSigla = ["JAN", "FEV", "MAR", "ABR", "MAI", "JUN", "JUL", "AGO", "SET", "OUT", "NOV", "DEZ"];

        

        // console.log(responseData)
 
        
        const dadosAgua = responseData.filter(function(item)
        {
            if (item.tipoDado === 'A')
            {
                return item 
            }
        })

        const dadosEsgoto = responseData.filter(function(item)
        {
            if (item.tipoDado === 'E')
            {
                return item 
            }
        })


        /*

            EXTENSAO POR DIAMETRO AGUA
        */

        let diametrosArray = []
        let diametroValores = []

        
        for(var i =0; i < responseData.length; i++)
        {

            if (! diametrosArray.includes(responseData[i].diametro))
            {
                diametrosArray.push(responseData[i].diametro)
            }
        }

        for(var i=0; i < diametrosArray.length; i++)
        {
            diametroValores.push({name: diametrosArray[i], valor: 0})
        }

        for(var i =0; i < dadosAgua.length; i++)
        {
            for(var j=0; j < diametroValores.length; j++)
            {
                if(dadosAgua[i].diametro === diametroValores[j].name)
                {
                    diametroValores[j].valor = diametroValores[j].valor + dadosAgua[i].extensao;
                }
            }
        }

        const dadoGrafico1 = {
            name: "Extensão Rede Agua por Diametro",
            data: diametroValores
        }

        /*
            EXTENSAO POR MATERIAL AGUA
        */

            let materialArray = []
            let materialValores = []

            for(var i=0; i < responseData.length; i++)
            {
                if(! materialArray.includes(responseData[i].material))
                {
                    materialArray.push(responseData[i].material)
                }
            }

            for(var i=0; i <materialArray.length; i++)
            {
                materialValores.push({name: materialArray[i], valor: 0})
            }

            for(var i =0; i < dadosAgua.length; i++)
            {
                for(var j=0; j < materialValores.length; j++)
                {
                    if(dadosAgua[i].material === materialValores[j].name)
                    {
                        materialValores[j].valor = materialValores[j].valor + dadosAgua[i].extensao;
                    }
                }
            }

        const dadoGrafico2 ={
            name: "Extensão Rede Agua por Material",
            data: materialValores
        }

        /*
            EXTENSAO POR TIPO 
        */

            let tipoValores = []
            let tiposArray = []

            for(var i=0; i < responseData.length; i++)
            {
                if(! tiposArray.includes(responseData[i].tipo))
                {
                    tiposArray.push(responseData[i].tipo)
                }
            }

            for(var i=0; i < tiposArray.length; i++)
            {
                tipoValores.push({name: tiposArray[i], valor: 0})
            }

            for(var i =0; i < dadosAgua.length; i++)
            {
                for(var j=0; j < tipoValores.length; j++)
                {
                    if(dadosAgua[i].tipo === tipoValores[j].name)
                    {
                        tipoValores[j].valor = tipoValores[j].valor + dadosAgua[i].extensao;
                    }
                }
            }

            const dadoGrafico3 ={
                name: "Extensão Rede Agua por Tipo",
                data: tipoValores
            }



            /*

            EXTENSAO POR DIAMETRO ESGOTO 
            */
            let diametroValoresEsgoto = []

    
            for(var i=0; i < diametrosArray.length; i++)
            {
                diametroValoresEsgoto.push({name: diametrosArray[i], valor: 0})
            }


            for(var i =0; i < dadosEsgoto.length; i++)
            {
                for(var j=0; j < diametroValoresEsgoto.length; j++)
                {
                    if(dadosEsgoto[i].diametro === diametroValoresEsgoto[j].name)
                    {
                        diametroValoresEsgoto[j].valor = diametroValoresEsgoto[j].valor + dadosEsgoto[i].extensao;
                    }
                }
            }

            const dadoGrafico4 = {
                name: "Extensão Rede Esgoto por Diametro",
                data: diametroValoresEsgoto
            }

                    /*
            EXTENSAO POR MATERIAL ESGOTO
        */

            let materialValoresEsgoto = []


            for(var i=0; i <materialArray.length; i++)
            {
                materialValoresEsgoto.push({name: materialArray[i], valor: 0})
            }

            for(var i =0; i < dadosEsgoto.length; i++)
            {
                for(var j=0; j < materialValoresEsgoto.length; j++)
                {
                    if(dadosEsgoto[i].material === materialValoresEsgoto[j].name)
                    {
                        materialValoresEsgoto[j].valor = materialValoresEsgoto[j].valor + dadosEsgoto[i].extensao;
                    }
                }
            }

        const dadoGrafico5 ={
            name: "Extensão Rede Esgoto por Material",
            data: materialValoresEsgoto
        }

        /*
            EXTENSAO POR TIPO ESGOTO
        */

            let tipoValoresEsgoto = []

            for(var i=0; i < tiposArray.length; i++)
            {
                tipoValoresEsgoto.push({name: tiposArray[i], valor: 0})
            }

            for(var i =0; i < dadosEsgoto.length; i++)
            {
                for(var j=0; j < tipoValoresEsgoto.length; j++)
                {
                    if(dadosEsgoto[i].tipo === tipoValoresEsgoto[j].name)
                    {
                        tipoValoresEsgoto[j].valor = tipoValoresEsgoto[j].valor + dadosEsgoto[i].extensao;
                    }
                }
            }

            const dadoGrafico6 ={
                name: "Extensão Rede Esgoto por Tipo",
                data: tipoValoresEsgoto
            }

        // {console.log(dadoGrafico1)}
        setDadosTecnicos([dadoGrafico1, dadoGrafico2, dadoGrafico3])
        setDadosTecnicosEsgoto([dadoGrafico4, dadoGrafico5, dadoGrafico6])
    }, [responseData])




    if(loading){
        return(
            <Loading/>
        )
        
    }
    return(

        
        <div className="content">
            <div className="content-top">
                
                {dadosTecnicos.map( (dadosTecnicos) =>{
                    return(
                       
                        
                            <div key={dadosTecnicos.name} className="twoinonedt">
                                <BarDadosTecnicos dados={dadosTecnicos}></BarDadosTecnicos>
                            </div>
                           
                        
                    )
                })}
            </div>
            <div className="content-top">
            {dadosTecnicosEsgoto.map( (dadosTecnicosEsgoto) =>{
                    return(
                       
                        
                            <div key={dadosTecnicosEsgoto.name} className="twoinonedt">
                                <BarDadosTecnicos dados={dadosTecnicosEsgoto}></BarDadosTecnicos>
                            </div>
                           
                        
                    )
                })}
            </div>
        </div>
    )
}