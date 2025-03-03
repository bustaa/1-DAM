using System;

namespace GestionProyectos
{
    class Tarea
    {
        private string descripcion;
        private DateTime fechaLimite;
        private Empleado responsable;

        public Tarea(string descripcion, DateTime fechaLimite, Empleado responsable)
        {
            this.descripcion = descripcion;
            this.fechaLimite = fechaLimite;
            this.responsable = responsable;
        }

        public string Descripcion { get => descripcion; }
        public DateTime FechaLImtie { get => fechaLimite; }
        public Empleado Responsable { get => responsable; }

        public void CambiarResponsable(Empleado nuevoResponsable)
        {
            responsable = nuevoResponsable;
        }

        public void ActualizarFechaLimite(DateTime nuevoFecha)
        {
            fechaLimite = nuevoFecha;
        }
    }
}
