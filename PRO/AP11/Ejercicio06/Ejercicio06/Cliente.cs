using System;

namespace Ejercicio06;

class Cliente
{
        protected string nif;
        protected int ncuenta;
        protected double saldo;

        public Cliente(string nif, int ncuenta, double saldo)
        {
                this.nif = nif;
                this.ncuenta = ncuenta;
                this.saldo = saldo;
        }

        public string Nif
        {
                get => nif;
        }

        public int Ncuenta
        {
                get => ncuenta;
        }

        public double Saldo
        {
                get => saldo;
        }

        public virtual void MostrarInfo()
        {
                Console.WriteLine($"Nif Cliente: {nif}");
                Console.WriteLine($"Num. cuenta: {ncuenta}");
                Console.WriteLine($"Saldo: {saldo}");
        }
}
