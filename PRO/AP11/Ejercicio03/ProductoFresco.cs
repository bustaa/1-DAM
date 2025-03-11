using System;

namespace Ejercicio03
{
    class ProductoFresco : Producto
    {
        private DateTime fechaEnvasado;
        private string paisOrigen;

        public ProductoFresco(DateTime fechaCaducidad, string numeroLote, DateTime fechaEnvasado, string paisOrigen) : base (fechaCaducidad, numeroLote)
        {
            this.fechaEnvasado = fechaEnvasado;
            this.paisOrigen = paisOrigen;
        }
    }
}
