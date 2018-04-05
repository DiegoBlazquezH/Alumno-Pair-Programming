using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vueling.Common.Logic.Model;
using Vueling.DataAccess.Dao.Interfaces;

namespace Vueling.DataAccess.Dao
{
    public class FicheroAlumnoJson : IFicheroAlumno
    {
        public string Ruta { get; set; }

        public FicheroAlumnoJson()
        {
            Ruta = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\" + "ListadoAlumnos.json";
        }

        public FicheroAlumnoJson(string ruta)
        {
            Ruta = ruta;
        }

        public Alumno Add(Alumno alumno)
        {
            List<Alumno> alumnosFicheroExistente = DeserializeJson();
            alumnosFicheroExistente.Add(alumno);
            string jsonNuevo = JsonConvert.SerializeObject(alumnosFicheroExistente, Formatting.Indented);
            FileUtils.EscribirFichero(jsonNuevo, Ruta);

            return Select(alumno.GUID);
        }

        public Alumno Select(Guid guid)
        {
            List<Alumno> alumnosFicheroExistente = DeserializeJson();
            foreach(Alumno alumno in alumnosFicheroExistente)
            {
                if (alumno.GUID == guid) return alumno;
            }
            return null;
        }

        private List<Alumno> DeserializeJson()
        {
            List<Alumno> alumnosFicheroExistente = new List<Alumno>();

            if (File.Exists(Ruta) && new FileInfo(Ruta).Length != 0)
            {
                alumnosFicheroExistente = JsonConvert.DeserializeObject<List<Alumno>>(File.ReadAllText(Ruta));
            }
            return alumnosFicheroExistente;
        }
    }
}
