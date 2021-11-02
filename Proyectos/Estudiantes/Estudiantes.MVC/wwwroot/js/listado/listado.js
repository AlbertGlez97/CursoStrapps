import cargarListado from "./obtenerListado.js";
import eliminar from "./eliminarListado.js";


document.addEventListener("DOMContentLoaded", (e) => {
    cargarListado();
});

document.addEventListener("click", (e) => {
    if (e.target.matches("#Eliminar")) {
        event.preventDefault();
        eliminar(e.target.dataset.id);
    }
        
});