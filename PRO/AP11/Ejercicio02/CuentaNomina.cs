using System;
using System.Collections.Generic;

namespace Ejercicio02
{
    class CuentaNomina : CuentaBancaria
    {
        private List<String> listaConceptos = new List<String>();

        public CuentaNomina(string titular) : base(titular) { }

        public void PagoRecibo(string conceptoPago, double cant)
        {
            if (saldo > cant)
            {
                saldo -= cant;
                listaConceptos.Add(conceptoPago);
            }
        }

        public void VerRecibos()
        {
            foreach (string concepto in listaConceptos)
            {
                Console.WriteLine(concepto);
            }
        }
    }
}
