using System;

namespace Ejercicio2
{
    class Triangulo
    {
        private double lado1;
        private double lado2;
        private double lado3;

        public Triangulo(double lado1, double lado2, double lado3)
        {
            this.lado1 = lado1;
            this.lado2 = lado2;
            this.lado3 = lado3;
        }

        public Triangulo()
        {
            double lado1, lado2, lado3;

            do
            {
                Console.Write("Introduce la longitud del lado 1: ");
                lado1 = Double.Parse(Console.ReadLine());
            } while (!LadoValido(lado1));
            this.lado1 = lado1;

            do
            {
                Console.Write("Introduce la longitud del lado 2: ");
                lado2 = Double.Parse(Console.ReadLine());
            } while (!LadoValido(lado2));
            this.lado2 = lado2;

            do
            {
                Console.Write("Introduce la longitud del lado 3: ");
                lado3 = Double.Parse(Console.ReadLine());
            } while (!LadoValido(lado3));
            this.lado3 = lado3;
        }

        private static bool LadoValido(double lado)
        {
            if (lado <= 0) return false;
            return true;
        }

        public bool EsEscaleno()
        {
            if (lado1 != lado2 && lado1 != lado3 && lado2 != lado3) return true;
            return false;
        }

        public bool EsIsosceles()
        {
            if (lado1 == lado2 || lado2 == lado3 || lado1 == lado3)
            {
                if (!EsEquilatero()) return true;
            }
            return false;
        }

        public bool EsEquilatero()
        {
            if (lado1 == lado2 && lado1 == lado3) return true;
            return false;
        }
    }
}
