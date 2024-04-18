import { Fragment } from "react"
import { Link } from "react-router-dom"
import add from '../../Imgs/adicionar-botao.png'
import completa from '../../Imgs/verificado.png'
import carregando from '../../Imgs/carregando.png'
import pausado from '../../Imgs/pausa.png'

const Atividades = ({activities}) =>{
    return (
        <Fragment>
            <div className="d-flex justify-content-center mt-3">
                <h1>Atividades</h1>
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
                        <td style={{padding:"16px", border:"1px solid"}}>Status</td>
                    </tr>
                </thead>
                <tbody>
                    {activities.map((activity,key)=>{
                        return(
                            <tr key={key} >
                                <th style={{padding:"16px", border:"1px solid"}}>
                                    {activity.name}
                                </th>
                                <th style={{padding:"16px", border:"1px solid"}}>
                                    {activity.description}
                                </th>
                                <th style={{padding:"16px", border:"1px solid"}}>
                                    {
                                        activity.state.name==="Em Andamento" ? <img src={carregando} width={"32px"}></img> 
                                        : activity.state.name==="Completa" ? <img src={completa} width={"32px"}></img> 
                                        :<img src={pausado} width={"32px"}></img>
                                    }
                                </th>
                            </tr>
                        )
                    })}
                </tbody>
            </table>
        </div>
        </Fragment>
    )
}

export default Atividades