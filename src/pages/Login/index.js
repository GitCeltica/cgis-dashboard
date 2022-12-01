
import {useState} from 'react'
import {Link} from 'react-router-dom'
import {useNavigate} from 'react-router-dom'
import { useDispatch } from 'react-redux'

import './login.css'
import logo from '../../assets/logo.svg'
import { changeUser } from '../../store/userSlice'


function App() {

  const [user, setUser] = useState("")
  const [password, setPassword] = useState("")
  
  const dispatch = useDispatch()
 
  const navigate = useNavigate();
  
  function handleLogin(e)
  {
        if(user !== '' && password !== '')
        {
            dispatch(changeUser(user))
            navigate('/home', {replace: true})
        }else{
            alert("Preencha todos os campos")
        }
  }

  return (
    <div className="container">
      <div className="container-login">
        <div className="wraper-login">
          <form className="login-form" onSubmit={handleLogin}>

              <span className="login-form-title">
                <img src={logo} alt="Céltica"/>
              </span>

              <div className="wraper-input">
                <input className={user != ""? 'has-val input':'input'} type="text" 
                  value={user}
                  onChange={e => setUser(e.target.value)}
                />
                <span className="focus-input" data-placeholder="Usuário"></span>
              </div>

              <div className="wraper-input">
                <input className={password != ""? 'has-val input': 'input'} type="password" 
                  value={password}
                  onChange={e=> setPassword(e.target.value)}
                />
                <span className="focus-input" data-placeholder="Senha"></span>
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

export default App;
