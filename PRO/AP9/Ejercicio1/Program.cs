using System;

namespace Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            Socio s1 = new Socio("JC", 18, 'M', 80, 1.70);
            Socio s2 = new Socio();

            s1.Informa();
            s2.Informa();
        }
    }
}
