import { useEffect, useState,Fragment } from "react"
import Projeto from '../Projeto/index.js'
import add from '../../Imgs/adicionar-botao.png'
import { Link } from 'react-router-dom'

const Projetos = ({projetos, showActivity}) =>{
    return (
        <Fragment>
            <div className="mt-3 d-flex justify-content-center align-items-center">
                <h1 >Projetos</h1>
            </div>
            <Link className="mt-3 d-flex justify-content-center align-items-center" style={{textDecoration:"none"}} to="/addProject">
                <h2 >New</h2>
                <img src={add} width={"32px"} height={"32px"} className="m-2"></img>
            </Link>
            <div style={{display:"flex", justifyContent:"center", marginTop:"32px"}}>
                <table border={1}>
                    <thead border={1}>
                        <tr>
                            <td style={{padding:"16px", border:"1px solid"}}>Nome</td>
                            <td style={{padding:"16px", border:"1px solid"}}>Descrição</td>
                            <td style={{padding:"16px", border:"1px solid"}}>Colaboradores</td>
                            <td style={{padding:"16px", border:"1px solid"}}>Atividades</td>
                        </tr>
                    </thead>
                    <tbody>
                        {projetos.map((projeto,index)=>{
                            return <Projeto
                            key={index} projeto={projeto} showActivity={showActivity}/>
                        })}
                    </tbody>
                </table>
            </div>
        </Fragment>
    )
}
export default Projetos