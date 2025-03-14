using System;

namespace Ejercicio03
{
    class ProdCongAgua : ProductoCongelado
    {
        private double salinidad;

        public ProdCongAgua(DateTime fechaCaducidad, DateTime fechaEnvasado, string paisOrigen, int numLote, double temperatura, double salinidad) : base(fechaCaducidad, fechaEnvasado, paisOrigen, numLote, temperatura)
        {
            this.salinidad = salinidad;
        }
    }
}
