export function ChangePassword() {

    async function Reset() {
        alert("Under Developmet");
    }

    return (
        <>
            <div className="container">
                <div className="col-md-12">
                    <div className="form-group">
                        <label forhtml="aadhar"><b>AADHAR NUMBER</b></label>
                        <input type="number" className="form-control" id="aadhar"/>
                    </div>
                    <div className="form-group">
                        <label forhtml="oldpwd"><b>CURRENT PASSWORD / OTP</b></label>
                        <input type="password" className="form-control" id="oldpwd"/>
                            {/*<!-- <span className="glyphicon glyphicon-eye-open"></span> -->*/}
                    </div>
                    <div className="form-group">
                        <label forhtml="newpwd"><b>NEW PASSWORD</b></label>
                        <input type="password" className="form-control" id="newpwd"/>
                    </div>
                    <div className="form-group">
                        <label forhtml="conpwd"><b>CONFIRM NEW PASSWORD</b></label>
                        <input type="password" className="form-control" id="conpwd"/>
                    </div>
                    <button onClick={Reset} type="button" className="btn btn-primary"><b>RESET</b></button>
                    <span style={{ float: "right", cursor: "pointer", color: "whitesmoke" }} data-toggle="modal" data-target="#myModal">
                        Guidelines
                    </span>

                    {/*<!-- The Modal -->*/}
                    <div className="modal fade" id="myModal">
                        <div className="modal-dialog">
                            <div className="modal-content">

                                {/*<!-- Modal Header -->*/}
                                <div className="modal-header">
                                    <h4 className="modal-title">Password Format</h4>
                                    {/*<!-- <button type="button" className="close" data-dismiss="modal">&times;</button> -->*/}
                                </div>

                                {/*<!-- Modal body -->*/}
                                <div className="modal-body">
                                    <ul>
                                        <li>Password must contain only alpha-numeric values.</li>
                                        <li>Password must contain only alpha-numeric values.</li>
                                        <li>Password must contain only alpha-numeric values.</li>
                                    </ul>
                                </div>

                                {/*<!-- Modal footer -->*/}
                                <div className="modal-footer">
                                    <button type="button" className="btn btn-danger" data-dismiss="modal">Close</button>
                                </div>

                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </>
    );
}