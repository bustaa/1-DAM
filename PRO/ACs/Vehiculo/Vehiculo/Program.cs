using System;

namespace Vehiculo
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehiculo miCoche = new Vehiculo("Toyota", "Corolla", 2020);
            miCoche.MostrarInfo();
            miCoche.Acelerar(30);
            miCoche.MostrarInfo();
            miCoche.Frenar(10);
            miCoche.MostrarInfo();
        }
    }
}
