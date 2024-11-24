const readlineSync = require("readline-sync");

function factorial(num) {
    let factorial = num;
    for (let i = num-1; i >= 1; i--) {
        factorial *= i;
    }
    return factorial;
}

let n, nFactorial;

n = readlineSync.questionInt("Introduce un numero: ")
nFactorial = factorial(n);
console.log(`El factorial de ${n} es: ${nFactorial}`);