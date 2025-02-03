using System;
using System.Collections;

namespace Ejercicio05
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehiculo[] listaCoches = new Vehiculo[4];

            Vehiculo vehiculo1 = new Vehiculo("BMW", "Serie 1", 145, 1000);
            Vehiculo vehiculo2 = new Vehiculo("Forda", "CMAX", 115, 2000);
            Vehiculo vehiculo3 = new Vehiculo("Volkswagen", "Golf", 215, 3000);
            Vehiculo vehiculo4 = new Vehiculo("Seat", "Ibiza", 90, 500);

            listaCoches[0] = vehiculo1;
            listaCoches[1] = vehiculo2;
            listaCoches[2] = vehiculo3;
            listaCoches[3] = vehiculo4;

            vehiculo1.CompararPrecio(listaCoches);
        }
    }
}
