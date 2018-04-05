using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Vueling.Business.Logic;

namespace Vueling.Business.LogicTests
{
    [TestClass]
    public class TestsAlumnoBL
    {
        private readonly IAlumnoBL alumnoBL = new AlumnoBL();

        public static IEnumerable<object[]> DatosFechasEdad()
        {
            yield return new object[] { new DateTime(2018, 4, 4), new DateTime(1994, 1, 24), 24 };
            yield return new object[] { new DateTime(2018, 4, 4), new DateTime(1994, 6, 24), 23 };
            yield return new object[] { new DateTime(2018, 4, 4), new DateTime(2000, 4,  4), 18 };
        }
        [DataTestMethod]
        [DynamicData(nameof(DatosFechasEdad), DynamicDataSourceType.Method)]
        public void CalcularEdadTest(DateTime fechaCompletaActual, DateTime fechaNacimiento, int edadEsperada)
        {
            Assert.IsTrue(alumnoBL.CalcularEdad(fechaCompletaActual, fechaNacimiento) == edadEsperada);
        }
    }
}
