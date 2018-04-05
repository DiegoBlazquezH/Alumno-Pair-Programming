using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vueling.Common.Logic.Model;

namespace Vueling.DataAccess.Dao.Interfaces
{
    public interface IFicheroAlumno
    {
        string Ruta { get; set; }

        Alumno Add(Alumno alumno);
        Alumno Select(Guid guid);
    }
}