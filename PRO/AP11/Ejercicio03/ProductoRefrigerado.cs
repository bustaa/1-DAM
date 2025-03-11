using System;

namespace Ejercicio03
{
    class ProductoRefrigerado : Producto
    {
        private string codOrgSupAli;
        private DateTime fechaEnvasado;
        private double tempMant;
        private string paisOrigen;

        public ProductoRefrigerado(DateTime fechaCaducidad, string numeroLote, string codOrgSupAli, DateTime fechaEnvasado, double tempMant, string paisOrigen) : base(fechaCaducidad, numeroLote)
        {
            this.codOrgSupAli = codOrgSupAli;
            this.fechaEnvasado = fechaEnvasado;
            this.tempMant = tempMant;
            this.paisOrigen = paisOrigen;
        }


    }
}
