const readlineSync = require("readline-sync");

let listNums = [];
let limite = 1000;
let seguir = true;
let num = 0;

while (seguir) {
    num = num*2+1;
    if (num < limite) {
        listNums.push(num);
    } else {
        seguir = false;
    }
}

console.log(listNums);