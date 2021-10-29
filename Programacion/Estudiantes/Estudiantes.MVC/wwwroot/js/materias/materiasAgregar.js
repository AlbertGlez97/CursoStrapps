export default function materiasAgregar(url, jsonBody) {

        fetch(url, {
            method: `POST`,
            headers: {
                "Content-type": "application/json; charset=utf-8"
            },
            body: jsonBody
        })

}