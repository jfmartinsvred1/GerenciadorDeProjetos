import { useEffect, useState } from "react"
import { returnProjects } from "../../ApiService/ApiService";
import Projeto from '../Projeto/index.js'
import style from '../Projetos/style.css'

const Projetos = ({projetos, showActivity}) =>{
    return (
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
    )
}
export default Projetos