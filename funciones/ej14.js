const readlineSync = require("readline-sync");

function tipoTriangulo(l1, l2, l3) {
    if (l1 == l2 && l2 == l3) {
        return "equilatero";
    } else if (l1 == l2 || l1 == l3 || l2 == l3) {
        return "isósceles";
    } else {
        return "escaleno";
    }
}

let lado1, lado2, lado3;

lado1 = readlineSync.questionFloat("Introduce el lado 1: ");
lado2 = readlineSync.questionFloat("Introduce el lado 2: ");
lado3 = readlineSync.questionFloat("Introduce el lado 3: ");

console.log(`El triangulo es ${tipoTriangulo(lado1, lado2, lado3)}`);