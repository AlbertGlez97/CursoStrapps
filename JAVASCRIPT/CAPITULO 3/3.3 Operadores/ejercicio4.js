var valores = [true, 5, false, "hola", "adios", 2];

// Determinar cual de los dos elementos de texto es mayor
let textoMayor = valores[3] > valores[4];
// Utilizando exclusivamente los dos valores booleanos del array, determinar los operadores necesarios para obtener un resultado true y otro resultado false
let resultPositivo =valores[0] || valores[2];

let resultNegativo =valores[0] && valores[2];
// Determinar el resultado de las cinco operaciones matemáticas realizadas con los dos elementos numéricos
var num1 = valores[1];
var num2 = valores[5];

var suma = num1 + num2;
console.log(suma);

var resta = num1 - num2;
console.log(resta);

var multiplicacion = num1 * num2;
console.log(multiplicacion);

var division = num1 / num2;
console.log(division);

var modulo = num1 % num2;
console.log(modulo);