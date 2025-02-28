using System;

namespace Ej02
{
    class Funcion
    {
        private string nombre;
        private double precio;

        public Funcion(string nombre, double precio)
        {
            this.nombre = nombre;
            this.precio = precio;
        }

        public string Nombre { get => nombre; }
        public double Precio { get => precio; }

        public void CambiarNombre(string nombre)
        {
            this.nombre = nombre;
        }

        public void CambiarPrecio(double precio)
        {
            this.precio = precio;
        }
    }
}
