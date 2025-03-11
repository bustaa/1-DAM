using System;

namespace Ejercicio03
{
    abstract class Producto
    {
        protected DateTime fechaCaducidad;
        protected DateTime fechaEnvasado;
        protected string paisOrigen;
        protected int numLote;

        public Producto(DateTime fechaCaducidad, DateTime fechaEnvasado, string paisOrigen, int numLote)
        {
            this.fechaCaducidad = fechaCaducidad;
            this.fechaEnvasado = fechaEnvasado;
            this.paisOrigen = paisOrigen;
            this.numLote = numLote;
        }
    }
}
