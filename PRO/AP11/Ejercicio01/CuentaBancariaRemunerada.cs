using System;

namespace Ejercicio01
{
    class CuentaBancariaRemunerada : CuentaBancaria
    {
        private double porcentajeRemu;

        public CuentaBancariaRemunerada(string titular, double porcentajeRemu) : base(titular)
        {
            this.titular = titular.ToUpper();
            this.porcentajeRemu = porcentajeRemu;
        }

        public override void IngresarDinero(double cant)
        {
            if (cant > 0) saldo += cant + cant * (porcentajeRemu / 100);
        }
    }
}
