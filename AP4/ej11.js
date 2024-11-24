const readlineSync = require("readline-sync");

function llenarArray(long) {
    let arr = [];
    let n;
    for (let i = 0; i < long; i++) {
        n = readlineSync.questionInt("Introduce un numero: ");
        arr.push(n);
    }
    return arr;
}

function ordenarArray(arr) {
    let arrOrdenado = [];
    let nMin, i;
    let array = [];
    array.push(...arr);
    do {
        nMin = Math.min(...array);
        i = array.indexOf(nMin);
        array.splice(i, 1);
        arrOrdenado.push(nMin);
    } while (arrOrdenado.length < 10);
    return arrOrdenado;
}

let long = 10;
let vecV = llenarArray(long);
let vecU = ordenarArray(vecV)

console.log(vecV, vecU);


