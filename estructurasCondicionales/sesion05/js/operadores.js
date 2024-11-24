let a, b, c;

a = 5;
b = 3;
c = 12;

let a1 = a > 3;
let a2 = a > c;
let a3 = a < c;
let a4 = b < c;
let a5 = b != c;
let a6 = a == 3;
let a7 = a * b == 15;
let a8 = a * b == -30;
let a9 = c / b < a;
let a10 = c / b == -10;
let a11 = c / b == -4;
let a12 = a + b + c == 5;
let a13 = (a + b == 8) && (a - b == 2);
let a14 = (a + b == 8) || (a - b == 6);
let a15 = a > 3 && b > 3 && c < 3;
let a16 = a > 3 && b >= 3 && c < -3;

console.log(a1, a2, a3, a4, a5, a6, a7, a8, a9, a10, a11, a12, a13, a14, a15, a16);