using System;
using Utilidades;

namespace EjemploUsoDLL
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Dame un DNI: ");
            string dni = Console.ReadLine();
            
            Console.WriteLine($"El nif es {Utiles.CalcularLetraNIF(dni)}");
        }
    }
}
