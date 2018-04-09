using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vueling.Business.Logic;
using Vueling.Common.Logic;
using Vueling.Common.Logic.Model;
using Vueling.DataAccess.Dao;
using static Vueling.Common.Logic.Enums.ExtensionesFicheros;

namespace Vueling.Presentation.Winsite
{
    public partial class AlumnoForm : Form
    {
        private Alumno alumno;
        private IAlumnoBL alumnoBL;
        ILogger logger = new Logger(MethodBase.GetCurrentMethod().DeclaringType);

        public AlumnoForm()
        {
            try
            {
                logger.Debug("Empieza AlumnoForm()");
                InitializeComponent();
                alumno = new Alumno();
                alumnoBL = new AlumnoBL();
            }
            catch (Exception ex)
            {
                logger.Exception(ex);
                MessageBox.Show(ex.Message);
            }
        }
        
        private void buttonTxt_Click(object sender, EventArgs e)
        {
            try
            {
                logger.Debug("Clickado el botón Txt");
                LoadAlumnoData();
                alumnoBL.SeleccionarTipoFichero(Extension.TXT);
                alumnoBL.Add(alumno);
                logger.Debug("Termina el botón TXT");
            }
            catch (Exception ex)
            {
                logger.Exception(ex);
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonJson_Click(object sender, EventArgs e)
        {
            try
            {
                logger.Debug("Clickado el botón Json");
                LoadAlumnoData();
                alumnoBL.SeleccionarTipoFichero(Extension.JSON);
                alumnoBL.Add(alumno);
                logger.Debug("Termina el botón Json");
            }
            catch (Exception ex)
            {
                logger.Exception(ex);
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonXML_Click(object sender, EventArgs e)
        {
            try
            {
                logger.Debug("Clickado el botón Xml");
                LoadAlumnoData();
                alumnoBL.SeleccionarTipoFichero(Extension.XML);
                alumnoBL.Add(alumno);
                logger.Debug("Termina el botón Xml");
            }
            catch (Exception ex)
            {
                logger.Exception(ex);
                MessageBox.Show(ex.Message);
            }
        }

        private void LoadAlumnoData()
        {
            try
            {
                logger.Debug("Empieza LoadAlumnoData()");
                alumno.SetGuid();
                alumno.ID = Convert.ToInt32(textBoxID.Text);
                alumno.Nombre = textBoxNombre.Text;
                alumno.Apellidos = textBoxApellidos.Text;
                alumno.DNI = textBoxDNI.Text;
                alumno.FechaNacimiento = textBoxNacimiento.Value.Date;
                logger.Debug("Termina LoadAlumnoData()");
            }
            catch (Exception ex)
            {
                logger.Exception(ex);
                throw;
            }
            
        }

        private void buttonMostrarAlumnos_Click(object sender, EventArgs e)
        {
            try
            {
                logger.Debug("Muestra AlumnosShow");
                AlumnosShowForm alumnosShowForm = new AlumnosShowForm();
                alumnosShowForm.ShowDialog();
            }
            catch (Exception ex)
            {
                logger.Exception(ex);
                throw;
            }
        }
    }
}
