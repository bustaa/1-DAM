using System;

namespace AC1
{
    class Program
    {
        static void Main(string[] args)
        {
            Raices ecu1 = new Raices(3, 4, 1);
            ecu1.Calcular();

            Raices ecu2 = new Raices(1, 4, 4);
            ecu2.Calcular();

            Raices ecu3 = new Raices(8, 2, 5);
            ecu3.Calcular();
        }
    }
}
