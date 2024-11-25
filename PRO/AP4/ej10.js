const readlineSync = require("readline-sync");
const arrLetras = ["A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z"];

let n;
let arr = [];
do {
    n = readlineSync.questionInt("Introduce el numero de letra que deseas añadir, (0-25): ");
    if (n >= 0 && n < 26) {
        arr.push(arrLetras[n]);
    } else if (n != -1) {
        console.log("Numero no valido");
    }
} while (n != -1);

console.log(arr.join(", "));
console.log("Programa finalizado");




