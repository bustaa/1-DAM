const readlineSync = require("readline-sync");

let salir, seleccion;

salir = false;

do {
    console.log(`
            Pulse una tecla
    ================================
    Introducir el primer valor: 1
    Introducir el segundo  valor: 2
    Realizar suma: 3
    Realizar resta: 4
    Realizar multiplicación: 5
    Realizar resta: 6
    Salir: 0
    ================================
    `);
    seleccion = readlineSync.questionInt("Introduzca su seleccion: ");
    if (seleccion == 0) {
        salir = true;
    } else {
        salir = false;
    }
    
} while (!salir);

console.log("Programa finalizado");