const readlineSync = require("readline-sync");

let totalSuma, promedio, num, nNums;

totalSuma = 0;
nNums = 0;
promedio = 0;

do {
    num = readlineSync.questionFloat("Introduce un numero: ");
    if (num == 0) break;
    if (num % 2 != 0) continue;
    totalSuma += num;
    nNums++
} while (num != 0);

promedio = totalSuma / nNums;

console.log(`El total de la suma de los numeros introducidos es: ${totalSuma}, y su promedio es ${promedio}`);
console.log("Programa terminado");

