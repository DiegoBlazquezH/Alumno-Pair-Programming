using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Vueling.Common.Logic;
using Vueling.Common.Logic.Model;
using Vueling.DataAccess.Dao.Interfaces;
using static Vueling.Common.Logic.Enums.ExtensionesFicheros;

namespace Vueling.DataAccess.Dao
{
    public class FicheroFactory
    {
        private readonly ILogger logger = new Logger(MethodBase.GetCurrentMethod().DeclaringType);
        public IFicheroAlumno CrearFichero(Extension extension)
        {
            try
            {
                logger.Debug("Empieza CrearFichero()");
                switch (extension)
                {
                    case Extension.TXT:
                        logger.Debug("Empieza CrearFichero(Texto)");
                        return new FicheroAlumnoTxt();
                    case Extension.JSON:
                        logger.Debug("Empieza CrearFichero(JSON)");
                        return new FicheroAlumnoJson();
                    case Extension.XML:
                        logger.Debug("Empieza CrearFichero(XML)");
                        return new FicheroAlumnoXml();
                    default:
                        logger.Debug("Empieza CrearFichero(Texto Default)");
                        return new FicheroAlumnoTxt();
                }
            }
            catch (Exception ex)
            {
                logger.Exception(ex);
                throw;
            }
        }
    }
}
