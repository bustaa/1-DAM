using System;

namespace Ejercicio03
{
    class ProductoRefrigerado : Producto
    {
        private string codOrganismo;
        private double temperatura;

        public ProductoRefrigerado(DateTime fechaCaducidad, DateTime fechaEnvasado, string paisOrigen, int numLote, string codOrganismo, double temperatura) : base(fechaCaducidad, fechaEnvasado, paisOrigen, numLote)
        {
            this.codOrganismo = codOrganismo;
            this.temperatura = temperatura;
        }
    }
}
