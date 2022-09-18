using Microsoft.VisualStudio.TestTools.UnitTesting;
using EjercicioExtExcTest.Program;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioExtExcTest.Program.Tests
{
    [TestClass()]
    public class TOperationTests
    {
        [TestMethod()]
        public void MathPowerTest()
        {
            // Arrange

            int numero = 2;
            int potencia = 6;
            int resultado = 64;

            // Act

            var pruebaPotencia = Math.Pow(numero, potencia);

            // Assert

            Assert.AreEqual(resultado,pruebaPotencia);
        }

    }
}