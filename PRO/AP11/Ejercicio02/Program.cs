using System;

namespace Ejercicio02
{
    class Program
    {
        static void Main(string[] args)
        {
            CuentaBancaria cuenta1 = new CuentaBancaria("Jose");
            CuentaNomina cuenta2 = new CuentaNomina("Pablo");

            cuenta1.ConsultarCuenta();

            cuenta2.IngresarDinero(500);
            cuenta2.PagoRecibo("Recibo 1", 200);
            cuenta2.ConsultarCuenta();
            cuenta2.VerRecibos();
        }
    }
}
