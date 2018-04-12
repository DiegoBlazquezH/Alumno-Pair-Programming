using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Vueling.Common.Logic;
using Vueling.Common.Logic.Model;
using Vueling.DataAccess.Dao.Interfaces;

namespace Vueling.DataAccess.Dao
{
    public class FicheroAlumnoSql : IFicheroAlumno
    {
        private readonly ILogger logger = new Logger(MethodBase.GetCurrentMethod().DeclaringType);
        private readonly string ConnectionString;

        public FicheroAlumnoSql()
        {
            try
            {
                logger.Debug("Empieza FicheroAlumnoJson()");
                //ConnectionString = ;
                logger.Debug("Termina FicheroAlumnoJson()");
            }
            catch (Exception ex)
            {
                logger.Exception(ex);
                throw;
            }
        }

        public Alumno Add(Alumno alumno)
        {
            throw new NotImplementedException();
        }

        public List<Alumno> GetAll()
        {
            throw new NotImplementedException();
        }

        public List<Alumno> GetSingletonInstance()
        {
            throw new NotImplementedException();
        }

        public Alumno Select(Guid guid)
        {
            throw new NotImplementedException();
        }
    }
}
