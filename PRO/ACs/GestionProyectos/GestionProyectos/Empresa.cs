using System;
using System.Collections.Generic;

namespace GestionProyectos
{
    class Empresa
    {
        private List<Empleado> empleados;
        private List<Proyecto> proyectos;

        public Empresa(List<Empleado> empleados, List<Proyecto> proyectos)
        {
            this.empleados = empleados;
            this.proyectos = proyectos;
        }

        public void AgregarEmpleado(Empleado nuevoEmpleado)
        {
            empleados.Add(nuevoEmpleado);
        }

        public int EliminarEmpleado(Empleado empleadoEliminar)
        {
            if (!empleados.Contains(empleadoEliminar)) return -1;

            int pos = empleados.IndexOf(empleadoEliminar);
            empleados.RemoveAt(pos);

            return 0;
        }

        public void AgregarProyecto(Proyecto nuevoProyecto)
        {
            proyectos.Add(nuevoProyecto);
        }

        public int EliminarProyecto(Proyecto proyectoEliminar)
        {
            if (!proyectos.Contains(proyectoEliminar)) return -1;

            int pos = proyectos.IndexOf(proyectoEliminar);
            proyectos.RemoveAt(pos);

            return 0;
        }

        public List<Empleado> ObtenerEmpleados()
        {
            return empleados;
        }

        public List<Proyecto> ObtenerProyectos()
        {
            return proyectos;
        }

        public Empleado BuscarEmpleadoPorNombre(string nombre)
        {
            foreach (Empleado empleado in empleados)
            {
                if (empleado.Nombre == nombre) return empleado;
            }

            return null;
        }

        public Proyecto BuscarProyectoPorNombre(string nombre)
        {
            foreach (Proyecto proyecto in proyectos)
            {
                if (proyecto.Nombre == nombre) return proyecto;
            }

            return null;
        }
    }
}
