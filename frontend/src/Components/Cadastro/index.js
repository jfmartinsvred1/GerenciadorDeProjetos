import { useState,Fragment } from 'react';
import { Container } from 'react-bootstrap';
import Button from 'react-bootstrap/Button';
import Form from 'react-bootstrap/Form';
import { login, register } from '../../ApiService/ApiService';

const Cadastro = ({aoCadastrar}) =>{
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

    async function aoRegistrar(){
        await register(user)
        await login(user)
        aoCadastrar(true)

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
                        <label id='email'>Email</label>
                        <input type="email" className="w-100 " placeholder='Email' value={email} onChange={(e)=>setEmail(e.target.value)}></input>
                    </div>
                    <div className='d-flex flex-column align-items-base m-3'>
                        <label id='password'>Password</label>
                        <input type="password" className="w-100 input" placeholder='Password' value={password} onChange={(e)=>setPassword(e.target.value)}></input>
                    </div>
                    <div className='d-flex flex-column align-items-base m-3'>
                        <label id='password'>Password</label>
                        <input type="password" className="w-100 input" placeholder='RePassword' value={rePassword} onChange={(e)=>setRePassword(e.target.value)}></input>
                    </div>
                    <button className="btn bg-primary m-3 w-75 text-light" onClick={(e)=>aoRegistrar()}>Cadastrar</button>
                </div>
            </div>
        </Fragment>
    )
}

export default Cadastro