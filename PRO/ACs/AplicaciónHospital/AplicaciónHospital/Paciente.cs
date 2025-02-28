using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace AplicaciónHospital
{
    class Paciente
    {
        private string nombre;
        private string id;
        private DateTime fechaNacimiento;
        private List<String> historialEnf;

        public Paciente()
        {
            do
            {
                Console.WriteLine("Introduce el nombre del paciente: ");
                nombre = Console.ReadLine();
            } while (nombre == null);

            do
            {
                Console.WriteLine("Introduce el id del paciente: ");
                id = Console.ReadLine();
            } while (id == null);

            do
            {
                Console.WriteLine("Introduce la fecha de nacimiento");
                fechaNacimiento = DateTime.Parse(Console.ReadLine());
            } while (fechaNacimiento == null);

            Console.WriteLine("Introduce el historial medico.");
            string elem;
            do
            {
                Console.WriteLine("Introduce un nuevo elemento para salir (S para salir): ");
                elem = Console.ReadLine();
                if (elem != "S")
                {
                    historialEnf = new List<String>();
                    historialEnf.Add(elem);
                }
            } while (elem != "S");
        }

        public void MostrarInfo()
        {
            Console.WriteLine($"Información Paciente");
            Console.WriteLine($"====================");
            Console.WriteLine($"Nombre: {nombre}");
            Console.WriteLine($"ID: {id}");
            Console.WriteLine($"Fecha nacimiento: {fechaNacimiento}");
            Console.WriteLine("Historial de enfermedades: ");
            if (historialEnf.Count > 0)
            {
                foreach (String elem in historialEnf)
                {
                    Console.WriteLine($"- {elem.ToUpper()}");
                }
            }
            else
            {
                Console.WriteLine("No existen enfermedades previas.");
            }
        }
    }
}
