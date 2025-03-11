using System;

namespace Ejercicio01
{
    class Program
    {
        static void Main(string[] args)
        {
            CuentaBancaria cuenta1 = new CuentaBancaria("Jose");
            CuentaBancaria cuentaPrueba = new CuentaBancaria("A");
            CuentaBancaria cuenta2 = new CuentaBancariaRemunerada("Pablo", 12);

            cuenta1.IngresarDinero(120);
            cuenta1.ConsultarCuenta();

            cuentaPrueba.ConsultarCuenta();

            cuenta2.IngresarDinero(120);
            cuenta2.ConsultarCuenta();
        }
    }
}
