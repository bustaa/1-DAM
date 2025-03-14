using System;
using System.Collections.Generic;

namespace Ejercicio05
{
    class Program
    {
        static int PublicacionesPrestadas(List<Publicacion> p)
        {
            int pPrestadas = 0;

            foreach (Publicacion pub in p)
            {
                if (pub.Prestado) pPrestadas++;
            }

            return pPrestadas;
        }
        static void Main(string[] args)
        {
            List<Publicacion> publicaciones = new List<Publicacion>();

            Publicacion p1 = new Libro(100, "2000", "Pepe");
            Publicacion p2 = new Libro(101, "2001", "Jose");
            Publicacion p3 = new Revista(102, "2002", 4);
            Publicacion p4 = new Revista(103, "2003", 5);

            publicaciones.Add(p1);
            publicaciones.Add(p2);
            publicaciones.Add(p3);
            publicaciones.Add(p4);

            p1.Prestar();
            p3.Prestar();

            Console.WriteLine($"Publicaciones prestadas: {PublicacionesPrestadas(publicaciones)}");

            foreach (Publicacion pub in publicaciones)
            {
                pub.VerInfo();
            }
        }
    }
}
