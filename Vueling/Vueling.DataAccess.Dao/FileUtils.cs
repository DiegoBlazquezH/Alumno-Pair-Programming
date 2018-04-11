using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Vueling.Common.Logic;

namespace Vueling.DataAccess.Dao
{
    public static class FileUtils
    {
        public static void EscribirFichero(string fileContent, string Ruta)
        {

            ILogger logger = new Logger(MethodBase.GetCurrentMethod().DeclaringType);

            logger.Debug("Empieza EscribirFichero()");
            try
            {
                using (StreamWriter sw = File.CreateText(Ruta))
                {
                    sw.WriteLine(fileContent);
                    
                }
            }
            catch (Exception ex)
            {
                if (ex is UnauthorizedAccessException)
                {
                    logger.Exception(ex, "EscribirFichero() - Error de fichero, acceso no autorizado");
                }
                else if(ex is DirectoryNotFoundException)
                {
                    logger.Exception(ex, "EscribirFichero() - Error de fichero, fichero no encontrado");
                }
                else
                {
                    logger.Exception(ex, "EscribirFichero() - Error de fichero");
                }
                throw;
            }
            logger.Debug("Termina EscribirFichero()");
        }
                
    }
}
