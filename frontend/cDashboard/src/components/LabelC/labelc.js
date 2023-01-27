export default function LabelC (dados){

    const data = (dados.dados);
    console.log (data)

    return(
        <div className="labelc">
           
            <label>{data.name}</label>
            <div>
                <span className="valor">
                {data.name === "Tempo médio correções OS de vazamento" ? (Number(Math.round(data.total +'e2')+'e-2')) :(Number(Math.round( (data.data.reduce((acc, d) => acc + d.valor, 0 )) +'e2')+'e-2')) }
                </span>
                {data.name === "Tempo médio correções OS de vazamento" ? (
                    <span className="medida">min</span>
                ) : (
                    null
                ) }
            </div>
        </div>
    );
}