using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Valoraciones.Test
{

    [TestClass]
    public class ValoracionesTest
    {
        [TestMethod]
        public void CalcularValoracionMaxima()
        {
            LibroValoraciones libro = new LibroValoraciones();
            libro.AgregarValoracion(5);
            libro.AgregarValoracion(4);
            libro.AgregarValoracion(3);
            libro.AgregarValoracion(0.5f);
            libro.AgregarValoracion(1);
            libro.AgregarValoracion(3.5f);

            CalcularValoraciones calculo = libro.PublicarValoraciones();

            Assert.AreEqual(5,calculo.ValoracionMax);
        }

        [TestMethod]
        public void CalcularValoracionMinima()
        {
            LibroValoraciones libro = new LibroValoraciones();
            libro.AgregarValoracion(5);
            libro.AgregarValoracion(4);
            libro.AgregarValoracion(3);
            libro.AgregarValoracion(0.5f);
            libro.AgregarValoracion(1);
            libro.AgregarValoracion(3.5f);

            CalcularValoraciones calculo = libro.PublicarValoraciones();

            Assert.AreEqual(0.5, calculo.ValoracionMin);
        }

        [TestMethod]
        public void CalcularPromedio()
        {
            LibroValoraciones libro = new LibroValoraciones();
            libro.AgregarValoracion(5);
            libro.AgregarValoracion(4);
            libro.AgregarValoracion(3);
            libro.AgregarValoracion(0.5f);
            libro.AgregarValoracion(1);
            libro.AgregarValoracion(3.5f);

            CalcularValoraciones calculo = libro.PublicarValoraciones();

            Assert.AreEqual(2.83, calculo.PromedioValoraciones, 0.01);
        }

    }
}
