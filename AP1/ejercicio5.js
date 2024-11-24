/*
    Programa que pida un carácter por teclado y compruebe si es una letra mayúscula.
*/


const readlineSync = require("readline-sync");

let letra = readlineSync.question("Introduce una letra: ");
let letraMayuscula = letra.toUpperCase();

if(letra === letraMayuscula) {
    console.log("La letra " + letra + " es mayuscula");
} else {
    console.log("La letra " + letra + " no es mayuscula");
}