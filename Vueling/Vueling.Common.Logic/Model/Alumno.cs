using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vueling.Common.Logic.Model
{
    public class Alumno : Persona
    {
        public Alumno()
        {
        }

        public Alumno(int iD, string nombre, string apellidos, string dNI, DateTime fechaNacimiento, int edad, DateTime fechaCompletaAlta) : base(iD, nombre, apellidos, dNI, fechaNacimiento, edad, fechaCompletaAlta)
        {
        }

        public Alumno(Guid gUID, int iD, string nombre, string apellidos, string dNI, DateTime fechaNacimiento, int edad, DateTime fechaCompletaAlta) : base(gUID, iD, nombre, apellidos, dNI, fechaNacimiento, edad, fechaCompletaAlta)
        {
        }
    }
}
