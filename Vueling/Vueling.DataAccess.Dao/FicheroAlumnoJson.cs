using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Vueling.Common.Logic;
using Vueling.Common.Logic.Model;
using Vueling.DataAccess.Dao.Interfaces;

namespace Vueling.DataAccess.Dao
{
    public class FicheroAlumnoJson : IFicheroAlumno
    {
        public string Ruta { get; set; }
        private readonly ILogger logger = new Logger(MethodBase.GetCurrentMethod().DeclaringType);

        public FicheroAlumnoJson()
        {
            try
            {
                logger.Debug("Empieza FicheroAlumnoJson()");
                Ruta = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\" + "ListadoAlumnos.json";
                logger.Debug("Termina FicheroAlumnoJson()");
            }
            catch (Exception ex)
            {
                logger.Exception(ex);
                throw;
            }
        }

        public FicheroAlumnoJson(string ruta)
        {
            try
            {
                logger.Debug("Empieza FicheroAlumnoJson()");
                Ruta = ruta;
                logger.Debug("Termina FicheroAlumnoJson()");
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
                List<Alumno> alumnosFicheroExistente = DeserializeJson();
                alumnosFicheroExistente.Add(alumno);
                string jsonNuevo = JsonConvert.SerializeObject(alumnosFicheroExistente, Formatting.Indented);
                FileUtils.EscribirFichero(jsonNuevo, Ruta);
                logger.Debug("Termina Add()");
                return Select(alumno.GUID);
            }
            catch (Exception ex)
            {
                logger.Exception(ex);
                throw;
            }
        }

        public Alumno Select(Guid guid)
        {
            try
            {
                logger.Debug("Empieza Select()");
                List<Alumno> alumnosFicheroExistente = DeserializeJson();
                foreach (Alumno alumno in alumnosFicheroExistente)
                {
                    if (alumno.GUID == guid) return alumno;
                }
                logger.Debug("Termina Select()");
                return null;
            }
            catch (Exception ex)
            {
                logger.Exception(ex);
                throw;
            }
        }

        private List<Alumno> DeserializeJson()
        {
            try
            {
                logger.Debug("Empieza DeserializeJson()");
                List<Alumno> alumnosFicheroExistente = new List<Alumno>();
                if (File.Exists(Ruta) && new FileInfo(Ruta).Length != 0)
                {
                    alumnosFicheroExistente = JsonConvert.DeserializeObject<List<Alumno>>(File.ReadAllText(Ruta));
                }
                logger.Debug("Termina DeserializeJson()");
                return alumnosFicheroExistente;
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
                List<Alumno> alumnos = DeserializeJson();
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
                logger.Debug("Empieza CrearListado()");
                ListadoAlumnosJson listadoAlumnosJson = ListadoAlumnosJson.Instance();
                logger.Debug("Termina CrearListado()");
                return listadoAlumnosJson.ListadoAlumnos;
            }
            catch (Exception ex)
            {
                logger.Exception(ex);
                throw;
            }
        }        
    }
}
