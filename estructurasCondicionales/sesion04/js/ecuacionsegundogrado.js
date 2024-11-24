
let a = 3;
let b = -5;
let c = 1;

let sol1 = (-b + Math.sqrt(Math.pow(b, 2) - 4 * a * c)) / (2 * a);
let sol2 = (-b - Math.sqrt(Math.pow(b, 2) - 4 * a * c)) / (2 * a);

console.log("La solución uno es: ", sol1);
console.log("La solución dos es: ", sol2);

let resultado1 = a * Math.pow(sol1, 2) + b * sol1 + c;
let resultado2 = a * Math.pow(sol2, 2) + b * sol2 + c;

if (resultado1 == 0 || resultado2 == 0) {
    console.log("Correcto");
    console.log(resultado1);
    console.log(resultado2);
}