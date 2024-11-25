const readlineSync = require("readline-sync");

let caracter, esVocal;

esVocal = false;

do {
    caracter = readlineSync.question("Introduce un caracter: ");
    switch (caracter) {
        case 'a':
            esVocal = true;
            break;
        case 'e':
            esVocal = true;
            break;
        case 'i':
            esVocal = true;
            break;
        case 'o':
            esVocal = true;
            break;
        case 'u':
            esVocal = true;
            break;
        default:
            esVocal = false;
    }
    
    if (caracter != '.') {
        if (esVocal) {
            console.log("VOCAL");
        } else {
            console.log("NO VOCAL");
        }    
    }
    
} while (caracter != '.');

console.log("Programa finalizado");