const readlineSync = require("readline-sync");

function imprimirTablero(coordX, coordY) {
    let x, y, line, longX, longY, liniaNum;
    x = coordX;
    y = coordY;
    longX = 10;
    longY = 10;
    for (let i = 0; i < longY; i++) {
        liniaNum = false;
        line = "";
        if (i == y) {
            liniaNum = true;
        }
        for (let j = 0; j < longX; j++) {
            if (liniaNum) {
                if (j == x) {
                    line += " * ";
                } else {
                    line += " · ";
                }
            } else {
                line += " · ";
            }
        }
        console.log(line);
    }
    imprimirMenu();
}

function imprimirMenu() {
    console.log(`
    
    ${mensaje}

    Movimientos en Tablero
    ======================
    1 - Mover arriba
    2 - Mover abajo
    3 - Mover derecha
    4 - Mover izquierda
    0 - Salir
    ======================
    CoordX = ${posX}
    CoordY = ${posY}
    `);
}

function moverArriba() {
    if (posY > 0 && posY <= 9) {
        posY--;
        mensaje = "";
    } else {
        mensaje = "Esta en el limite";
    }
    imprimirTablero(posX, posY);
}

function moverAbajo() {
    if (posY >= 0 && posY < 9) {
        posY++;
        mensaje = "";
    } else {
        mensaje = "Esta en el limite";
    }
    imprimirTablero(posX, posY);
}

function moverDerecha() {
    if (posX >= 0 && posX < 9) {
        posX++;
        mensaje = "";
    } else {
        mensaje = "Esta en el limite";
    }
    imprimirTablero(posX, posY);
}

function moverIzquierda() {
    if (posX > 0 && posX <= 9) {
        posX--;
        mensaje = "";
    } else {
        mensaje = "Esta en el limite";
    }
    imprimirTablero(posX, posY);
}

let posX, posY, nSelec, nSalir, mensaje;

posX = 0;
posY = 0;
nSalir = 0;
mensaje = "";

do {
    console.clear();
    imprimirTablero(posX, posY);
    nSelec = readlineSync.questionInt("Seleccione: ");
    if (nSelec != nSalir) {
        switch (nSelec) {
            case 1: 
                moverArriba();
                break;
            case 2:
                moverAbajo();
                break;
            case 3:
                moverDerecha();
                break;
            case 4:
                moverIzquierda();
                break;
            default:
                mensaje = "Seleccione un numero correcto"
        }
    }
} while (nSelec != nSalir);

console.log("Fin de programa");