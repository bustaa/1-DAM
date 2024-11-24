const readlineSync = require("readline-sync");

let n, nNums, sumaNums, media;

nNums = 0;
sumaNums = 0;

do {
    n = readlineSync.questionInt("Intorduce un numero (pulse 0 para salir): ")
    if (n != 0) {
        nNums++;
        sumaNums += n;
    }
} while (n != 0)

media = sumaNums / nNums;
console.log(`La suma total de los numeros introducidos es ${sumaNums} y la media es ${media}`);