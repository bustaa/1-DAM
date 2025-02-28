using System;
using System.Collections.Generic;

namespace Ej02
{
    class Teatro
    {
        private string nombre;
        private string direccion;
        private Funcion[] funciones = new Funcion[4];

        public Teatro(string nombre, string direccion, String[] nombres, Double[] precios)
        {
            this.nombre = nombre;
            this.direccion = direccion;

            for (int i = 0; i < funciones.Length; i++)
            {
                funciones[i] = new Funcion(nombres[i], precios[i]);
            }
        }

        public string Nombre { get => nombre; }
        public string Direccion { get => direccion; }

        public void CambiarNombre(string nombre)
        {
            this.nombre = nombre;
        }

        public void CambiarDireccion(string direccion)
        { 
            this.direccion = direccion;
        }

        public void ActualizarNombreFuncion(int n_funcion, string nombre)
        {
            funciones[n_funcion].CambiarNombre(nombre);
        }

        public void PrecioFuncion(int n_funcion, double precio)
        {
            funciones[n_funcion].CambiarPrecio(precio);
        }

        public string DevuelveNombreFuncion(int n_funcion)
        {
            return funciones[n_funcion].Nombre;
        }

        public double DevuelvePrecioFuncion(int n_funcion)
        {
            return funciones[n_funcion].Precio;
        }
    }
}
