using System;

namespace RuletaRusa
{
    class Revolver
    {
        private int posicionActual;
        private int posicionBala;
        Random rng = new Random();

        public Revolver()
        {
            posicionActual = 0;
            posicionBala = rng.Next(1, 7);
        }

        public void Rotacion()
        {
            posicionActual = rng.Next(1, 7);
        }

        public bool Disparo()
        {
            return posicionActual == posicionBala;
        }

        public void SiguienteBala()
        {
            if (posicionActual < 6)
            {
                posicionActual++;
            }
            else
            {
                posicionActual = 1;
            }
        }

        public void VerInfo()
        {
            Console.WriteLine($"Posición actual: {posicionActual}");
            Console.WriteLine($"Posición bala: {posicionBala}");
        }
    }
}
