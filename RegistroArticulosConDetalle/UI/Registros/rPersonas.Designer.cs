namespace RegistroArticulosConDetalle.UI.Registros
{
    partial class rPersonas
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.PersonaIdnumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.FechadateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.NombretextBox = new System.Windows.Forms.TextBox();
            this.DirecciontextBox = new System.Windows.Forms.TextBox();
            this.TelefonomaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.CedulamaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.BtnNuevo = new System.Windows.Forms.Button();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.GeneralerrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.PersonaIdnumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GeneralerrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Persona ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fecha:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nombre:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Direccion:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Telefono:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(253, 141);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Cedula:";
            // 
            // PersonaIdnumericUpDown
            // 
            this.PersonaIdnumericUpDown.Location = new System.Drawing.Point(77, 11);
            this.PersonaIdnumericUpDown.Name = "PersonaIdnumericUpDown";
            this.PersonaIdnumericUpDown.Size = new System.Drawing.Size(64, 20);
            this.PersonaIdnumericUpDown.TabIndex = 6;
            // 
            // FechadateTimePicker
            // 
            this.FechadateTimePicker.CustomFormat = "dd/MM/yyyy";
            this.FechadateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.FechadateTimePicker.Location = new System.Drawing.Point(77, 39);
            this.FechadateTimePicker.Margin = new System.Windows.Forms.Padding(2);
            this.FechadateTimePicker.Name = "FechadateTimePicker";
            this.FechadateTimePicker.Size = new System.Drawing.Size(145, 20);
            this.FechadateTimePicker.TabIndex = 65;
            // 
            // NombretextBox
            // 
            this.NombretextBox.Location = new System.Drawing.Point(77, 70);
            this.NombretextBox.Name = "NombretextBox";
            this.NombretextBox.Size = new System.Drawing.Size(325, 20);
            this.NombretextBox.TabIndex = 66;
            // 
            // DirecciontextBox
            // 
            this.DirecciontextBox.Location = new System.Drawing.Point(77, 106);
            this.DirecciontextBox.Name = "DirecciontextBox";
            this.DirecciontextBox.Size = new System.Drawing.Size(325, 20);
            this.DirecciontextBox.TabIndex = 67;
            // 
            // TelefonomaskedTextBox
            // 
            this.TelefonomaskedTextBox.Location = new System.Drawing.Point(77, 138);
            this.TelefonomaskedTextBox.Mask = "(999)000-0000";
            this.TelefonomaskedTextBox.Name = "TelefonomaskedTextBox";
            this.TelefonomaskedTextBox.Size = new System.Drawing.Size(100, 20);
            this.TelefonomaskedTextBox.TabIndex = 68;
            // 
            // CedulamaskedTextBox
            // 
            this.CedulamaskedTextBox.Location = new System.Drawing.Point(302, 138);
            this.CedulamaskedTextBox.Mask = "000-0000000-0";
            this.CedulamaskedTextBox.Name = "CedulamaskedTextBox";
            this.CedulamaskedTextBox.Size = new System.Drawing.Size(100, 20);
            this.CedulamaskedTextBox.TabIndex = 69;
            // 
            // BtnNuevo
            // 
            this.BtnNuevo.Image = global::RegistroArticulosConDetalle.Properties.Resources.icons8_Add_Property_32;
            this.BtnNuevo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnNuevo.Location = new System.Drawing.Point(16, 210);
            this.BtnNuevo.Name = "BtnNuevo";
            this.BtnNuevo.Size = new System.Drawing.Size(88, 52);
            this.BtnNuevo.TabIndex = 71;
            this.BtnNuevo.Text = "Nuevo";
            this.BtnNuevo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnNuevo.UseVisualStyleBackColor = true;
            this.BtnNuevo.Click += new System.EventHandler(this.BtnNuevo_Click);
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.Image = global::RegistroArticulosConDetalle.Properties.Resources.icons8_Save_32;
            this.BtnGuardar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnGuardar.Location = new System.Drawing.Point(156, 210);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(92, 52);
            this.BtnGuardar.TabIndex = 72;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnGuardar.UseVisualStyleBackColor = true;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Image = global::RegistroArticulosConDetalle.Properties.Resources.icons8_Delete_Document_32;
            this.BtnEliminar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnEliminar.Location = new System.Drawing.Point(302, 210);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(100, 52);
            this.BtnEliminar.TabIndex = 73;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnEliminar.UseVisualStyleBackColor = true;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.Image = global::RegistroArticulosConDetalle.Properties.Resources.icons8_Search_16;
            this.BtnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnBuscar.Location = new System.Drawing.Point(147, 8);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(75, 23);
            this.BtnBuscar.TabIndex = 70;
            this.BtnBuscar.Text = "Buscar";
            this.BtnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnBuscar.UseVisualStyleBackColor = true;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // GeneralerrorProvider
            // 
            this.GeneralerrorProvider.ContainerControl = this;
            // 
            // rPersonas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 273);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.BtnNuevo);
            this.Controls.Add(this.BtnBuscar);
            this.Controls.Add(this.CedulamaskedTextBox);
            this.Controls.Add(this.TelefonomaskedTextBox);
            this.Controls.Add(this.DirecciontextBox);
            this.Controls.Add(this.NombretextBox);
            this.Controls.Add(this.FechadateTimePicker);
            this.Controls.Add(this.PersonaIdnumericUpDown);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "rPersonas";
            this.Text = "rPersonas";
            ((System.ComponentModel.ISupportInitialize)(this.PersonaIdnumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GeneralerrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown PersonaIdnumericUpDown;
        private System.Windows.Forms.DateTimePicker FechadateTimePicker;
        private System.Windows.Forms.TextBox NombretextBox;
        private System.Windows.Forms.TextBox DirecciontextBox;
        private System.Windows.Forms.MaskedTextBox TelefonomaskedTextBox;
        private System.Windows.Forms.MaskedTextBox CedulamaskedTextBox;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.Button BtnNuevo;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.ErrorProvider GeneralerrorProvider;
    }
}