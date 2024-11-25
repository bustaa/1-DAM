const readlineSync = require("readline-sync");
const fs = require("fs");

/**
 * @description Utiliza la función .trim() para eliminar los espacios del string. De esta forma si al eliminar los espacios esta el string vacío poder detectar que el usuario haya introducido una cadena de espacios o directamente un string vacío.
 * @param {string} nombre - Nombre introducido en la función padre
 * @returns {string} - Mensaje de error
 */
function validarNombre(nombre) {
    if (nombre.trim() == "") {
        return "El nombre no puede estar vacío o ser solo espacios.";
    }
    return null;
}

/**
 * @description Agrega un cliente en la última posición de la lista, si el cliente ya existe será indicado mediante la variable global mensaje, de igual modo sucederá si el cliente insertado es un string vacío.
 * @param {Array<string>} arr - Lista de espera
 * @return {string} - Mensaje para el usuario
 */
function agregarCliente(arr) {
    let cliente = readlineSync.question("Introduce el nombre del cliente: ").toLowerCase();
    let noValido = validarNombre(cliente);
    if (noValido) return noValido;

    if (arr.indexOf(cliente) == -1) {
        arr.push(cliente);
        return "Cliente añadido correctamente";
    } else {
        return "El cliente ya esta en la lista";
    } 
}

/**
 * @description Elimina el cliente en primera posición ya que este pasa a la mesa, mediante la variables global mensaje lo indicará. Si la lista esta vacía lo indicará en la variable mensaje. 
 * @param {Array<string>} arr - Lista de espera 
 * @return {string} - Mensaje para el usuario
 */
function siguienteCliente(arr) {
    if (arr.length != 0) {
        let cliente = arr.shift();
        return `${cliente} ha ocupado la correctamante la mesa`;
    } else {
        return "La lista esta vacia";
    }
}

/**
 * @description Borra el cliente seleccionado. Mediante el nombre la función buscará la posición de este y lo eliminará si existe, si no existe lo indicará.
 * @param {Array<string>} arr 
 * @return {string} - Mensaje para el usuario
 */
function borrarCliente(arr) {
    let clienteImp = readlineSync.question("Introduce el nombre del cliente que deseas borrar: ").toLowerCase();
    let noValido = validarNombre(clienteImp);
    if (noValido) {
        return noValido;
    }

    let nListCliente = arr.indexOf(clienteImp);
    if (nListCliente != -1) {
        arr.splice(nListCliente, 1);
        return "Cliente borrado correctamente";
    } else {
        return "El cliente no exite";
    }
}

/**
 * @description Visualiza la posición del cliente pedido por consola. Si no existe lo indicará, de igual modo si la lista está vacía.
 * @param {Array<string>} arr - Lista de espera
 * @return {string} - Mensaje para el usuario
 */
function verTurnoCliente(arr) {
    let nombreCliente = readlineSync.question("Introduce el nombre del cliente: ").toLowerCase();
    let noValido = validarNombre(nombreCliente);
    if (noValido) {
        return noValido;
    }

    let nListCliente = arr.indexOf(nombreCliente);
    if (nListCliente != -1) {
        return `${arr[nListCliente]} está en la posición ${nListCliente + 1}`;
    } else if (arr.length == 0) {
        return "La lista esta vacía";
    } else {
        return "El cliente no esta en la lista";
    }
}

/**
 * @description Visualiza la lista de espera en bruto mediante el uso de la función JSON.stringify()
 * @param {Array<string>} arr - Lista de espera
 * @return {string} - Mensaje para el usuario
 */
function verEstadoLista(arr) {
    return `
Visualizando lista:
${JSON.stringify(arr)}`;
    /*
    Utilizar el JSON.stringify() es la forma más simple que he encontrado para visualizar el array en bruto,
    otra forma sería la siguiente pero he considerado que es menos leible: [${'"' + arr.join('", "') + '"'}]
    */
}

/**
 * @description Guarda la lista de espera en el fichero listado.txt, si este no existe o la lista está vacía lo indicará.
 * @param {Array<string>} arr - Lista de espera
 * @return {string} - Mensaje para el usuario
 */
function guardarLista(arr) {
    if (!fs.existsSync("listado.txt")) {
        return "El archivo listado.txt no existe";
    } else {
        if (arr.length == 0) {
            return "La lista esta vacia";
        } else {
            let ficheroListado = fs.openSync("listado.txt", "w");
            for (let i = 0; i < arr.length; i++) {
                fs.writeSync(ficheroListado, `${arr[i]}\n`, undefined, "utf-8");
            }
            fs.closeSync(ficheroListado);
            return "Lista guardada correctamente"
        }
    }
}

/**
 * @description Carga la lista guardada en el fichero listado.txt, si este no existe o está vacío lo indicará.
 * @param {Array<string>} arr - Lista de espera
 * @return {string} - Mensaje para el usuario
 */
function recuperarLista(arr) {
    if (!fs.existsSync("listado.txt")) {
        return "El archivo listado.txt no existe";
    } else {
        let ficheroListado = fs.openSync("listado.txt", "r");
        let lines = fs.readFileSync(ficheroListado, "utf8");
        for (let line of lines.split("\n")) {
            if (line != "") {
                arr.push(line);
            }
        }
        fs.closeSync(ficheroListado);
        if (arr.length == 0) {
            return "La lista guardada esta vacia";
        } else {
            return "Lista cargada correctamente";
        }
    }

}

/**
 * @description Imprime en pantalla el menu del programa, al inicio si existe algún mensaje lo indicará por consola.
 * @param {string} m - Mensaje que debe salir por la consola.
 */
function imprimirMenu(m) {

    if (m != " ") {
        console.log(`\n${m}\n`);
    }

    console.log(`
LISTA ESPERA - Restaurante Florida's Hollywood
===============================================    
 1. Agreagar nuevo cliente a la lista.
 2. Siguiente cliente ocupa mesa.
 3. Borrar cliente impaciente.
 4. Ver turno de cliente.
 5. Ver estado de la lista de espera.
 6. Guardar la lista de espera.
 7. Recuperar la lista de espera.
 8. Salir del programa.`)
}


let nSel, mensaje = " ";
let listaClientes = [];

do {
    console.clear();
    imprimirMenu(mensaje);
    mensaje = " ";
    nSel = readlineSync.questionInt("Introduce opcion (1..8): ");
    switch (nSel) {
        case 1: mensaje = agregarCliente(listaClientes); break;
        case 2: mensaje = siguienteCliente(listaClientes); break;
        case 3: mensaje = borrarCliente(listaClientes); break;
        case 4: mensaje = verTurnoCliente(listaClientes); break;
        case 5: mensaje = verEstadoLista(listaClientes); break;
        case 6: mensaje = guardarLista(listaClientes); break;
        case 7: mensaje = recuperarLista(listaClientes); break;
        case 8: break;
        default: mensaje = "Selección no valida.";
    }
} while (nSel != 8);

console.log("\nPrograma finalizado");