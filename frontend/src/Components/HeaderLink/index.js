import { Link } from "react-router-dom"

const HeaderLink = (props) =>{
    return (
        <Link className="m-4" to={props.to} style={{
            color:props.color, padding: "4px" , textDecoration:"none"
            
        }}>
            {props.name}
        </Link>
    )
}

export default HeaderLink