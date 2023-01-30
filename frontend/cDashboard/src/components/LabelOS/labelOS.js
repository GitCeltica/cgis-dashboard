export default function LabelOS (dados){
    // console.log(dados)
    const data = (dados.dados);

    return(
        <div className="labelos">
           
            <label>{data.name}</label>
            <div>
                <span className="valor">
                    {data.name === "Custo Medio" ? ((data.data).toLocaleString('pt-br',{style: 'currency', currency: 'BRL'})) : (parseFloat((data.data).toFixed(2)).toLocaleString('pt-br')) }
                    {/* {data.name === "Custo Medio" ? ((data.data).toLocaleString('pt-br',{style: 'currency', currency: 'BRL'})) : ((data.data).toLocaleString('pt-br')) } */}

                </span>
                {data.name === "Tempo médio correções OS de vazamento" || data.name === "Tempo Medio" || data.name === "Distancia Media"  ? (
                   data.name === "Distancia Media" ? (<span className="medida">km</span>) : (<span className="medida">min</span>) 
                ) : (
                    null
                ) }
               
            </div>
        </div>
    );
}