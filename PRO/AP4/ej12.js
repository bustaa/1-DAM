function lanzarDado() {
    return Math.trunc(Math.random()*6) + 1;;
}

let lanzamietosTotales = 36000;
let dado1, dado2, suma, n2, n3, n4, n5, n6, n7, n8, n9, n10, n11, n12;
let arrDados = [];

n2 = 0;
n3 = 0;
n4 = 0;
n5 = 0;
n6 = 0;
n7 = 0;
n8 = 0;
n9 = 0;
n10 = 0;
n11 = 0;
n12 = 0;

for (let i = 0; i < lanzamietosTotales; i++) {
    dado1 = lanzarDado();
    dado2 = lanzarDado();
    suma = dado1 + dado2;
    arrDados.push(suma);
    switch (suma) {
        case 2: n2++; break;
        case 3: n3++; break;
        case 4: n4++; break;
        case 5: n5++; break;
        case 6: n6++; break;
        case 7: n7++; break;
        case 8: n8++; break;
        case 9: n9++; break;
        case 10: n10++; break;
        case 11: n11++; break;
        case 12: n12++; break;
        default:
            console.error("Número no identificado: ", suma);
    }
}

console.log(`
Resultados tiradas de dados
===========================
2: ${n2} veces, ${((n2/lanzamietosTotales)*100).toFixed(2)}%
3: ${n3} veces, ${((n3/lanzamietosTotales)*100).toFixed(2)}%
4: ${n4} veces, ${((n4/lanzamietosTotales)*100).toFixed(2)}%
5: ${n5} veces, ${((n5/lanzamietosTotales)*100).toFixed(2)}%
6: ${n6} veces, ${((n6/lanzamietosTotales)*100).toFixed(2)}%
7: ${n7} veces, ${((n7/lanzamietosTotales)*100).toFixed(2)}%
8: ${n8} veces, ${((n8/lanzamietosTotales)*100).toFixed(2)}%
9: ${n9} veces, ${((n9/lanzamietosTotales)*100).toFixed(2)}%
10: ${n10} veces, ${((n10/lanzamietosTotales)*100).toFixed(2)}%
11: ${n11} veces, ${((n11/lanzamietosTotales)*100).toFixed(2)}%
12: ${n12} veces, ${((n12/lanzamietosTotales)*100).toFixed(2)}%
    `);