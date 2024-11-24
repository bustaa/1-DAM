const readlineSync = require("readline-sync");

function calculaSalario(h, tarf) {
    let horas, tarifa, impTotal, impExtra, tarifaExtra;
    horas = h;
    tarifa = tarf;
    tarifaExtra = tarifa + (tarifa * porcExtra);
    if (horas > limHoras) {
        impExtra = (horas - limHoras) * tarifaExtra;
        impTotal = impExtra + (tarifa * limHoras);
    } else {
        impTotal = tarifa * horas;
    }
    return impTotal;
}

let nombrePersona, horasTrabSem, tarfConven, salir, limHoras, salario, tarfExtra;

limHoras = 40;
porcExtra = 0.25;
salir = "FIN";

do {
    nombrePersona = readlineSync.question("Introduce el nombre del trabajador: ");
    if (nombrePersona != salir) {
        horasTrabSem = readlineSync.questionFloat("Cuantas horas ha trabajado esta semana: ");
        tarfConven = readlineSync.questionInt("Cuanto es la tarifa convencional: ");
        salario = calculaSalario(horasTrabSem, tarfConven);
        console.log(`Su salario sera: ${salario} €`);
    }
} while (nombrePersona != salir);

console.log("Fin de programa");