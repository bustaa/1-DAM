const readlineSync = require("readline-sync");

function llenarArray(longArray) {
    let n, arr = [];
    for (let i = longArray; i > 0; i--) {
        n = readlineSync.questionInt("Intorduce un numero: ");
        arr.push(n);
    }
    return arr;
}

function imprimirArray(arr) {
    for (let i = 0; i < arr.length; i++) {
        console.log(`Posicion ${i}: ${arr[i]}`);
    }
}

let longArr = 10;
let arrNums = llenarArray(longArr);
imprimirArray(arrNums);


