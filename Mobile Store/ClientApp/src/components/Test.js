import { useState, useEffect } from "react";

export default function Test() {

    const [stringData, setstringData] = useState();

    useEffect(() => {
        fetch('weatherforecast')
            .then(response => response.text())
            .then(json => setstringData(json))
            .catch(error => console.error(error));
    }, []);

    return (
        <div>
            {stringData ? JSON.stringify(stringData) : 'Loading...'}
        </div>
    );

}