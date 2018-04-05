using Microsoft.VisualStudio.TestTools.UnitTesting;
using Vueling.DataAccess.Dao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vueling.Business.Logic;
using Vueling.DataAccess.Dao.Interfaces;

namespace Vueling.DataAccess.Dao.Tests
{
    [TestClass()]
    public class TestsFicheroAlumno
    {
        private readonly string Ruta = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\" + "ListadoAlumnos.";
        private readonly IFicheroFactory ficheroFactory;
        private readonly IFichero ficheroFactory

        public static IEnumerable<object[]> DatosAlumno()
        {
            yield return new object[] { new DateTime(2018, 4, 4), new DateTime(1994, 1, 24), 24 };
            yield return new object[] { new DateTime(2018, 4, 4), new DateTime(1994, 6, 24), 23 };
            yield return new object[] { new DateTime(2018, 4, 4), new DateTime(2000, 4, 4), 18 };
        }
        [DataTestMethod]
        [DynamicData(nameof(DatosAlumno), DynamicDataSourceType.Method)]

        
    }
}