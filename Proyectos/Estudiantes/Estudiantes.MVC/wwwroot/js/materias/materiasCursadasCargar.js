export default function materiasCursadasCargar(idEstudianteURL,visible) {

    const $table = document.getElementById("tablaMateriasCursadas");
    const $template = document.getElementById("templateMateriasCursadas").content;
    const $fragment = document.createDocumentFragment();

    var requestOptions = {
        method: 'GET',
        redirect: 'follow'
    };

    var urlMateriasCursadas = "https://localhost:44337/MateriasCursadas/" + idEstudianteURL;

fetch(urlMateriasCursadas, requestOptions)
    .then(response => {
        return response.json();
    })
    .then(result => {
      
        result.forEach((el) => {

            $template.querySelector(".clave").textContent = el.claveMateria;
            $template.querySelector(".materia").textContent = el.materia;
            $template.querySelector(".calificacionPrimera").textContent = el.calificacionUno;
            $template.querySelector(".calificacionSegunda").textContent = el.calificacionDos;
            $template.querySelector(".calificacionTercera").textContent = el.calificacionTres;
            $template.querySelector(".calificacionFinal").textContent = el.calificacionFinal;

            $template.querySelector(".editarMaterias").dataset.idMateriasCursadas = el.idMateriasCursadas;
            $template.querySelector(".editarMaterias").dataset.claveMateria = el.claveMateria;
            $template.querySelector(".editarMaterias").dataset.materia = el.materia;
            $template.querySelector(".editarMaterias").dataset.calificacionUno = el.calificacionUno;
            $template.querySelector(".editarMaterias").dataset.calificacionDos = el.calificacionDos;
            $template.querySelector(".editarMaterias").dataset.calificacionTres = el.calificacionTres;
            $template.querySelector(".editarMaterias").dataset.calificacionFinal = el.calificacionFinal;
            $template.querySelector(".editarMaterias").disabled = visible;

            $template.querySelector(".eliminarMaterias").dataset.idMateriasCursadas = el.idMateriasCursadas;
            $template.querySelector(".eliminarMaterias").disabled = visible;

            let clone = document.importNode($template, true);
            $fragment.appendChild(clone);
        })

        $table.querySelector("tbody").appendChild($fragment);
    })
}