const readlineSync = require("readline-sync");

let nCamisetas = readlineSync.questionInt("Cuantas camisetas ha comprado? ");

let rango1, rango2, descuento1, descuento2, descuento3, precioCamiseta;

rango1 = 4;
rango2 = 8;
descuento1 = 0.125;
descuento2 = 0.2;
descuento3 = 0.315;
precioCamiseta = 10;

let compraSinDescuento, montoDescuento, compraConDescuento;

let esValido = true;

if(nCamisetas < 0) {
    esValido = false;
} else {
    if (nCamisetas <= rango1) {
        montoDescuento = (precioCamiseta * nCamisetas) * descuento1;
    } else if (nCamisetas <= rango2) {
        montoDescuento = (precioCamiseta * nCamisetas) * descuento2;
    } else {
        montoDescuento = (precioCamiseta * nCamisetas) * descuento3;
    }
    }
    compraSinDescuento = nCamisetas * precioCamiseta;
    compraConDescuento = compraSinDescuento * montoDescuento;

    console.log(`Compra final sin descuento: ${compraSinDescuento}`);
}

