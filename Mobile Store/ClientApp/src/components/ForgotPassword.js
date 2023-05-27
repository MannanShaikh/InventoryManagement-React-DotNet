export function ForgotPassword() {

    async function SendMail() {
        alert("Under Development");
    }

    return (
        <>
            <div className="container">
                <div className="col-md-12">
                    <div className="form-group">
                        <label for="aadhar"><b>AADHAR NUMBER</b></label>
                        <input type="number" className="form-control" id="aadhar"/>
                    </div>
                    <button onClick={SendMail} type="button" className="btn btn-primary"><b>GET OTP</b></button>
                </div>
            </div>

            {/*<!-- The Modal -->*/}
            <div className="modal" id="myModal">
                <div className="modal-dialog">
                    <div className="modal-content">

                        {/*<!-- Modal Header -->*/}
                        <div className="modal-header">
                            <h4 className="modal-title">Modal Heading</h4>
                            <button type="button" className="close" data-dismiss="modal">&times;</button>
                        </div>

                        {/*<!-- Modal body -->*/}
                        <div className="modal-body">
                            Modal body..
                        </div>

                        {/*<!-- Modal footer -->*/}
                        <div className="modal-footer">
                            <button type="button" className="btn btn-danger" data-dismiss="modal">Close</button>
                        </div>

                    </div>
                </div>
            </div>
        </>
        );
}