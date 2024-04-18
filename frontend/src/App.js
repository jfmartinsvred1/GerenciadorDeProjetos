import './App.css';
import Header from './Components/Header/Index';
import "bootstrap/dist/css/bootstrap.css"
import Footer from './Components/Footer';
import Login from './Components/Login';
import { useEffect, useState } from 'react';
import { decodeToken } from './TokenService/TokenService';
import Cadastro from './Components/Cadastro';
import { BrowserRouter,Routes,Route } from "react-router-dom";
import Projetos from './Components/Projetos';
import { returnProjects } from './ApiService/ApiService';
import ActivitiesFromProject from './Components/ActivitiesFromProject';

function App() {
  

  const [isLogged,setIsLogged]= useState(false)
  const [user, setUser]=useState('');
  const [activity,setActivity]=useState([]);

  const [projetos,setProjetos] = useState([]);

  function carregaProjects(){
    returnProjects(user.id).then((res)=>res.json()).then((resp)=>{setProjetos(resp)}).catch((err)=>console.log(err))
  }

  function aoLogar(param){
    setIsLogged(param)
    setUser(decodeToken(sessionStorage.getItem('token')))
  }

  useEffect(()=>{
    if(user===''){
      if(sessionStorage.getItem('token')!==null){
        setUser(decodeToken(sessionStorage.getItem('token')))
        setIsLogged(true)
      }
    }
    if(isLogged && projetos.length===0){
      carregaProjects()
    }
  }
)

  function showActivitiesFromProject(activities){
    setActivity(activities)
    console.log(activities)
  }


  
  

  return (
    <>
      <BrowserRouter>
        <Header logged={isLogged} user={user} carregar={carregaProjects}></Header>
        <Routes>
          <Route path="/" element={<div><h1>Home</h1></div>}/>
          <Route path='/sobre' element={<h1>Sobre</h1>}/>
          <Route path="/login" element={<Login aoLogar={aoLogar}/>}/>
          <Route path="/cadastro" element={<Cadastro></Cadastro>} />
          <Route path='/meusProjetos' element={isLogged ?<Projetos projetos={projetos} showActivity={showActivitiesFromProject}/> : <Login aoLogar={aoLogar}/>}/>
          <Route path='/minhasAtividades' element={isLogged ?<h1>Atividades</h1> : <Login aoLogar={aoLogar}/>}/>
          <Route path='/activitiesOfProject' element={<ActivitiesFromProject activities={activity}/>}/>
          <Route path='*' element={<h1>Pagina n encontrada</h1>}/>
        </Routes>
        <Footer className="footer"></Footer>
      </BrowserRouter>
    </>
    
  );
}

export default App;
