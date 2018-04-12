using System.Collections.Generic;
using Vueling.DataAccess.Dao;
using Vueling.DataAccess.Dao.Interfaces;
using System;
using System.Reflection;
using Vueling.Common.Logic.Properties;

namespace Vueling.Common.Logic.Model
{
    public class ListadoAlumnosJson
    {
        private static ListadoAlumnosJson _instance;
        public List<Alumno> ListadoAlumnos { get; set; }
        private static object syncLock = new object();

        protected ListadoAlumnosJson()
        {
            ILogger logger = new Logger(MethodBase.GetCurrentMethod().DeclaringType);
            logger.Debug(LogStrings.Instantiating + " " + MethodBase.GetCurrentMethod().DeclaringType.Name + " " + LogStrings.Singleton);
        }

        public static ListadoAlumnosJson Instance()
        {
            ILogger logger = new Logger(MethodBase.GetCurrentMethod().DeclaringType);

            try
            {
                logger.Debug(MethodBase.GetCurrentMethod().DeclaringType.Name + " " + LogStrings.Starts);
                if (_instance == null)
                {
                    lock (syncLock)
                    {
                        if (_instance == null)
                        {
                            _instance = new ListadoAlumnosJson();
                            IFicheroAlumno ficheroAlumno = new FicheroAlumnoJson();
                            _instance.ListadoAlumnos = ficheroAlumno.GetAll();
                        }
                    }
                }
                logger.Debug(MethodBase.GetCurrentMethod().DeclaringType.Name + " " + LogStrings.Ends);
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
