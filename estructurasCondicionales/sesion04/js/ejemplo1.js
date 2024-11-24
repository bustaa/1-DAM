
let salarioBruto = 2200;
let porceImpuesto = 0.31;
let cantImpuesto = salarioBruto * porceImpuesto;
let salarioNeto = salarioBruto - cantImpuesto;

console.log("Tu salario bruto es: ", salarioBruto);
console.log("Prorcentaje de impuestos: ", porceImpuesto*100,"%");
console.log("Cantidad que pagas en impuestos: ", cantImpuesto);
console.log("Tu salario neto es: ", salarioNeto);