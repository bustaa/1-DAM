using System;
using System.Globalization;
using System.Text;

namespace Ejercicio05
{
    class Vehiculo
    {
        private string marca;
        private string modelo;
        private double potencia;
        private double precio;

        public Vehiculo(string marca, string modelo, double potencia, double precio)
        {
            this.marca = marca;
            this.modelo = modelo;
            this.potencia = potencia;
            this.precio = precio;
        }

        public string Marca { get => marca; }
        public string Modelo { get => modelo; }
        public double Potencia { get => potencia; }
        public double Precio { get => precio; }


        public void verInfo()
        {
            CultureInfo euro = new CultureInfo("es-ES");

            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine($"Marca: {marca}");
            Console.WriteLine($"Modelo: {modelo}");
            Console.WriteLine($"Potencia: {potencia}cv");
            Console.WriteLine($"Precio: {precio.ToString("C", euro)}");

        }

        public void CompararPrecio(Vehiculo[] vehiculos)
        {
            bool cocheMin;
            foreach (Vehiculo coche in vehiculos)
            {
                cocheMin = true;
                foreach (Vehiculo otroCoche in vehiculos)
                {
                    if (coche.Precio > otroCoche.Precio)
                    {
                        cocheMin = false;
                    }
                }
                if (cocheMin) coche.verInfo();
            }
        }
    }
}
