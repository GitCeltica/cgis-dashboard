import wellcome from "../../assets/wellcomemsg.svg";

export default function Home (){

    // console.log(t.toFixed(0))

    return(
        <div className="content">
             
                <h1 className="nodata">
                <img className="loginMsg" src={wellcome} alt="Bem-vindo"/>
                </h1>
            
        </div>
    )
}