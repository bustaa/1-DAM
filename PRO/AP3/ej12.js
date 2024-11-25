const readlineSync = require("readline-sync");

function calculaPrecioFinal(precio, porcDesc) {
    const IVA = 0.16;
    let descuento, totalIVA, precioFinal;
    precioFinal = precio;

    descuento = precio * (porcDesc/100);
    precioFinal -= descuento;
    totalIVA = precioFinal * IVA;
    precioFinal += totalIVA;

    return precioFinal;
}

function descValido(desc) {
    if (desc >= 0 && desc <= 20) {
        return true;
    } else {
        return false;
    }
}

let precioInicial, precioTotal, descuento, finPrograma;

finPrograma = 0;

do {
    precioInicial = readlineSync.questionInt("Introduce el precio inicial: ");
    
    if (precioInicial != finPrograma) {
        descuento = readlineSync.questionInt("Introduce el descuento (0-20%): ");
        if (descValido(descuento)) {
            precioTotal = calculaPrecioFinal(precioInicial, descuento);
            console.log(`El precio final será: ${precioTotal}`);
        } else {
            console.log("Debes introducir un descuento valido");
        }
    }
} while (precioInicial != finPrograma);

console.log("Fin de programa");