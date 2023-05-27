export function Supplier() {

    async function Register() {
        let name = document.getElementById("name").value;
        let aadhar = document.getElementById("aadhar").value;
        let email = document.getElementById("email").value;
        let contact = document.getElementById("contact").value;
        let password = document.getElementById("password").value;
        let confirm = document.getElementById("confirm").value;
        let credentials = {
            //"username": username,
            //"password": password
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
            //"username": username,
            //"password": password
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
        <>
            <div id="AdminHeader"></div>
            <div className="container-fluid">
                <div className="col-md-12">
                    <label className="switch">
                        <input type="checkbox" id="togBtn"/>
                            <div className="slider round"></div>
                    </label>
                    <div className="row">
                        <div className="form-group col">
                            <label forHtml="name"><b>NAME</b></label>
                            <input type="text" className="form-control" id="name"/>
                        </div>
                        <div className="form-group col hideshow">
                            <label forHtml="gst"><b>GST NUMBER</b></label>
                            <input type="number" className="form-control" id="gst"/>
                        </div>
                    </div>
                    <div className="row">
                        <div className="form-group col">
                            <label forHtml="email"><b>EMAIL</b></label>
                            <input type="email" className="form-control" id="email"/>
                        </div>
                        <div className="form-group col">
                            <label forHtml="contact"><b>CONTACT</b></label>
                            <input type="tel" className="form-control" id="contact"/>
                        </div>
                    </div>
                    <div className="row">
                        <div className="form-group col">
                            <label forHtml="address"><b>ADDRESS</b></label>
                            <input type="text" className="form-control" id="address"/>
                        </div>
                    </div>
                    <button onClick={Register} type="button" className="btn btn-primary register"><b>REGISTER</b></button>
                    <button onClick={Update} type="button" className="btn btn-primary update"><b>UPDATE</b></button>
                </div>
            </div>
        </>
    );
}