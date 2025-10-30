namespace GestorTareas
{
    public class Tarea
    {
        public int Id { get; }
        public string Descripcion { get; }
        public bool Completada { get; private set; }

        public Tarea(int id, string descripcion)
        {
            if (string.IsNullOrWhiteSpace(descripcion))
                throw new ArgumentException("La descripción no puede estar vacía.");

            Id = id;
            Descripcion = descripcion;
            Completada = false;
        }

        public void Completar()
        {
            Completada = true;
        }
    }
}

