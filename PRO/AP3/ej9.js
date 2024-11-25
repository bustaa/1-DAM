const readlineSync = require("readline-sync");

function calculaSuma(lim1, lim2) {
    let sumaTotal = 0;
    for (let i = lim1+1; i < lim2; i++) {
        if (i % 2 == 0) {
            sumaTotal += i;
        }
    }
    return sumaTotal;
}

function limiteValido(lim1, lim2) {
    if (lim1 < 0 || lim2 < 0) {
        return false;
    } else if (lim1 >= lim2) {
        return false;
    } else {
        return true;
    }
}

let limite1, limite2, suma;

limite1 = readlineSync.questionInt("Introduce el limite 1: ");
limite2 = readlineSync.questionInt("Introduce el limite 2: ");

if (limiteValido(limite1, limite2)) {
    suma = calculaSuma(limite1, limite2);
    console.log(`La suma de los numeros pares comprendidos entre ${limite1} y ${limite2} es: ${suma}`);
} else {
    console.log("El limite debe ser valido");
}