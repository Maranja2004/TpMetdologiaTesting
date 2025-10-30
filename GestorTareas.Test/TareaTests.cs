using GestorTareas;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GestorTareas.Tests
{
    [TestClass]
    public class TareaTests
    {
        [TestMethod]
        public void Completar_DeberiaCambiarEstadoACompletada()
        {
            var tarea = new Tarea(1, "Escribir informe");
            tarea.Completar();
            Assert.IsTrue(tarea.Completada);
        }

        [TestMethod]
        public void CrearTarea_DeberiaGuardarDescripcionCorrecta()
        {
            var tarea = new Tarea(2, "Enviar mail");
            Assert.AreEqual("Enviar mail", tarea.Descripcion);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void CrearTarea_SinDescripcion_DeberiaLanzarExcepcion()
        {
            var tarea = new Tarea(3, "");
        }

        [TestMethod]
        public void CrearTarea_AumentaCantidadArray()
        {
            var gestor = new GestorTareas();
            int cantidadInicial = gestor.ObtenerPendientes().Count();
            gestor.Agregar("Nueva tarea");
            int cantidadFinal = gestor.ObtenerPendientes().Count();
            Assert.AreEqual(cantidadInicial + 1, cantidadFinal);
        }
    }
}
