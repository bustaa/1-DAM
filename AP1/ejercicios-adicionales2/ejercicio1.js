const readlineSync = require("readline-sync");

let sexo, edad;
let puedeJubilarse = false;

sexo = readlineSync.question("Indique su sexo (hombre - mujer): ").toLowerCase(); 
edad = readlineSync.questionInt("Indique su edad: ");

if (sexo == "hombre" && edad >= 67) {
    puedeJubilarse = true;
} else if (sexo == "mujer" && edad >= 65) {
    puedeJubilarse = true;
}

if (puedeJubilarse) {
    console.log("Puede jubilarse");
} else {
    console.log("No puede jubilarse");
}



