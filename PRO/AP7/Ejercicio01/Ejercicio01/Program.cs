using System;

namespace Ejercicio01
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;

            Console.WriteLine("Introduzca un numero entre el 1 y el 10: ");
            num = Convert.ToInt16(Console.ReadLine());

            switch (num) 
            {
                case 1:
                    Console.WriteLine("I");
                    break;
                case 2:
                    Console.WriteLine("II");
                    break;
                case 3:
                    Console.WriteLine("III");
                    break;
                case 4:
                    Console.WriteLine("IV");
                    break;
                case 5:
                    Console.WriteLine("V");
                    break;
                case 6:
                    Console.WriteLine("VI");
                    break;
                case 7:
                    Console.WriteLine("VII");
                    break;
                case 8:
                    Console.WriteLine("VIII");
                    break;
                case 9:
                    Console.WriteLine("IX");
                    break;
                case 10:
                    Console.WriteLine("X");
                    break;
                default:
                    Console.WriteLine("Debe introducir un numero entre el 1 y el 10");
                    break;
            }
        }
    }
}