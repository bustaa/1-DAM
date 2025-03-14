using System;

namespace Ejercicio04
{
    class Program
    {
        static Deporte TipoDeporte(int num)
        { 
            switch (num)
            {
                case 1: return new Futbol();
                case 2: return new Baloncesto();
                case 3: return new Rugby();
                default: return null;
            }
        }

        static void Main(string[] args)
        {
            Deporte[] deportes = new Deporte[5];
            Random rnd = new Random();
            int num;

            for (int i = 0; i < deportes.Length; i++)
            {
                num = rnd.Next(1, 4);
                deportes[i] = TipoDeporte(num);
            }

            foreach (Deporte deporte in deportes)
            {
                Console.WriteLine(deporte.TipoPuntuacion);
            }
        }
    }
}
