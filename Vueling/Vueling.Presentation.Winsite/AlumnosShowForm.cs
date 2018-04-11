using System;
using System.Collections.Generic;
using System.Reflection;
using System.Windows.Forms;
using Vueling.Business.Logic;
using Vueling.Common.Logic;
using Vueling.Common.Logic.Model;
using static Vueling.Common.Logic.Enums.ExtensionesFicheros;

namespace Vueling.Presentation.Winsite
{
    public partial class AlumnosShowForm : Form
    {
        private IAlumnoBL alumnoBL;        
        private List<Alumno> alumnos;

        ILogger logger = new Logger(MethodBase.GetCurrentMethod().DeclaringType);

        public AlumnosShowForm()
        {
            try
            {
                logger.Debug("Empieza AlumnoShowForm()");
                InitializeComponent();
                alumnoBL = new AlumnoBL();                
                CargarDatosGrid();
            }
            catch (Exception ex)
            {
                logger.Exception(ex);
                MessageBox.Show(ex.Message);
            }
        }
                
        private void CargarDatosGrid()
        {
            try
            {
                logger.Debug("Empieza CargarDatosGrid()");
                buttonTxt_Click(null, null);
                logger.Debug("Termina CargarDatosGrid()");
            }
            catch (Exception ex)
            {
                logger.Exception(ex);
                throw;
            }
        }

        private void buttonJson_Click(object sender, EventArgs e)
        {
            try
            {
                logger.Debug("Empieza buttonJson_Click()");
                alumnoBL.SeleccionarTipoFichero(Extension.JSON);
                alumnos = alumnoBL.GetSingletonInstance();
                var source = new BindingSource();
                source.DataSource = alumnos;
                dataGridAlumnos.DataSource = source;                
                logger.Debug("Termina buttonJson_Click()");
            }
            catch (Exception ex)
            {
                logger.Exception(ex);
                MessageBox.Show(ex.Message);
            }
            
        }

        private void buttonXml_Click(object sender, EventArgs e)
        {
            try
            {
                logger.Debug("Empieza buttonXml_Click()");
                alumnoBL.SeleccionarTipoFichero(Extension.XML);
                alumnos = alumnoBL.GetSingletonInstance();
                var source = new BindingSource();
                source.DataSource = alumnos;
                dataGridAlumnos.DataSource = source;                
                logger.Debug("Termina buttonXml_Click()");
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
                logger.Debug("Empieza buttonTxt_Click()");
                alumnoBL.SeleccionarTipoFichero(Extension.TXT);
                alumnos = alumnoBL.GetAll();
                var source = new BindingSource();
                source.DataSource = alumnos;
                dataGridAlumnos.DataSource = source;                
                logger.Debug("Termina buttonTxt_Click()");
            }
            catch (Exception ex)
            {
                logger.Exception(ex);
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                logger.Debug("Empieza buttonBuscar_Click()");
                string guid = txtGuid.Text;
                string nombre = txtNombre.Text;
                string apellidos = txtApellidos.Text;
                string dni = txtDni.Text;
                string id = txtId.Text;                
                DateTime dtFechaNacimiento = dtpFechaNacimiento.Value;
                string edad = txtEdad.Text;                
                DateTime dtFechaRegistro = dtpFechaRegistro.Value;

                List<Alumno> result = alumnoBL.Filter(guid,nombre,apellidos,dni,id,dtFechaNacimiento,chckBxFechaNacimiento.Checked,edad,dtFechaRegistro, chckBxFechaRegistro.Checked);

                var source = new BindingSource();                
                source.DataSource = result;
                dataGridAlumnos.DataSource = source;
                logger.Debug("Termina buttonBuscar_Click()");
            }
            catch (Exception ex)
            {
                logger.Exception(ex);
                MessageBox.Show(ex.Message);
            }
        }

        private void chckBxFechaRegistro_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                logger.Debug("Empieza chckBxFechaRegistro_CheckedChanged()");
                CheckBox checkBox = (CheckBox)sender;
                if (checkBox.Checked) dtpFechaRegistro.Enabled = true;
                else dtpFechaRegistro.Enabled = false;
                logger.Debug("Termina chckBxFechaRegistro_CheckedChanged()");
            }
            catch (Exception ex)
            {
                logger.Exception(ex);
                MessageBox.Show(ex.Message);
            }
        }

        private void chckBxFechaNacimiento_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                logger.Debug("Empieza chckBxFechaNacimiento_CheckedChanged()");
                CheckBox checkBox = (CheckBox)sender;
                if (checkBox.Checked) dtpFechaNacimiento.Enabled = true;
                else dtpFechaNacimiento.Enabled = false;
                logger.Debug("Termina chckBxFechaNacimiento_CheckedChanged()");
            }
            catch (Exception ex)
            {
                logger.Exception(ex);
                MessageBox.Show(ex.Message);
            }
        }
    }
}
