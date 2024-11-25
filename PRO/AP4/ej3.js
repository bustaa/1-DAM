const readlineSync = require("readline-sync");

function llenarArray(longArray) {
    let n, arr = [];
    for (let i = longArray; i > 0; i--) {
        n = readlineSync.questionInt("Intorduce un numero: ");
        arr.push(n);
    }
    return arr;
}

function esPar(n) {
    if (n % 2 == 0) {
        return true;
    } else {
        return false;
    }
}

let longArr = 10;
let arrNums = llenarArray(longArr);
let nPar = 0;

for (let i = 0; i < arrNums.length; i++) {
    if (esPar(arrNums[i])) {
        nPar++;
    }    
}

console.log(`Numeros pares: ${nPar}\nNumeros impares: ${longArr - nPar}`);