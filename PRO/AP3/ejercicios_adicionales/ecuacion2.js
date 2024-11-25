const readlineSync = require("readline-sync");

function ecuSegSol1(a, b, c) {
    let sol1;
    let discrmin = calculaDiscr(a, b, c);
    if (!discrmin) {
        return "No existe";
    }
    sol1 = (-b + discrmin) / (2 * a);
    return sol1.toFixed(5);
}

function ecuSegSol2(a, b, c) {
    let sol2;
    let discrmin = calculaDiscr(a, b, c);
    if (!discrmin) {
        return "No existe";
    }
    sol2 = (-b - discrmin) / (2 * a);
    return sol2.toFixed(2);
}

function calculaDiscr(a, b, c) {
    let discriminante, discrCont;

    discrCont = Math.pow(b, 2) - (4 * a * c);

    if (discrCont < 0) {
        return false;
    }
    
    discriminante = Math.sqrt(discrCont);
    return discriminante;
}

let numA, numB, numC, solu1, solu2;

numA = readlineSync.questionFloat("Introduce el numero (a): ");
numB = readlineSync.questionFloat("Introduce el numero (b): ");
numC = readlineSync.questionFloat("Introduce el numero (c): ");

solu1 = ecuSegSol1(numA, numB, numC);
solu2 = ecuSegSol2(numA, numB, numC);

console.log(`
La solución 1 es: ${solu1}
La solución 2 es: ${solu2}
    `)