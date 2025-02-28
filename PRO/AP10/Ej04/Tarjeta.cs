using System;

namespace Ej04
{
    class Tarjeta
    {
        private double saldo;

        public Tarjeta(double saldo) 
        {
            this.saldo = saldo;
        }

        public double getSaldo()
        {
            return saldo;
        }

        public void Descontar(double dinero)
        {
            saldo -= dinero;
        }

        public void VerSaldo()
        {
            Console.WriteLine($"Saldo de la tarjeta: {saldo} euros.");
        }
    }
}
