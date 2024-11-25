/*
    Programa que lea una variable numérica <mes> e indique si el valor corresponde a un
    mes de 30, 31 o 28 días. Se mostrará además el nombre del mes. Se debe comprobar que
    el valor introducido esté comprendido entre 1 y 12.
*/

const readlineSync = require("readline-sync");

let numMes, numDias, esValido = true, nombreMes = "";

numMes = readlineSync.questionInt("Introduce el numero del mes: ");

switch(numMes) {
    case 1:
        nombreMes = "Enero";
        numDias = 31;
        break;
    case 2:
        nombreMes = "Febrero";
        numDias = 28;
        break;
    case 3:
        nombreMes = "Marzo";
        numDias = 31;
        break;
    case 4:
        nombreMes = "Abril";
        numDias = 30;
        break;
    case 5:
        nombreMes = "Mayo";
        numDias = 31;
        break;
    case 6:
        nombreMes = "Junio";
        numDias = 30;
        break;
    case 7:
        nombreMes = "Julio";
        numDias = 31;
        break;
    case 8:
        nombreMes = "Agosto";
        numDias = 31;
        break;
    case 9:
        nombreMes = "Septiembre";
        numDias = 30;
        break;
    case 10:
        nombreMes = "Octubre";
        numDias = 31;
        break;
    case 11:
        nombreMes = "Noviembre";
        numDias = 30;
        break;
    case 12:
        nombreMes = "Diciembre";
        numDias = 31;
        break;
    default:
        esValido = false;
}

if (esValido) {
    console.log("El mes numero " + numMes + " es el mes de " + nombreMes + " y tiene " + numDias + " dias");
} else {
    console.log("El numero no es valido");
}