const readlineSync = require("readline-sync");

function diferenciaEdad(edad1, edad2) {
    let diferencia = Math.abs(edad1 - edad2);
    return diferencia;
}

let edadHer1, edadHer2, dif;

edadHer1 = readlineSync.questionInt("Introduce la edad del hermano 1: ");
edadHer2 = readlineSync.questionInt("Introduce la edad del hermano 2: ");
dif = diferenciaEdad(edadHer1, edadHer2);

if (dif == 1) {
    console.log(`La diferencia de edad es de ${dif} año`);
} else {
    console.log(`La diferencia de edad es de ${dif} años`);
}