import { useEffect, useState } from 'react'
import style from './style.css'
import { getWorkers, returnActivitiesOfProject } from '../../ApiService/ApiService'
import { Link } from 'react-router-dom'
import expandir from '../../Imgs/expandir.png'
const Projeto = ({projeto,showActivity}) =>{
    const [activities,setActivities]=useState([])
    const [workers, setWorkers]=useState([])

    useEffect(()=>
    {
        if(activities.length===0){
            returnActivitiesOfProject(projeto.projectId).then((resp)=>resp.json()).then((resp)=>setActivities(resp)).catch((err)=>{console.log(err)})
            // getWorkers(projeto.projectId).then((resp)=>resp.json()).then((resp)=>setWorkers(resp)).catch((err)=>{console.log(err)})
        }
    })
    return (
        <tr>
            <th style={{padding:"16px", border:"1px solid"}} >{projeto.name}</th>
            <th style={{padding:"16px", border:"1px solid"}} >{projeto.description}</th>
            <th style={{padding:"16px", border:"1px solid"}} >
                <Link style={{textDecoration:"none", color:"black", display:"flex", justifyContent:"center"}} onMouseOver={(e)=>{showActivity(activities)}} >
                    <img src={expandir} width={"32px"}>

                    </img>
                </Link>
            </th>
            <th style={{padding:"16px", border:"1px solid"}} >
                <Link style={{textDecoration:"none", color:"black", display:"flex", justifyContent:"center"}} onClick={(e)=>{showActivity(activities)}} to={"/activitiesOfProject"}>
                    <img src={expandir} width={"32px"}>

                    </img>
                </Link>
            </th>
        </tr>
    )
}

export default Projeto