const readlineSync = require("readline-sync")

let sumaSueldo, promSueldo, nSueldos, nPedirSueldos, sueldo, listSueldos, maxSueldo;

sumaSueldo = 0;
nSueldos = 0;
nPedirSueldos = 5;
listSueldos = [];

do {
    sueldo = readlineSync.questionFloat("Introduce el sueldo del empleado: ");
    sumaSueldo += sueldo;
    nSueldos++;
    listSueldos.push(sueldo);
} while (nSueldos < nPedirSueldos);

promSueldo = sumaSueldo / nSueldos;

maxSueldo = Math.max(...listSueldos)

console.log(`La suma total de sueldo es ${sumaSueldo}\nEl promedio de sueldo es: ${promSueldo}\nEl sueldo maximo es: ${maxSueldo}`);