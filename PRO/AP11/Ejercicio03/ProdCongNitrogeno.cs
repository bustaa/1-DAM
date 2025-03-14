using System;

namespace Ejercicio03
{
    class ProdCongNitrogeno : ProductoCongelado
    {
        private string metodoCongelacion;
        private int tiempoExposicion;

        public ProdCongNitrogeno(DateTime fechaCaducidad, DateTime fechaEnvasado, string paisOrigen, int numLote, double temperatura, string metodoCongelacion, int tiempoExposicion) : base(fechaCaducidad, fechaEnvasado, paisOrigen, numLote, temperatura)
        {
            this.metodoCongelacion = metodoCongelacion;
            this.tiempoExposicion = tiempoExposicion;
        }
    }
}
