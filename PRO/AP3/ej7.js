const readlineSync = require("readline-sync");

function tipoCaracter(c) {
    let tipo;
    for (let i = 0; i < 10; i++) {
        if (c == i) {
            tipo = "numerico";
        }
    }
    if (tipo != "numerico") {
        c = c.toLowerCase();
        if (c.match(/[a-z]/i)) {
            tipo = "alfabetico"
        } else {
            tipo = "otro";
        }
    }
    return tipo;
}

function caracterUnico(c) {
    if (c.length == 1) {
        return true;
    } else {
        return false;
    }
}

let caracter, tipoCarac, salidaProg;

salidaProg = ".";

do {
    caracter = readlineSync.question("Introduce un caracter: ");
    if (caracter != salidaProg) {
        if (caracterUnico(caracter)) {
            tipoCarac = tipoCaracter(caracter);
            console.log(`${caracter} es de tipo ${tipoCarac}`);
        } else {
            console.log("Debe introducir un solo caracter");
        }
    }
} while (caracter != salidaProg);





