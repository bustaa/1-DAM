var readlineSync = require("readline-sync");

let num1 = readlineSync.questionFloat("Introduce el primer numero: ");
let num2 = readlineSync.questionFloat("Introduce el segundo numero: ");

let resultado = num1 + num2;

console.log("La suma de los dos numeros es: " + resultado);
console.log(typeof resultado);