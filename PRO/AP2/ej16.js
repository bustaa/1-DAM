const readlineSync = require("readline-sync");

let inicioLimite, finLimite, nNumsPrimos, esPrimo;

inicioLimite = 2;
finLimite = 1000;
nNumsPrimos = 0;
esPrimo = true;

for (let i = inicioLimite; i < 1000; i++) {
    esPrimo = true;
    for (let j = 2; j < i; j++) {
        if (i % j == 0) {
            esPrimo = false;
            break;
        } else {
            esPrimo = true;
        }
    }
    if (esPrimo) {
        nNumsPrimos++;
    }
}

console.log(`Hay ${nNumsPrimos} numeros primos entre ${inicioLimite} y ${finLimite}`);