/*
    Programa que lea dos frases por teclado y compruebe si son iguales.
*/

const readlineSync = require("readline-sync");

let frase1, frase2;

frase1 = readlineSync.question("Introduce la frase 1: ");
frase2 = readlineSync.question("Introduce la frase 2: ");

if (frase1.localeCompareç(frase2) == 0) {
    console.log("Las dos frases son iguales");
} else {
    console.log("Las dos frases no son iguales");
}