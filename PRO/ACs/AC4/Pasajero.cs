using System;

namespace AC4;

class Pasajero
{
    private string nif;
    private string nombre;
    private string apellidos;
    private string nacionalidad;
    private DateTime fechaNacimiento;
    private int numMaletas;

    public Pasajero(string nif, string nombre, string apellidos, string nacionalidad, DateTime fechaNacimiento, int numMaletas)
    {
        this.nif = nif;
        this.nombre = nombre;
        this.apellidos = apellidos;
        this.nacionalidad = nacionalidad;
        this.fechaNacimiento = fechaNacimiento;
        this.numMaletas = numMaletas;
    }
        
}

