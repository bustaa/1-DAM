const readlineSync = require("readline-sync");

function primo(n) {
    nDivisores = 0;
    for (let i = 1; i <= n; i++) {
        if (n % i == 0) {
            nDivisores++;
        }
    }
    if (nDivisores == 2) {
        return true;
    } else {
        return false;
    }
}

let num, esPrimo;

num = readlineSync.questionInt("Introduce un numero: ");
esPrimo = primo(num);

if (esPrimo) {
    console.log(`El ${num} es primo`);
} else {
    console.log(`El ${num} no es primo`);
}