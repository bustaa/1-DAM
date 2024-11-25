/*
    Programa que permita calcular el número de CDs necesarios para hacer una copia de
    seguridad de la información almacenada en un HD cuya capacidad se conoce (deberás pedirla por
    teclado). Considera que el disco duro está lleno de información y su capacidad expresada en
    GigaBytes. Un CD virgen tiene 700 Megabytes de capacidad y un Gigabyte es igual a 1.024 megabytes.
*/

const readlineSync = require("readline-sync");
const CAPACIDAD_CD = 700;

let capacidadDisco, capacidadDiscoMegabytes, numCDs;

capacidadDisco = readlineSync.questionFloat("Introduce la capacidad del disco (en GB): ");

capacidadDiscoMegabytes = capacidadDisco * 1024;

numCDs = capacidadDiscoMegabytes / CAPACIDAD_CD;

console.log("Para hacer una copia de seguridad del disco con una capacidad de " + capacidadDisco + " GB, necesitarás " + Math.trunc(numCDs)+ 1 + " CDs");

