using System;

namespace Ejercicio05
{
    abstract class Publicacion
    {
        protected int codigo;
        protected string anyo;
        protected bool prestado;

        public Publicacion(int codigo, string anyo)
        {
            this.codigo = codigo;
            this.anyo = anyo;
        }

        public int Codigo { get => codigo; }
        public string Anyo { get => anyo; }
        public bool Prestado { get => prestado; }

        public void Prestar()
        {
            prestado = true;   
        }

        public void Devolver()
        {
            prestado = false;
        }

        public virtual void VerInfo()
        {
            string libroPrestado;

            if (prestado)
            {
                libroPrestado = "si";
            }
            else
            {
                libroPrestado = "no";
            }

            Console.WriteLine($"Codigo: {codigo}");
            Console.WriteLine($"Año: {anyo}");
            Console.WriteLine($"Prestado: {libroPrestado}");
        }
    }
}
