export function User() {

    async function Register() {
        let name = document.getElementById("name").value;
        let aadhar = document.getElementById("aadhar").value;
        let email = document.getElementById("email").value;
        let contact = document.getElementById("contact").value;
        let password = document.getElementById("password").value;
        let confirm = document.getElementById("confirm").value;
        let credentials = {
            "username": username,
            "password": password
        };

        const response = await fetch('/api/user/Adduser', {
            method: "POST",
            headers: {
                'Accept': 'application/json',
                'Content-Type': 'application/json'
            },
            body: JSON.stringify(credentials)
        })

        const json = await response.json();
    }

    async function Update() {
        let name = document.getElementById("name").value;
        let aadhar = document.getElementById("aadhar").value;
        let email = document.getElementById("email").value;
        let contact = document.getElementById("contact").value;
        let password = document.getElementById("password").value;
        let confirm = document.getElementById("confirm").value;
        let credentials = {
            "username": username,
            "password": password
        };

        const response = await fetch('/api/user/Edituser', {
            method: "POST",
            headers: {
                'Accept': 'application/json',
                'Content-Type': 'application/json'
            },
            body: JSON.stringify(credentials)
        })

        const json = await response.json();
    }

    return (
        <div className="container-fluid">
            <div className="col-md-12">
                <label className="switch">
                    <input type="checkbox" id="togBtn" />
                    <div className="slider round"></div>
                </label>
                <div className="row">
                    <div className="form-group col">
                        <label htmlFor="name"><b>NAME</b></label>
                        <input type="text" className="form-control" id="name" />
                    </div>
                    <div className="form-group col">
                        <label htmlFor="aadhar"><b>AADHAR NUMBER</b></label>
                        <input type="number" className="form-control" id="aadhar" />
                    </div>
                </div>
                <div className="row">
                    <div className="form-group col">
                        <label htmlFor="email"><b>EMAIL</b></label>
                        <input type="email" className="form-control" id="email" />
                    </div>
                    <div className="form-group col">
                        <label htmlFor="contact"><b>CONTACT</b></label>
                        <input type="tel" className="form-control" id="contact" />
                    </div>
                </div>
                <div className="row hideshow">
                    <div className="form-group col">
                        <label htmlFor="password"><b>PASSWORD</b></label>
                        <input type="password" className="form-control" id="password" />
                    </div>
                    <div className="form-group col">
                        <label htmlFor="confirm"><b>CONFIRM PASSWORD</b></label>
                        <input type="password" className="form-control" id="confirm" />
                    </div>
                </div>
                <button onClick={Register} type="button" className="btn btn-primary register"><b>REGISTER</b></button>
                <button onClick={Update} type="button" className="btn btn-primary update"><b>UPDATE</b></button>
            </div>
        </div>
    );
}