import { useState } from "react";

import { ReactReduxContext } from "react-redux"

import { BsGrid } from "react-icons/bs";

import { ImMenu, ImSearch, ImUser, ImOffice, ImPieChart, ImCog, ImWrench, ImDatabase, ImMap, ImFolderOpen } from 'react-icons/im'

import {BiLogOut} from "react-icons/bi"

import logo_mini from '../../assets/logomini.svg'

import './side_menu.css'

function SideMenu()
{
    const [showSideBar, setShowSideBar] = useState(false)
    function handleMenuSideBar()
    {
        //let sidebar = document.querySelector(".sidebar")
        setShowSideBar(! showSideBar)

        //sidebar.classList.toogle("active")
    }

    return(
        <div className={ showSideBar? 'sidebar active': 'sidebar'}>
            <div className="logo_content">
                <div className="logo">
                    <i><img src={logo_mini} alt="Céltica"/></i>
                    <div className="logo_name">Céltica</div>
                </div>

               
               <button className='btnMenu'
                    onClick={handleMenuSideBar}
               ><ImMenu/></button>

            </div>

            <ul className="nav_list">
                <li>
                    <a  href="#">
                        <i ><ImSearch className="icon-search" /></i>
                        <input type="text" placeholder="Pesquisar..."/>
                    </a>
                    {showSideBar? 
                        <span></span>:<span className='tooltip'>Pesquisar</span> }
                </li>

                <li>
                    <a href="#">
                        <i><BsGrid/></i>
                        <span className="links_name">Home</span>
                    </a>
                    {showSideBar? 
                        <span></span>:<span className='tooltip'>Home</span> }
                    
                </li>

                <li>
                    <a href="#">
                        <i><ImUser/></i>
                        <span className="links_name">Perdas</span>
                    </a>
                    {showSideBar? 
                        <span></span>:<span className='tooltip'>Perdas</span> }
                </li>

                <li>
                    <a href="#">
                        <i><ImOffice/></i>
                        <span className="links_name">Dados Técnicos</span>
                    </a>
                    {showSideBar? 
                        <span></span>:<span className='tooltip'>Dados Técnicos</span> }
                </li>

                <li>
                    <a href="#">
                        <i><ImPieChart/></i>
                        <span className="links_name">Ordem de Serviço</span>
                    </a>
                    {showSideBar? 
                        <span></span>:<span className='tooltip'>Ordem de Serviço</span> }
                </li>

                <li>
                    <a href="#">
                        <i><ImCog/></i>
                        <span className="links_name">Configurações</span>
                    </a>
                    {showSideBar? 
                        <span></span>:<span className='tooltip'>Configurações</span> }
                </li>
            </ul>

            <div className="profile_content">
                <div className="profile">
                    <div className="profile_details">
                        <div className="user_info"></div>
                            <div className="user_name">João Afonso</div>
                    </div>

                    <i id="log_out"><BiLogOut/></i>
                </div>
            </div>
        </div>
    )
}

export default SideMenu