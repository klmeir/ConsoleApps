using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Valoraciones.Test.Tipos
{
    [TestClass]
    public class TiposDeValorTest
    {
        /*
        int x;
        float y;
        double z;
        string cadenas;
        */

        [TestMethod]
        public void VariablesTipoValor()
        {
            int x1 = 10;
            int x2 = x1;

            Assert.AreEqual(x1, x2);
        }

        [TestMethod]
        public void VariablesTipoValorEnum()
        {
            LibroValoraciones libro = new LibroValoraciones();
            libro.Idioma = IdiomaLibro.ES;

            Assert.AreEqual(libro.Idioma, IdiomaLibro.ES);
        }
    }
}
