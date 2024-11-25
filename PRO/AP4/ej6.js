function randomNum() {
    let n = Math.trunc((Math.random() * 21));
    return n;
}

function llenarArr(arr, longArr) {
    for (let i = 0; i < longArr; i++) {
        arr.push(randomNum());
    }
    return arr;
}

function sumaArray(array1, array2) {
    let suma;
    let arr = [];
    for (let i = 0; i < array1.length; i++) {
        suma = array1[i] + array2[i];
        arr.push(suma);
    }
    return arr;
}

let longArray = 10;
let arr1 = [];
let arr2 = [];
let sumaArr = [];

arr1 = llenarArr(arr1, longArray);
arr2 = llenarArr(arr2, longArray);
sumaArr = sumaArray(arr1, arr2);

console.log(arr1);
console.log(arr2);
console.log(sumaArr);