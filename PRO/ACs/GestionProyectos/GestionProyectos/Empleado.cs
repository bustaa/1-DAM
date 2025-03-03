using System;
using System.Collections.Generic;

namespace GestionProyectos
{
    class Empleado
    {
        private string nombre;
        private string puesto;
        private List<Proyecto> proyectosAsignados;

        public Empleado(string nombre, string puesto)
        {
            this.nombre = nombre;
            this.puesto = puesto;
            proyectosAsignados = new List<Proyecto>();
        }

        public string Nombre { get => nombre; }
        public string Puesto { get => puesto; }

        public void AsignarProyecto(Proyecto nuevoProyecto)
        {
            proyectosAsignados.Add(nuevoProyecto);
        }

        public int EliminarProyecto(Proyecto proyectoEliminar)
        {
            if (!proyectosAsignados.Contains(proyectoEliminar)) return -1;

            int posProyecto = proyectosAsignados.IndexOf(proyectoEliminar);
            proyectosAsignados.RemoveAt(posProyecto);

            return 0;
        }

        public List<Proyecto> ListarProyectos()
        {
            return proyectosAsignados;
        }
    }
}
