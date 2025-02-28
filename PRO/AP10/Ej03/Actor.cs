using System;

namespace Ej03
{
    class Actor
    {
        private string nombre;
        private int anyoNac;

        public Actor(string nombre, int anyoNac)
        {
            this.nombre = nombre;
            this.anyoNac = anyoNac;
        }

        public int getAnyoNacimiento()
        {
            return anyoNac;
        }

        public void VerDatosActor()
        {
            Console.WriteLine($"Nombre: {nombre}");
            Console.WriteLine($"Año de nacimiento: {anyoNac}");
        }
    }
}
