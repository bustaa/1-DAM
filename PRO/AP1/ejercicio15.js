/*
    Programa que tras leer un número entre 1 y 10, muestre su equivalente en númeor
    romano.
*/

const readlineSync = require("readline-sync");

let num, equivalenteRomano, numValido;

numValido = true;
num = readlineSync.questionInt("Introduce un numero entre 1 y 10: ");

switch(num) {
    case 1: 
        equivalenteRomano = "I";
        break;
    case 2:
        equivalenteRomano = "II";
        break;
    case 3: 
        equivalenteRomano = "III";
        break;
    case 4:
        equivalenteRomano = "IV";
        break;
    case 5:
        equivalenteRomano = "V";
        break;
    case 6:
        equivalenteRomano = "VI";
        break;
    case 7: 
        equivalenteRomano = "VII";
        break;
    case 8:
        equivalenteRomano = "VIII";
        break;
    case 9:
        equivalenteRomano = "IX";
        break;
    case 10:
        equivalenteRomano = "X";
        break;
    default:
        numValido = false;
}

if(numValido) {
    console.log("El numero " + num + " en numero romano es: " + equivalenteRomano);
} else {
    console.log("Numero no valido");
}