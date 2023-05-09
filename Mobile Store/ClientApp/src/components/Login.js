import { useState, useEffect } from 'react';

export default function Login() {

    const [stringData, setstringData] = useState();

    function Authenticate() {

        let username = document.getElementById("aadhar").value;
        let password = document.getElementById("pwd").value
        let credentials = { username: username, password: password };

        //fetch('api/authentication/', {
        //    method: "GET"
        //    //body: JSON.stringify(credentials)
        //})
        //    .then(json => setstringData(json))
        //    .then(json => console.log(json))
        //    .catch(error => console.error(error));
    }
    
    return (
        <div className="container">
            <div className="col-md-12">
                <div className="form-group">
                    <label htmlFor="aadhar"><b>AADHAR NUMBER</b></label>
                    <input type="number" className="form-control" id="aadhar" max="12" />
                </div>
                <div className="form-group">
                    <label htmlFor="pwd"><b>PASSWORD</b></label>
                    <input type="password" className="form-control" id="pwd" />
                    {/*<i className="glyphicon glyphicon-eye-open"></i>*/}
                </div>
                <button onClick={Authenticate} type="button" className="btn btn-primary"><b>LOGIN</b></button>
                {/*<a href="forgotPassword.html" style="float: right;">Cannot Login ?</a>*/}
            </div>
        </div>
    );
}