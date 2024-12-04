class Persona {
    constructor(nombre, edad, sexo, peso, altura) {
        this.nombre = nombre;
        this.edad = edad;
        this.DNI = this.generarDNI();
        if (sexo == 'M') {
            this.sexo = "hombre";
        } else {
            this.sexo = "mujer";
        }
        this.peso = peso;
        this.altura = altura;
    }

    generarDNI() {
        let letras = "TRWAGMYFPDXBNJZSQVHLCKE";
        let n, dni = "";
        for (let i = 0; i < 8; i++) {
            n = Math.trunc(Math.random() * 10).toString();
            dni += n;
        }
        dni += letras[dni%23];
        console.log(dni);
    }

    calcularIMC() {
        let imc = this.peso / (Math.sqrt(this.altura, 2));
        console.log();
    }
}

let persona1 = new Persona('JC', 45, 'F', 80, 1.70)