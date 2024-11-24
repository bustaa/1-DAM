const readlineSync = require("readline-sync");

function esMultiplo(n, nMult) {
    if (n % nMult == 0) {
        return true;
    } else {
        return false;
    }
}

let num, nMultiplo, esMult;

num = readlineSync.questionInt("Introduce un numero: ");
nMultiplo = 10;
esMult = esMultiplo(num, nMultiplo);

if (esMult) {
    console.log(`${num} es multiplo de ${nMultiplo}`);
} else {
    console.log(`${num} no es multiplo de ${nMultiplo}`);
}
