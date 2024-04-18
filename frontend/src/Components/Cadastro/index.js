import { useState } from 'react';
import { Container } from 'react-bootstrap';
import Button from 'react-bootstrap/Button';
import Form from 'react-bootstrap/Form';
import { register } from '../../ApiService/ApiService';

const Cadastro = () =>{
    const [username,setUsername]=useState('')
    const [email,setEmail]=useState('')
    const [password,setPassword]=useState('')
    const [rePassword,setRePassword]=useState('')
    const user = {
        username:username,
        email:email,
        password:password,
        repassword:rePassword
    }


    

    return(
        <Container className='p-3 w-25 bg-white rounded'>
            <Form.Group className="mb-3" controlId="formBasicUsernameRegister">
                <Form.Label>Username</Form.Label>
                <Form.Control type="text" placeholder="Enter Username" value={username} onChange={(e)=>setUsername(e.target.value)}/>
                <Form.Text className="text-muted">
                    We'll never share your email with anyone else.
                </Form.Text>
            </Form.Group>
            <Form.Group className="mb-3" controlId="formBasicEmailRegister">
                <Form.Label>Email address</Form.Label>
                <Form.Control type="email" placeholder="Enter email" value={email} onChange={(e)=>setEmail(e.target.value)}/>
                <Form.Text className="text-muted">
                    We'll never share your email with anyone else.
                </Form.Text>
            </Form.Group>
            <Form.Group className="mb-3" controlId="formBasicPasswordRegister">
                <Form.Label>Password</Form.Label>
                <Form.Control type="password" placeholder="Password" value={password} onChange={(e)=>setPassword(e.target.value)}/>
            </Form.Group>
            <Form.Group className="mb-3" controlId="formBasicRePasswordRegister">
                <Form.Label>Re Password</Form.Label>
                <Form.Control type="password" placeholder="RePassword" value={rePassword} onChange={(e)=>setRePassword(e.target.value)}/>
            </Form.Group>
            <Button variant="primary" type="submit" onClick={(e)=>register(user)}>
                Submit
            </Button>
        </Container>
    )
}

export default Cadastro