const Ordenacion = require('../src/aev6');

test('Caso 1: Longitud de array = 1', () => {
    const arrVacio = [];
    const arrUno = [42];

    expect(Ordenacion(arrVacio)).toEqual(arrVacio);
    expect(Ordenacion(arrUno)).toEqual(arrUno);
});

test('Caso 3: No se cumple la condición del nodo4', () => {
    const arr = [1, 2];

    expect(Ordenacion(arr)).toEqual(arr);
});

test('Caso 4: Se cumple la condición del nodo4 y se ordena el array', () => {
    const arr = [2, 1];
    const resultado = [1, 2];

    expect(Ordenacion(arr)).toEqual(resultado);
})