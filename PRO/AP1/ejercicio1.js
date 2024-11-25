/* 
    Programa que calcule la distancia recorrida (m) por un movil que tiene velocidad
    constante (m/sg) durante un tiempo T (sg). Considera que es un MRU (Movimiento
    rectilíneo uniforme)
*/

const readlineSync = require("readline-sync");

let velocidad, tiempo, distancia;

velocidad = readlineSync.questionFloat("Introduce la velocidad (m/s): ");
tiempo = readlineSync.questionFloat("Introduce el tiempo (s): ");

distancia = velocidad * tiempo;

console.log("La distancia recorrieda en " + tiempo + " a una velocidad de " + velocidad + " es: " + distancia + " (m)");
