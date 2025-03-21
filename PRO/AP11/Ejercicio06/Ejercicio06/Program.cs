using System;

namespace Ejercicio06;

class Program
{
    static void Main(string[] args)
    {
        Random rng = new Random();
        
        int nFondos;
        
        Console.Write("Cuantos fondos desea introducir: ");
        nFondos = int.Parse(Console.ReadLine());

        Fondo[] fondos = new Fondo[nFondos];
        double cantMes;
        for (int i = 0; i < nFondos; i++)
        {
            Console.Write("Cantidad al mes: ");
            cantMes = double.Parse(Console.ReadLine());
            Fondo nuevoFondo = new Fondo(rng.Next(1000, 10000), cantMes);
            fondos[i] = nuevoFondo;
        }

        Cliente cliente1 = new Cliente("99999999A", 1231232, 234.34);
        Cliente cliente2 = new ClientePreferente("234239842D", 23423423, 12334.23, fondos);
    }
}
