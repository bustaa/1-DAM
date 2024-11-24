var readlineSync = require("readline-sync");

let nota = readlineSync.questionFloat("Introduce tu nota: ")
let rangoNota = "";

if (nota < 0 || nota > 10) {
    rangoNota = "no valida";
} else if (nota < 5) {
    rangoNota = "insuficiente";
} else if (nota < 7) {
    rangoNota = "bien";
} else if (nota < 9) {
    rangoNota = "notable"
} else {
    rangoNota = "sobresaliente";
}

console.log("Tu nota", nota, "es un", rangoNota);