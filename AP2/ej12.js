const readlineSync = require("readline-sync");

let contrasenyaPedida, contrasenyaIntroducida, nIntentos;

contrasenyaPedida = "ALDEBARAN";
nIntentos = 5;

do {
    contrasenyaIntroducida = readlineSync.question(`Introduzca la contraseña, tiene ${nIntentos} intentos: `);
    if (contrasenyaIntroducida == contrasenyaPedida) {
        console.log("Contraseña correcta");
        break;
    } else {
        nIntentos--;
        if (nIntentos == 0) {
            console.log("Intentos agotados");
            break;
        }
    }
} while (nIntentos > 0); 