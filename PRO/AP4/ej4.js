let clasificacion = ["Ana", "Oswaldo", "Raul", "Celia", "Maria", "Antonio"];
let clasFinal = [];

function imprimirClasif(arrCls) {
    for (let i = 0; i < arrCls.length; i++) {
        console.log(`${i+1}º: ${arrCls[i]}`);
    }
}

function empezarCarrera(arrClas) {
    arrClas.splice(2, 1, "Celia");
    arrClas.splice(3, 1, "Raul");
    arrClas.pop();
    arrClas.splice(1, 0, "Roberto");
    arrClas.splice(2, 0, "Amaya");
    arrClas.unshift("Marta");

    return arrClas;
}

console.log(`Clasificación inicial:`);
imprimirClasif(clasificacion);
clasFinal = empezarCarrera(clasificacion);
console.log(`\nClasificación final:`);
imprimirClasif(clasFinal);