namespace Vueling.Presentation.Winsite
{
    partial class AlumnoForm
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
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.textBoxDNI = new System.Windows.Forms.TextBox();
            this.textBoxApellidos = new System.Windows.Forms.TextBox();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.buttonText = new System.Windows.Forms.Button();
            this.buttonJson = new System.Windows.Forms.Button();
            this.buttonXML = new System.Windows.Forms.Button();
            this.labelID = new System.Windows.Forms.Label();
            this.labelNombre = new System.Windows.Forms.Label();
            this.labelApellidos = new System.Windows.Forms.Label();
            this.labelDNI = new System.Windows.Forms.Label();
            this.labelNacimiento = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBoxNacimiento = new System.Windows.Forms.DateTimePicker();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(288, 95);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(100, 20);
            this.textBoxNombre.TabIndex = 1;
            // 
            // textBoxDNI
            // 
            this.textBoxDNI.Location = new System.Drawing.Point(288, 196);
            this.textBoxDNI.Name = "textBoxDNI";
            this.textBoxDNI.Size = new System.Drawing.Size(100, 20);
            this.textBoxDNI.TabIndex = 3;
            // 
            // textBoxApellidos
            // 
            this.textBoxApellidos.Location = new System.Drawing.Point(288, 148);
            this.textBoxApellidos.Name = "textBoxApellidos";
            this.textBoxApellidos.Size = new System.Drawing.Size(100, 20);
            this.textBoxApellidos.TabIndex = 2;
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(288, 41);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(100, 20);
            this.textBoxID.TabIndex = 0;
            // 
            // buttonText
            // 
            this.buttonText.Location = new System.Drawing.Point(70, 301);
            this.buttonText.Name = "buttonText";
            this.buttonText.Size = new System.Drawing.Size(75, 23);
            this.buttonText.TabIndex = 5;
            this.buttonText.Text = "Txt";
            this.buttonText.UseVisualStyleBackColor = true;
            this.buttonText.Click += new System.EventHandler(this.buttonTxt_Click);
            // 
            // buttonJson
            // 
            this.buttonJson.Location = new System.Drawing.Point(254, 301);
            this.buttonJson.Name = "buttonJson";
            this.buttonJson.Size = new System.Drawing.Size(75, 23);
            this.buttonJson.TabIndex = 6;
            this.buttonJson.Text = "Json";
            this.buttonJson.UseVisualStyleBackColor = true;
            this.buttonJson.Click += new System.EventHandler(this.buttonJson_Click);
            // 
            // buttonXML
            // 
            this.buttonXML.Location = new System.Drawing.Point(429, 301);
            this.buttonXML.Name = "buttonXML";
            this.buttonXML.Size = new System.Drawing.Size(75, 23);
            this.buttonXML.TabIndex = 7;
            this.buttonXML.Text = "XML";
            this.buttonXML.UseVisualStyleBackColor = true;
            this.buttonXML.Click += new System.EventHandler(this.buttonXML_Click);
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Location = new System.Drawing.Point(85, 48);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(18, 13);
            this.labelID.TabIndex = 8;
            this.labelID.Text = "ID";
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Location = new System.Drawing.Point(85, 95);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(44, 13);
            this.labelNombre.TabIndex = 9;
            this.labelNombre.Text = "Nombre";
            // 
            // labelApellidos
            // 
            this.labelApellidos.AutoSize = true;
            this.labelApellidos.Location = new System.Drawing.Point(85, 148);
            this.labelApellidos.Name = "labelApellidos";
            this.labelApellidos.Size = new System.Drawing.Size(49, 13);
            this.labelApellidos.TabIndex = 10;
            this.labelApellidos.Text = "Apellidos";
            // 
            // labelDNI
            // 
            this.labelDNI.AutoSize = true;
            this.labelDNI.Location = new System.Drawing.Point(85, 196);
            this.labelDNI.Name = "labelDNI";
            this.labelDNI.Size = new System.Drawing.Size(26, 13);
            this.labelDNI.TabIndex = 11;
            this.labelDNI.Text = "DNI";
            // 
            // labelNacimiento
            // 
            this.labelNacimiento.AutoSize = true;
            this.labelNacimiento.Location = new System.Drawing.Point(85, 244);
            this.labelNacimiento.Name = "labelNacimiento";
            this.labelNacimiento.Size = new System.Drawing.Size(106, 13);
            this.labelNacimiento.TabIndex = 12;
            this.labelNacimiento.Text = "Fecha de nacimiento";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBoxNacimiento);
            this.panel1.Controls.Add(this.labelNacimiento);
            this.panel1.Controls.Add(this.labelDNI);
            this.panel1.Controls.Add(this.labelApellidos);
            this.panel1.Controls.Add(this.labelNombre);
            this.panel1.Controls.Add(this.labelID);
            this.panel1.Controls.Add(this.buttonXML);
            this.panel1.Controls.Add(this.buttonJson);
            this.panel1.Controls.Add(this.buttonText);
            this.panel1.Controls.Add(this.textBoxID);
            this.panel1.Controls.Add(this.textBoxApellidos);
            this.panel1.Controls.Add(this.textBoxDNI);
            this.panel1.Controls.Add(this.textBoxNombre);
            this.panel1.Location = new System.Drawing.Point(36, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(556, 389);
            this.panel1.TabIndex = 13;
            // 
            // textBoxNacimiento
            // 
            this.textBoxNacimiento.Location = new System.Drawing.Point(288, 244);
            this.textBoxNacimiento.Name = "textBoxNacimiento";
            this.textBoxNacimiento.Size = new System.Drawing.Size(100, 20);
            this.textBoxNacimiento.TabIndex = 13;
            // 
            // AlumnoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 450);
            this.Controls.Add(this.panel1);
            this.Name = "AlumnoForm";
            this.Text = "AlumnoForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.TextBox textBoxDNI;
        private System.Windows.Forms.TextBox textBoxApellidos;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.Button buttonText;
        private System.Windows.Forms.Button buttonJson;
        private System.Windows.Forms.Button buttonXML;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Label labelApellidos;
        private System.Windows.Forms.Label labelDNI;
        private System.Windows.Forms.Label labelNacimiento;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker textBoxNacimiento;
    }
}