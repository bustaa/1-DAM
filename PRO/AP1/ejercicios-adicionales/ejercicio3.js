const readlineSync = require("readline-sync");

let gastoAnual = readlineSync.questionFloat("Introduzca gasto anual: ");
let tipoCliente = "";
let esValido = true;

if (gastoAnual < 0) {
    esValido = false;
}

if (esValido) {
    if (gastoAnual <= 25.34) {
        tipoCliente = "normal";
    } else if (gastoAnual <= 57.16) {
        tipoCliente = "bronce";
    } else if (gastoAnual <= 68.04) {
        tipoCliente = "plata";
    } else {
        tipoCliente = "oro";
    }
    console.log(`Usten es un cliente de tipo ${tipoCliente}`);
} else {
    console.log("Gasto anual no valido");
}

