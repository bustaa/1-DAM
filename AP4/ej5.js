const readlineSync = require("readline-sync");

function llenarArr() {
    let arr = [];
    let n;
    do {
        n = readlineSync.questionInt("Introduce un numero entero, (0 para terminar): ");
        if (n != 0) {
            arr.push(n);
        }
    } while (n != 0);
    return arr;
}

function productoElemArr(array1, array2) {
    let res;
    for (let i = 0; i < array1.length; i++) {
        res = array1[i] * array2[i];
        console.log(`Pos ${i+1}: ${res}`);
    }
}

let arr1, arr2;

console.log("Introduce los numeros del array 1: ");
arr1 = llenarArr();
console.log("Introduce los numeros del array 2: ");
arr2 = llenarArr();

if (arr1.length == arr2.length) {
    productoElemArr(arr1, arr2);
} else {
    console.log("Debes introducir dos arrays de la misma longitud");
}

console.log("Programa finalizado");