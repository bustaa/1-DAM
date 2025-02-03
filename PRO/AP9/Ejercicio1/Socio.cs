using System;
using System.Runtime.InteropServices;

namespace Ejercicio1
{
    class Socio
    {
        private string nombre;
        private int edad;
        private string nif;
        private char sexo;
        private double peso;
        private double altura;

        public Socio(string nombre, int edad, char sexo, double peso, double altura)
        {
            this.nombre = nombre;
            this.edad = edad;
            this.nif = GenerarNIF();
            this.sexo = sexo;
            this.peso = peso;
            this.altura = altura;
        }

        public Socio()
        {
            int edad;
            string nif;
            char sexo;
            double peso;
            double altura;

            Console.Write("Introduce el nombre: ");
            nombre = Console.ReadLine();

            Console.Write("Introduce la edad: ");
            edad = int.Parse(Console.ReadLine());
            if (ComprobarEdad(edad)) this.edad = edad;
            else edad = 0;

            do
            {
                Console.Write("Introduce el NIF: ");
                nif = Console.ReadLine();
            } while (!ComprobarNIF(nif));

            do
            {
                Console.Write("Introduce el sexo: ");
                sexo = Convert.ToChar(Console.ReadLine());
            } while (!ComprobarSexo(sexo));

            Console.Write("Introduce el peso: ");
            peso = Double.Parse(Console.ReadLine());
            if (ComprobarPeso(peso)) this.peso = peso;
            else this.peso = 0;

            Console.Write("Introduce la altura: ");
            altura = Double.Parse(Console.ReadLine());
            if (ComprobarAltura(altura)) this.altura = altura;
            else this.altura = 0;
        }

        private static bool ComprobarEdad(int edad) 
        {
            if (edad < 0) return false;
            return true;
        }

        private static bool ComprobarNIF(string nif)
        {
            string letras = "TRWAGMYFPDXBNJZSQVHLCKE";

            char letraNIF = nif[8];
            nif = nif.Remove(8, 1);
            int numNIF = int.Parse(nif);
            int indiceLetra = numNIF % 23;

            if (letras[indiceLetra] == letraNIF) return true;
            return false;
        }

        private static bool ComprobarSexo(char sexo)
        {
            if (sexo == 'H' || sexo == 'M') return true;
            return false;
        }

        private static bool ComprobarPeso(double peso)
        {
            if (peso < 0) return false;
            return true;
        }

        private static bool ComprobarAltura(double altura)
        {
            if (altura < 0) return false;
            return true;
        }

        public string CalcularIMC()
        {
            double imc;
            imc = peso / (Math.Pow(altura, 2));

            if (imc < 18.5) return "bajo";
            if (imc >= 18.5 && imc < 25) return "normal";
            return "alto";
        }

        public bool EsMayorDeEdad()
        {
            if (edad < 18) return false;
            return true;
        }

        public void Informa()
        {
            string strSexo;
            if (sexo == 'H') strSexo = "hombre";
            else strSexo = "mujer";

            Console.WriteLine($"Nombre: {nombre}\tDni: {nif}");
            Console.WriteLine($"Edad: {edad}\tSexo: {strSexo}");
            Console.WriteLine($"Peso: {peso}\tAltura: {altura}");
        }

        private string GenerarNIF()
        {
            string letras = "TRWAGMYFPDXBNJZSQVHLCKE";
            string nuevoNIF = "";

            Random rnd = new Random();
            for (int i = 0; i < 9; i++)
            {
                nuevoNIF += Convert.ToString(rnd.Next(1, 10));
            }

            int numNIF = Convert.ToInt32(nuevoNIF);
            nuevoNIF += letras[numNIF % 23];

            return nuevoNIF;
        }

        public string Nombre { get { return nombre; } }
    }
}
