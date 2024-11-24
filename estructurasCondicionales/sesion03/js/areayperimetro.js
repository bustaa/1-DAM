// Area y perimetro de un circulo

let radio = 30;
let area;
let perimetro;
const PI = Math.PI;

area = PI * Math.pow(radio, 2);
perimetro = 2 * PI * radio;

console.log("Dado un circulo de radio ", radio);
console.log("El area del circulo es: ", area.toFixed(2));
console.log("El perimetro del circulo es: ", perimetro.toFixed(2));