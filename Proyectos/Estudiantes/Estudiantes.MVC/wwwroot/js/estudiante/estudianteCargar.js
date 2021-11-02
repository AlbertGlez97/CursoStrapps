export default function cargar(idEstudianteURL,visible) {
  
    var requestOptions = {
        method: 'GET',
        redirect: 'follow'
    };

    var url = "https://localhost:44337/Estudiantes/" + idEstudianteURL;
    fetch(url, requestOptions)
        .then(response => {
            if (response.status == 200) {
                response.json().then(estudiante => {

                    const btnGuardar = document.querySelector(".bttnGuardar");
                    btnGuardar.disabled = visible;
                    const nombre = document.getElementById("nombre");
                    const paterno = document.getElementById("paterno");
                    const materno = document.getElementById("materno");
                    const sexo = document.getElementById("slcsexo");
                    const curp = document.getElementById("curp");
                    const nacimiento = document.getElementById("nacimiento");
                    const nacionalidad = document.getElementById("slcnacionalidad");
                    const telefono = document.getElementById("telefono");
                    const correo = document.getElementById("correo");
                    const calle = document.getElementById("calle");
                    const numeroi = document.getElementById("numeroi");
                    const numeroe = document.getElementById("numeroe");
                    const colonia = document.getElementById("colonia");
                    const municipio = document.getElementById("municipio");
                    const estado = document.getElementById("slcestado");
                    const cp = document.getElementById("cp");
                    const matricula = document.getElementById("matricula");
                    const carrera = document.getElementById("carrera");
                    const fechaIngreso = document.getElementById("fechaIngreso");
                    const semestre = document.getElementById("slcsemestre");
                    
                    nombre.value = estudiante.nombre;
                    nombre.disabled= visible;

                    paterno.value = estudiante.apellidoPaterno;
                    paterno.disabled= visible;

                    materno.value = estudiante.apellidoMaterno;
                    materno.disabled= visible;

                    sexo.value = estudiante.sexo;
                    sexo.disabled = visible;

                    curp.value = estudiante.curp;
                    curp.disabled = visible;

                    nacimiento.value = (estudiante.fechaNacimiento).substring(0, 10);
                    nacimiento.disabled = visible;

                    nacionalidad.value = estudiante.nacionalidad;
                    nacionalidad.disabled = visible;

                    telefono.value = estudiante.telefono;
                    telefono.disabled = visible;

                    correo.value = estudiante.correoElectronico;
                    correo.disabled = visible;

                    calle.value = estudiante.direccion.calle;
                    calle.disabled = visible;

                    numeroi.value = estudiante.direccion.numeroInterior;
                    numeroi.disabled = visible;

                    numeroe.value = estudiante.direccion.numeroExterior;
                    numeroe.disabled = visible;

                    colonia.value = estudiante.direccion.colonia;
                    colonia.disabled = visible;

                    municipio.value = estudiante.direccion.municipio;
                    municipio.disabled = visible;

                    estado.value = estudiante.direccion.estado;
                    estado.disabled = visible;

                    cp.value = estudiante.direccion.codigoPostal;
                    cp.disabled = visible;

                    matricula.value = estudiante.numeroMatricula;
                    matricula.disabled = visible;

                    carrera.value = estudiante.carrera;
                    carrera.disabled = visible;

                    fechaIngreso.value = (estudiante.fechaIngreso).substring(0, 10);
                    fechaIngreso.disabled = visible;

                    semestre.value = estudiante.semestre;
                    semestre.disabled = visible;
                })
            } else {
                alert("No se encontro el estudiante, contactar al administrador");
                console.log("No se encontro el estudiante, contactar al administrador", response)
            }
        })
        .catch(error => {
            alert("Ocurrio un error, contactar al administrador")
            console.log("Ocurrio un error, contactar al administrador", error)
        });
     
}
