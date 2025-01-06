using System;

namespace Ejercicio05 
{
    class Program
    {
        static void Main(string[] args)
        {
            double lado1, lado2, lado3;

            Console.WriteLine("Introduce los tres lados del triangulo: ");

            Console.Write("Lado 1: ");
            lado1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Lado 2: ");
            lado2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Lado 3: ");
            lado3 = Convert.ToDouble(Console.ReadLine());

            if (lado1 == lado2 && lado1 == lado3)
            {
                Console.WriteLine("El triángulo es equilátero");
            }
            else if (lado1 == lado2 || lado1 == lado3 || lado2 == lado3)
            {
                Console.WriteLine("El triángulo es isósceles");
            }
            else
            {
                Console.WriteLine("El triángulo es escaleno");
            }
        }
    }
}