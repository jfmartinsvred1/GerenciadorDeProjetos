import Button from 'react-bootstrap/Button';
import Container from 'react-bootstrap/Container';
import Nav from 'react-bootstrap/Nav';
import Navbar from 'react-bootstrap/Navbar';

const Header = (props) => {
    return (
        <Navbar bg="primary" data-bs-theme="dark" className='p-4'>
          {!props.logged ? 
            <Container>
                <Navbar.Brand href="#home" className='fs-2'>Gerenciador De Projetos</Navbar.Brand>
                <Nav className="me-auto fs-4">
                    <Nav.Link href="#home" className=''>Home</Nav.Link>
                    <Nav.Link href="#features">Sobre</Nav.Link>
                </Nav>
                <div className='d-flex'>
                    <Button variant="secondary"className='m-2'>Login</Button>
                    <Button variant="secondary" className="m-2">Cadastro</Button>
                </div>
            </Container> :
            <Container>
                <Navbar.Brand href="#home" className='fs-2'>Gerenciador De Projetos</Navbar.Brand>
                <Nav className="me-auto fs-4">
                    <Nav.Link href="#home" className=''>Home</Nav.Link>
                    <Nav.Link href="#features">Minhas Atividades</Nav.Link>
                    <Nav.Link href="#pricing">Meus Projetos</Nav.Link>
                </Nav>
                <h4>Olá, {props.user.name}</h4>
            </Container>
        }
        </Navbar>
    )
}

export default Header