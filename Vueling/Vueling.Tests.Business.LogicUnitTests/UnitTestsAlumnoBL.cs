using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NMock;
using Vueling.Common.Logic.Model;

namespace Vueling.Tests.Business.LogicUnitTests
{
    [TestClass]
    public class UnitTestsAlumnoBL
    {
        private readonly MockFactory _factory = new MockFactory();
        private Mock<ListadoAlumnosJson> SingletonJson;
        private List<Alumno> ListaAlumnos = new List<Alumno>();


        [TestInitialize]
        public void InitTest()
        {
            SingletonJson = _factory.CreateMock<ListadoAlumnosJson>();
            ListaAlumnos.Add(new Alumno(Guid.NewGuid(), 1, "Diego", "Blázquez", "11111111A", new DateTime(1994, 1, 24), 24, DateTime.Now));
            ListaAlumnos.Add(new Alumno(Guid.NewGuid(), 2, "Niño", "Pequeño", "22222222B", new DateTime(2000, 12, 3), 17, DateTime.Now));
            ListaAlumnos.Add(new Alumno(Guid.NewGuid(), 3, "Usuario", "Pruebas", "33333333C", new DateTime(2015, 4, 4), 3, DateTime.Now));
        }

        [TestCleanup]
        public void CleanTest()
        {
            _factory.ClearExpectations();
        }

        public static IEnumerable<object[]> DatosAlumno()
        {
            yield return new object[] { "", "1", "", "", "", null,  false, "", DateTime.Now, false };
        }

        [DataTestMethod]
        [DynamicData(nameof(DatosAlumno), DynamicDataSourceType.Method)]
        public void FilterUnitTest(string guid, string nombre, string apellidos, string dni, string id, DateTime dtFechaNacimiento, bool fechaNacimientoChecked, string edad, DateTime dtFechaRegistro, bool fechaRegistroChecked)
        {

            SingletonJson.Expects
               .One
               .Method(s => s.GetList())
               .WillReturn(ListaTest);
        }
    }
}
