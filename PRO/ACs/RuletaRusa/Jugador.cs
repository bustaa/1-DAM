using System;

namespace RuletaRusa
{
    class Jugador
    {
        private int id;
        private string nombre;
        private bool vivo;
        static int cont = 1;

        public Jugador(string nombre)
        {
            id = cont++;
            this.nombre = nombre;
            vivo = true;
        }

        public void Disparar(Revolver r)
        {
            if (r.Disparo())
            {
                vivo = false;
                Console.WriteLine($"{nombre} ha muerto.");
            }
            else
            {
                Console.WriteLine($"Sigues vivo.");
            }
        }
    }
}
