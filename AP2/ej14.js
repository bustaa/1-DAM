const readlineSync = require("readline-sync");

let numRandom, numIntroducido, nIntentos;

numRandom = (Math.random()*100).toFixed(0);
nIntentos = readlineSync.questionInt("En cuantos intentos quieres realizarlo: ");

do {
    if (nIntentos > 0) {
        numIntroducido = readlineSync.questionInt(`Introduce el numero, te quedan ${nIntentos} intentos: `);
        if (numIntroducido == numRandom) {
            console.log("Correcto");
            continue;
        } else if (numIntroducido < numRandom) {
            console.log(`El numero es mayor a ${numIntroducido}`);
            nIntentos--;
        } else {
            console.log(`El numero es menor a ${numIntroducido}`);
            nIntentos--;
        }
    } else {
        console.log("No te quedan intentos");
        break;
    }
} while (numIntroducido != numRandom)