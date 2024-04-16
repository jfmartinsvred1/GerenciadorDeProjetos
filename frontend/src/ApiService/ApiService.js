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

 
