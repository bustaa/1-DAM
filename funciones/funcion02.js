const readlineSync = require("readline-sync");

function areaRectangulo(base, altura) {
    area = base * altura;
    return area;
}

let baseRectangulo, alturaRectanguro, area;

baseRectangulo = readlineSync.questionFloat("Cual es la base del rectangulo: ");
alturaRectanguro = readlineSync.questionFloat("Cual es la altura del rectangulo: ");
area = areaRectangulo(baseRectangulo,alturaRectanguro);

console.log(`El area del rectangulo es: ${area}`);