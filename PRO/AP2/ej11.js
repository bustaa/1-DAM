const readlineSync = require("readline-sync")

let inicioLimite, finalLimite, esNegativo, sumaImpares;

do {
    esNegativo = true;
    inicioLimite = readlineSync.questionInt("Introduce el numero de inicio: ");
    finalLimite = readlineSync.questionInt("Introduce el numero de final: ");
    if (inicioLimite < 0 || finalLimite < inicioLimite) {
        console.log("El valor no puede ser negativo y el final no puede ser menor que el inicio");
        esNegativo = true;
    } else {
        esNegativo = false;
    }
} while (esNegativo)

let i = inicioLimite;
sumaImpares = 0;

while (i <= finalLimite) {
    if (i % 2 != 0) {
        sumaImpares += i;
    } 
    i++;
}

console.log(`La suma de los impares entre ${inicioLimite} y ${finalLimite} es: ${sumaImpares}`);

