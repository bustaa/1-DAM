const readlineSync = require("readline-sync")

let nombreEmpleado, antiguedad, gratificacion, continuar;

do {
    gratificacion = 0;
    nombreEmpleado = readlineSync.question("Introduce tu nombre: ");
    antiguedad = readlineSync.questionInt("Introduce cuantos años llevas en la empresa: ");

    if (antiguedad > 3 && antiguedad < 10) {
        gratificacion = 100;
        console.log(`${nombreEmpleado}, tu gratificacion es de ${gratificacion}€`);
    } else if (antiguedad >= 10 && antiguedad <= 15) {
        gratificacion = 115;
        console.log(`${nombreEmpleado}, tu gratificacion es de ${gratificacion}€`);
    } else if (antiguedad > 15) {
        gratificacion = 130;
        console.log(`${nombreEmpleado}, tu gratificacion es de ${gratificacion}€`);
    } else {
        console.log("No te corresponde ninguna gratificación");
    }
    continuar = readlineSync.keyInYN("Desea calcular la gratificación de otro empleado?(Y/N)");
} while (continuar);