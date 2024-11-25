function primo(n) {
    nDivisores = 0;
    for (let i = 1; i <= n; i++) {
        if (n % i == 0) {
            nDivisores++;
        }
    }
    if (nDivisores == 2) {
        return true;
    } else {
        return false;
    }
}

let lim1, lim2;

lim1 = 1;
lim2 = 1000;

for (let i = lim1; i <= lim2; i++) {
    if (primo(i)) {
        console.log(i);
    }
}