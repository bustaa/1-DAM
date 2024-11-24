/*
    Programa que pida un número y muestre si el número es múltiplo de 10.
*/ 

const readlineSync = require("readline-sync");

let num = readlineSync.questionInt("Introduce el numero: ");

if (num % 10 == 0) {
    console.log("El numero " + num + " es multiplo de 10.");
} else {
    console.log("El numero " + num + " no es multiplo de 10.");
}