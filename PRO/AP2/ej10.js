const readlineSync = require("readline-sync");

let nNumsLoteria, numsLoteria, numRandom;

nNumsLoteria = 6;
numsLoteria = [];

do {
    numRandom = (Math.random()*100).toFixed(0);
    if (numRandom >= 1 && numRandom <= 49) {
        numsLoteria.push(numRandom);
    }
} while (numsLoteria.length < 6)

console.log(`La combinación de lotería primitiva es: ${numsLoteria}`);