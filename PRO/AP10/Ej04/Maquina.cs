using System;
using System.Runtime.CompilerServices;

namespace Ej04
{
    class Maquina
    {
        private double ganancia;
        private int numBotellas;
        private static double precio = 1;

        public Maquina(int numBotellas)
        {
            this.numBotellas = numBotellas;
        }

        public int getNumBotellas()
        {
            return numBotellas;
        }

        public double getGanancia()
        {
            return ganancia;
        }

        public string Extraer(Tarjeta t)
        {
            if (t.getSaldo() > precio)
            {
                if (numBotellas > 0)
                {
                    numBotellas--;
                    ganancia += precio;
                    t.Descontar(precio);
                    return "Su botella. Gracias";
                }
                else return "Existencias agotadas";
            }
            else return "Saldo insuficiente";
        }

        public string Extraer(Tarjeta t, int nBotellas)
        {
            if (t.getSaldo() > precio * nBotellas)
            {
                if (numBotellas > nBotellas)
                {
                    numBotellas -= nBotellas;
                    ganancia += precio * nBotellas;
                    t.Descontar(precio * nBotellas);
                    return "Sus botellas. Gracias";
                }
                else return "No hay suficientes existencias";
            }
            else return "Saldo insuficiente";
        }

        public void VerInfo()
        {
            Console.WriteLine("Información de la máquina");
            Console.WriteLine("=========================");
            Console.WriteLine($"Precio: {precio}");
            Console.WriteLine($"Botellas restantes: {numBotellas}");
            Console.WriteLine($"Ganancia: {ganancia}");
        }

        public static void CambiarPrecio(double nuevoPrecio)
        {
            precio = nuevoPrecio;
        }
    }
}
