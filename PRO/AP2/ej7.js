const readlineSync = require("readline-sync");

let letraIntroducir = "x";
let letraIntroducida = "";

do {
    letraIntroducida = readlineSync.question("Introduce una letra: ").toLowerCase();
    if (letraIntroducida.length != 1) {
        console.log("Introduce solo una letra");
        continue;
    } else if (letraIntroducida == letraIntroducir) {
        console.log("Letra correcta");
    } else {
        console.log("Letra incorrecta, vuelva a intentarlo");
    }

} while (letraIntroducida != letraIntroducir)