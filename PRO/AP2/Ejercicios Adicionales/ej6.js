const readlineSync = require("readline-sync");

let numBase, numExponente, resultado;

numBase = readlineSync.questionInt("Introduce la base: ");
numExponente = readlineSync.questionInt("Introduce el exponente: ");
resultado = numBase;

for (let i = numExponente; i > 1; i--) {
    resultado *= numBase;
}

console.log(`El resultado de ${numBase} elevado a ${numExponente} es: ${resultado}`);