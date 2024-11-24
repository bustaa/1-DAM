const readlineSync = require("readline-sync");

function numRomano(n) {
    let nRomano;
    switch (n) {
        case 1:
            nRomano = "I";
            break;
        case 2:
            nRomano = "II";
            break;
        case 3:
            nRomano = "III";
            break;
        case 4:
            nRomano = "IV";
            break;
        case 5:
            nRomano = "V";
            break;
        case 6:
            nRomano = "VI";
            break;
        case 7:
            nRomano = "VII";
            break;
        case 8:
            nRomano = "VIII";
            break;
        case 9:
            nRomano = "IX";
            break;
        case 10:
            nRomano = "X";
            break;
        default:
            console.log("Error");
    }
    return nRomano;
}

let num, nRom;

num = readlineSync.questionInt("Introduce un numero (entre 1 y 10): ")

if (num > 1 && num <= 10) {
    nRom = numRomano(num);
    console.log(`${num} en numeros romanos es ${nRom}`);
} else {
    console.log("Numero no valido");
}