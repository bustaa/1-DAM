using System;

namespace Ejercicio03
{
    class ProdCongAire : ProductoCongelado
    {
        private double porNitrogeno;
        private double porOxigeno;
        private double porDioxido;
        private double porVaporAgua;

        public ProdCongAire(DateTime fechaCaducidad, DateTime fechaEnvasado, string paisOrigen, int numLote, double temperatura, double porNitrogeno, double porOxigeno, double porDioxido, double porVaporAgua) : base(fechaCaducidad, fechaEnvasado, paisOrigen, numLote, temperatura)
        {
            this.porNitrogeno = porNitrogeno;
            this.porOxigeno = porOxigeno;
            this.porDioxido = porDioxido;
            this.porVaporAgua = porVaporAgua;
        }
    }
}
