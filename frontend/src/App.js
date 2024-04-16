import './App.css';
import Header from './Components/Header/Index';
import "bootstrap/dist/css/bootstrap.css"
import Footer from './Components/Footer';
import Login from './Components/Login';
import { useState } from 'react';
import { decodeToken } from './TokenService/TokenService';
import Cadastro from './Components/Cadastro';
import { BrowserRouter,Routes,Route } from "react-router-dom";

function App() {
  

  const [isLogged,setIsLogged]= useState(false)
  const [user, setUser]=useState('');

  

  function aoLogar(param){
    setIsLogged(param)
    setUser(decodeToken(sessionStorage.getItem('token')))
  }
  


  return (
    <>
      <BrowserRouter>
        <Header logged={isLogged} user={user}></Header>
        <Routes>
          <Route path="/" element={<div><h1>SOBRE NOS</h1></div>}/>
          <Route path="/login" element={<Login aoLogar={aoLogar}/>}/>
          <Route path="/cadastro" element={<Cadastro></Cadastro>} />
        </Routes>
        <Footer className="footer"></Footer>
      </BrowserRouter>
    </>
    
  );
}

export default App;
