export default function materiasCursandoCargar(idEstudianteURL) {

    var requestOptions = {
        method: 'GET',
        redirect: 'follow'
    };

    var urlMateriasCursando = "https://localhost:44337/MateriasCursando/" + idEstudianteURL;

fetch(urlMateriasCursando, requestOptions)
    .then(response => {
        return response.json();
    })
    .then(result => {
       
        const table = document.getElementById("tablaMateriasCursando");
        const template = document.getElementById("templateMateriasCursando").content;
        const fragment = document.createDocumentFragment();

        result.forEach((el) => {

            template.querySelector(".clave").textContent = el.claveMateria
            template.querySelector(".materia").textContent = el.materia
            template.querySelector(".horario").textContent = el.horario
            template.querySelector(".primerCalificacion").textContent = el.calificacionUno
            template.querySelector(".segundaCalificacion").textContent = el.calificacionDos
            template.querySelector(".tercerCalificacion").textContent = el.calificacionTres

            template.querySelector(".editar").dataset.idMateriasCursando = el.idMateriasCursando;
            template.querySelector(".editar").dataset.claveMateria = el.claveMateria
            template.querySelector(".editar").dataset.materia = el.materia
            template.querySelector(".editar").dataset.horario = el.horario
            template.querySelector(".editar").dataset.calificacionUno = el.calificacionUno
            template.querySelector(".editar").dataset.calificacionDos = el.calificacionDos
            template.querySelector(".editar").dataset.calificacionTres = el.calificacionTres

            template.querySelector(".eliminar").dataset.idMateriasCursando = el.idMateriasCursando;

            let clone = document.importNode(template, true);
            fragment.appendChild(clone);
        });

        table.querySelector("tbody").appendChild(fragment);
    })
}