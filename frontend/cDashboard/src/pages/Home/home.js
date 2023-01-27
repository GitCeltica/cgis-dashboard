import wellcome from "../../assets/wellcomemsg.svg";

export default function Home() {

    // console.log(t.toFixed(0))

    return (
        <div className="content">

            <h1 className="wellcome">
                {/* <img className="loginMsg" src={wellcome} alt="Bem-vindo"/> */}
                <label> Bem-vindo ao Dashboard Gerencial do cGIS Saneamento!</label>

                <br></br><br></br><br></br>
                
                <div>
                <p> Aqui estão disponíveis indicadores para os assuntos abaixo:</p>
                <br></br>
                    <p>● Perdas</p>
                    <p>● Dados Técnicos</p>
                    <p>● Ordens de Serviço</p>
                    <br></br>
                <p>Utilize o menu lateral para navegar entre eles.</p>
                <p>👈</p>
                </div>
                
            </h1>

        </div>
    )
}