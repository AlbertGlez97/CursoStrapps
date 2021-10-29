export default function materiasActualizar(url, jsonBody) {
    fetch(url, {
        method: `PUT`,
        headers: {
            "Content-type": "application/json; charset=utf-8"
        },
        body: jsonBody
    })
}