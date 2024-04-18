import completa from '../../Imgs/verificado.png'
import carregando from '../../Imgs/carregando.png'
import pausado from '../../Imgs/pausa.png'
const ActivitiesFromProject = ({activities}) => {

    return (
        <div style={{display:"flex", justifyContent:"center", marginTop:"32px"}}>
            <table border={1}>
                <thead border={1}>
                    <tr>
                        <td style={{padding:"16px", border:"1px solid"}}>Nome</td>
                        <td style={{padding:"16px", border:"1px solid"}}>Descrição</td>
                        <td style={{padding:"16px", border:"1px solid"}}>Status</td>
                        <td style={{padding:"16px", border:"1px solid"}}>Worker</td>
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
                                <th style={{padding:"16px", border:"1px solid"}}>
                                    {activity.user.username}
                                </th>
                            </tr>
                        )
                    })}
                </tbody>
            </table>
        </div>
    )
}

export default ActivitiesFromProject