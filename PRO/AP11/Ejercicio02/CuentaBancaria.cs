using System;

namespace Ejercicio02
{
    class CuentaBancaria
    {
        protected string titular;
        protected int numero;
        protected double saldo;
        protected static int cont = 1000;

        public CuentaBancaria(string titular)
        {
            this.titular = titular.ToUpper();
            saldo = 0;
            numero = cont++;
        }

        public string Titular { get => titular; set => titular = value.ToUpper(); }
        public int Numero { get => numero; set => numero = value; }
        public double Saldo { get => saldo; }

        public virtual void IngresarDinero(double cant)
        {
            if (cant > 0) saldo += cant;
        }

        public void RetirarDinero(double cant)
        {
            if (cant > saldo) saldo -= cant;
        }

        public void ConsultarCuenta()
        {
            Console.WriteLine($"Titular:\t{titular}");
            Console.WriteLine($"Numero:\t{numero}");
            Console.WriteLine($"Saldo:\t{saldo}");
        }
    }
}
