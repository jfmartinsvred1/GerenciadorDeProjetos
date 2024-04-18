import { Container } from 'react-bootstrap';
import Button from 'react-bootstrap/Button';
import Form from 'react-bootstrap/Form';
import { login} from '../../ApiService/ApiService';
import { Fragment, useState } from 'react';

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
        <Fragment>
            <div className="d-flex justify-content-center mt-5">
                <div className="d-flex flex-column bg-light p-3 shadow p-3 mb-5 bg-white rounded justify-content-center align-items-center">
                    <div className='d-flex flex-column align-items-base m-3'>
                        <label id='username'>Username</label>
                        <input type="text" className="w-100 " placeholder='Username' value={username} onChange={(e)=>setUsername(e.target.value)}></input>
                    </div>
                    <div className='d-flex flex-column align-items-base m-3'>
                        <label id='password'>Password</label>
                        <input type="password" className="w-100 input" placeholder='Password' value={password} onChange={(e)=>setPassword(e.target.value)}></input>
                    </div>
                    <button className="btn bg-primary m-3 w-75 text-light" onClick={(e)=>aoLogin()}>Logar</button>
                </div>
            </div>
        </Fragment>

    )
 }

 export default Login