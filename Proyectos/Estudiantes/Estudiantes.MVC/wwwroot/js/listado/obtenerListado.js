export default function cargarListado() {

    const requestOptions = {
        method: 'GET',
        redirect: 'follow'
    };

    fetch("https://localhost:44337/Estudiantes", requestOptions)
        .then(response => response.json())
        .then(result => {
            
            const tabla = document.getElementById("tablaempleado");
            const tbody = tabla.querySelectorAll("tbody")[0];
            const fragment = document.createDocumentFragment();

            result.forEach((estudiante) => {
                const tr = document.createElement("tr")
                tr.innerHTML = `<td>${estudiante.idEstudiante}</td>
                                <td>${estudiante.numeroMatricula}</td>
                                <td>${estudiante.nombre} ${estudiante.apellidoPaterno} ${estudiante.apellidoMaterno}</td>
                                <td>${estudiante.carrera}</td>
                                <td>${estudiante.correoElectronico}</td>
                                <td><a href="/Estudiantes/Consultar/${estudiante.idEstudiante}">Consultar</a></td>
                                <td><a href="/Estudiantes/Editar/${estudiante.idEstudiante}">Editar</a></td>
                                <td><a href="" id="Eliminar" data-id="${estudiante.idEstudiante}">Eliminar</a></td>`
                fragment.appendChild(tr)
            })
            tbody.appendChild(fragment);

        })
        .catch(error => {
            alert("Error al momento de realizar la petición, contacte al administrador");
            console.log(error);
        });
}
