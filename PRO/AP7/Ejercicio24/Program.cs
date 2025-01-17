using System;

namespace Ejercicio24
{
    internal class Program
    {
        static string TipoCaracter(char caracter)
        {
            switch (caracter)
            {
                case '0': return "num"; break;
                case '1': return "num"; break;
                case '2': return "num"; break;
                case '3': return "num"; break;
                case '4': return "num"; break;
                case '5': return "num"; break;
                case '6': return "num"; break;
                case '7': return "num"; break;
                case '8': return "num"; break;
                case '9': return "num"; break;
                default: return "alfa"; break;
            }
        }
        static void Main(string[] args)
        {
            char caracter;
            string tipo;

            do
            {
                Console.Write("Introduce un caracter (. para salir): ");
                caracter = Convert.ToChar(Console.ReadLine());
                if (caracter != '.')
                {
                    tipo = TipoCaracter(caracter);
                    if (tipo == "num")
                    {
                        Console.WriteLine("Numerico");
                    }
                    else
                    {
                        Console.WriteLine("Alfabetico");
                    }
                }
            } while (caracter != '.');
        }
    }
}
