const readlineSync = require("readline-sync");

function calculaPuntos(pGan, pPer, pEmp) {

    let puntosGanado, puntosEmpatado, puntosPerdido, totalPuntos;
    
    totalPuntos = 0;

    puntosGanado = 3;
    puntosEmpatado = 1;
    puntosPerdido = 0;

    totalPuntos = pGan * puntosGanado + pEmp * puntosEmpatado + pPer * puntosPerdido;
    return totalPuntos; 
}

let parGanados, parEmpatados, parPerdidos, total;

parGanados = readlineSync.questionInt("Partidos ganados: ");
parEmpatados =readlineSync.questionInt("Partidos empatados: ");
parPerdidos = readlineSync.questionInt("Partidos perdidos: ");

total = calculaPuntos(parGanados, parEmpatados, parEmpatados);
console.log(`El equipo ha conseguido un total de ${total} puntos`);