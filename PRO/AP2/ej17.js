const readlineSync = require("readline-sync");

let inicioLimite, nNumsPrimos, esPrimo, nNumsPrimosEncontrados, n, listPrimos;

inicioLimite = 2;
nNumsPrimos = 50;
nNumsPrimosEncontrados = 0;
n = inicioLimite;
listPrimos = [];

while (nNumsPrimosEncontrados < nNumsPrimos) {
    esPrimo = true;

    if (n === 2) {
        nNumsPrimosEncontrados++;
        listPrimos.push(n);
    } else if (n > 2) {
        for (let j = 2; j < n; j++) {
            if (n % j === 0) {
                esPrimo = false;
                break;
            }
        }
        
        if (esPrimo) {
            nNumsPrimosEncontrados++;
            listPrimos.push(n);
        }
    }
    
    n++;
}

console.log(listPrimos);
