const readlineSync = require("readline-sync");

function horaValida(h, m, s) {
    if (h > 23 || h < 0) {
        return false;
    }
    if (m > 59 || m < 0) {
        return false;
    }
    if (s > 59 || s < 0) {
        return false;
    }
    return true;
}

let horas, minutos, segundos;

horas = readlineSync.questionInt("Introduce la hora: ");
minutos = readlineSync.questionInt("Introduce los minutos: ");
segundos = readlineSync.questionInt("Introduce los segundos: ");

if (horaValida(horas, minutos, segundos)) {
    console.log("La hora es valida");
} else {
    console.log("La hora no es valida");
}
 
