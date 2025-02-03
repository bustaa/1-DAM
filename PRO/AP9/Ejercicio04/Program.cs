using System;

namespace Ejercicio04
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            Tablero tablero1 = new Tablero();
            int ele;

            do
            {
                ele = tablero1.ImprimirMenu();
                switch (ele)
                {
                    case 1: tablero1.MoverArriba(); break;
                    case 2: tablero1.MoverAbajo(); break;
                    case 3: tablero1.MoverIzquierda(); break;
                    case 4: tablero1.MoverDerecha(); break;
                }
                Console.ReadKey();
            } while (ele != 5);
        }
    }
}
