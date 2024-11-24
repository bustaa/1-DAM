var readlineSync = require("readline-sync");

let edad = readlineSync.questionInt("Cual es tu edad: ");

if (edad < 0) {
    console.log("Edad Errónea. Debe ser positiva");
} else if (edad <= 18) {
    console.log("Eres joven");
} else if (edad <= 65){
    console.log("Eres adulto");
} else {
    console.log("Eres mayor");
}
