using System;
using System.Collections.Generic;

namespace Ej01
{
    class Program
    {
        static void Main(string[] args)
        {
            Cuenta cuenta1 = new Cuenta("254", 1000);
            Cuenta cuenta2 = new Cuenta("345", 750);

            List<Cuenta> cuentas = new List<Cuenta>();
            cuentas.Add(cuenta1);
            cuentas.Add(cuenta2);

            Cliente cliente = new Cliente("Aitor", "Orozco", "23423423F", cuentas);

            cliente.IngresarDinero();
            cliente.ConsultarSaldo();
            cliente.RetirarDinero();
            cliente.ConsultarSaldo();
        }
    }
}
