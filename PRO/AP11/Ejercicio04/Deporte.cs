using System;

namespace Ejercicio04
{
    abstract class Deporte
    {
        protected string nombre;
        protected string tipoPuntuacion;

        public string TipoPuntuacion { get => tipoPuntuacion; }
    }
}
