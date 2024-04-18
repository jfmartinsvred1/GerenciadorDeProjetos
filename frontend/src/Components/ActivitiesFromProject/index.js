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
                            <tr key={key} style={activity.state.name==="Em Andamento" ?{ backgroundColor:"yellow"} : activity.state.name==="Completa" ? {backgroundColor:"green"} :{}}>
                                <th style={{padding:"16px", border:"1px solid"}}>
                                    {activity.name}
                                </th>
                                <th style={{padding:"16px", border:"1px solid"}}>
                                    {activity.description}
                                </th>
                                <th style={{padding:"16px", border:"1px solid"}}>
                                    {activity.state.name}
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