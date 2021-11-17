import cargar from "./estudiante/estudianteCargar.js";
import materiasCursadasCargar from "./materias/materiasCursadasCargar.js";
import materiasCursandoCargar from "./materias/materiasCursandoCargar.js";
import guardar from "./estudiante/estudianteGuardar.js";
import materiasAgregar from "./materias/materiasAgregar.js";
import materiasActualizar from "./materias/materiasActualizar.js";

const path = window.location.pathname;
const arreglo = path.split("/");
const accionURL = arreglo[2];
var urlEstudiante = arreglo[3];

document.addEventListener("DOMContentLoaded", (e) => {

    let accion = "";
    let idEstudiante;

    if (accionURL.toUpperCase() == "EDITAR") {
       

        accion = "EDITAR";

        const titulo = document.getElementById("titulo");
        titulo.innerHTML = 'Edición de estudiante';

        cargar(urlEstudiante,false);
        materiasCursandoCargar(urlEstudiante,false);
        materiasCursadasCargar(urlEstudiante,false);
        
    }
    else if (accionURL.toUpperCase() == "REGISTRO") {
        // 5.- Si es REGISTRAR
        // 5.1.- Registrar la acción de REGISTRAR como variable global
        accion = "REGISTRO";
        // 5.2.- Actualizar el titulo de Alta de empleados
        const titulo = document.getElementById("titulo");
        titulo.innerHTML = 'Alta de estudiante';
    } else if (accionURL.toUpperCase() == "CONSULTAR") {
        accion = "CONSULTAR";
        const titulo = document.getElementById("titulo");
        titulo.innerHTML = 'Consulta de estudiante';

        cargar(urlEstudiante,true);
        materiasCursandoCargar(urlEstudiante,true);
        materiasCursadasCargar(urlEstudiante,true);
    }else {
        // 6.- Si la opción es diferente de EDITAR y REGISTRAR, mnadar mensaje de acción no valida
        alert("Acción no valida");
    }
    // 6.- Fin
});


let formMateriasCursando = document.querySelector(".formularioMateriasCursando");
let formMateriasCursadas = document.querySelector(".formularioMateriasCursadas");

document.addEventListener("click", (e) => {
    
    if (e.target.matches(".bttnGuardar")) {
        guardar();
    }

    if (e.target.matches(".editar")) {
        event.preventDefault();
        formMateriasCursando.clave.value = e.target.dataset.claveMateria;
        formMateriasCursando.materia.value = e.target.dataset.materia;
        formMateriasCursando.horario.value = e.target.dataset.horario;
        formMateriasCursando.primerCalificacion.value = e.target.dataset.calificacionUno;
        formMateriasCursando.segundaCalificacion.value = e.target.dataset.calificacionDos;
        formMateriasCursando.tercerCalificacion.value = e.target.dataset.calificacionTres;
        formMateriasCursando.id.value = e.target.dataset.idMateriasCursando;
    }

    if (e.target.matches(".editarMaterias")) {
        event.preventDefault();
        formMateriasCursadas.clave.value = e.target.dataset.claveMateria;
        formMateriasCursadas.materia.value = e.target.dataset.materia;
        formMateriasCursadas.calificacionPrimera.value = e.target.dataset.calificacionUno;
        formMateriasCursadas.calificacionSegunda.value = e.target.dataset.calificacionDos;
        formMateriasCursadas.calificacionTercera.value = e.target.dataset.calificacionTres;
        formMateriasCursadas.calificacionFinal.value = e.target.dataset.calificacionFinal;
        formMateriasCursadas.id.value = e.target.dataset.idMateriasCursadas;
    }

    if (e.target.matches(".eliminar")) {
        event.preventDefault();
        let idMateriasCursando = e.target.dataset.idMateriasCursando;
        let isDelete = confirm(`Estas seguro de eliminar el id ${idMateriasCursando}`);

        if (isDelete) {
            //Delete - DELETE

            var url = "https://localhost:44337/MateriasCursando/" + idMateriasCursando;
            fetch(url, {
                method: `DELETE`,
                headers: {
                    "Content-type": "application/json; charset=utf-8"
                }
            });

            location.reload();

        }
    }

    if (e.target.matches(".eliminarMaterias")) {
        event.preventDefault();
        let idMateriasCursadas = e.target.dataset.idMateriasCursadas;
        let isDelete = confirm(`Estas seguro de eliminar el id ${idMateriasCursadas}`);

        if (isDelete) {
            //Delete - DELETE

            var url = "https://localhost:44337/MateriasCursadas/" + idMateriasCursadas;
            fetch(url, {
                method: `DELETE`,
                headers: {
                    "Content-type": "application/json; charset=utf-8"
                }
            });

            location.reload();

        }
    }
});


