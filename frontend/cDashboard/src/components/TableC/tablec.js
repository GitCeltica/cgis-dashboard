export default function TableC (dados){

    const data = (dados.dados);

    return(
        <div className="tablec">
            <label>Sumário</label>
            <div>
                <table>
                    <tbody>

                    {data.map(index => {
                        return(
                        <tr key={index.name}>
                        <th>{index.name}</th>
                        <td>{ index.name === "Percentual de Clientes com Esgoto Tratado"? index.valor : Number(Math.round(index.valor+'e2')+'e-2').toLocaleString('pt-BR') } </td>
                        </tr>
                        )
                    })}
                    </tbody>
                </table>
            </div>
        </div>
    )
}