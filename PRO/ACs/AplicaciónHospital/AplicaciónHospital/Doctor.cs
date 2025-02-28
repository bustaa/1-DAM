using System;

namespace AplicaciónHospital
{
    class Doctor
    {
        private string nombre;
        private string numColegiado;
        private string especialidad;
        private TimeZone Horario;

        public void MostrarInfo()
        {
            do
            {
                Console.WriteLine("Introduce el nombre del doctor: ");
                nombre = Console.ReadLine();
            } while (nombre == null);

            do
            {
                Console.WriteLine("Introduce el numero de colegiado: ");
                numColegiado = Console.ReadLine();
            } while (numColegiado == null);

            do
            {
                Console.WriteLine("Introduce la especialidad del doctor: ");
                especialidad = Console.ReadLine();
            } while (especialidad == null);


        }
    }
}
