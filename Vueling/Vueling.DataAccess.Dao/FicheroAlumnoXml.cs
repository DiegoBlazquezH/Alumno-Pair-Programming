using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Vueling.Common.Logic;
using Vueling.Common.Logic.Model;
using Vueling.DataAccess.Dao.Interfaces;

namespace Vueling.DataAccess.Dao
{
    public class FicheroAlumnoXml : IFicheroAlumno
    {
        public string Ruta { get; set; }
        private readonly ILogger logger = new Logger(MethodBase.GetCurrentMethod().DeclaringType);

        public FicheroAlumnoXml()
        {
            try
            {
                logger.Debug("Empieza FicheroAlumnoXml()");
                Ruta = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\" + "ListadoAlumnos.xml";
                logger.Debug("Termina FicheroAlumnoXml()");
            }
            catch (Exception ex)
            {
                logger.Exception(ex);
                throw;
            }
        }

        public FicheroAlumnoXml(string ruta)
        {
            try
            {
                logger.Debug("Empieza FicheroAlumnoXml()");
                Ruta = ruta;
                logger.Debug("Termina FicheroAlumnoXml()");
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
                logger.Debug("Empieza FicheroAlumnoXml()");
                List<Alumno> alumnosFicheroExistente = DeserializeXml();
                alumnosFicheroExistente.Add(alumno);
                string xmlNuevo = SerializeXml(alumnosFicheroExistente);
                FileUtils.EscribirFichero(xmlNuevo, Ruta);
                logger.Debug("Termina FicheroAlumnoXml()");
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
                List<Alumno> alumnosFicheroExistente = DeserializeXml();
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

        private string SerializeXml(List<Alumno> alumnosFicheroExistente)
        {
            try
            {
                logger.Debug("Empieza SerializeXml()");
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Alumno>));
                using (StringWriter writer = new StringWriter())
                {
                    xmlSerializer.Serialize(writer, alumnosFicheroExistente);
                    logger.Debug("Termina SerializeXml()");
                    return writer.ToString();
                }
            }
            catch (Exception ex)
            {
                logger.Exception(ex);
                throw;
            }
        }

        private List<Alumno> DeserializeXml()
        {
            try
            {
                logger.Debug("Empieza DeserializeXml()");
                List<Alumno> alumnosFicheroExistente = new List<Alumno>();
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Alumno>));

                if (File.Exists(Ruta) && new FileInfo(Ruta).Length != 0)
                {
                    alumnosFicheroExistente = (List<Alumno>)xmlSerializer.Deserialize(new StringReader(File.ReadAllText(Ruta)));
                }
                logger.Debug("Termina FicheroAlumnoXml()");
                return alumnosFicheroExistente;
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
                logger.Debug("Empieza CrearListado()");
                ListadoAlumnosXml listadoAlumnosXml = ListadoAlumnosXml.Instance();
                logger.Debug("Termina CrearListado()");
                return listadoAlumnosXml.ListadoAlumnos;
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
                List<Alumno> alumnos = DeserializeXml();
                logger.Debug("Termina GetAll()");
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
