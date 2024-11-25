const readlineSync = require("readline-sync");

let numExit, iva, ivaMin, ivaMax, ivaValido, precio, precioFinal, cantIVA;

ivaMin = 16;
ivaMax = 21;
ivaValido = false;
cantIVA = 0;
numExit = 0;

do {
    precio = readlineSync.questionFloat("Introduce el precio: ");
    if (precio == 0) {
        console.log("Programa finalizado");
        continue;
    }
    do {
        iva = readlineSync.questionFloat("Introduce el iva, debe estar entre el 16% y 21% (ambos incluidos): ");
        if (iva < ivaMin || iva > ivaMax) {
            ivaValido = false;
            console.log("IVA no valido");
        } else {
            ivaValido = true;
        }
    } while (!ivaValido);
    cantIVA = precio * (iva/100);
    precioFinal = precio + cantIVA;
    console.log(`El precio sin IVA es ${precio.toFixed(2)}€, con IVA ${precioFinal.toFixed(2)}€`);
} while (precio != numExit)