namespace Vueling.Presentation.Winsite
{
    partial class AlumnosShowForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridAlumnos = new System.Windows.Forms.DataGridView();
            this.buttonTxt = new System.Windows.Forms.Button();
            this.buttonJson = new System.Windows.Forms.Button();
            this.buttonXml = new System.Windows.Forms.Button();
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.txtGuid = new System.Windows.Forms.TextBox();
            this.dtpFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.dtpFechaRegistro = new System.Windows.Forms.DateTimePicker();
            this.labelGuid = new System.Windows.Forms.Label();
            this.labelNombre = new System.Windows.Forms.Label();
            this.labelApellidos = new System.Windows.Forms.Label();
            this.labelDni = new System.Windows.Forms.Label();
            this.labelId = new System.Windows.Forms.Label();
            this.labelFechaNacimiento = new System.Windows.Forms.Label();
            this.labelEdad = new System.Windows.Forms.Label();
            this.labelFechaRegistro = new System.Windows.Forms.Label();
            this.chckBxFechaRegistro = new System.Windows.Forms.CheckBox();
            this.chckBxFechaNacimiento = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAlumnos)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridAlumnos
            // 
            this.dataGridAlumnos.AllowUserToAddRows = false;
            this.dataGridAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridAlumnos.Location = new System.Drawing.Point(38, 162);
            this.dataGridAlumnos.Name = "dataGridAlumnos";
            this.dataGridAlumnos.Size = new System.Drawing.Size(451, 176);
            this.dataGridAlumnos.TabIndex = 0;
            // 
            // buttonTxt
            // 
            this.buttonTxt.Location = new System.Drawing.Point(51, 354);
            this.buttonTxt.Name = "buttonTxt";
            this.buttonTxt.Size = new System.Drawing.Size(75, 23);
            this.buttonTxt.TabIndex = 1;
            this.buttonTxt.Text = "Txt";
            this.buttonTxt.UseVisualStyleBackColor = true;
            this.buttonTxt.Click += new System.EventHandler(this.buttonTxt_Click);
            // 
            // buttonJson
            // 
            this.buttonJson.Location = new System.Drawing.Point(226, 354);
            this.buttonJson.Name = "buttonJson";
            this.buttonJson.Size = new System.Drawing.Size(75, 23);
            this.buttonJson.TabIndex = 2;
            this.buttonJson.Text = "Json";
            this.buttonJson.UseVisualStyleBackColor = true;
            this.buttonJson.Click += new System.EventHandler(this.buttonJson_Click);
            // 
            // buttonXml
            // 
            this.buttonXml.Location = new System.Drawing.Point(400, 354);
            this.buttonXml.Name = "buttonXml";
            this.buttonXml.Size = new System.Drawing.Size(75, 23);
            this.buttonXml.TabIndex = 3;
            this.buttonXml.Text = "Xml";
            this.buttonXml.UseVisualStyleBackColor = true;
            this.buttonXml.Click += new System.EventHandler(this.buttonXml_Click);
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.Location = new System.Drawing.Point(195, 125);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(123, 23);
            this.buttonBuscar.TabIndex = 4;
            this.buttonBuscar.Text = "Buscar";
            this.buttonBuscar.UseVisualStyleBackColor = true;
            this.buttonBuscar.Click += new System.EventHandler(this.buttonBuscar_Click);
            // 
            // txtGuid
            // 
            this.txtGuid.Location = new System.Drawing.Point(38, 30);
            this.txtGuid.Name = "txtGuid";
            this.txtGuid.Size = new System.Drawing.Size(100, 20);
            this.txtGuid.TabIndex = 5;
            // 
            // dtpFechaNacimiento
            // 
            this.dtpFechaNacimiento.Enabled = false;
            this.dtpFechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaNacimiento.Location = new System.Drawing.Point(154, 76);
            this.dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            this.dtpFechaNacimiento.Size = new System.Drawing.Size(100, 20);
            this.dtpFechaNacimiento.TabIndex = 6;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(154, 30);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 7;
            // 
            // txtApellidos
            // 
            this.txtApellidos.Location = new System.Drawing.Point(272, 30);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(100, 20);
            this.txtApellidos.TabIndex = 8;
            // 
            // txtDni
            // 
            this.txtDni.Location = new System.Drawing.Point(389, 30);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(100, 20);
            this.txtDni.TabIndex = 9;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(38, 76);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 20);
            this.txtId.TabIndex = 10;
            // 
            // txtEdad
            // 
            this.txtEdad.Location = new System.Drawing.Point(272, 76);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(100, 20);
            this.txtEdad.TabIndex = 11;
            // 
            // dtpFechaRegistro
            // 
            this.dtpFechaRegistro.Enabled = false;
            this.dtpFechaRegistro.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaRegistro.Location = new System.Drawing.Point(389, 76);
            this.dtpFechaRegistro.Name = "dtpFechaRegistro";
            this.dtpFechaRegistro.Size = new System.Drawing.Size(100, 20);
            this.dtpFechaRegistro.TabIndex = 12;
            // 
            // labelGuid
            // 
            this.labelGuid.AutoSize = true;
            this.labelGuid.Location = new System.Drawing.Point(35, 15);
            this.labelGuid.Name = "labelGuid";
            this.labelGuid.Size = new System.Drawing.Size(34, 13);
            this.labelGuid.TabIndex = 13;
            this.labelGuid.Text = "GUID";
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Location = new System.Drawing.Point(151, 15);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(44, 13);
            this.labelNombre.TabIndex = 14;
            this.labelNombre.Text = "Nombre";
            // 
            // labelApellidos
            // 
            this.labelApellidos.AutoSize = true;
            this.labelApellidos.Location = new System.Drawing.Point(269, 15);
            this.labelApellidos.Name = "labelApellidos";
            this.labelApellidos.Size = new System.Drawing.Size(49, 13);
            this.labelApellidos.TabIndex = 15;
            this.labelApellidos.Text = "Apellidos";
            // 
            // labelDni
            // 
            this.labelDni.AutoSize = true;
            this.labelDni.Location = new System.Drawing.Point(386, 15);
            this.labelDni.Name = "labelDni";
            this.labelDni.Size = new System.Drawing.Size(26, 13);
            this.labelDni.TabIndex = 16;
            this.labelDni.Text = "DNI";
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Location = new System.Drawing.Point(35, 60);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(16, 13);
            this.labelId.TabIndex = 17;
            this.labelId.Text = "Id";
            // 
            // labelFechaNacimiento
            // 
            this.labelFechaNacimiento.AutoSize = true;
            this.labelFechaNacimiento.Location = new System.Drawing.Point(151, 60);
            this.labelFechaNacimiento.Name = "labelFechaNacimiento";
            this.labelFechaNacimiento.Size = new System.Drawing.Size(106, 13);
            this.labelFechaNacimiento.TabIndex = 18;
            this.labelFechaNacimiento.Text = "Fecha de nacimiento";
            // 
            // labelEdad
            // 
            this.labelEdad.AutoSize = true;
            this.labelEdad.Location = new System.Drawing.Point(269, 62);
            this.labelEdad.Name = "labelEdad";
            this.labelEdad.Size = new System.Drawing.Size(32, 13);
            this.labelEdad.TabIndex = 19;
            this.labelEdad.Text = "Edad";
            // 
            // labelFechaRegistro
            // 
            this.labelFechaRegistro.AutoSize = true;
            this.labelFechaRegistro.Location = new System.Drawing.Point(386, 62);
            this.labelFechaRegistro.Name = "labelFechaRegistro";
            this.labelFechaRegistro.Size = new System.Drawing.Size(89, 13);
            this.labelFechaRegistro.TabIndex = 20;
            this.labelFechaRegistro.Text = "Fecha de registro";
            // 
            // chckBxFechaRegistro
            // 
            this.chckBxFechaRegistro.AutoSize = true;
            this.chckBxFechaRegistro.Location = new System.Drawing.Point(425, 102);
            this.chckBxFechaRegistro.Name = "chckBxFechaRegistro";
            this.chckBxFechaRegistro.Size = new System.Drawing.Size(64, 17);
            this.chckBxFechaRegistro.TabIndex = 21;
            this.chckBxFechaRegistro.Text = "Habilitar";
            this.chckBxFechaRegistro.UseVisualStyleBackColor = true;
            this.chckBxFechaRegistro.CheckedChanged += new System.EventHandler(this.chckBxFechaRegistro_CheckedChanged);
            // 
            // chckBxFechaNacimiento
            // 
            this.chckBxFechaNacimiento.AutoSize = true;
            this.chckBxFechaNacimiento.Location = new System.Drawing.Point(154, 102);
            this.chckBxFechaNacimiento.Name = "chckBxFechaNacimiento";
            this.chckBxFechaNacimiento.Size = new System.Drawing.Size(64, 17);
            this.chckBxFechaNacimiento.TabIndex = 22;
            this.chckBxFechaNacimiento.Text = "Habilitar";
            this.chckBxFechaNacimiento.UseVisualStyleBackColor = true;
            this.chckBxFechaNacimiento.CheckedChanged += new System.EventHandler(this.chckBxFechaNacimiento_CheckedChanged);
            // 
            // AlumnosShowForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 389);
            this.Controls.Add(this.chckBxFechaNacimiento);
            this.Controls.Add(this.chckBxFechaRegistro);
            this.Controls.Add(this.labelFechaRegistro);
            this.Controls.Add(this.labelEdad);
            this.Controls.Add(this.labelFechaNacimiento);
            this.Controls.Add(this.labelId);
            this.Controls.Add(this.labelDni);
            this.Controls.Add(this.labelApellidos);
            this.Controls.Add(this.labelNombre);
            this.Controls.Add(this.labelGuid);
            this.Controls.Add(this.dtpFechaRegistro);
            this.Controls.Add(this.txtEdad);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.txtDni);
            this.Controls.Add(this.txtApellidos);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.dtpFechaNacimiento);
            this.Controls.Add(this.txtGuid);
            this.Controls.Add(this.buttonBuscar);
            this.Controls.Add(this.buttonXml);
            this.Controls.Add(this.buttonJson);
            this.Controls.Add(this.buttonTxt);
            this.Controls.Add(this.dataGridAlumnos);
            this.Name = "AlumnosShowForm";
            this.Text = "AlumnosShowForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAlumnos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridAlumnos;
        private System.Windows.Forms.Button buttonTxt;
        private System.Windows.Forms.Button buttonJson;
        private System.Windows.Forms.Button buttonXml;
        private System.Windows.Forms.Button buttonBuscar;
        private System.Windows.Forms.TextBox txtGuid;
        private System.Windows.Forms.DateTimePicker dtpFechaNacimiento;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.DateTimePicker dtpFechaRegistro;
        private System.Windows.Forms.Label labelGuid;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Label labelApellidos;
        private System.Windows.Forms.Label labelDni;
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.Label labelFechaNacimiento;
        private System.Windows.Forms.Label labelEdad;
        private System.Windows.Forms.Label labelFechaRegistro;
        private System.Windows.Forms.CheckBox chckBxFechaRegistro;
        private System.Windows.Forms.CheckBox chckBxFechaNacimiento;
    }
}