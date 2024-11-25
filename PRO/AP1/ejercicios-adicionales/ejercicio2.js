const readlineSync = require("readline-sync");

let anyo = readlineSync.questionInt("Introduce el anyo: ");
let esBisiesto = false;

if (anyo % 4 == 0) {
    esBisiesto = true;
    if (anyo % 100 == 0 && anyo % 400 != 0) {
        esBisiesto = false;
    } 
}

if(esBisiesto) {
    console.log(`El año ${anyo} es bisiesto`);
} else {
    console.log(`El año ${anyo} no es bisiesto`);
}
