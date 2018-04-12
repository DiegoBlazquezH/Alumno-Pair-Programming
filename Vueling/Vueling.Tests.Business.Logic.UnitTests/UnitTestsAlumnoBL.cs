using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NMock;
using Vueling.Business.Logic;
using Vueling.Common.Logic.Model;

namespace Vueling.Tests.Business.Logic.UnitTests
{
    [TestClass]
    public class UnitTestsAlumnoBL
    {
        private readonly MockFactory _factory = new MockFactory();
        private Mock<ListadoAlumnosJson> SingletonJson;
        private List<Alumno> ListaAlumnos = new List<Alumno>();
        private Alumno alumno1 = new Alumno();
        private Alumno alumno2 = new Alumno();
        private Alumno alumno3 = new Alumno();


        [TestInitialize]
        public void InitTest()
        {
            SingletonJson = _factory.CreateMock<ListadoAlumnosJson>();

            alumno1 = new Alumno(Guid.NewGuid(), 1, "Diego", "Blázquez", "11111111A", new DateTime(1994, 1, 24), 24, DateTime.Now);
            alumno2 = new Alumno(Guid.NewGuid(), 2, "Niño", "Pequeño", "22222222B", new DateTime(2000, 12, 3), 17, DateTime.Now);
            alumno3 = new Alumno(Guid.NewGuid(), 3, "Usuario", "Pruebas", "33333333C", new DateTime(2015, 4, 4), 3, DateTime.Now);
            ListaAlumnos.Add(alumno1);
            ListaAlumnos.Add(alumno2);
            ListaAlumnos.Add(alumno3);
        }

        [TestCleanup]
        public void CleanTest()
        {
            _factory.ClearExpectations();
        }

        public static IEnumerable<object[]> DatosAlumno()
        {
            yield return new object[] { "", "1", "", "", "", null, false, "", DateTime.Now, false };
        }

        [DataTestMethod]
        [DynamicData(nameof(DatosAlumno), DynamicDataSourceType.Method)]
        public void FilterUnitTest(string guid, string nombre, string apellidos, string dni, string id, DateTime dtFechaNacimiento, bool fechaNacimientoChecked, string edad, DateTime dtFechaRegistro, bool fechaRegistroChecked)
        {

            throw new NotImplementedException();
        }
    }
}
