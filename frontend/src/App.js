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
import { getActivitiesOfUser, returnProjects } from './ApiService/ApiService';
import ActivitiesFromProject from './Components/ActivitiesFromProject';
import Atividades from './Components/Atividades';
import EmailConfirmation from './Components/EmailConfirmation';

function App() {
  

  const [isLogged,setIsLogged]= useState(false)
  const [user, setUser]=useState('');
  const [activitiesWithProject,setActivitiesWithProject]=useState([]);
  const [activitiesWithUser, setActivitiesWithUser]= useState([]);

  const [projetos,setProjetos] = useState([]);

  function carregaProjects(){
    returnProjects(user.id).then((res)=>res.json()).then((resp)=>{setProjetos(resp)}).catch((err)=>console.log(err))
    getActivitiesOfUser(user.id).then((resp)=>resp.json()).then((resp)=>setActivitiesWithUser(resp)).catch((err)=>console.log(err))
  }

  function aoLogar(param){
    setIsLogged(param)
    setUser(decodeToken(sessionStorage.getItem('token')))
  }

  async function aoCadastrar(param){
    await aoLogar(param)
    
    if(user.emailconfirmed==="False"){
      //Ir para tela de confirmacao
    }
    else{
      //ir para home logado
    }
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
    setActivitiesWithProject(activities)
  }



  
  

  return (
    <>
      <BrowserRouter>
        <Header logged={isLogged} user={user} carregar={carregaProjects} ></Header>
        <Routes>
          <Route path="/" element={<div><h1>Home</h1></div>}/>
          <Route path='/sobre' element={<h1>Sobre</h1>}/>
          <Route path="/login" element={<Login aoLogar={aoLogar}/>}/>
          <Route path="/cadastro" element={<Cadastro aoCadastrar={aoCadastrar}></Cadastro>} />
          <Route path='/meusProjetos' element={isLogged ?<Projetos projetos={projetos} showActivity={showActivitiesFromProject}/> : <Login aoLogar={aoLogar}/>}/>
          <Route path='/minhasAtividades' element={isLogged ?<Atividades activities={activitiesWithUser}></Atividades> : <Login aoLogar={aoLogar}/>}/>
          <Route path='/activitiesOfProject' element={<ActivitiesFromProject activities={activitiesWithProject}/>}/>
          <Route path='/emailConfirmation' element={<EmailConfirmation></EmailConfirmation>}/>
          <Route path='*' element={<h1>Pagina n encontrada</h1>}/>
        </Routes>
        <Footer className="footer"></Footer>
      </BrowserRouter>
    </>
    
  );
}

export default App;
