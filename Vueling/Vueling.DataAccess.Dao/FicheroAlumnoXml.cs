using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Vueling.Common.Logic.Model;
using Vueling.DataAccess.Dao.Interfaces;

namespace Vueling.DataAccess.Dao
{
    public class FicheroAlumnoXml : IFicheroAlumno
    {
        public string Ruta { get; set; }

        public FicheroAlumnoXml()
        {
            Ruta = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\" + "ListadoAlumnos.xml";
        }

        public FicheroAlumnoXml(string ruta)
        {
            Ruta = ruta;
        }

        public Alumno Add(Alumno alumno)
        {
            List<Alumno> alumnosFicheroExistente = DeserializeXml();
            alumnosFicheroExistente.Add(alumno);
            string xmlNuevo = SerializeXml(alumnosFicheroExistente);
            FileUtils.EscribirFichero(xmlNuevo, Ruta);
            return Select(alumno.GUID);
        }

        public Alumno Select(Guid guid)
        {
            List<Alumno> alumnosFicheroExistente = DeserializeXml();
            foreach (Alumno alumno in alumnosFicheroExistente)
            {
                if (alumno.GUID == guid) return alumno;
            }
            return null;
        }

        private string SerializeXml(List<Alumno> alumnosFicheroExistente)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Alumno>));
            using (StringWriter writer = new StringWriter())
            {
                xmlSerializer.Serialize(writer, alumnosFicheroExistente);
                return writer.ToString();
            }
        }

        private List<Alumno> DeserializeXml()
        {
            List<Alumno> alumnosFicheroExistente = new List<Alumno>();
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Alumno>));

            if (File.Exists(Ruta) && new FileInfo(Ruta).Length != 0)
            {
                alumnosFicheroExistente = (List<Alumno>)xmlSerializer.Deserialize(new StringReader(File.ReadAllText(Ruta))); 
            }
            return alumnosFicheroExistente;
        }
    }
}
