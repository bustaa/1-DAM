using System;

namespace EP3
{
    class Program
    {
        static void Main(string[] args)
        {
            Despertador desp1 = new Despertador(18, 33, 20, 43, true);

            desp1.MostrarAlarma();
            desp1.MostrarHora();
            desp1.Hora = 20;
            desp1.Minuto = 20;
            desp1.ActivarAlarma(false);
            desp1.MostrarHora();
            Console.WriteLine(desp1.EstaAlarmaActiva());
        }
    }
}
