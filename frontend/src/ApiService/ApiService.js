async function login(form){
 
    const resp =await fetch("https://localhost:7147/User/login", {
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

export default login