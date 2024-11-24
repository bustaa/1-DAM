const readlineSync = require("readline-sync");

function pedirNumArr(longVec) {
    let n;
    let arr = [];
    for (let i = longVec; i > 0; i--) {
        n = readlineSync.questionInt("Introduce un numero: ");
        arr.push(n);
    }
    return arr; 
}

function promedio(array) {
    let min = Math.min(...array);
    let max = Math.max(...array);

    let promedio = (min + max) / 2;

    return promedio;
} 

let longVec = 5;
let media;

vec = pedirNumArr(longVec);
console.log(vec)
media = promedio(vec)

console.log(`El promedio de los numeros introducidos es: ${media}`)

let cambio = true;
