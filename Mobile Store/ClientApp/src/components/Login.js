import { Role } from '../RoleEnumeration';
import { useNavigate, Link } from 'react-router-dom';

export function Login() {
    let navigate = useNavigate();

    async function Authenticate() {

        let username = document.getElementById("username").value;
        let password = document.getElementById("password").value
        let credentials = {
            "username": username,
            "password": password
        };

        const response = await fetch('/api/authentication/CheckAuthentication', {
            method: "POST",
            headers: {
                'Accept': 'application/json',
                'Content-Type': 'application/json'
            },
            body: JSON.stringify(credentials)
        })

        const json = await response.json();

        switch (json.roleId) {
            case Role.Admin:
                navigate("/AdminPanel");
                break;
            case Role.Employee:
                navigate("/UserPanel");
                break;
            default:
                navigate("/");
                break;
        }
    }

    return (
        <div className="container">
            <div className="col-md-12">
                <div className="form-group">
                    <label htmlFor="username"><b>USER NAME</b></label>
                    <input type="text" className="form-control" id="username" max="12" />
                </div>
                <div className="form-group">
                    <label htmlFor="password"><b>PASSWORD</b></label>
                    <input type="password" className="form-control" id="password" />
                    {/*<i className="glyphicon glyphicon-eye-open"></i>*/}
                </div>
                <button onClick={Authenticate} type="button" className="btn btn-primary"><b>LOGIN</b></button>
                <Link to="/forgotPassword" style={{ float: "right" }}>Cannot Login ?</Link>
            </div>
        </div>
    );
}