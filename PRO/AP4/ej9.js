const readlineSync = require("readline-sync");

function esPrimo(n) {
    if (n <= 2) return false;
    for (let i = 2; i < n; i++) {
        if (n % i == 0) return false;
    }
    return true;
}

function llenarArrayPrimos(longArr) {
    let arr = [];
    let n = 1;
    do {
        if (esPrimo(n)) {
            arr.push(n);
        }
        n++;
    } while (arr.length < longArr);
    return arr;
}

let longArr = readlineSync.questionInt("Cuantos numeros debe contener el array: ");
let arrayPrimos = llenarArrayPrimos(longArr);
console.log(arrayPrimos.join(", "));


