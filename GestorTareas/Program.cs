using GestorTareas;
namespace GestorTareas

{
    internal class Program

    {
        static void Main(string[] args)
        {
            var gestor = new GestorTareas();
            gestor.Agregar("Preparar presentación");
            gestor.Agregar("Enviar correo al cliente");

            gestor.ObtenerPendientes()
                  .ToList()
                  .ForEach(t => Console.WriteLine($"{t.Id}. {t.Descripcion} - Pendiente"));
        }
    }
}
