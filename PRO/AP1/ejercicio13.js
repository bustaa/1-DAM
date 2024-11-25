/*
    Programa que lea tres números enteros H, M, S que contienen hora, minutos y 
    segundos respectivamente, y comprueba si la hora que indican es una hora válida.
    Será válida en caso que la hora esté entre 0..24 y los minutos y segundos entre 0..59.
*/

const readlineSync = require("readline-sync");

let h, m, s;

h = readlineSync.questionInt("Introduce la hora (H): ")
m = readlineSync.questionInt("Introduce los minutos (M): ")
s = readlineSync.questionInt("Introduce los segundos (S): ")

let esValida;

if (h >= 0 && h <= 24 && m >= 0 && m <= 59 && s >= 0 && s <= 59) {
    esValida = true;
} else {
    esValida = false;
}

if (esValida) {
    console.log("La hora es valida");
} else {
    console.log("La hora no es valida");
}