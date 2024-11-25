/*
    Programa que, tras pedir la medida de los tres lados de un triángulo identifique qué
    tipo es (escaleno, equilátero o isósceles). Averigua cual es la característica de cada
    uno de ellos que te puede ayudar a identificarlos y pensar la lógica de programación a
    emplear.
*/

const readlineSync = require("readline-sync");

let lado1, lado2, lado3, tipoTriangulo;

lado1 = readlineSync.questionFloat("Introduce la medida del lado 1: ")
lado2 = readlineSync.questionFloat("Introduce la medida del lado 2: ")
lado3 = readlineSync.questionFloat("Introduce la medida del lado 3: ")
tipoTriangulo = "";

if (lado1 == lado2 && lado2 == lado3) {
    tipoTriangulo = "escaleno"
} else if (lado1 == lado2 || lado1 == lado3 || lado2 == lado3) {
    tipoTriangulo = "isósceles";
} else {
    tipoTriangulo = "equilatero";
}

console.log("El trinagulo es " + tipoTriangulo);

