using System;
using System.Collections.Generic;
using System.Reflection;
using Vueling.Common.Logic.Properties;
using Vueling.DataAccess.Dao;
using Vueling.DataAccess.Dao.Interfaces;

namespace Vueling.Common.Logic.Model
{
    public class ListadoAlumnosXml
    {
        private static ListadoAlumnosXml _instance;
        public List<Alumno> ListadoAlumnos { get; set; }
        private static object syncLock = new object();

        protected ListadoAlumnosXml()
        {
            ILogger logger = new Logger(MethodBase.GetCurrentMethod().DeclaringType);
            logger.Debug(LogStrings.Instantiating + " " + MethodBase.GetCurrentMethod().DeclaringType.Name + " " + LogStrings.Singleton);
        }

        public static ListadoAlumnosXml Instance()
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
                            _instance = new ListadoAlumnosXml();
                            IFicheroAlumno ficheroAlumno = new FicheroAlumnoXml();
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
