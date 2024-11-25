const readlineSync = require("readline-sync");

function llenarArray() {
    let arr = [];
    let marca;
    do {
        marca = readlineSync.question("Introduce una marca, (pulse N para finalizar): ");
        if (marca != "N") {
            arr.push(marca);
        }
    } while (marca != "N")
    return arr;
}

let arrCoches, arrMotos, transportes = [];

console.log("Introduce los datos del array de coches.");
arrCoches = llenarArray();
console.log("Introduce los datos del array de motos.");
arrMotos = llenarArray();

transportes.push(...arrCoches, ...arrMotos);
console.log(transportes);