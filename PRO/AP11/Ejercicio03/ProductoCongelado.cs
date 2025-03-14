using System;

namespace Ejercicio03
{
    class ProductoCongelado : Producto
    {
        private double temperatura;

        public ProductoCongelado(DateTime fechaCaducidad, DateTime fechaEnvasado, string paisOrigen, int numLote, double temperatura) : base(fechaCaducidad, fechaEnvasado, paisOrigen, numLote)
        {
            this.temperatura = temperatura;
        }
    }
}
