import obtenerPeticion from "./estudianteObtenerPeticion.js";

export default async function guardar() {
    
    const path = window.location.pathname;
    // 3.- Obtener la acción a realizar con la url (REGISTRAR o EDITAR)
    const arreglo = path.split("/");
    const accionURL = arreglo[2];
    const idEstudiante = arreglo[3];
    // 1.- Inicio
    let accion = accionURL.toUpperCase();
    // 2.- Obtener la acción de EDITAR o REGISTRAR
    if (accion == "EDITAR") {
        console.log("ACCION: EDITAR")
        // 3.- Si es EDITAR
        // 3.1.- Obtener la petición a traves del metodo obtenerPetición
        var raw = obtenerPeticion(idEstudiante);
        // 3.2.- Crear y realizar la petición al servicio de editar
        var myHeaders = new Headers();
        myHeaders.append("Content-Type", "application/json");

        var requestOptions = {
            method: 'PUT',
            headers: myHeaders,
            body: raw,
            redirect: 'follow'
        };

        fetch("https://localhost:44337/Estudiantes", requestOptions)
            .then(response => {
                if (response.status == 200) {
                    // 3.3.- Si se guardo correctamente, mandar el mensaje de que los datos se guardaron correctamente
                    alert("Los datos se guardaron correctamente");  
                } else {
                    // 3.4.- Si no se guardo correctamente, mandar el mensaje de que los datos no se guardaron correctamente
                    alert("Los datos no se guardaron correctamente, contacte al administrador");
                    console.log("Los datos no se guardaron correctamente", response);
                }
            }).catch(error => {
                // 3.5.- Si no se pudo realizar la conexión al servicio, mandar mensaje de que no se pudo conectar al servicio
                alert("No se pudo realizar la acción, contacte al administrador");
                console.log("No se pudo realizar la acción", response);
            });
    }
    else if (accion == "REGISTRO") {
        // 4.- Si es REGISTRO
        // 4.1.- Obtener la petición a traves del metodo obtener
        var raw = obtenerPeticion(idEstudiante);
        // 4.2.- Crear y realizar la petición al servicio de registrar
        var myHeaders = new Headers();
        myHeaders.append("Content-Type", "application/json");

        var requestOptions = {
            method: 'POST',
            headers: myHeaders,
            body: raw,
            redirect: 'follow'
        };

        await fetch("https://localhost:44337/Estudiantes", requestOptions)
            .then(response => {
                if (response.status == 200) {
                    // 4.3.- Si se guardo correctamente, mandar el mensaje de que los datos se guardaron correctamente
                    alert("Los datos se guardaron correctamente");
                } else {
                    // 4.4.- Si no se guardo correctamente, mandar el mensaje de que los datos no se guardaron correctamente
                    alert("Los datos no se guardaron correctamente, contacte al administrador");
                    console.log("Los datos no se guardaron correctamente", response);
                }
                await response.json()
            })
            .then(res => await console.log(JSON.stringify(res)))
            .catch(error => {
                // 4.5.- Si no se pudo realizar la conexión al servicio, mandar mensaje de que no se pudo conectar al servicio
                alert("No se pudo realizar la acción, contacte al administrador");
                console.log("No se pudo realizar la acción", response);
            });
    }
    else {
        // 5.- Si no es EDITAR y tampoco REGISTRO
        // 5.1.- Mandar un mensaje de error de acción no valida
        alert("Acción no valida");
    }
    // 6.- Fin
}