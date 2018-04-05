using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Vueling.Business.Logic;
using Vueling.Common.Logic.Model;
using static Vueling.Common.Logic.Enums.ExtensionesFicheros;

namespace Vueling.Presentation.Winsite
{
    public partial class AlumnosShowForm : Form
    {
        private IAlumnoBL alumnoBL;
        private List<Alumno> alumnosJson;
        private List<Alumno> alumnosXml;
        private List<Alumno> alumnos;

        public AlumnosShowForm()
        {
            InitializeComponent();
            alumnoBL = new AlumnoBL();
            CrearListados();
        }

        private void AlumnosShowForm_Load(object sender, EventArgs e)
        {
            
        }

        private void CrearListados()
        {
            alumnoBL.SeleccionarTipoFichero(Extension.JSON);
            alumnosJson = alumnoBL.CrearListado();
            alumnoBL.SeleccionarTipoFichero(Extension.XML);
            alumnosXml = alumnoBL.CrearListado();
        }

        private void buttonJson_Click(object sender, EventArgs e)
        {            
            var source = new BindingSource();
            source.DataSource = alumnosJson;
            dataGridView1.DataSource = source;
            alumnos = alumnosJson;
        }

        private void buttonXml_Click(object sender, EventArgs e)
        {            
            var source = new BindingSource();
            source.DataSource = alumnosXml;
            dataGridView1.DataSource = source;
            alumnos = alumnosXml;
        }

        private void buttonTxt_Click(object sender, EventArgs e)
        {
            alumnoBL.SeleccionarTipoFichero(Extension.TXT);
            List<Alumno> alumns = alumnoBL.GetAll();
            var source = new BindingSource();
            source.DataSource = alumns;
            dataGridView1.DataSource = source;
            alumnos = alumns;
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            string guid = txtGuid.Text;
            string nombre = txtNombre.Text;
            string apellidos = txtApellidos.Text;
            string dni = txtDni.Text;
            string id = txtId.Text;
            DateTime dtFechaNacimiento = dtpFechaNacimiento.Value;
            string edad = txtEdad.Text;
            DateTime dtFechaRegistro = dtpFechaRegistro.Value;

            var source = new BindingSource();
            var query = from alu in alumnos select alu;
            if (!String.IsNullOrEmpty(guid)) query = query.Where(alu => alu.GUID.Equals(Guid.Parse(guid)));
            if (!String.IsNullOrEmpty(nombre)) query = query.Where(alu => alu.Nombre.Equals(nombre));
            if (!String.IsNullOrEmpty(apellidos)) query = query.Where(alu => alu.Apellidos.Equals(apellidos));
            if (!String.IsNullOrEmpty(dni)) query = query.Where(alu => alu.DNI.Equals(dni));
            if (!String.IsNullOrEmpty(id)) query = query.Where(alu => alu.ID.Equals(Convert.ToInt32(id)));
            if (chckBxFechaNacimiento.Checked) query = query.Where(alu => alu.FechaNacimiento.Date.Equals(dtFechaNacimiento.Date));
            if (!String.IsNullOrEmpty(edad)) query = query.Where(alu => alu.Edad.Equals(Convert.ToInt32(edad)));
            if (chckBxFechaRegistro.Checked) query = query.Where(alu => alu.FechaCompletaAlta.Date.Equals(dtFechaRegistro.Date));
            query = query.OrderBy(alu => alu.ID);

            var result = query.ToList();
            source.DataSource = result;
            dataGridView1.DataSource = source;
        }

        private void chckBxFechaRegistro_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = (CheckBox)sender;
            if (checkBox.Checked) dtpFechaRegistro.Enabled = true;
            else dtpFechaRegistro.Enabled = false;
        }

        private void chckBxFechaNacimiento_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = (CheckBox)sender;
            if (checkBox.Checked) dtpFechaNacimiento.Enabled = true;
            else dtpFechaNacimiento.Enabled = false;
        }
    }
}
