const readlineSync = require("readline-sync");

let listTemperturas, temperatura, tempExit, maxTemp, minTemp;

listTemperturas = []
tempExit = 99;

do {
    temperatura = readlineSync.questionFloat("Introduce la temperatura registrada: ");
    if (temperatura == 99) continue;
    listTemperturas.push(temperatura);
} while (temperatura != tempExit)

maxTemp = Math.max(...listTemperturas);
minTemp = Math.min(...listTemperturas);

console.log(`Temperatura maxima: ${maxTemp}\nTemperatura minima: ${minTemp}`);