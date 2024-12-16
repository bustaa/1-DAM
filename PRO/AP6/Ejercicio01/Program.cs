using System;

namespace Ejercicio01 
{
    class Program
    {
        static void Main(string[] args) 
        {
            Console.WriteLine(" ** PROMEDIO DE NOTAS ** ");
            Console.WriteLine(" ");

            string alumno;
            float nota1, nota2, nota3;

            Console.Write("Ingrese nombre del alumno: ");
            alumno = Console.ReadLine();
            Console.Write("Ingrese la nota 1: ");
            nota1 = float.Parse(Console.ReadLine());
            Console.Write("Ingrese la nota 2: ");
            nota2 = float.Parse(Console.ReadLine());
            Console.Write("Ingrese la nota 3: ");
            nota3 = float.Parse(Console.ReadLine());

            double promedio = (nota1 + nota2 + nota3) / 3.00;

            Console.WriteLine("---------------------------------");
            Console.WriteLine("EL PROMEDIO: " + promedio.ToString("0.00"));

            Console.ReadKey();
        }
    }
}