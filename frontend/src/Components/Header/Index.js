import Button from 'react-bootstrap/Button';
import Container from 'react-bootstrap/Container';
import Nav from 'react-bootstrap/Nav';
import Navbar from 'react-bootstrap/Navbar';
import HeaderLink from '../HeaderLink';

const Header = ({logged, user, carregar}) => {
    

    return (
        <Navbar bg="primary" data-bs-theme="dark" className='p-4'>
          {!logged ? 
            <Container>
                <Navbar.Brand  className='fs-2' >Gerenciador De Projetos</Navbar.Brand>
                <Nav className="me-auto fs-4">
                    <HeaderLink to="/" name="Home" color="black" />    
                    <HeaderLink to="/sobre" name="Sobre" color="black"/>
                </Nav>
                <div className='d-flex'>
                    <Button  variant="secondary"className='m-2' ><HeaderLink to="/login" name="Login" color="black"/></Button>
                    <Button variant="secondary" className="m-2" ><HeaderLink to="/cadastro" name="Cadastro" color="black"/></Button>
                </div>
            </Container> :
            <Container>
                <Navbar.Brand  className='fs-2'>Gerenciador De Projetos</Navbar.Brand>
                <Nav className="me-auto fs-4">
                    <HeaderLink to="/" name="Home" color="black"/>
                    <HeaderLink to="/minhasAtividades" name="Minhas Atividades" color="black"/>
                    <HeaderLink to="/meusProjetos" name="Meus Projetos" color="black" carregar={carregar}/>
                </Nav>
                <h4>Olá, {user.username}</h4>
            </Container>
        }
        </Navbar>
    )
}

export default Header