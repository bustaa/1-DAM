const readlineSync = require("readline-sync");
let tabla;

while (true) {
    tabla = readlineSync.questionInt("Que tabla de multiplicar quieres: ");
    if (tabla == 0) break;
    for (let i = 1; i <= 10; i++) {
        console.log(`${tabla} x ${i} = ${i*tabla}`);
    }   
}
console.log("Fin de programa");