let i = 1;
let j;

do {
    console.log(`\nTabla del ${i}`);
    j=1;
    do {
        console.log(`${i} x ${j} = ${i*j}`);
        j++;
    } while (j <= 10);
    i++;
} while (i <= 10);