using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vueling.Common.Logic.Model;
using Vueling.DataAccess.Dao;
using Vueling.DataAccess.Dao.Interfaces;
using static Vueling.Common.Logic.Enums.ExtensionesFicheros;

namespace Vueling.Business.Logic
{
    public class AlumnoBL : IAlumnoBL
    {
        private IFicheroAlumno ficheroAlumno;

        public AlumnoBL()
        {
            FicheroFactory ficheroFactory = new FicheroFactory();
            ficheroAlumno = ficheroFactory.CrearFichero((Extension)Enum.Parse(typeof(Extension), ConfigurationManager.AppSettings["tipoFichero"]));
        }

        public Alumno Add(Alumno alumno)
        {
            alumno.FechaCompletaAlta = DateTime.Now;
            alumno.Edad = CalcularEdad(DateTime.Now, alumno.FechaNacimiento);
            return ficheroAlumno.Add(alumno);
        }

        public int CalcularEdad(DateTime fechaCompletaActual, DateTime fechaNacimiento)
        {
            return (Convert.ToInt32((fechaCompletaActual - fechaNacimiento).TotalDays) / 365);
        }

        public void SeleccionarTipoFichero(Extension extension)
        {
            FicheroFactory ficheroFactory = new FicheroFactory();
            ficheroAlumno = ficheroFactory.CrearFichero(extension);
        }
    }
}
