using System;

namespace Ejercicio03
{
    class ProductoFresco : Producto
    {
        public ProductoFresco(DateTime fechaCaducidad, DateTime fechaEnvasado, string paisOrigen, int numLote) : base(fechaCaducidad, fechaEnvasado, paisOrigen, numLote)
        { 
            
        }
    }
}
