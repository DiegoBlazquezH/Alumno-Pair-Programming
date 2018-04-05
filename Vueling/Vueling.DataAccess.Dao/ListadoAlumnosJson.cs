using System.Collections.Generic;
using Vueling.DataAccess.Dao;
using Vueling.DataAccess.Dao.Interfaces;

namespace Vueling.Common.Logic.Model
{
    public class ListadoAlumnosJson
    {
        private static ListadoAlumnosJson _instance;
        public List<Alumno> ListadoAlumnos { get; set; }

        // Constructor is 'protected'

        protected ListadoAlumnosJson()
        {
        }

        public static ListadoAlumnosJson Instance()
        {
            // Uses lazy initialization.

            // Note: this is not thread safe.

            if (_instance == null)
            {
                _instance = new ListadoAlumnosJson();
                IFicheroAlumno ficheroAlumno = new FicheroAlumnoJson();
                _instance.ListadoAlumnos = ficheroAlumno.GetAll();
            }

            return _instance;
        }
        
    }
}
