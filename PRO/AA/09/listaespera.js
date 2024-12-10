const readline = require("readline-sync");
const fs = require("fs");

class Customer {
    constructor(customerName, diners) {
        this.customerName = customerName.toLowerCase();
        if (diners <= 1) {
            this.diners = 1;
        } else {
            this.diners = diners;
        }
    }
}

function addCustomer(arrList) {
    console.clear();
    let name, diners, customer, exist = false;
    console.log(`
Añadir nuevo cliente a la lista
===============================
        `);
    name = readline.question("Introduce el nombre de la reserva: ").trim().toLowerCase();
    
    if (name != "") {
        arrList.forEach(customer => {
            if (customer.customerName == name) {
                exist = true;
            } 
        });
        if (!exist) {
            diners = readline.questionInt("Introduce el nombre de comensales: ");
            customer = new Customer(name, diners);
            arrList.push(customer);
            console.log("Cliente añadido correctamente.");
        } else {
            console.log("El cliente ya existe.");
        }
    } else {
        console.log("El nombre del cliente no puede estar vacío.");
    }
    readline.keyInPause();
}

function nextCustomer(arrList) {
    console.clear();
    console.log("Siguiente cliente ocupa mesa");
    console.log("============================");
    if (arrList.length != 0) {
        seeListStatus(arrList);
        let nCustomer = readline.questionInt("Que cliente quieres que ocupe la mesa: ")-1;
        if (nCustomer >= 0 && nCustomer < arrList.length) {
            arrList.splice(nCustomer, 1);
            console.log("El cliente ocupó la mesa correctamente.");
        } else {
            console.log("Debe seleccionar una posición existente.");
        }
    } else {
        console.log("La lista está vacía.");
    }
    readline.keyInPause();
}

function removeCustomer(arrList) {
    console.clear();
    console.log("Borrar cliente impaciente");
    console.log("=========================");
    if (arrList.length != 0) {
        seeListStatus(arrList);
        let nRemove = readline.questionInt("Que reserva quiere eliminar: ")-1;
        if (nRemove > 0 && nRemove < arrList.length) {
            arrList.splice(nRemove, 1);
            console.log("El cliente fue eliminado correctamente.");
        } else {
            console.log("Debe seleccionar una reserva existente.");
        }
    } else {
        console.log("La lista está vacía.");
    }
    readline.keyInPause();
}

function seeCustomerShift(arrList) {
    console.clear();
    console.log("Ver turno de cliente");
    console.log("====================");
    if (arrList.length != 0) {
        let name = readline.question("Introduce el nombre del cliente: ").toLowerCase();
        let n = 0, exist = false;
        arrList.forEach(customer => {
            n++;
            if (customer.customerName == name) {
                console.log(`El cliente ${customer.customerName} está en la posición ${n}.`);
                exist = true;
            }
        });
        if (!exist) {
            console.log("El cliente no existe");
        }
    } else {
        console.log("La lista está vacía.");
    }
    readline.keyInPause();
}

function seeListStatus(arrList) {
    console.clear();
    console.log("Ver estado lista");
    console.log("================");
    if (arrList.length != 0) {
        let n = 0;
        arrList.forEach(customer => {
            n++;
            console.log(`Reserva ${n}. Nombre: ${customer.customerName}. Comensales: ${customer.diners}`);
        });
    } else {
        console.log("La lista está vacía.");
    }
}

function saveList(arrList) {
    if (arrList.length != 0) {
        if(!fs.existsSync("listado.txt")) {
            fs.writeFileSync("listado.txt", "", "utf-8");
        }
    } else { 
        console.log("La lista está vacía.");
    }
    readline.keyInPause();
}

function recoverList(arrList) {
    
}

function printMenu() {
    console.log(`
LISTA ESPERA - Restaurante Florida's Hollywood
==============================================
1. Agregar nuevo cliente a la lista.
2. Siguiente cliente ocupa mesa.
3. Borrar cliente impaciente.
4. Ver turno de cliente.
5. Ver estado de la lista de espera.
6. Guardar la lista de espera.
7. Recuperar la lista de espera.
8. Salir del programa.

`);
    return readline.questionInt("Introduce opcion (1..8): ");
};

let list = [];
let option;

do {
    console.clear();
    option = printMenu();
    switch(option) {
        case 1: addCustomer(list); break;
        case 2: nextCustomer(list); break;
        case 3: removeCustomer(list); break;
        case 4: seeCustomerShift(list); break;
        case 5: 
            seeListStatus(list); 
            readline.keyInPause();
            break;
        case 6: saveList(list); break;
        case 7: recoverList(list); break;
        case 8: console.log("Fin de programa"); break;
        default: 
            console.log("Seleccione una opción correcta");
            readline.keyInPause();
    }
} while(option != 8);