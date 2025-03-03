using System;
using System.Collections.Generic;
using System.Net.Http.Headers;

namespace GestionProyectos
{
    class Proyecto
    {
        private string nombre;
        private string descripcion;
        private List<Tarea> tareas;

        public Proyecto(string nombre, string descripcion)
        {
            this.nombre = nombre;
            this.descripcion = descripcion;
            tareas = new List<Tarea>();
        }

        public string Nombre { get => nombre; }
        public string Descripcion { get => descripcion; }

        public void AgregarTarea(string descripcion, DateTime fechaLimite, Empleado responsable)
        {
            Tarea nuevaTarea = new Tarea(descripcion, fechaLimite, responsable);
            tareas.Add(nuevaTarea);
        }

        public int EliminarTarea(int pos)
        {
            if (tareas.Count < pos || pos < 0) return -1;

            tareas.RemoveAt(pos);
            return 0;
        }

        public List<Tarea> ListarTareas()
        {
            return tareas;
        }
    }
}
