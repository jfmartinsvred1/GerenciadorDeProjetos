const EmailConfirmation = () =>{
    return(
        <div className="d-flex justify-content-center mt-5">
            <div className="d-flex flex-column bg-light p-3 shadow p-3 mb-5 bg-white rounded justify-content-center align-items-center">
                <h4 className="m-5">Insira o código de confirmação</h4>
                <input type="text" className="m-5 w-50 "></input>
                <button className="btn bg-primary m-3 w-25 text-light">Confirmar</button>
            </div>
        </div>
    )
}

export default EmailConfirmation