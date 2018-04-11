using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
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
        public List<Alumno> GetSingletonInstance()
        {
            try
            {
                logger.Debug("Empieza GetSingletonInstance()");
                List<Alumno> alumnos = ficheroAlumno.GetSingletonInstance();
                logger.Debug("Termina CrearListado()");
                return alumnos;
            }
            catch (Exception ex)
            {
                logger.Exception(ex);
                throw;
            }
        }

      
        public List<Alumno> Filter(string guid, string nombre, string apellidos, string dni, string id, DateTime dtFechaNacimiento,bool fechaNacimientoChecked, string edad, DateTime dtFechaRegistro, bool fechaRegistroChecked)
        {
            try
            {
                List<Alumno> alumnos = GetSingletonInstance();
                logger.Debug("Empieza Filter()");
                int idInt, edadInt;
                var query = from alu in alumnos select alu;
                if (!String.IsNullOrEmpty(guid))
                    query = query.Where(alu => alu.GUID.Equals(Guid.Parse(guid)));
                if (!String.IsNullOrEmpty(nombre))
                    query = query.Where(alu => alu.Nombre.Equals(nombre));
                if (!String.IsNullOrEmpty(apellidos))
                    query = query.Where(alu => alu.Apellidos.Equals(apellidos));
                if (!String.IsNullOrEmpty(dni))
                    query = query.Where(alu => alu.DNI.Equals(dni));
                if (!String.IsNullOrEmpty(id))
                {
                    idInt = Convert.ToInt32(id);
                    query = query.Where(alu => alu.ID.Equals(idInt));
                }
                if (fechaNacimientoChecked)
                    query = query.Where(alu => alu.FechaNacimiento.Date.Equals(dtFechaNacimiento.Date));
                if (!String.IsNullOrEmpty(edad))
                {
                    edadInt = Convert.ToInt32(edad);
                    query = query.Where(alu => alu.Edad.Equals(edadInt));
                }
                if (fechaRegistroChecked)
                    query = query.Where(alu => alu.FechaCompletaAlta.Date.Equals(dtFechaRegistro.Date));

                query = query.OrderBy(alu => alu.ID);

                var result = query.ToList();
                logger.Debug("Termina Filter()");
                return result;
            }
            catch (Exception ex)
            {
                logger.Exception(ex);
                throw;
            }
        }
    }
}
