export default function obtenerPeticion(idEstudiante) {
    // 1.- Inicio
    // 2.- Obteneer los elementos de html
    // 3.- Obtener los valores de los elementos html
    const nombre = document.getElementById("nombre").value;
    const paterno = document.getElementById("paterno").value;
    const materno = document.getElementById("materno").value;
    const sexo = document.getElementById("slcsexo").value;
    const curp = document.getElementById("curp").value;
    const nacimiento = document.getElementById("nacimiento").value;
    const nacionalidad = document.getElementById("slcnacionalidad").value;
    const telefono = document.getElementById("telefono").value;
    const correo = document.getElementById("correo").value;
    const calle = document.getElementById("calle").value;
    const numeroi = document.getElementById("numeroi").value;
    const numeroe = document.getElementById("numeroe").value;
    const colonia = document.getElementById("colonia").value;
    const municipio = document.getElementById("municipio").value;
    const estado = document.getElementById("slcestado").value;
    const cp = document.getElementById("cp").value;
    const matricula = document.getElementById("matricula").value;
    const carrera = document.getElementById("carrera").value;
    const fechaIngreso = document.getElementById("fechaIngreso").value;
    const semestre = document.getElementById("slcsemestre").value;

    // 4.- Crear la petición (JSON) a realizar
    var raw = JSON.stringify({
        "idEstudiante": idEstudiante,
        "nombre": nombre,
        "apellidoPaterno": paterno,
        "apellidoMaterno": materno,
        "sexo": sexo,
        "curp": curp,
        "fechaNacimiento": nacimiento,
        "nacionalidad": nacionalidad,
        "telefono": telefono,
        "correoElectronico": correo,
        "activo": true,
        "direccion": {
            "calle": calle,
            "numeroInterior": numeroi,
            "numeroExterior": numeroe,
            "colonia": colonia,
            "municipio": municipio,
            "estado": estado,
            "codigoPostal": cp,
        },
        "idDatosEscolares": idEstudiante,
        "numeroMatricula": matricula,
        "carrera": carrera,
        "fechaIngreso": fechaIngreso,
        "semestre": semestre

    });
    console.log(raw)
    return raw;
    // 5.- Fin
}