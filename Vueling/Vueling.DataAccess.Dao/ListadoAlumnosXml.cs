using System.Collections.Generic;
using Vueling.DataAccess.Dao;
using Vueling.DataAccess.Dao.Interfaces;

namespace Vueling.Common.Logic.Model
{
    public class ListadoAlumnosXml
    {
        private static ListadoAlumnosXml _instance;
        public List<Alumno> ListadoAlumnos { get; set; }

        // Constructor is 'protected'

        protected ListadoAlumnosXml()
        {
        }

        public static ListadoAlumnosXml Instance()
        {
            // Uses lazy initialization.

            // Note: this is not thread safe.

            if (_instance == null)
            {
                _instance = new ListadoAlumnosXml();
                IFicheroAlumno ficheroAlumno = new FicheroAlumnoXml();
                _instance.ListadoAlumnos = ficheroAlumno.GetAll();
            }

            return _instance;
        }
    }
}
