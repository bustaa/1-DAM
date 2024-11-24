const readlineSync = require("readline-sync");

let totalSuma, promedio, num, nNums, esPositivo;

totalSuma = 0;
esPositivo = false;

do {
    nNums = readlineSync.questionInt("Cuantos numeros: ");
    if (nNums < 0) {
        console.log("No se aceptan numeros negativos");
    } else {
        esPositivo = true;
    }
} while (!esPositivo)

for (let i = 0; i < nNums; i++) {
    num = readlineSync.questionFloat("Introduce un numero: ");
    totalSuma += num;
}

promedio = totalSuma / nNums;

console.log(`El total de la suma de los numeros introducidos es: ${totalSuma}, y su promedio es ${promedio}`);
console.log("Programa terminado");

