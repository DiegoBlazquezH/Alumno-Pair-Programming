﻿using Vueling.DataAccess.Dao.Interfaces;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using Vueling.DataAccess.Dao;
using Vueling.Common.Logic.Model;
using Vueling.Common.Logic.Enums;

namespace Vueling.Tests.DataAccess.Dao.IntegrationTests
{
    [TestClass()]
    public class IntegrationTestsFicheroAlumno
    {
        private readonly string Ruta = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\" + "ListadoAlumnos.";
        private readonly FicheroFactory ficheroFactory = new FicheroFactory();

        [TestInitialize]
        public void InitTest()
        {
            if (File.Exists(Ruta + "txt")) File.Delete(Ruta + "txt");
            if (File.Exists(Ruta + "json")) File.Delete(Ruta + "json");
            if (File.Exists(Ruta + "xml")) File.Delete(Ruta + "xml");
        }

        [TestCleanup]
        public void CleanTest()
        {
            File.Delete(Ruta + "txt");
            File.Delete(Ruta + "json");
            File.Delete(Ruta + "xml");
        }

        public static IEnumerable<object[]> DatosAlumno()
        {
            yield return new object[] { new Alumno(Guid.NewGuid(), 1, "Diego", "Blázquez", "11111111A", new DateTime(1994, 1, 24), 24, DateTime.Now) };
            yield return new object[] { new Alumno(Guid.NewGuid(), 2, "Niño", "Pequeño", "22222222B", new DateTime(2000, 12, 3), 17, DateTime.Now) };
            yield return new object[] { new Alumno(Guid.NewGuid(), 3, "Usuario", "Pruebas", "33333333C", new DateTime(2015, 4, 4), 3, DateTime.Now) };
        }

        [DataTestMethod]
        [DynamicData(nameof(DatosAlumno), DynamicDataSourceType.Method)]
        public void TestFicheroAlumnoTxt(Alumno alumno)
        {

            IFicheroAlumno ficheroAlumnoTxt = new FicheroAlumnoTxt();
            ficheroFactory.CrearFichero(Extension.TXT);
            Alumno alumnoAñadido = ficheroAlumnoTxt.Add(alumno);
            Assert.IsTrue(alumno.Equals(alumnoAñadido));
        }

        [DataTestMethod]
        [DynamicData(nameof(DatosAlumno), DynamicDataSourceType.Method)]
        public void TestFicheroAlumnoJson(Alumno alumno)
        {
            IFicheroAlumno ficheroAlumnoJson = new FicheroAlumnoJson();
            ficheroFactory.CrearFichero(Extension.JSON);
            Alumno alumnoAñadido = ficheroAlumnoJson.Add(alumno);
            Assert.IsTrue(alumno.Equals(alumnoAñadido));
        }

        [DataTestMethod]
        [DynamicData(nameof(DatosAlumno), DynamicDataSourceType.Method)]
        public void TestFicheroAlumnoXml(Alumno alumno)
        {
            IFicheroAlumno ficheroAlumnoXml = new FicheroAlumnoXml();
            ficheroFactory.CrearFichero(Extension.XML);
            Alumno alumnoAñadido = ficheroAlumnoXml.Add(alumno);
            Assert.IsTrue(alumno.Equals(alumnoAñadido));
        }

    }
}