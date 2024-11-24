const readlineSync = require("readline-sync");

let limInferios, limSuperior, limValido, num, sumaNums, numsFuera;

limValido = false;
sumaNums = 0;
numsFuera = 0;

do {
    limInferios = readlineSync.questionInt("Introduce el limite inferior del intervalo: ");
    limSuperior = readlineSync.questionInt("Introduce el limite superior del intervalo: ");
    if (limInferios > limSuperior) {
        console.log("El intervalo no es valido, vuelva a introducirlo.");
        limValido = false;
    } else {
        limValido = true;
    }
} while (!limValido);

do {
    num = readlineSync.questionInt("Introduce un numero: ");
    if (num != 0) {
        if (num >= limInferios && num <= limSuperior) {
            sumaNums += num;
        } else {
            numsFuera++;
        }
    }
} while (num != 0);

console.log(`Programa finalizado\nSuma de numeros dentro del intervalo: ${sumaNums}\nNumeros fuera del intervalo: ${numsFuera}`);