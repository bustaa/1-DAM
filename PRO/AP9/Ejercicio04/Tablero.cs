using System;

namespace Ejercicio04
{
    class Tablero
    {
        private Int16 coordX = 5;
        private Int16 coordY = 5;
        private Int16 limSuperior = 1;
        private Int16 limInferior = 10;

        public void MoverArriba()
        {
            if (coordY > limSuperior)
            {
                coordY--;
                VisualizarPos();
            }
            else
            {
                Console.WriteLine("Movimiento no permitido.");
            }
        }

        public void MoverAbajo()
        {
            if (coordY < limInferior)
            {
                coordY++;
                VisualizarPos();
            }
            else
            {
                Console.WriteLine("Movimiento no permitido.");
            }
        }

        public void MoverDerecha()
        {
            if (coordX < limInferior)
            {
                coordX++;
                VisualizarPos();
            }
            else
            {
                Console.WriteLine("Movimiento no permitido.");
            }
        }

        public void MoverIzquierda()
        {
            if (coordX > limSuperior)
            {
                coordX--;
                VisualizarPos();
            }
            else
            {
                Console.WriteLine("Movimiento no permitido.");
            }
        }

        public void VisualizarPos()
        {
            Console.WriteLine($"\nCoord.X = {coordX} -- Coord.Y = {coordY}");
        }

        public int ImprimirMenu()
        {
            int eleccion;
            Console.Clear();
            Console.WriteLine("Movimientos permitidos");
            Console.WriteLine("======================");
            Console.WriteLine("1. Arriba.");
            Console.WriteLine("2. Abajo.");
            Console.WriteLine("3. Izquierda.");
            Console.WriteLine("4. Derecha.");
            Console.WriteLine("5. Salir / Acabar.");
            Console.Write("Introduce opción (1..5): ");
            eleccion = int.Parse(Console.ReadLine());
            return eleccion;
        }
    }
}
