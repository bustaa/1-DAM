/*
    Programa que permita ingresar el número de partidos ganados, perdidos y empatados
    por un equipo en un torneo de futbol. Debe calcular y mostrar el total de los 
    putnos obtenidos, teniendo en cuenta que por cada partido ganador obtendrá 3 puntos,
    empatado sería 1 punto y perdido 0 puntos.
*/

const readlineSync = require("readline-sync");

let partidosGanados, partidosEmpatados, partidosPerdidos, puntos = 0;
let puntosG = 3, puntosE = 1, puntosP = 0;

partidosGanados = readlineSync.questionInt("Cuantos partidos ha ganado el equipo de futbol: ")
partidosEmpatados = readlineSync.questionInt("Cuantos partidos ha empatado el equipo de futbol: ")
partidosPerdidos = readlineSync.questionInt("Cuantos partidos ha perdido el equipo de futbol: ")

for (let i = 0; i < partidosGanados; i++) {
    puntos += puntosG;
}

for (let i = 0; i < partidosEmpatados; i++) {
    puntos += puntosE;
}

for (let i = 0; i < partidosPerdidos; i++) {
    puntos += puntosP;
}

console.log("El equipo ha conseguido un total de " + puntos + " puntos");
