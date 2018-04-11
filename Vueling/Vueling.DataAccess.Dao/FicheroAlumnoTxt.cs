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
    public class FicheroAlumnoTxt : IFicheroAlumno
    {
        public string Ruta { get; set; }
        private readonly ILogger logger = new Logger(MethodBase.GetCurrentMethod().DeclaringType);

        public FicheroAlumnoTxt()
        {
            try
            {
                logger.Debug("Empieza FicheroAlumnoTxt()");
                Ruta = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\" + "ListadoAlumnos.txt";
                logger.Debug("Termina FicheroAlumnoTxt()");

            }
            catch (Exception ex)
            {
                logger.Exception(ex);
                throw;
            }
        }

        public FicheroAlumnoTxt(string ruta)
        {
            try
            {
                logger.Debug("Empieza FicheroAlumnoTxt()");
                Ruta = ruta;
                logger.Debug("Termina FicheroAlumnoTxt()");
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
                using (StreamWriter sw = File.AppendText(Ruta))
                {
                    sw.WriteLine(alumno.ToString());
                }
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
            string linea;

            try
            {
                logger.Debug("Empieza Select()");
                using (StreamReader sr = new StreamReader(Ruta))
                {
                    while ((linea = sr.ReadLine()) != null)
                    {
                        Alumno alumno = Deserialize(linea);
                        if (alumno.GUID == guid) return alumno;
                    }
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

        private Alumno Deserialize(string alumnoTxt)
        {
            try
            {
                logger.Debug("Empieza Deserialize()");
                List<string> paramsAlumno = alumnoTxt.Split(',').ToList<string>();

                Alumno alumno = new Alumno(Guid.Parse(paramsAlumno[0]), Convert.ToInt32(paramsAlumno[1]), paramsAlumno[2],
                        paramsAlumno[3], paramsAlumno[4], DateTime.Parse(paramsAlumno[5]),
                        Convert.ToInt32(paramsAlumno[6]), DateTime.Parse(paramsAlumno[7]));
                logger.Debug("Termina Deserialize()");
                return alumno;
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
                List<Alumno> alumnos = new List<Alumno>();
                string linea;

                using (StreamReader sr = new StreamReader(Ruta))
                {
                    while ((linea = sr.ReadLine()) != null)
                    {
                        Alumno alumno = Deserialize(linea);
                        alumnos.Add(alumno);
                    }
                }
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
                logger.Debug("Empieza CrearListado()");
                List<Alumno> alumnos = GetAll();
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