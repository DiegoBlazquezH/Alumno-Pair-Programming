using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vueling.Business.Logic;
using Vueling.Common.Logic.Model;
using Vueling.DataAccess.Dao;
using static Vueling.Common.Logic.Enums.ExtensionesFicheros;

namespace Vueling.Presentation.Winsite
{
    public partial class AlumnoForm : Form
    {
        private Alumno alumno;
        private IAlumnoBL alumnoBL;

        public AlumnoForm()
        {
            InitializeComponent();
            alumno = new Alumno();
            alumnoBL = new AlumnoBL();
        }
        
        private void buttonTxt_Click(object sender, EventArgs e)
        {
            LoadAlumnoData();
            alumnoBL.SeleccionarTipoFichero(Extension.TXT);
            alumnoBL.Add(alumno);
        }

        private void buttonJson_Click(object sender, EventArgs e)
        {
            LoadAlumnoData();
            alumnoBL.SeleccionarTipoFichero(Extension.JSON);
            alumnoBL.Add(alumno);
        }

        private void buttonXML_Click(object sender, EventArgs e)
        {
            LoadAlumnoData();
            alumnoBL.SeleccionarTipoFichero(Extension.XML);
            alumnoBL.Add(alumno);
        }

        private void LoadAlumnoData()
        {
            alumno.SetGuid();
            alumno.ID = Convert.ToInt32(textBoxID.Text);
            alumno.Nombre = textBoxNombre.Text;
            alumno.Apellidos = textBoxApellidos.Text;
            alumno.DNI = textBoxDNI.Text;
            alumno.FechaNacimiento = textBoxNacimiento.Value.Date;
            
        }

    }
}
