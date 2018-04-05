using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Vueling.Common.Logic.Model;
using Vueling.DataAccess.Dao.Interfaces;

namespace Vueling.DataAccess.Dao
{
    public class FicheroAlumnoTxt : IFicheroAlumno
    {
        public string Ruta { get; set; }

        public FicheroAlumnoTxt()
        {
            Ruta = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\" + "ListadoAlumnos.txt";
        }

        public FicheroAlumnoTxt(string ruta)
        {
            Ruta = ruta;
        }


        public Alumno Add(Alumno alumno)
        {
            using (StreamWriter sw = File.AppendText(Ruta))
            {
                sw.WriteLine(alumno.ToString());
            }
            return Select(alumno.GUID);
        }

        public Alumno Select(Guid guid)
        {
            string linea;

            using (StreamReader sr = new StreamReader(Ruta))
            {
                while ((linea = sr.ReadLine()) != null)
                {
                    Alumno alumno = Deserialize(linea);
                    if (alumno.GUID == guid) return alumno;
                }
            }
            return null;
        }

        private Alumno Deserialize(string alumnoTxt)
        {
            List<string> paramsAlumno = alumnoTxt.Split(',').ToList<string>();
            
            Alumno alumno = new Alumno(Guid.Parse(paramsAlumno[0]), Convert.ToInt32(paramsAlumno[1]), paramsAlumno[2],
                    paramsAlumno[3], paramsAlumno[4], DateTime.Parse(paramsAlumno[5]),
                    Convert.ToInt32(paramsAlumno[6]), DateTime.Parse(paramsAlumno[7]));
            return alumno;
        }
    }
}