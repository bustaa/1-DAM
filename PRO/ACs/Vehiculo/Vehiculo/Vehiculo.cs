using System;

namespace Vehiculo
{
    class Vehiculo
    {
        private string marca;
        private string modelo;
        private int anio;
        private int velocidadActual = 0;

        /// <summary>
        /// Constructor de la clase vehiculo que toma los valores directos de Program
        /// </summary>
        /// <param name="marca"></param>
        /// <param name="modelo"></param>
        /// <param name="anio"></param>
        public Vehiculo (string marca, string modelo, int anio) 
        {
            this.marca = marca;
            this.modelo = modelo;
            this.anio = anio;
        }

        /// <summary>
        /// Aumenta la velocidad del vehiculo
        /// </summary>
        /// <param name="cantidad">km/h incrementados para la velocidad</param>
        public void Acelerar(int cantidad) 
        {
            velocidadActual += cantidad;
        }

        public void Frenar(int cantidad) 
        {
            velocidadActual -= cantidad;
        }

        public void MostrarInfo()
        {
            Console.WriteLine($"{marca} {modelo} ({anio} - Velocidad: {velocidadActual} km/h)");
        }
    }
}
