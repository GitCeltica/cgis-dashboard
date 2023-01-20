export default function LabelOS (dados){
    console.log(dados)
    const data = (dados.dados);

    return(
        <div className="labelc">
           
            <label>{data.name}</label>
            <div>
                <span className="valor">
                    {data.name === "Custo Medio" ? ((data.data).toLocaleString('pt-br',{style: 'currency', currency: 'BRL'})) : ((data.data))                }
                </span>
                {data.name === "Tempo médio correções OS de vazamento" || data.name === "Tempo Medio" ? (
                    <span className="medida">min</span>
                ) : (
                    null
                ) }
            </div>
        </div>
    );
}