const readlineSync = require("readline-sync");

function tabla(n, lim) {
    let r;
    for (let i = 1; i <= lim; i++) {
        r = n * i;
        console.log(`${n} x ${i} = ${r}`);
    }
}

let nTabla, limTabla; 

nTabla = readlineSync.questionInt("Introduce la tabla que quieres visualizar: ");
limTabla = readlineSync.questionInt("Cual es el limite de la tabla: ")

tabla(nTabla, limTabla);
