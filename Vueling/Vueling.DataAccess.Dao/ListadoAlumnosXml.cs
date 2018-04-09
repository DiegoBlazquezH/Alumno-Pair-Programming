using System;
using System.Collections.Generic;
using System.Reflection;
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
            ILogger logger = new Logger(MethodBase.GetCurrentMethod().DeclaringType);
            logger.Debug("Instanciando ListadoAlumnosXml Singleton");
        }

        public static ListadoAlumnosXml Instance()
        {
            // Uses lazy initialization.

            // Note: this is not thread safe.

            ILogger logger = new Logger(MethodBase.GetCurrentMethod().DeclaringType);

            try
            {
                logger.Debug("Empieza Instance()");
                if (_instance == null)
                {
                    _instance = new ListadoAlumnosXml();
                    IFicheroAlumno ficheroAlumno = new FicheroAlumnoXml();
                    _instance.ListadoAlumnos = ficheroAlumno.GetAll();
                }
                logger.Debug("Termina Instance()");
                return _instance;
            }
            catch (Exception ex)
            {
                logger.Exception(ex);
                throw;
            }
        }
    }
}
