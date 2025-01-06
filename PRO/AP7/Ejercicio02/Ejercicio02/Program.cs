using System;

namespace Ejercicio02
{
    class Program
    {
        static void Main(string[] args)
        {
            string frase1, frase2;

            Console.WriteLine("Introduzca la primera frase: ");
            frase1 = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Introduzca la segunda frase: ");
            frase2 = Convert.ToString(Console.ReadLine());

            if (frase1 == frase2)
            {
                Console.WriteLine("Las frase son iguales");
            }
            else
            {
                Console.WriteLine("Las frases no son iguales");
            }

        }
    }
}