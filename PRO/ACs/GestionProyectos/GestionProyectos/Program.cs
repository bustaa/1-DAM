using System;
using System.Collections.Generic;

namespace GestionProyectos
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Empleado> empleadosEmpresa1 = new List<Empleado>();
            List<Proyecto> proyectosEmpresa1 = new List<Proyecto>();

            Empleado empleado1 = new Empleado("Pablo", "FrontEnd");
            Empleado empleado2 = new Empleado("Carlos", "BackEnd");

            empleadosEmpresa1.Add(empleado1);
            empleadosEmpresa1.Add(empleado2);

            Proyecto proyecto1 = new Proyecto("Pagina Web", "Pagina web sobre la gestión de residuos.");

            proyectosEmpresa1.Add(proyecto1);

            Empresa empresa1 = new Empresa(empleadosEmpresa1, proyectosEmpresa1);

            DateTime fechaTarea = new DateTime(2025, 8, 12);
            proyecto1.AgregarTarea("Descripción tarea 1", fechaTarea, empleado1);

            foreach (Tarea tarea in proyecto1.ListarTareas())
            {
                Console.WriteLine(tarea.Descripcion);
            }

            proyecto1.EliminarTarea(0);

            foreach (Tarea tarea in proyecto1.ListarTareas())
            {
                Console.WriteLine(tarea.Descripcion);
            }

            empresa1.EliminarEmpleado(empleado1);

            Console.WriteLine(empresa1.BuscarEmpleadoPorNombre("Carlos").Puesto);
        }
    }
}
