export function SupplierOrder() {
    return (
        <>
            <div id="AdminHeader"></div>
            <div className="container-fluid">
                <div className="col-md-12">
                    <div className="row">
                        <div className="form-group col">
                            <label forHtml="gst"><b>GSTIN</b></label>
                            <input type="text" className="form-control" id="gst" onchange=""/>
                        </div>
                    </div>
                    <div className="row">
                        <div className="form-group col">
                            <label forHtml="brand"><b>BRAND</b></label>
                            <select className="form-control" id="brand"></select>
                        </div>
                        <div className="form-group col">
                            <label forHtml="model"><b>MODEL</b></label>
                            <select className="form-control" id="model"></select>
                        </div>
                    </div>
                    <div className="row">
                        <div className="form-group col">
                            <label forHtml="ram"><b>RAM</b></label>
                            <select className="form-control" id="ram"></select>
                        </div>
                        <div className="form-group col">
                            <label forHtml="colour"><b>COLOUR</b></label>
                            <select className="form-control" id="colour"></select>
                        </div>
                    </div>
                    <button type="button" className="btn btn-primary order" onclick=""><b>ORDER</b></button>
                </div>
            </div>
        </>
        );
}