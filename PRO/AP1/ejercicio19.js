/*
    Programa que te permita ingresar el total de ventas alcanzado por un vendedor durante
    un mes y calcule la comisión que recibirá atendiendo a la siguiente tabla de comisiones:

    ---------------------------------------
    | Cifra de Ventas  |  Comisión (%)   |
    ---------------------------------------
    |     0-999        |        0        |
    ---------------------------------------
    |    1000-4999     |        3        |
    ---------------------------------------
    |    5000-19999    |        5        |
    ---------------------------------------
    |   20000 y más    |        8        |
    ---------------------------------------
*/

const readlineSync = require("readline-sync");

let ventas, tipoComision, comision;

ventas = readlineSync.questionInt("Cuantas ventas ha alcanzado el vendedor en el ultimo mes: ");

if (ventas >= 20000) {
    tipoComision = 0.08;
} else if (ventas >= 5000) {
    tipoComision = 0.05;
} else if (ventas >= 1000) {
    tipoComision = 0.03;
} else {
    tipoComision = 0;
}

comision = ventas * tipoComision;

console.log("El vendedor se llevará una comisión de " + comision + " € \nEl tipo de comision es del " + tipoComision * 100);
