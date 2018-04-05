using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vueling.DataAccess.Dao
{
    public static class FileUtils
    {
        public static void EscribirFichero(string fileContent, string Ruta)
        {
            using (StreamWriter sw = File.CreateText(Ruta))
            {
                sw.WriteLine(fileContent);
            }
        }
    }
}
