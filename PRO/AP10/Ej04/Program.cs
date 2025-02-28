using System;

namespace Ej04
{
    class Program
    {
        static void Main(string[] args)
        {
            Maquina maquina = new Maquina(30);

            Tarjeta tarjeta1 = new Tarjeta(20);
            tarjeta1.VerSaldo();

            Tarjeta tarjeta2 = new Tarjeta(18);
            tarjeta2.VerSaldo();

            maquina.Extraer(tarjeta1);
            maquina.Extraer(tarjeta2);

            maquina.VerInfo();
            tarjeta1.VerSaldo();
            tarjeta2.VerSaldo();

            Maquina.CambiarPrecio(1.80);

            maquina.Extraer(tarjeta1, 2);
            maquina.Extraer(tarjeta2, 5);

            maquina.VerInfo();
            tarjeta1.VerSaldo();
            tarjeta2.VerSaldo();
        }
    }
}
