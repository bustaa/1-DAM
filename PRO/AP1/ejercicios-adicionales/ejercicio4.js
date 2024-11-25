const readlineSync = require("readline-sync");

let hora = readlineSync.questionInt("Introduce la hora: ");
let minutos = readlineSync.questionInt("Introduce la minutos: ");
let esPM = false;
let esValido = true;

if (hora < 0 || hora > 23 || minutos < 0 || minutos > 59) {
    esValido = false;
}

if(esValido) {

    if (hora > 12) {
        hora -= 12;
        esPM = true;
    }

    if (esPM) {
        console.log(`Son las ${hora}:${minutos} PM`);
    } else {
        console.log(`Son las ${hora}:${minutos} AM`);
    }
    
} else {
    console.log("La hora no es valida");
}

