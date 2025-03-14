using System;

namespace Ejercicio05
{
    class Libro : Publicacion
    {
        private string autor;

        public Libro(int codigo, string anyo, string autor) : base(codigo, anyo)
        {
            this.autor = autor;
        }
        
        public string Autor { get => autor; }

        public override void VerInfo()
        {
            base.VerInfo();
            Console.WriteLine($"Autor: {autor}");
        }
    }
}
