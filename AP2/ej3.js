const readlineSync = require("readline-sync")

let n1, n2, resultado;

resultado = 0;

n1 = readlineSync.questionInt("Introduce el primer numero: ");
n2 = readlineSync.questionInt("Introduce el segundo numero: ");

for (let i = 0; i < n2; i++) {
    resultado += n1;
}

console.log(`El resultado es ${resultado}`);