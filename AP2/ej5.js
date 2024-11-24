const readlineSync = require("readline-sync")

let nMultiplos = 50;
let multiplo = 3;
let nMultiplosEncontrados = 0;
let i = 1;
let listNums = [];

while (nMultiplosEncontrados <= nMultiplos) {
    if (i % multiplo == 0) {
        listNums.push(i);
        nMultiplosEncontrados++;
    }
    i++;
}

console.log(`Los primeros ${nMultiplos} multiplos de ${multiplo} son: ${listNums}`);