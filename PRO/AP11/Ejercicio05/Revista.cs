using System;

namespace Ejercicio05
{
    class Revista : Publicacion
    {
        private int numero;

        public Revista(int codigo, string anyo, int numero) : base(codigo, anyo)
        {
            this.numero = numero;
        }

        public int Numero { get => numero; }

        public override void VerInfo()
        {
            base.VerInfo();
            Console.WriteLine($"Numero: {numero}");
        }
    }
}
