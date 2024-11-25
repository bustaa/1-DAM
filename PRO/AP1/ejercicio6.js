/*
    Porgrama que pida la edaa de 2 hermanos y muestre un mensaje indicando la edad del 
    mayor y cuantos años de diferencia tiene con el menor.
*/

const readlineSync = require("readline-sync");

let edadHermano1, edadHermano2, diferenciaEdad;

edadHermano1 = readlineSync.questionInt("Introduce la edad del hermano 1: ");
edadHermano2 = readlineSync.questionInt("Introduce la edad del hermano 2:");
diferenciaEdad = Math.abs(edadHermano1 - edadHermano2);

if (edadHermano1 == edadHermano2) {
    console.log("Los dos hermanos tiene la misma edad");
} else if (edadHermano1 > edadHermano2) {
    console.log("El hermano 1 es mayor, la diferencia de edad es: " + diferenciaEdad);
} else {
    console.log("El hermano 2 es mayor, la diferencia de edad es: " + diferenciaEdad);
}