document.addEventListener("submit", (e) => {

    e.preventDefault();

    const path = window.location.pathname;
    const arreglo = path.split("/");
    const accionURL = arreglo[2];
    const idEstudianteURL = arreglo[3];


    if (e.target === formMateriasCursando && accionURL.toUpperCase() == "EDITAR") {
        const url = "https://localhost:44337/MateriasCursando";
        console.log("Ey me pico")
        console.log(e.target);
        if (!e.target.id.value && idEstudianteURL != null) {

            let raw = JSON.stringify({
                idMateriasCursando: 0,
                claveMateria: e.target.clave.value,
                materia: e.target.materia.value,
                horario: e.target.horario.value,
                calificacionUno: e.target.primerCalificacion.value,
                calificacionDos: e.target.segundaCalificacion.value,
                calificacionTres: e.target.tercerCalificacion.value,
                activo: true,
                idEstudiante: idEstudianteURL,
            })

            materiasAgregar(url, raw);

            location.reload();

        }


        if (e.target.id.value && idEstudianteURL != null) {

            let raw = JSON.stringify({
                idMateriasCursando: e.target.id.value,
                claveMateria: e.target.clave.value,
                materia: e.target.materia.value,
                horario: e.target.horario.value,
                calificacionUno: e.target.primerCalificacion.value,
                calificacionDos: e.target.segundaCalificacion.value,
                calificacionTres: e.target.tercerCalificacion.value,
                activo: true,
                idEstudiante: idEstudianteURL,
            })
            materiasActualizar(url, raw);
            location.reload();
        }

    } 


    if (e.target === formMateriasCursadas && accionURL.toUpperCase() == "EDITAR") {

        const tabla = document.getElementById("tablaMateriasCursadas");
        const tBody = document.createElement('tbody')

        const url = "https://localhost:44337/MateriasCursadas";
        if (!e.target.id.value && idEstudianteURL != null) {

            let raw = JSON.stringify({
                idMateriasCursadas: 0,
                claveMateria: e.target.clave.value,
                materia: e.target.materia.value,
                calificacionUno: e.target.calificacionPrimera.value,
                calificacionDos: e.target.calificacionSegunda.value,
                calificacionTres: e.target.calificacionTercera.value,
                calificacionFinal: e.target.calificacionFinal.value,
                activo: true,
                idEstudiante: idEstudianteURL,
            })

            formMateriasCursadas.reset();

            materiasAgregar(url, raw);

            tabla.replaceChild(tBody, tabla.querySelector('tbody'))
            
            materiasCursadasCargar(urlEstudiante);
            

        }


        if (e.target.id.value && idEstudianteURL != null) {

            let raw = JSON.stringify({
                idMateriasCursadas: e.target.id.value,
                claveMateria: e.target.clave.value,
                materia: e.target.materia.value,
                calificacionUno: e.target.calificacionPrimera.value,
                calificacionDos: e.target.calificacionSegunda.value,
                calificacionTres: e.target.calificacionTercera.value,
                calificacionFinal: e.target.calificacionFinal.value,
                activo: true,
                idEstudiante: idEstudianteURL,
            })

            materiasActualizar(url, raw);
            formMateriasCursadas.reset();
            materiasCursadasCargar(urlEstudiante);
        }
    }

    if (accionURL.toUpperCase() == "REGISTRO") {
        alert("Primero Guarda, ya despues ingresas Materias")
    }

 
});