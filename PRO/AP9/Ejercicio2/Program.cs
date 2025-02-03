using System;

namespace Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangulo t1 = new Triangulo(12.3, 1.2, 11);
            Triangulo t2 = new Triangulo();
            Triangulo t3 = new Triangulo(10, 10, 10);

            Console.WriteLine("Triangulo 1: ");
            Console.WriteLine($"Escaleno: {t1.EsEscaleno()}");
            Console.WriteLine($"Isosceles: {t1.EsIsosceles()}");
            Console.WriteLine($"Equilatero: {t1.EsEquilatero()}");

            Console.WriteLine("Triangulo 2: ");
            Console.WriteLine($"Escaleno: {t2.EsEscaleno()}");
            Console.WriteLine($"Isosceles: {t2.EsIsosceles()}");
            Console.WriteLine($"Equilatero: {t2.EsEquilatero()}");

            Console.WriteLine("Triangulo 3: ");
            Console.WriteLine($"Escaleno: {t3.EsEscaleno()}");
            Console.WriteLine($"Isosceles: {t3.EsIsosceles()}");
            Console.WriteLine($"Equilatero: {t3.EsEquilatero()}");
        }
    }
}
