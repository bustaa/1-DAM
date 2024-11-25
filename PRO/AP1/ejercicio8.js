/*
    Programa que lea dos caracteres y compruebe si son dos letras minúsuclas
*/

const readlineSync = require("readline-sync");

let letra1, letra2;

letra1 = readlineSync.question("Introduce el primer caracter: ");
letra2 = readlineSync.question("Introduce el segundo caracter: ");

if (letra1.length == 1 && letra2.length == 1) {
    let minusculaLetra1, minusculaLetra2;

    minusculaLetra1 = letra1.toLowerCase();
    minusculaLetra2 = letra2.toLowerCase();

    if(letra1 == minusculaLetra1 && letra2 == minusculaLetra2) {
        console.log("Las dos letras son minusculas");
    } else {
        console.log("No son dos letras minusculas");
    }
} else {
    console.log("Has introducido más de un caracter, prueba de nuevo");
    console.log(letra1.length, letra2.length);
}