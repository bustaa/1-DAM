const readlineSync = require("readline-sync");
const letrasDNI = ["T", "R", "W", "A", "G", "M", "Y", "F", "P", "D", "X", "B", "N", "J", "Z", "S", "Q", "V", "H", "L", "C", "K", "E"];

let dni = readlineSync.questionInt("Introduce el numero de dni: ")
let i = dni % 23;
let dniFinal = dni + letrasDNI[i];

console.log(dniFinal);