using Vueling.Common.Logic.Enums;

namespace Vueling.DataAccess.Dao.Interfaces
{
    public interface IFicheroFactory
    {
        IFicheroAlumno CrearFichero(Extension extension);
    }
}
