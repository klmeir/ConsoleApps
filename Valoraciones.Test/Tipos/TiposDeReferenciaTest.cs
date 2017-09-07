using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Valoraciones.Test.Tipos
{
    [TestClass]
    public class TiposDeReferenciaTest
    {
        [TestMethod]
        public void VariablesTipoRererencia()
        {
            LibroValoraciones l1 = new LibroValoraciones();
            l1.Nombre = "Libro de Test 1";

            LibroValoraciones l2 = l1;

            l1.Nombre = "Lirbo ...";

            Assert.AreEqual(l1.Nombre, l2.Nombre);
        }

        [TestMethod]
        public void MyArrayTestMethod()
        {            
            letras = new string[3];
            AgregarLetra("A");
            Assert.AreEqual("A", letras[0]);
        }

        [TestMethod]
        public void IntTestMethod()
        {
            numerosReferencia = new int[3];
            numerosReferencia[0] = 1;
            numerosReferencia[0] = 2;
            numerosReferencia[0] = 3;

            int[] numerosReferencia2 = numerosReferencia;

            Assert.AreEqual(numerosReferencia[0], numerosReferencia2[0]);
        }

        private void AgregarLetra(string l)
        {
            letras[0] = l;
        }

        string[] letras;
        int[] numerosReferencia;
    }
}
