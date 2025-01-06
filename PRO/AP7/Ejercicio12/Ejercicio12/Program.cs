using System;


namespace Ejercicio12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char caracter;
            int nCharNum = 0;

            do
            {
                Console.Write("Introduce un caracter (Pulse . para salir): ");
                caracter = Convert.ToChar(Console.ReadLine());

                if (caracter != '.') 
                {
                    switch (caracter)
                    {
                        case '0':
                            nCharNum++;
                            break;
                        case '1':
                            nCharNum++;
                            break;
                        case '2':
                            nCharNum++;
                            break;
                        case '3':
                            nCharNum++;
                            break;
                        case '4':
                            nCharNum++;
                            break;
                        case '5':
                            nCharNum++;
                            break;
                        case '6':
                            nCharNum++;
                            break;
                        case '7':
                            nCharNum++;
                            break;
                        case '8':
                            nCharNum++;
                            break;
                        case '9':
                            nCharNum++;
                            break;
                    }
                }
            } while (caracter != '.');

            Console.WriteLine($"Se han introducido un total de {nCharNum} caracteres entre el 0 y el 9");
        }
    }
}
