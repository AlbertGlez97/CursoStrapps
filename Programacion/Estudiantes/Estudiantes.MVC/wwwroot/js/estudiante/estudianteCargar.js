export default function cargar(idEstudianteURL) {
  
    var requestOptions = {
        method: 'GET',
        redirect: 'follow'
    };

    var url = "https://localhost:44337/Estudiantes/" + idEstudianteURL;
    fetch(url, requestOptions)
        .then(response => {
            if (response.status == 200) {
                response.json().then(estudiante => {
                   
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
                    paterno.value = estudiante.apellidoPaterno;
                    materno.value = estudiante.apellidoMaterno;
                    sexo.value = estudiante.sexo;
                    curp.value = estudiante.curp;
                    nacimiento.value = (estudiante.fechaNacimiento).substring(0, 10);
                    nacionalidad.value = estudiante.nacionalidad;
                    telefono.value = estudiante.telefono;
                    correo.value = estudiante.correoElectronico;
                    calle.value = estudiante.direccion.calle;
                    numeroi.value = estudiante.direccion.numeroInterior;
                    numeroe.value = estudiante.direccion.numeroExterior;
                    colonia.value = estudiante.direccion.colonia;
                    municipio.value = estudiante.direccion.municipio;
                    estado.value = estudiante.direccion.estado;
                    cp.value = estudiante.direccion.codigoPostal;

                    matricula.value = estudiante.numeroMatricula;
                    carrera.value = estudiante.carrera;
                    fechaIngreso.value = (estudiante.fechaIngreso).substring(0, 10);
                    semestre.value = estudiante.semestre;
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
