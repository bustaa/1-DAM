using System;
using System.Collections.Generic;

namespace Ej03
{
    class Pelicula
    {
        private string nombre;
        private int anyoEstreno;
        private List<Actor> actores;

        public Pelicula(string nombre, int anyoEstreno, List<Actor> actores)
        {
            this.nombre = nombre;
            this.anyoEstreno = anyoEstreno;
            this.actores = actores;
        }

        public void VerDatosPeli()
        {
            Console.WriteLine($"Nombre: {nombre}");
            Console.WriteLine($"Año estreno: {anyoEstreno}");
            Console.WriteLine("Actores");
            Console.WriteLine("===========");
            foreach (Actor actor in actores)
            {
                actor.VerDatosActor();
            }
        }
        
        public List<Actor> getActoresMenores18()
        {
            List<Actor> actoresMenores = new List<Actor>();
            
            foreach (Actor actor in actores)
            {
                if (anyoEstreno - actor.getAnyoNacimiento() < 18 && actor.getAnyoNacimiento() < anyoEstreno)
                {
                    actoresMenores.Add(actor);
                }
            }

            return actoresMenores;
        }

        public void DatosActores()
        {
            foreach (Actor actor in actores)
            {
                actor.VerDatosActor();
                Console.WriteLine($"Edad: {DateTime.Now.Year - actor.getAnyoNacimiento()}");
                Console.WriteLine("\n");
            }
        }
    }
}
