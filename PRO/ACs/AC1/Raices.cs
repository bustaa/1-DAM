using System;

namespace AC1
{
    class Raices
    {
        private double a;
        private double b;
        private double c;
        private double sol1;
        private double sol2;

        public Raices(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        private double getDiscriminante()
        {
            return Math.Pow(b, 2) - 4 * a * c;
        }

        private bool TieneRaices()
        {
            return getDiscriminante() > 0;
        }

        private bool TieneRaiz()
        {
            return getDiscriminante() == 0;
        }

        private void ObtenerRaices()
        {
            Console.WriteLine($"\n\tLa solución 1 es: {sol1}\n\tLa solución 2 es: {sol2}");
        }

        private void ObtenerRaiz()
        {
            Console.WriteLine($"\n\tLa solución es: {sol1}");
        }

        public void Calcular()
        {
            if (TieneRaices())
            {
                sol1 = (-b + Math.Sqrt(getDiscriminante())) / (2 * a);
                sol2 = (-b - Math.Sqrt(getDiscriminante())) / (2 * a);

                ObtenerRaices();
            }
            else if (TieneRaiz())
            {
                sol1 = -b / (2 * a);

                ObtenerRaiz();
            }
            else
            {
                Console.WriteLine("\n\tLa ecuación no tiene una solución posible en R\n");
            }
        }
    }
}
