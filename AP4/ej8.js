const readlineSync = require("readline-sync");

function llenarArr() {
    let arr = [];
    let n;
    do {
        n = readlineSync.questionInt("Introduce un numero entero, (-1 para terminar): ");
        if (n != -1) {
            arr.push(n);
        }
    } while (n != -1);
    return arr;
}

function esCapicua(arr) {
    let arrInvertida = []
    arrInvertida.push(...arr);
    arrInvertida.reverse();
    for (let i = 0; i < arr.length; i++) {
        if (arr[i] != arrInvertida[i]) return false;
    }
    return true;
}

let arrayNums = llenarArr();

if(esCapicua(arrayNums)) {
    console.log("El array es capicua");
} else {
    console.log("El array no es capicua");
}