using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using Vueling.Business.Logic;
using Vueling.Common.Logic;
using Vueling.Common.Logic.Exceptions;
using Vueling.Common.Logic.Model;
using Vueling.Common.Logic.Properties;
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
                logger.Debug(MethodBase.GetCurrentMethod().DeclaringType.Name + " " + LogStrings.Starts);
                InitializeComponent();
                alumnoBL = new AlumnoBL();                
                CargarDatosGrid();
            }
            catch (Exception ex)
            {
                logger.Exception(ex);
            }
        }
                
        private void CargarDatosGrid()
        {
            try
            {
                logger.Debug(MethodBase.GetCurrentMethod().DeclaringType.Name + " " + LogStrings.Starts);
                buttonTxt_Click(null, null);
                logger.Debug(MethodBase.GetCurrentMethod().DeclaringType.Name + " " + LogStrings.Ends);
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
                var button = (Button)sender;
                logger.Debug(button.Name + " " + LogStrings.Clicked);
                alumnoBL.SeleccionarTipoFichero(Extension.JSON);
                alumnos = alumnoBL.GetSingletonInstance();
                var source = new BindingSource();
                source.DataSource = alumnos;
                dataGridAlumnos.DataSource = source;                
                logger.Debug(button.Name + " " + LogStrings.Ends);
            }
            catch (Exception ex)
            {
                logger.Exception(ex);
                ShowExceptionMessage(ex);
            }
            
        }
               
        private void buttonXml_Click(object sender, EventArgs e)
        {
            try
            {
                var button = (Button)sender;
                logger.Debug(button.Name + " " + LogStrings.Clicked);
                alumnoBL.SeleccionarTipoFichero(Extension.XML);
                alumnos = alumnoBL.GetSingletonInstance();
                var source = new BindingSource();
                source.DataSource = alumnos;
                dataGridAlumnos.DataSource = source;                
                logger.Debug(button.Name + " " + LogStrings.Ends);
            }
            catch (Exception ex)
            {
                logger.Exception(ex);
                ShowExceptionMessage(ex);
            }
        }

        private void buttonTxt_Click(object sender, EventArgs e)
        {
            try
            {
                var button = (Button)sender;
                logger.Debug(button.Name + " " + LogStrings.Clicked);
                alumnoBL.SeleccionarTipoFichero(Extension.TXT);
                alumnos = alumnoBL.GetAll();
                var source = new BindingSource();
                source.DataSource = alumnos;
                dataGridAlumnos.DataSource = source;                
                logger.Debug(button.Name + " " + LogStrings.Ends);
            }
            catch (Exception ex)
            {
                logger.Exception(ex);
                ShowExceptionMessage(ex);
            }
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                var button = (Button)sender;
                logger.Debug(button.Name + " " + LogStrings.Clicked);
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
                logger.Debug(button.Name + " " + LogStrings.Ends);
            }
            catch (Exception ex)
            {
                logger.Exception(ex);
                ShowExceptionMessage(ex);
            }
        }

        private void chckBxFechaRegistro_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                CheckBox checkBox = (CheckBox)sender;
                logger.Debug(MethodBase.GetCurrentMethod().DeclaringType.Name + " " + LogStrings.Starts);                
                if (checkBox.Checked) dtpFechaRegistro.Enabled = true;
                else dtpFechaRegistro.Enabled = false;
                logger.Debug(MethodBase.GetCurrentMethod().DeclaringType.Name + " " + LogStrings.Ends);
            }
            catch (Exception ex)
            {
                logger.Exception(ex);
                ShowExceptionMessage(ex);
            }
        }

        private void chckBxFechaNacimiento_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                logger.Debug(MethodBase.GetCurrentMethod().DeclaringType.Name + " " + LogStrings.Starts);
                CheckBox checkBox = (CheckBox)sender;
                if (checkBox.Checked) dtpFechaNacimiento.Enabled = true;
                else dtpFechaNacimiento.Enabled = false;
                logger.Debug(MethodBase.GetCurrentMethod().DeclaringType.Name + " " + LogStrings.Ends);
            }
            catch (Exception ex)
            {
                logger.Exception(ex);
                ShowExceptionMessage(ex);
            }
        }

        private void ShowExceptionMessage(Exception ex)
        {            
            if (ex is ArgumentException)
                MessageBox.Show(Exceptions.ResourceManager.GetString("ArgumentException"));
            if (ex is ArgumentNullException)
                MessageBox.Show(Exceptions.ResourceManager.GetString("ArgumentNullException"));
            if (ex is ArgumentOutOfRangeException)
                MessageBox.Show(Exceptions.ResourceManager.GetString("ArgumentOutOfRangeException"));
            if (ex is DirectoryNotFoundException)
                MessageBox.Show(Exceptions.ResourceManager.GetString("DirectoryNotFoundException"));
            if (ex is FileNotFoundException)
                MessageBox.Show(Exceptions.ResourceManager.GetString("FileNotFoundException"));
            if (ex is FormatException)
                MessageBox.Show(Exceptions.ResourceManager.GetString("FormatException"));
            if (ex is IOException)
                MessageBox.Show(Exceptions.ResourceManager.GetString("IOException"));
            if (ex is OutOfMemoryException)
                MessageBox.Show(Exceptions.ResourceManager.GetString("OutOfMemoryException"));
            if (ex is OverflowException)
                MessageBox.Show(Exceptions.ResourceManager.GetString("OverflowException"));
            if (ex is PlatformNotSupportedException)
                MessageBox.Show(Exceptions.ResourceManager.GetString("PlatformNotSupportedException"));
            if (ex is TargetException)
                MessageBox.Show(Exceptions.ResourceManager.GetString("TargetException"));
        }
    }
}
