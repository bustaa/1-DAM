/*
    Programa que pida un número y calcule si es par o impar.
*/ 

const readlineSync = require("readline-sync");

let num = readlineSync.questionInt("Introduce el numero: ");

if (num % 2 == 0) {
    console.log("El numero " + num + " es par.");
} else {
    console.log("El numero " + num + " es impar.");
}