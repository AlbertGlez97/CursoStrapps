// 3.3.2. Incremento y decremento
var numero = 5;
// numero = numero + 1;
++numero;
console.log(`Incremento y decremento ${numero}`);


//3.3.3.1. Negación
var visible = true;
alert(!visible);  // Muestra "false" y no "true"

var cantidad = 0;
vacio = !cantidad;  // vacio = true

cantidad = 2;
vacio = !cantidad;  // vacio = false

var mensaje = "";
mensajeVacio = !mensaje;  // mensajeVacio = true

mensaje = "Bienvenido";
mensajeVacio = !mensaje;  // mensajeVacio = false

//3.3.3.2. AND
//variable1 | variable2 | variable1 && variable2
//true      |  true	    |         true
//true      |  false	|         false
//false     |  true	    |         false
//false     |  false	|         false 

//3.3.3.3. OR
//variable1 | variable2 | variable1 && variable2
//true      |  true	    |         true
//true      |  false	|         true
//false     |  true	    |         true
//false     |  false	|         false 

//3.3.4. Matemáticos
var numero1 = 5;
numero1 += 3;  // numero1 = numero1 + 3 = 8
numero1 -= 1;  // numero1 = numero1 - 1 = 4
numero1 *= 2;   // numero1 = numero1 * 2 = 10
numero1 /= 5;   // numero1 = numero1 / 5 = 1
numero1 %= 4;   // numero1 = numero1 % 4 = 1

//3.3.5. Relacionales
var numero1 = 3;
var numero2 = 5;
resultado = numero1 > numero2; // resultado = false
resultado = numero1 < numero2; // resultado = true

numero1 = 5;
numero2 = 5;
resultado = numero1 >= numero2; // resultado = true
resultado = numero1 <= numero2; // resultado = true
resultado = numero1 == numero2; // resultado = true
resultado = numero1 != numero2; // resultado = false

// El operador "=" asigna valores
var numero1 = 5;
resultado = numero1 = 3;  // numero1 = 3 y resultado = 3

// El operador "==" compara variables
var numero1 = 5;
resultado = numero1 == 3; // numero1 = 5 y resultado = false