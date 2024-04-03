
import './App.css';
import Header from './Components/Header/Index';
import "bootstrap/dist/css/bootstrap.css"
import Footer from './Components/Footer';
import { Container } from 'react-bootstrap';
import Login from './Components/Login';

function App() {
  let isLogged=false;
  let user= {
    username:"jfmartins",
    name:"João Victor Fernandes Martins"
  }
  return (
    <>
      <Header logged={isLogged} user={user}></Header>
      <div className='bg-secondary p-3'>
        {/* <Container className='pt-4'>
        <h2>Site Gerenciador De Projetos</h2>
        <h4>Aplicativo com objetivo de gerenciar projetos, destinar atividades pendentes a colaboradores do projeto, dashbords e muito mais!</h4>
        </Container> */}
        <Login ></Login>
      </div>
      <Footer className="footer"></Footer>
    </>
    
  );
}

export default App;
