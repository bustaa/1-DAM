// Crear una promesa
const miPromesa = new Promise((resolve, reject) => {
    const exito = true; // Cambia a false para simular un error

    setTimeout(() => {
        if (exito) {
            resolve("¡Operación exitosa!");
        } else {
            reject("Ocurrió un error.");
        }
    }, 2000); // Simula una operación asincrónica (2 segundos)
});

// Usar la promesa
miPromesa
    .then((resultado) => {
        console.log(resultado); // Se ejecuta si la promesa se resuelve
    })
    .catch((error) => {
        console.error(error); // Se ejecuta si la promesa se rechaza
    });
