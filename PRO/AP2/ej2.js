const readlineSync = require("readline-sync")

let nMayores, nMenores, edad, nPersonas, i;

nPersonas = 5;
nMayores = 0;
nMenores = 0;
i = 0;

do {
    edad = readlineSync.questionInt("Introduzca la edad: ");
    if (edad < 18 && edad >= 0) {
        nMenores++;
    } else if (edad >= 18) {
        nMayores++;
    } else {
        console.log("Edad no valida");
    }
    i++;
} while (i < nPersonas);

console.log(`Hay ${nMenores} menores de edad y ${nMayores} mayores de edad.`);