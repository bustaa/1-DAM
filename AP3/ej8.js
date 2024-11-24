function dameNumero() {
    let nLimite = 49;
    let numRandom;
    do {
        numRandom = Math.trunc(Math.random()*100)+1;
    } while (numRandom > nLimite);
    return numRandom;
}

let nNumsRandoms, listNums, nLimite;

nNumsRandoms = 6;
listNums = [];

for (let i = nNumsRandoms; i > 0; i--) {
    listNums.push(dameNumero());
}

for (let i = 0; i < listNums.length; i++) {
    console.log(listNums[i]);
}