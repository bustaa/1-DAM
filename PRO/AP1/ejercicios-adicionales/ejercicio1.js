const readlineSync = require("readline-sync");


let minutosHablados = readlineSync.questionInt("Cuantos minutos ha hablado el ultimo mes? ");
let tarifaBase = 10;
let esValido = true;
let franja1, franja2, tarifa1, tarifa2;

franja1 = 180;
franja2 = 240;
tarifa1 = 0.1;
tarifa2 = 0.2;

esValido = minutosHablados < 0 ? false : true; 

if (esValido) {
    if (minutosHablados <= franja1) {
        tarifaBase;
    } else if (minutosHablados <= franja1) {
        let anyadidoFranja1 = (minutosHablados - franja1) * tarifa1;
        tarifaBase += anyadidoFranja1;
    } else {
        let anyadidoFranja2 = (franja2 - franja1) * tarifa1 + (minutosHablados - franja2) * tarifa2;
        tarifaBase += anyadidoFranja2;
    }
    console.log(`Debe pagar ${tarifaBase.toFixed(2)}€`);
} else {
    console.log("Debes introducir un numero valido");
}

