using System;
using System.Collections.Generic;

namespace Ej03
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombrePeli;
            Console.Write("Introduce el nombre de la pelicula: ");
            nombrePeli = Console.ReadLine();

            int anyoEstreno;
            Console.Write("Introduce el año de estreno: ");
            anyoEstreno = int.Parse(Console.ReadLine());

            string nombreActor = "";
            int anyoNac;
            List<Actor> actores = new List<Actor>();
            do {
                Console.Write("Introduce el nombre del actor: ");
                nombreActor = Console.ReadLine();
                if (nombreActor.Trim().Length > 0)
                {
                    Console.Write("Introduce el año de nacieminto: ");
                    anyoNac = int.Parse(Console.ReadLine());
                    actores.Add(new Actor(nombreActor, anyoNac));
                }
            } while (nombreActor.Trim().Length != 0);


            Pelicula pelicula1 = new Pelicula(nombrePeli, anyoEstreno, actores);

            Console.WriteLine("Actores menores de 18 años cuando se estreno la pelicula.");
            Console.WriteLine("=========================================================");

            if (pelicula1.getActoresMenores18().Count > 0)
            { 
                foreach (Actor actorMenor in pelicula1.getActoresMenores18())
                {
                    actorMenor.VerDatosActor();
                    Console.WriteLine("\n");
                }
            }

            Console.WriteLine("Datos actores.");
            Console.WriteLine("==============");
            pelicula1.DatosActores();
        }
    }
}
