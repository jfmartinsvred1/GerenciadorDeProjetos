import { useEffect, useState } from 'react'
import style from './style.css'
import { getWorkers, returnActivitiesOfProject } from '../../ApiService/ApiService'
import { Link } from 'react-router-dom'
const Projeto = ({projeto,showActivity}) =>{
    const [activities,setActivities]=useState([])
    const [workers, setWorkers]=useState([])

    useEffect(()=>
    {
        if(activities.length===0){
            returnActivitiesOfProject(projeto.projectId).then((resp)=>resp.json()).then((resp)=>setActivities(resp)).catch((err)=>{console.log(err)})
            getWorkers(projeto.projectId).then((resp)=>resp.json()).then((resp)=>setWorkers(resp)).catch((err)=>{console.log(err)})
        }
    })
    return (
        <tr>
            <th style={{padding:"16px", border:"1px solid"}} >{projeto.name}</th>
            <th style={{padding:"16px", border:"1px solid"}} >{projeto.description}</th>
            <th style={{padding:"16px", border:"1px solid"}} >
                <Link style={{textDecoration:"none", color:"black"}} onMouseOver={(e)=>{showActivity(activities)}} to={"/activitiesOfProject"}>Mostrar</Link>
            </th>
            <th style={{padding:"16px", border:"1px solid"}} >
                <Link style={{textDecoration:"none", color:"black"}} onClick={(e)=>{showActivity(activities)}}>Mostrar</Link>
            </th>
        </tr>
    )
}

export default Projeto