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
using static Vueling.Common.Logic.Enums.ExtensionesFicheros;

namespace Vueling.Presentation.Winsite
{
    public partial class AlumnosShowForm : Form
    {
        private IAlumnoBL alumnoBL;        

        public AlumnosShowForm()
        {
            InitializeComponent();
            alumnoBL = new AlumnoBL();
        }

        private void AlumnosShowForm_Load(object sender, EventArgs e)
        {
            
        }

        private void buttonJson_Click(object sender, EventArgs e)
        {
            alumnoBL.SeleccionarTipoFichero(Extension.JSON);
            List<Alumno> alumnos = alumnoBL.CrearListado();
            var source = new BindingSource();
            source.DataSource = alumnos;
            dataGridView1.DataSource = source;
        }

        private void buttonXml_Click(object sender, EventArgs e)
        {
            alumnoBL.SeleccionarTipoFichero(Extension.XML);            
            List<Alumno> alumnos = alumnoBL.CrearListado();
            var source = new BindingSource();
            source.DataSource = alumnos;
            dataGridView1.DataSource = source;
        }

        private void buttonTxt_Click(object sender, EventArgs e)
        {
            alumnoBL.SeleccionarTipoFichero(Extension.TXT);
            List<Alumno> alumnos = alumnoBL.CrearListado();
            var source = new BindingSource();
            source.DataSource = alumnos;
            dataGridView1.DataSource = source;
        }
    }
}
