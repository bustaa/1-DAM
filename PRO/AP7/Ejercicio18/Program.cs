using System;

namespace Ejercicio18
{
    class Program
    {
        static void Main(string[] args)
        {
            string salir;
            string nombre;
            int anyos;
            int gratTotal;
            int rango1 = 100;
            int rango2 = 115;
            int rango3 = 130;

            do
            {
                Console.Write("Introduzca el nombre del empleado: ");
                nombre = Console.ReadLine();

                Console.Write("Introduzca la antiguedad del empleado: (en años) ");
                anyos = int.Parse(Console.ReadLine());

                if (anyos > 3 && anyos < 10)
                {
                    gratTotal = anyos * rango1;
                }
                else if (anyos >= 10 && anyos <= 15)
                {
                    gratTotal = anyos * rango2;
                }
                else if (anyos > 15)
                {
                    gratTotal = anyos * rango3;
                }
                else
                {
                    gratTotal = 0;
                }

                Console.WriteLine($"La gratificación de {nombre} por haber trabajado {anyos} años en la empresa es de: {gratTotal}$");

                Console.Write("¿Desea calcular la gratificación de otro empleado (S/N): ?");
                salir = Console.ReadLine();
            } while (salir.ToUpper() != "N");
        }
    }
}
