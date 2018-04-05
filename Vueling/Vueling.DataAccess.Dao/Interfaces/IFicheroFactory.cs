using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Vueling.Common.Logic.Enums.ExtensionesFicheros;

namespace Vueling.DataAccess.Dao.Interfaces
{
    public interface IFicheroFactory
    {
        IFicheroAlumno CrearFichero(Extension extension);
    }
}
