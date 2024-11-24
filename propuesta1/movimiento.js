const readlineSync = require("readline-sync");

function moverDerecha() {
    if (coordX < nColumnas) {
        coordX++;
        estaLimite = false;
    } else {
        estaLimite = true;
    }
}

function moverIzquierda() {
    if (coordX > minCol) {
        coordX--;
        estaLimite = false;
    } else {
        estaLimite = true;
    }
}

function moverArriba() {
    if (coordY < nFilas) {
        coordY++;
        estaLimite = false;
    } else {
        estaLimite = true;
    }
}

function moverAbajo() {
    if (coordY > minFil) {
        coordY--;
        estaLimite = false;
    } else {
        estaLimite = true;
    }
}

let nFilas, nColumnas, coordX, coordY, salir, teclaPulsada, estaLimite, minCol, minFil;

minCol = 0;
minFil = 0;
nFilas = 10;
nColumnas = 10;
coordX = 5;
coordY = 5;
salir = false;
estaLimite = false;

do {
    console.clear();
    if (estaLimite) {
        console.log("No se ha podido realizar el movimiento, estas en el limite\n");
    }
    teclaPulsada = readlineSync.questionInt(
    `
    Coord.X = ${coordX} -- Coord.Y = ${coordY}\n
    Movimientos permitidos
    ======================
    1. Arriba
    2. Abajo
    3. Izquierda
    4. Derecha
    5. Salir / Acabar
    Introduce Opcion (1..5): `);

    switch (teclaPulsada) {
        case 1: 
            moverArriba();
            break;
        case 2:
            moverAbajo();
            break;
        case 3:
            moverIzquierda();
            break;
        case 4:
            moverDerecha();
            break;
        case 5:
            salir = true;
            break;
        default:
            console.log("Numero no valido");
    }

} while (!salir);

console.log("Programa finalizado");
