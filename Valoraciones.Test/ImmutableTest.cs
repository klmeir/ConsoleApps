using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Valoraciones.Test
{
    [TestClass]
    public class ImmutableTest
    {
        [TestMethod]
        public void ImmutableTestMethod()
        {
            string nombre = "Nombre";
            nombre = nombre.ToUpper();

            Assert.AreEqual("NOMBRE", nombre);

            LibroValoraciones libro1 = new LibroValoraciones();
            libro1.Nombre = "Nombre";
            libro1.Nombre = libro1.Nombre.ToUpper();

            Assert.AreEqual("NOMBRE", libro1.Nombre);

            DateTime fecha = new DateTime(1997, 8, 26);
            fecha = fecha.AddDays(1);

            Assert.AreEqual(27, fecha.Day);
        }
    }
}
