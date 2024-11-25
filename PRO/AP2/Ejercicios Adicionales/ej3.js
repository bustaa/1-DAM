const  readlineSync = require("readline-sync");

let nPedir, mayor0, menor0, igual0, num;

nPedir = readlineSync.questionInt("Cuantos numeros quieres introducir: ");
mayor0 = 0;
menor0 = 0;
igual0 = 0;

while (nPedir > 0) {
    nPedir--;
    num = readlineSync.questionInt("Introduce un numero: ");
    if (num < 0) {
        menor0++;
    } else if (num > 0) {
        mayor0++;
    } else {
        igual0++;
    }
}

console.log(`Numeros mayores que 0: ${mayor0}\nNumeros menores que 0: ${menor0}\nNumeros iguales a 0: ${igual0}`);