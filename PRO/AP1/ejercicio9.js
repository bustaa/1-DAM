/*
    Programa que lea dos números por teclado y muestre el resultado de la división del
    primero por el segundo Se debe comprobar que el divisor no puede ser cero.
*/

const readlineSync = require("readline-sync");

let num1, num2;

num1 = readlineSync.questionFloat("Introduce el primer numero: ");
num2 = readlineSync.questionFloat("Introduce el segundo numero: ");

if (num2 != 0) {
    let resultado = num1 / num2;
    console.log("El resultado de la división es: " + resultado);
} else {
    console.log("El divisor no puede ser 0");
}
