export function Product() {
    return (
        <>
            <div className="container-fluid">
                <div className="col-md-12">
                    <label className="switch">
                        <input type="checkbox" id="togBtn" />
                        <div className="slider round"></div>
                    </label>
                    <div className="row">
                        <div className="form-group col">
                            <label forhtml="imei"><b>IMEI</b></label>
                            <input type="number" className="form-control" id="imei" />
                        </div>
                        <div className="form-group col">
                            <label forhtml="brand"><b>BRAND</b></label>
                            <input type="text" className="form-control" id="brand" />
                        </div>
                    </div>
                    <div className="row">
                        <div className="form-group col">
                            <label forhtml="model"><b>MODEL</b></label>
                            <input type="text" className="form-control" id="model" />
                        </div>
                        <div className="form-group col">
                            <label forhtml="colour"><b>COLOUR</b></label>
                            <input type="text" className="form-control" id="colour" />
                        </div>
                    </div>
                    <div className="row">
                        <div className="form-group col">
                            <label forhtml="ram"><b>RAM</b></label>
                            <input type="number" className="form-control" id="ram" />
                        </div>
                        <div className="form-group col">
                            <label forhtml="storage"><b>INTERNAL STORAGE</b></label>
                            <input type="number" className="form-control" id="storage" />
                        </div>
                    </div>
                    <button type="button" className="btn btn-primary register"><b>REGISTER</b></button>
                    <button type="button" className="btn btn-primary update"><b>UPDATE</b></button>
                </div>
            </div>
        </>
    );
}