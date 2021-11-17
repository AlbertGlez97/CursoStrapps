//Ejercicio.- Determinar la cantidad total a pagar por una llamada telefonica,
//teniendo en cuenta lo siguiente:
//* Toda llamada que dure menos de tres minutos (cinco pasos) tiene un coste de 10 centimos
//* Cada minuto adicional a partir de los tres primeros es un paso de contador y cuesta 5 centimos
//1.- Inicio
//2.- Leer la duracion de la llamada y asignarla a duracion
let Duracion = prompt("¿Cuál es la duracion de la llamada?", "");
//Detectamos si el usuario ingreso un valor
if (Duracion != null){
    totalPagar (Duracion)
}
//Detectamos si el usuario NO ingreso un valor
else {
alert("No has ingresado una Duracion");
}

function totalPagar (Duracion){
//3.- Declarar variables totalPagar , resto
let totalPagar, resto;
//4.- Asignar totalPagar = 10
totalPagar = 10;
//5.- Valida si la duracion es mayor a 3 minutos
if(Duracion > 3){
    //5.1.- Si la duracion es mayor a 3 minutos
        //resto = duracion - 3
        resto = Duracion - 3;
        // totalPagar = totalPagar + resto * S
        totalPagar = totalPagar + resto * 5;
}
//6.- El totla a pagar es totalPagar
alert(`Total a pagar es: ${totalPagar}`);
//7.- Fin
}