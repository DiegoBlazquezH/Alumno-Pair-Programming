using System;
using System.Collections.Generic;
using System.Configuration;
using System.Reflection;
using Vueling.Common.Logic;
using Vueling.Common.Logic.Model;
using Vueling.DataAccess.Dao;
using Vueling.DataAccess.Dao.Interfaces;
using static Vueling.Common.Logic.Enums.ExtensionesFicheros;

namespace Vueling.Business.Logic
{
    public class AlumnoBL : IAlumnoBL
    {
        private IFicheroAlumno ficheroAlumno;
        private readonly ILogger logger = new Logger(MethodBase.GetCurrentMethod().DeclaringType);

        public AlumnoBL()
        {
            try
            {
                logger.Debug("Empieza AlumnoBL()");
                FicheroFactory ficheroFactory = new FicheroFactory();
                ficheroAlumno = ficheroFactory.CrearFichero((Extension)Enum.Parse(typeof(Extension), ConfigurationManager.AppSettings["tipoFichero"]));
                logger.Debug("Termina AlumnoBL()");
            }
            catch (Exception ex)
            {
                logger.Exception(ex);
                throw;
            }
        }

        public Alumno Add(Alumno alumno)
        {
            try
            {
                logger.Debug("Empieza Add()");
                alumno.FechaCompletaAlta = DateTime.Now;
                alumno.Edad = CalcularEdad(DateTime.Now, alumno.FechaNacimiento);
                logger.Debug("Termina Add()");
                return ficheroAlumno.Add(alumno);
            }
            catch (Exception ex)
            {
                logger.Exception(ex);
                throw;
            }
        }

        public int CalcularEdad(DateTime fechaCompletaActual, DateTime fechaNacimiento)
        {
            try
            {
                logger.Debug("Empieza y termina CalcularEdad()");
                return (Convert.ToInt32((fechaCompletaActual - fechaNacimiento).TotalDays) / 365);
            }
            catch (Exception ex)
            {
                logger.Exception(ex);
                throw;
            }
        } 

        public void SeleccionarTipoFichero(Extension extension)
        {
            try
            {
                logger.Debug("Empieza SeleccionarTipoFichero()");
                FicheroFactory ficheroFactory = new FicheroFactory();
                ficheroAlumno = ficheroFactory.CrearFichero(extension);
                logger.Debug("Termina SeleccionarTipoFichero()");
            }
            catch (Exception ex)
            {
                logger.Exception(ex);
                throw;
            }
        }

        public List<Alumno> GetAll()
        {
            try
            {
                logger.Debug("Empieza GetAll()");
                List<Alumno> alumnos = ficheroAlumno.GetAll();
                logger.Debug("Termina GetAll()");
                return alumnos;
            }
            catch (Exception ex)
            {
                logger.Exception(ex);
                throw;
            }
        }
        public List<Alumno> CrearListado()
        {
            try
            {
                logger.Debug("Empieza SeleccionarTipoFichero()");
                List<Alumno> alumnos = ficheroAlumno.CrearListado();
                logger.Debug("Termina CrearListado()");
                return alumnos;
            }
            catch (Exception ex)
            {
                logger.Exception(ex);
                throw;
            }
        }
    }
}
