const readlineSync = require("readline-sync");

let caracter;
let nNums = 0;

do {
    caracter = "";
    caracter = readlineSync.question("Introduce un caracter/letra: ");
    if (caracter.length != 1) {
        console.log("Intorduce solo un caracter");
        continue;
    } else {
        for (let i = 0; i <= 9; i++) {
            if (caracter == i) {
                nNums++;
            }
        }
    }
} while (caracter != ".")

console.log(`La cantidad total de caracteres entre el '0' y el '9' es ${nNums}`);