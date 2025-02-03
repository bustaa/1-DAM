using System;

namespace Ejercicio06
{
    internal class Circulo
    {
        private double radio;

        public Circulo(double r)
        {
            radio = r;
        }

        public double Radio { get => radio; }

        public double Perimetro()
        {
            return 2 * radio * Math.PI;
        }

        public double Area()
        {
            return Math.PI * Math.Pow(radio, 2);
        }
    }
}
