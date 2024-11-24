/*
    Programa que calcula el mayor de tres números proporcionados por teclado.
    Previamente a ello debe comprobar que los tres números suministrados son
    distintos. En caso de que no lo sea debe avisar que los números suministrados
    no son válidos.
*/

const readlineSync = require("readline-sync");

let num1, num2, num3;

num1 = readlineSync.questionFloat("Introduce el primer numero: ")
num2 = readlineSync.questionFloat("Introduce el segundo numero: ")
num3 = readlineSync.questionFloat("Introduce el tercer numero: ")

if (num1 == num2 || num2 == num3 || num1 == num3) {
    console.log("Los numeros suministrados no son validos");
} else {
    if (num1 > num2 && num1 > num3) {
        console.log("El numero " + num1 + " es el mayor de los tres");
    } else if (num2 > num3) {
        console.log("El numero " + num2 + " es el mayor de los tres");
    } else {
        console.log("El numero " + num3 + " es el mayor de los tres");
    }
}