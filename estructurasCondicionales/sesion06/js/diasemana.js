const readlineSync = require('readline-sync');

let diaSemana = readlineSync.question("Que dia es? ");
let numDia;
let diaEncontrado = true;

diaSemana = diaSemana.toLowerCase();

switch(diaSemana) {
    case "lunes": 
        numDia = 1;
        break;
    case "martes": 
        numDia = 2;
        break;
    case "miercoles": 
        numDia = 3;
        break;
    case "jueves": 
        numDia = 4;
        break;
    case "viernes": 
        numDia = 5;
        break;
    case "sabado": 
        numDia = 6;
        break;
    case "domingo":  
        numDia = 7;
        break;
    default: 
        diaEncontrado = false;
}

if (diaEncontrado) {
    console.log("El día", diaSemana, "es el", numDia + "º");
} else {
    console.log("Dia no encontrado");
}
