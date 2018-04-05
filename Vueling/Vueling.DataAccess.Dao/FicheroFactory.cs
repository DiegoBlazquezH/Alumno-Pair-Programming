using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vueling.Common.Logic.Model;
using Vueling.DataAccess.Dao.Interfaces;
using static Vueling.Common.Logic.Enums.ExtensionesFicheros;

namespace Vueling.DataAccess.Dao
{
    public class FicheroFactory
    {
        public IFicheroAlumno CrearFichero(Extension extension)
        {
            switch (extension)
            {
                case Extension.TXT:
                    return new FicheroAlumnoTxt();
                case Extension.JSON:
                    return new FicheroAlumnoJson();
                case Extension.XML:
                    return new FicheroAlumnoXml();
                default:
                    return new FicheroAlumnoTxt();
            }
        }
    }
}
