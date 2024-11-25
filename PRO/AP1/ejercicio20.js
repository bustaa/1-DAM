/*
    Realiza un programa que, tras introducir el precio inicial de un producto, calcule su
    precio final teniendo en cuenta que:
    
        · Se le puede aplicar dos tipos de IVA (16% y 21%). Se deberá preguntar este dato.
        · El comprador/a puede tener tres tipos de descuento, que puede ser acumulativos:
          5% si es de Catarroja, 5% si es alumanadodel ciclo formativo de DAM y 5% si 
          además es de 1er curso.
        · Los descuentos se aplicarán antes que el IVA.
    
    El programa debe informar del precio final, el importe del IVA aplicado en Euros, así
    como de la totalidad de los descuentos aplicados.
*/

const readlineSync = require("readline-sync");

let precioInicial; 
let precioFinal = 0; 
let porcentajeIVA = 0
let tipoIVA21 = false, tipoIVA16 = false, esValido = false;
let descuento = 0;
let esDeCatarroja, esEstudianteDAM, esDePrimero;

precioInicial = readlineSync.questionFloat("Introduce el precio inicial: ");
esDeCatarroja = readlineSync.keyInYN("Eres de Catarroja? ");
esEstudianteDAM = readlineSync.keyInYN("Eres estudiante de DAM? ");

if(esEstudianteDAM) {
  descuento += 0.05;
  esDePrimero = readlineSync.keyInYN("Eres de primero? ");
  if (esDePrimero) {
    descuento += 0.05;
  }
}

if(esDeCatarroja) {
  descuento += 0.05;
} 

tipoIVA21 = readlineSync.keyInYN("Es tipo de IVA del 21%?");

if (tipoIVA21) {
  porcentajeIVA = 0.21;
  esValido = true;
} else {
  tipoIVA16 = readlineSync.keyInYN("El tipo de IVA es del 16%? ");
  if (tipoIVA16) {
    porcentajeIVA = 0.16;
    esValido = true;
  } else {
    console.log("Error, el IVA tiene que ser del 21% o 16%");
  }
}

let cantidadDescuento = precioInicial * descuento;
cantidadDescuento.toFixed(2);

precioFinal = precioInicial - cantidadDescuento;

let cantidadIVA = precioFinal * porcentajeIVA;
cantidadIVA.toFixed(2);

precioFinal += cantidadIVA;

descuento.toFixed(2);
porcentajeIVA.toFixed(2);

if (esValido) {
  console.log("El precio final es: " + precioFinal + " €");
  console.log("Ha sido aplicado un importe final de IVA de " + cantidadIVA + " € (" + porcentajeIVA * 100 + "%) ");
  console.log("Ha sido aplicado una totalidad de descuentos de " + cantidadDescuento + " € (" + descuento * 100 + "%) ");
}
