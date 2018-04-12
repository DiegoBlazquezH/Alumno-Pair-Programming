using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Vueling.Common.Logic;
using Vueling.Common.Logic.Model;
using Vueling.Common.Logic.Properties;
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
                logger.Debug(MethodBase.GetCurrentMethod().DeclaringType.Name + " " + LogStrings.Starts);
                switch (extension)
                {
                    case Extension.TXT:
                        logger.Debug(MethodBase.GetCurrentMethod().DeclaringType.Name + " " + Extension.TXT + " " + LogStrings.Starts);
                        return new FicheroAlumnoTxt();
                    case Extension.JSON:
                        logger.Debug(MethodBase.GetCurrentMethod().DeclaringType.Name + " " + Extension.JSON + " " + LogStrings.Starts);
                        return new FicheroAlumnoJson();
                    case Extension.XML:
                        logger.Debug(MethodBase.GetCurrentMethod().DeclaringType.Name + " " + Extension.XML + " " + LogStrings.Starts);
                        return new FicheroAlumnoXml();
                    case Extension.SQL:
                        logger.Debug(MethodBase.GetCurrentMethod().DeclaringType.Name+ " " + Extension.SQL + " " + LogStrings.Starts);
                        return new FicheroAlumnoSql();
                    default:
                        logger.Debug(MethodBase.GetCurrentMethod().DeclaringType.Name + " " + Extension.TXT + " " + LogStrings.Starts);
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
