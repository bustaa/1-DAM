const readlineSync = require("readline-sync");

let nIntroducidos, nPares, nImpares, numExit, n;

nIntroducidos = 0;
nPares = 0;
nImpares = 0;
numExit = 0;

do {
    n = readlineSync.questionInt("Introduce un numero: ");
    if (n == 0) continue;
    nIntroducidos++;
    if (n % 2 == 0) {
        nPares++;
    } else {
        nImpares++;
    }
} while (n != numExit);

console.log(`Numeros introducidos: ${nIntroducidos}`);
console.log(`Numeros pares: ${nPares}\nNumeros impares: ${nImpares}`);

