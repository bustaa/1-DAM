/*
    Programa que solicite una vocal e indique el número / orden de la misma, teniendo en
    cuenta que la "A" sería la primera y la "U" sería la quinta.
*/

const readlineSync = require("readline-sync");

let vocal, orden, esValida;

esValida = true;
vocal = readlineSync.question("Introduce una vocal: ");

switch(vocal) {
    case "a":
        orden = 1;
        break;
    case "e":
        orden = 2;
        break;
    case "i":
        orden = 3;
        break;
    case "o":
        orden = 4;
        break;
    case "u":
        orden = 5;
        break;
    default: 
        esValida = false;
}

if (esValida) {
    console.log("La vocal " + vocal + " esta en el orden " + orden);
} else {
    console.log("No has introducido una vocal");
}