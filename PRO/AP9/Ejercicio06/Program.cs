using System;

namespace Ejercicio06
{
    class Program
    {
        static double MayorCirculo(Circulo[] circulos)
        {
            double minRadio = double.MaxValue;
            foreach (Circulo circ in circulos)
            {
                if (circ.Radio < minRadio) minRadio = circ.Radio;
            }
            return minRadio * 2;
        }
        static void Main(string[] args)
        {
            Circulo[] circulos = new Circulo[3];

            Circulo circ1 = new Circulo(5);
            Circulo circ2 = new Circulo(7.4);
            Circulo circ3 = new Circulo(2);

            circulos[0] = circ1;
            circulos[1] = circ2;
            circulos[2] = circ3;

            Console.WriteLine($"El diametro mayor es: {MayorCirculo(circulos)}");
        }
    }
}
