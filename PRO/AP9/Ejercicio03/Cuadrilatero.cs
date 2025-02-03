using System;

namespace Ejercicio03
{
    class Cuadrilatero
    {
        private double ladoA;
        private double ladoB;

        public Cuadrilatero(double lado1, double lado2)
        {
            ladoA = lado1;
            ladoB = lado2;
        }

        public Cuadrilatero(double lado)
        {
            ladoA = lado;
            ladoB = lado;
        }

        public double CalcularArea()
        {
            return ladoA * ladoB;
        }

        public double CalcularPerimetro()
        {
            return 2 * ladoB + 2 * ladoA;   
        }
    }
}
