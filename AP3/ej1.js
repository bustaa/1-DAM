const readlineSync = require("readline-sync");

function esPar(n) {
    if (n % 2 == 0) {
        return true;
    } else {
        return false;
    }
}

let num, par;

num = readlineSync.questionInt("Introduce un numero: ");
par = esPar(num);

if (par) {
    console.log(`${num} es par`);
} else {
    console.log(`${num} es impar`);
}