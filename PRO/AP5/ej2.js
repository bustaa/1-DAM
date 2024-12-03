class Perro {
    constructor (nombre, raza, talla) {
        this.nombre = nombre;
        this.raza = raza;
        this.talla = talla;
    }

    ladrar() {
        if (this.talla <= 50) {
            console.log("¡Guauu!");
        } else {
            console.log("¡buf buf!");
        }
    }
}

let perro1 = new Perro("JC", "Chiguagua", "10");
let perro2 = new Perro("PerroPau", "Golden", "51");
let perro3 = new Perro("Manuel Calero", "No", "80");

perro1.ladrar();
perro2.ladrar();
perro3.ladrar();