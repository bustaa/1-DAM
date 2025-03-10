using System;
using System.Collections.Generic;

namespace RuletaRusa
{
    class Juego
    {
        private List<Jugador> jugadores;
        private Revolver revolver;

        public Juego(List<Jugador> jugadores, Revolver revolver)
        {
            this.jugadores = jugadores;
            this.revolver = revolver;
        }

        public void Ronda()
        {
            foreach (Jugador jugador in jugadores)
            {
                revolver.Rotacion();
                jugador.Disparar(revolver);
            }
        }
    }
}
