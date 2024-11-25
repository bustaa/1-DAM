const meses = ["Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre"];
const anyo = 2018;

function fechaRandom(n) {
    let mes = meses[Math.trunc((Math.random()*12))+1];
    let dia, mesIncorrecto;
    do {
        dia = Math.trunc((Math.random()*31)+1);
        switch(dia) {
            case 29, 30, 31:
                if (mes == "Febrero") mesIncorrecto = true; break;
            case 31:
                if (mes == "Abril" || mes == "Junio" || mes == "Septiembre" || mes == "Noviembre") mesIncorrecto = true; break;
            default:
                mesIncorrecto = false;
        }
    } while (mesIncorrecto);
    console.log(`Fecha ${n}: ${dia} de ${mes} de ${anyo}`);
}

for (let i = 1; i <= 10; i++) {
    fechaRandom(i);
}