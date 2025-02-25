using System;

namespace Ej01
{
    class Cuenta
    {
        private string numeroCuenta;
        private double saldoCuenta;

        public Cuenta(string numeroCuenta, double saldoCuenta)
        {
            this.numeroCuenta = numeroCuenta;
            this.saldoCuenta = saldoCuenta;
        }

        public string Numero { get => numeroCuenta; }
        public double Saldo { get => saldoCuenta; set => saldoCuenta = value; }
    }
}
