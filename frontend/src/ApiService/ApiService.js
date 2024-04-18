import {SaveToken,RemoveToken} from "../TokenService/TokenService" 

let _token 
if(sessionStorage.getItem('token')!=null)
{
   _token= sessionStorage.getItem('token')
}

export async function acess(form){
   const resp =await fetch("https://localhost:7147/Acess", {
       method:'GET',
       headers:{
            'Authorization': 'Bearer ' + _token
       }
    })
 
    const data = await resp
}


export async function login(form){
 
    const resp =await fetch("https://localhost:7147/User/login", {
       method:'POST',
       body:JSON.stringify(form),
       headers:{
          'Content-Type': 'application/json',
             'Accept': 'application/json'
       }
    })
 
    const data = await resp.json()
    if(resp.status == 200){
      SaveToken(data)
      return resp.status
    }
    else{
      RemoveToken()
      return resp.status
    }
    
 }

 export async function register(form){
   const resp =await fetch("https://localhost:7147/User/cadastro", {
      method:'POST',
      body:JSON.stringify(form),
      headers:{
         'Content-Type': 'application/json',
            'Accept': 'application/json'
      }
   })

   const data = await resp.json()
   console.log(data)
 }

 export function returnProjects(id){
   const resp = fetch(`https://localhost:7147/Project?managerId=${id}`,{
      method:'GET',
      headers:{
         'Content-Type': 'application/json',
         'Accept': 'application/json',
         'Authorization': 'Bearer ' + _token
      }

      
   })

   return resp
 }
 export function returnActivitiesOfProject(id){
   const resp = fetch(`https://localhost:7147/WithProject?projectId=${id}`,{
      method:'GET',
      headers:{
         'Content-Type': 'application/json',
         'Accept': 'application/json',
         'Authorization': 'Bearer ' + _token
      }

      
   })

   return resp
 }
 export function getWorkers(id){
   const resp = fetch(`https://localhost:7147/ProjectUser?projectId=${id}`,{
      method:'GET',
      headers:{
         'Content-Type': 'application/json',
         'Accept': 'application/json',
         'Authorization': 'Bearer ' + _token
      }

      
   })

   return resp
 }

 
