import { Container } from 'react-bootstrap';
import Button from 'react-bootstrap/Button';
import Form from 'react-bootstrap/Form';
import { login} from '../../ApiService/ApiService';
import { useState } from 'react';

 const Login =({aoLogar})=>{
    const [username,setUsername] = useState('')
    const [password,setPassword]=useState('')
    let user = {
        username:username,
        password:password
    }

    async function aoLogin(){
        const resp = await login(user)
        if(resp===200){
            aoLogar(true)
        }
    }

    return(
        <Container className='p-3 w-25 bg-white rounded'>
            <Form.Group className="mb-3" controlId="formBasicEmail">
                <Form.Label>Email address</Form.Label>
                <Form.Control type="email" placeholder="Enter email" value={username} onChange={(e)=>setUsername(e.target.value)}/>
                <Form.Text className="text-muted">
                    We'll never share your email with anyone else.
                </Form.Text>
            </Form.Group>
            <Form.Group className="mb-3" controlId="formBasicPassword">
                <Form.Label>Password</Form.Label>
                <Form.Control type="password" placeholder="Password" value={password} onChange={(e)=>setPassword(e.target.value)}/>
            </Form.Group>
            <Form.Group className="mb-3" controlId="formBasicCheckbox">
                <Form.Check type="checkbox" label="Check me out" />
            </Form.Group>
            <Button variant="primary" type="submit" onClick={(e)=>aoLogin()}>
                Submit
            </Button>
        </Container>
    )
 }

 export default Login