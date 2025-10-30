using System.Threading;

namespace GestorTareas
{
    public class GestorTareas
    {
        private readonly List<Tarea> _tareas = new(); //tiene una lista de tareas de tipo tarea

        public void Agregar(string descripcion) //agrega una nueva tarea a la lista
        {
            int nuevoId = _tareas.Count + 1;
            var tarea = new Tarea(nuevoId, descripcion);
            _tareas.Add(tarea);
        }

        public IEnumerable<Tarea> ObtenerPendientes() //devuelve las tareas que no están completadas (completada == false)
        {
            return _tareas.Where(t => !t.Completada);
        }

        public IEnumerable<Tarea> ObtenerCompletadas() //devuelve las tareas que están completadas (completada == true)
        {
            return _tareas.Where(t => t.Completada);
        }
    }
}