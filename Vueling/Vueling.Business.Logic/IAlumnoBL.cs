using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vueling.Common.Logic.Model;
using static Vueling.Common.Logic.Enums.ExtensionesFicheros;

namespace Vueling.Business.Logic
{
    public interface IAlumnoBL
    {
        Alumno Add(Alumno alumno);
        void SeleccionarTipoFichero(Extension extension);
        int CalcularEdad(DateTime fechaCompletaActual, DateTime fechaNacimiento);
    }
}