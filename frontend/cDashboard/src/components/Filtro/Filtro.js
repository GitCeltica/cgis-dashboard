import filter from "../../assets/filtro.svg"
import close from "../../assets/close.svg"
import React, { useState, useEffect, useRef } from "react";
import { useLocation, useHistory } from "react-router-dom";
import useOnClickOutside from "../UseOnClickOutside";
import api from "../../services/api";
import { useSelector, useDispatch } from "react-redux";

export default function Filtro(props, start) {
    const ref = useRef();
    let local = useLocation();
    const [inactiveFilter, setInactiveFilter] = useState(true);

    const [loading, setLoading] = useState(true);


    const [ano, setAno] = useState([]);
    const [bairro, setBairro] = useState([]);
    const [mes, setMes] = useState([]);
    const [equipe, setEquipe] = useState([]);
    const [natureza, setNatureza] = useState([]);


    const [selectedAno, setSelectedAno] = useState('0');
    const [selectedBairro, setSelectedBairro] = useState('');
    const [selectedMes, setSelectedMes] = useState('0');
    const [selectedEquipe, setSelectedEquipe] = useState('');
    const [selectedNatureza, setSelectedNatureza] = useState('');


    const [filtro, setFiltro] = useState([]);

    const [caminho, setCaminho] = useState([]);

    const history = useHistory()

    useEffect(() => {
        return history.listen((location) => {

            if (location.pathname === '/perdas') {
                setCaminho('perdas/Filtro/10');
            } 
            else if (location.pathname === '/dadostecnicos') {
                setCaminho('dadostecnicos/Filtro/10')
            }
            else if (location.pathname === '/os') {
                setCaminho('ordemservicos/Filtro/10')
            }
           

            if (ano.length > 0) {
                // console.log(ano)
                //agora o ano é dinamico 
                let anoInicial = (ano[0].label)
                setSelectedAno(anoInicial)
                dispatch({ type: 'CHANGE_FILTRO', data: { ano: anoInicial, bairro: selectedBairro, mes: selectedMes, equipe: selectedEquipe, natureza: selectedNatureza } })
            }
        })
    }, [loading])



    // const filtroteste = useSelector(state => state.data);
    const dispatch = useDispatch();

    const mesesSigla = ["JANEIRO", "FEVEREIRO", "MARÇO", "ABRIL", "MAIO", "JUNHO", "JULHO", "AGOSTO", "SETEMBRO", "OUTUBRO", "NOVEMBRO", "DEZEMBRO"];



    useEffect(() => {
        async function getDadosFiltro() {

            setLoading(true);


            // history.listen((location) => {

            //     if (location.pathname === '/perdas') {
            //         setCaminho('perdas/Filtro/10');
            //     }
            //     else if (location.pathname === '/dadostecnicos') {
            //         setCaminho('dadostecnicos/Filtro/10')
            //     }
            //     else if (location.pathname === '/os') {
            //         setCaminho('ordemservicos/Filtro/10')
            //     }
            // })
            // console.log(caminho)

            const response = await api.get(`${caminho}`);

            // console.log(response.data)

            setAno(response.data.ano.map(label => ({ label })).sort((a, b) => (a.label < b.label) ? 1 : -1))

            setMes(mesesSigla.map((label, i) => ({ label, value: `${i + 1}` })))

            let rotaURL = caminho.split('/').shift()
            if (rotaURL === 'perdas') {

                setBairro(response.data.regioes.map(label => ({ label })))

            }

            if (rotaURL === 'ordemservicos') {

                setEquipe(response.data.equipe.map(label => ({ label })))

                setNatureza(response.data.natureza.map(label => ({ label })))

            }

            setLoading(false)
        }
        getDadosFiltro();

    }, [caminho])

    function HandleFilter(e) {
        e.preventDefault();
        setInactiveFilter(true)
        dispatch({ type: 'CHANGE_FILTRO', data: { ano: selectedAno, bairro: selectedBairro, mes: selectedMes, equipe: selectedEquipe, natureza: selectedNatureza } })
    }

    function changeAno(e) {
        setSelectedAno(e.target.value);
    }

    function changeBairro(e) {
        setSelectedBairro(e.target.value);
    }

    function changeMes(e) {
        setSelectedMes(e.target.value);
    }

    function changeEquipe(e) {
        setSelectedEquipe(e.target.value);
    }

    function changeNatureza(e) {
        setSelectedNatureza(e.target.value);
    }


    //set o valor inicial de ano para o ano atual
    // useEffect(() => {
    //     setSelectedAno(new Date().getFullYear().toString())
    //     dispatch({ type: 'CHANGE_FILTRO', data: { ano: selectedAno, bairro: selectedBairro, mes: selectedMes } })
    // }, [loading])


    useEffect(() => {
        if (ano.length > 0) {
            // console.log(ano)
            //agora o ano é dinamico 
            let anoInicial = (ano[0].label)
            setSelectedAno(anoInicial)
            setSelectedBairro('')
            setSelectedMes('0')
            setSelectedEquipe('')
            setSelectedNatureza('')
            dispatch({ type: 'CHANGE_FILTRO', data: { ano: anoInicial, bairro: selectedBairro, mes: selectedMes, equipe: selectedEquipe, natureza: selectedNatureza } })
        }

    }, [loading])

    useOnClickOutside(ref, () => setInactiveFilter(!false))

    useEffect(() => {
        props.onCollapse(inactiveFilter);
    }, [inactiveFilter]);


    return (
        //se a página for home ou configurações não exibe filtro
        local.pathname === "/" || local.pathname === "/configuracoes" ? (
            null
        ) : (
            <form ref={ref} className={`filtro ${inactiveFilter ? "inactiveFilter" : ""}`} onSubmit={HandleFilter}>
                {/* Retira click do filtro se display width < 1500 */}
                {inactiveFilter ? (
                    <img src={filter} alt="Filtro" onClick={() => setInactiveFilter(!inactiveFilter)} />
                ) : (
                    <img src={filter} alt="Filtro" />
                )}

                <img className="fechar" src={close} alt="Fechar" onClick={() => setInactiveFilter(!inactiveFilter)} />
                <label>Filtros</label>
                <br />

                {loading ?
                    (null) :
                    (
                        <div className="campos">
                            <div>
                                <label className="title">Ano:</label>
                                <select name="ano" id="ano" onBlur={changeAno} onChange={changeAno} value={selectedAno} select={filtro.ano}>
                                    {/*faz um map no array de ano e cria uma option */}
                                    {ano.map(index => {
                                        return (
                                            <option key={index.label} value={index.label}>{index.label}</option>
                                        )
                                    })}
                                </select>
                            </div>
                            {local.pathname !== "/perdas" ? (null) : (<div>
                                <label className="title">Bairro:</label>
                                <select name="bairro" id="bairro" onLoad={changeBairro} onChange={changeBairro} value={selectedBairro} select={filtro.bairro}>
                                    <option value="">TODOS</option>
                                    {/*faz um map no array de bairro e cria uma option */}
                                    {bairro.map(index => {
                                        return (
                                            <option key={index.label} value={index.label}>{index.label}</option>
                                        )
                                    })}
                                </select>
                            </div>)}
                            <div>
                                <label className="title">Mês:</label>
                                <select name="mes" id="mes"
                                    onLoad={changeMes} onChange={changeMes} value={selectedMes} select={filtro.mes}
                                >
                                    <option value="0">TODOS</option>
                                    {/*faz um map no array de mes e cria uma option */}
                                    {mes.map(index => {
                                        return (
                                            <option key={index.label} value={index.value}>{index.label}</option>
                                        )
                                    })}
                                </select>
                            </div>
                            {local.pathname !== "/os" ? (null) : (<div>
                                <label className="title">Equipe:</label>
                                <select name="equipe" id="equipe" onLoad={changeEquipe} onChange={changeEquipe} value={selectedEquipe} select={filtro.equipe}>
                                <option value="">TODAS</option>
                                    {/*faz um map no array de ano e cria uma option */}
                                    {equipe.map(index => {
                                        return (
                                            <option key={index.label} value={index.label}>{index.label}</option>
                                        )
                                    })}
                                </select>
                            </div>)}
                            {local.pathname !== "/os" ? (null) : (<div>
                                <label className="title">Natureza:</label>
                                <select name="natureza" id="natureza" onLoad={changeNatureza} onChange={changeNatureza} value={selectedNatureza} select={filtro.natureza}>
                                <option value="">TODAS</option>
                                    {/*faz um map no array de ano e cria uma option */}
                                    {natureza.map(index => {
                                        return (
                                            <option key={index.label} value={index.label}>{index.label}</option>
                                        )
                                    })}
                                </select>
                            </div>)}
                            <input type="submit" value="Filtrar" className="btnfiltrar"></input>
                        </div>
                    )}
            </form>)

    )
}