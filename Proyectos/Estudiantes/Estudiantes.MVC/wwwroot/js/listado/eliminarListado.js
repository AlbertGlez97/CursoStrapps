export default function eliminar(idEstudiante) {

    let Eliminar = confirm("¿Esta seguro que desea eliminar el empleado?");
   
    if (Eliminar == true) {
        const requestOptions = {
            method: 'DELETE',
            redirect: 'follow'
        };
        let url ="https://localhost:44337/Estudiantes/"+idEstudiante;

        fetch(url, requestOptions)
            .then(response => response.json())
            .then(result => { 
                console.log("El estudiante se elimino correctamente");
                location.reload();
            })
            .catch(error => {
                console.log('error', error)
                alert("Hubo un error al eliminar el estudiante, contacte al administrador del sistema");
            });
    } else
    {
        return;
    }
   
}