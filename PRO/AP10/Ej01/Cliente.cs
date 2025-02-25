using System;
using System.Collections.Generic;

namespace Ej01
{
    class Cliente
    {
        private string nombre;
        private string apellido;
        private string NIF;
        private List<Cuenta> cuentasAsociadas;

        public Cliente(string nombre, string apellido, string NIF, List<Cuenta> cuentas)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.NIF = NIF;
            cuentasAsociadas = new List<Cuenta>();
            foreach (Cuenta cuenta in cuentas)
            {
                cuentasAsociadas.Add(cuenta);
            }
        }

        public void ConsultarSaldo()
        {
            string numCuenta;
            bool cuentaExiste = false;
            Console.Write("Ingrese el numero de cuenta: ");
            numCuenta = Console.ReadLine();

            foreach (Cuenta cuenta in cuentasAsociadas)
            {
                if (numCuenta == cuenta.Numero)
                { 
                    Console.WriteLine($"El saldo de su cuenta es de {cuenta.Saldo} euros.");
                    cuentaExiste = true;
                }
            }

            if (!cuentaExiste)
            {
                Console.WriteLine($"No tiene ninguna cuenta asociada con el numero de cuenta {numCuenta}.");
            }
        }

        public void IngresarDinero()
        {
            string numCuenta;
            bool cuentaExiste = false;
            Console.Write("Ingrese el numero de cuenta: ");
            numCuenta = Console.ReadLine();

            foreach (Cuenta cuenta in cuentasAsociadas)
            {
                if (numCuenta == cuenta.Numero)
                {
                    double cantidad;
                    Console.Write("Introduzca la cantidad a ingresar: ");
                    cantidad = double.Parse(Console.ReadLine());
                    cuenta.Saldo += cantidad;
                    Console.WriteLine($"Se ha ingresado correctamente {cantidad} euros a la cuenta.");
                    cuentaExiste = true;
                }
            }

            if (!cuentaExiste)
            {
                Console.WriteLine($"No tiene ninguna cuenta asociada con el numero de cuenta {numCuenta}.");
            }
        }

        public void RetirarDinero()
        {
            string numCuenta;
            bool cuentaExiste = false;
            Console.Write("Ingrese el numero de cuenta: ");
            numCuenta = Console.ReadLine();

            foreach (Cuenta cuenta in cuentasAsociadas)
            {
                if (numCuenta == cuenta.Numero)
                {
                    double cantidad;
                    Console.Write("Introduzca la cantidad a retirar: ");
                    cantidad = double.Parse(Console.ReadLine());
                    if (cantidad > cuenta.Saldo)
                    {
                        Console.WriteLine("No dispone de suficiente saldo.");
                    }
                    else
                    {
                        cuenta.Saldo -= cantidad;
                        Console.WriteLine($"Se ha retirado correctamente {cantidad} euros de la cuenta.");
                    }
                    cuentaExiste = true;
                }
            }

            if (!cuentaExiste)
            {
                Console.WriteLine($"No tiene ninguna cuenta asociada con el numero de cuenta {numCuenta}.");
            }
        }
    }
}
