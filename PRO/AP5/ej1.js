class Persona {
    constructor (nombre, edad) {
        this.nombre = nombre;
        this.edad = edad;
        if (edad >= 67) {
            this.jubilada = true;
        } else {
            this.jubilada = false;
        }
    }

    cumplirAnyos() {
        this.edad++;  
        console.log(`${this.nombre} tiene ${this.edad} años.`); 
        if (this.edad >= 67) {
            this.jubilada = true;
        }
        if (this.jubilada) {
            console.log(`${this.nombre} está jubilado/a.`);
        }
    }
}   

let persona = new Persona('Aitor', 66);
console.log(persona);
persona.cumplirAnyos();
console.log(persona);
