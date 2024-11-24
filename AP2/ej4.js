const readlineSync = require("readline-sync")

let limite = 100;
let multiplo = 3;
let listNums = [];

for (let i = 1; i <= limite; i++) {
    if (i % 3 == 0) {
        listNums.push(i);
    }
}

console.log(`Los numeros multiplos de ${multiplo} entre 1 y ${limite} son: ${listNums}`);