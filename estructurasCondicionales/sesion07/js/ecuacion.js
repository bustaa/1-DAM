const readlineSync = require("readline-sync");

let numA, numB, numC;

numA = readlineSync.questionInt("Introduce el numero a: ");
numB = readlineSync.questionInt("Introduce el numero b: ");
numC = readlineSync.questionInt("Introduce el numero c: ");

let discriminante = Math.pow(numB, 2) - 4 * numA * numC;

if (discriminante >= 0) {
    let discriminanteRaiz = Math.sqrt(discriminante);
    let x1, x2;

    x1 = (-numB - discriminanteRaiz) / (2 * numA);
    x2 = (-numB + discriminanteRaiz) / (2 * numA);

    console.log("La solución uno es: " + x1 + ", la solución dos es: " + x2);
} else {
    console.log("No tiene solución real");
}

