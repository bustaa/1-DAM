// Mecanismo de ordenación ascendente
function Ordenacion(secuencia) {

    // Indices i y k ; auxiliar para intercambio
    var i, k, aux;

    // Mostramos por consola la secuencia tal y como lelga
    console.log(secuencia);

    // Bucle de ordenación
    for (k = 1; k < secuencia.length; k++) {

        for (i = 0; i < (secuencia.length - k); i++) {

            if (secuencia[i] > secuencia[i + 1]) {

                // Intercambio entre la posición i la posterior
                aux = secuencia[i];
                secuencia[i] = secuencia[i+1];
                secuencia[i + 1] = aux;
            }
        }
    }

    // Mostramos por consola la secuencia ordenada
    console.log(secuencia);
    return secuencia;
}

// Llamada de ejemplo a la función (el ejemplo puede variar, claro...)
var ejemplo = [2, 1]
resultado = Ordenacion(ejemplo);

module.exports = Ordenacion;

