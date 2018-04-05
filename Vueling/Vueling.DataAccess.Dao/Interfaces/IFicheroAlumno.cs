using System;
using System.Collections.Generic;
using Vueling.Common.Logic.Model;

namespace Vueling.DataAccess.Dao.Interfaces
{
    public interface IFicheroAlumno
    {
        string Ruta { get; set; }

        Alumno Add(Alumno alumno);
        Alumno Select(Guid guid);
        List<Alumno> GetAll();
        List<Alumno> CrearListado();        
    }
}