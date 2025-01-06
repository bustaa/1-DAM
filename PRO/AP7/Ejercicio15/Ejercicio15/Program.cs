using System;

namespace Ejercicio15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string password = "ALDEBARAN";
            int intentosRest = 5;
            string passIntroducida;
            bool passCorrecta = false;

            do
            {
                Console.Write($"Introduce la contraseña ({intentosRest} intentos): ");
                passIntroducida = Convert.ToString(Console.ReadLine());

                if (passIntroducida == password)
                {
                    Console.WriteLine("Contraseña correcta");
                    passCorrecta = true;
                }
                else
                {
                    intentosRest--;
                    Console.WriteLine("Contraseña incorrecta");
                    if (intentosRest == 0)
                    {
                        Console.WriteLine("No le quedan más intentos.");
                    }
                }
            } while (!passCorrecta && intentosRest > 0);
        }
    }
}
