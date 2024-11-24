const readlineSync = require("readline-sync");

function multSumasSuce(n1, n2) {
    let resultado = 0;

    for (let i = n2; i > 0; i--) {
        resultado += n1;
    }

    return resultado;
}

let num1, num2, res;

num1 = readlineSync.questionInt("Introduce el primer numero: ");
num2 = readlineSync.questionInt("Introduce el segundo numero: ");

res = multSumasSuce(num1, num2);
console.log(`El resultado es ${res}`);

