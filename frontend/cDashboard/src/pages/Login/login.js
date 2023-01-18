
import {useState} from 'react'



import './login.css'
import logo from '../../assets/logo.svg'
import eyeOpen from '../../assets/eye-open.svg'
import eyeClose from '../../assets/eye-close.svg'


function Login(props) {

  const [usuario, setUsuario] = useState("")
  const [senha, setSenha] = useState("")

  const [showPassword, setShowPassword] = useState(false)
  const [passwordInput, setPasswordInput] = useState("password")
 

  const contas = [
    {
        user: 'daniel',
        pass: '1234'
    },
    {
        user: 'pirapora',
        pass: '123'
    },
    {
        user: 'admin',
        pass: '1234'
    },
]
  
function handleLogin(e){
    e.preventDefault()
    var index = contas.findIndex(p => p.user === usuario && p.pass === senha );
    if(index < 0){
        alert("usuario ou senha invalidos!")
    }else{
        props.onSubmit(!false)
    }        
}

function changeUsuario(e){
    setUsuario(e.target.value);
}

function changeSenha(e){
    setSenha(e.target.value);
}



  return (
    <div className="container">
      <div className="container-login">
        <div className="wraper-login">
          <form className="login-form" onSubmit={(e) => handleLogin(e)} value={props.logged}>

              <span className="login-form-title">
                <img src={logo} alt="Céltica"/>
              </span>

              <div className="wraper-input">
                <input className={usuario != ""? 'has-val input':'input'} type="text" 
                  value={usuario}
                  onChange={changeUsuario}
                />
                <span className="focus-input" data-placeholder="Usuário"></span>
              </div>

              <div className="wraper-input">
                <input className={senha != ""? 'has-val input': 'input'} type={ (showPassword == false) ? "password": "text"}
                  value={senha}
                  onChange={changeSenha}
                />
                
    
                <span className="focus-input" data-placeholder="Senha"></span>
                
                <div>
                <img  className="eye" onClick={(() =>{


                        if(showPassword)
                        {
                            setShowPassword(false)
                            setPasswordInput("password")
                        }else
                        {
                            setShowPassword(true)
                            setPasswordInput("text")
                        }

                })} width="20px" src={ (showPassword == false) ? eyeClose: eyeOpen} alt="Mostrar senha" />
                </div>
              </div>
              

              <div className="container-login-form-btn">
                  <button className="login-form-btn">Login</button>
              </div>
          </form>

          <div className="account-info">
            <span className="info1">Não consegue acessar o sistema?</span>
            <a className="info2" href="#">Fale Conosco.</a>
          </div>
        </div>
      </div>
    </div>
  );
}

export default Login;
