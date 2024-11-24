/*
    Programa que calcule el promedio aritmético de las notas obtenidas por un estudiante.
    las notas corresponden a tres exámenes parciales que deberán ser suministradas por
    teclado.
*/


const readlineSync = require("readline-sync");

let nota1, nota2, nota3;

nota1 = readlineSync.questionFloat("Introduce la nota 1: ");
nota2 = readlineSync.questionFloat("Introduce la nota 2: ");
nota3 = readlineSync.questionFloat("Introduce la nota 3: ");

let promedio = (nota1 + nota2 + nota3) / 3;

console.log("El promedio de las 3 notas es: " + promedio.toFixed(2));