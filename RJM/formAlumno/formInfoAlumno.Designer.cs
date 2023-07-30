namespace RJM.formsRJM
{
    partial class formInfoAlumno
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
            this.panel1 = new RJM.panel();
            this.cBModalidad = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tBNumeroControl = new System.Windows.Forms.TextBox();
            this.tBProyecto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tBNombre = new System.Windows.Forms.TextBox();
            this.iconoCerrar = new FontAwesome.Sharp.IconButton();
            this.icnonoMinimizar = new FontAwesome.Sharp.IconButton();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.tBId = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.tBMateria = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderRadius = 30;
            this.panel1.Controls.Add(this.cBModalidad);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.tBNumeroControl);
            this.panel1.Controls.Add(this.tBProyecto);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.tBNombre);
            this.panel1.Controls.Add(this.iconoCerrar);
            this.panel1.Controls.Add(this.icnonoMinimizar);
            this.panel1.Controls.Add(this.btnGuardar);
            this.panel1.Controls.Add(this.tBId);
            this.panel1.Controls.Add(this.btnAceptar);
            this.panel1.Controls.Add(this.tBMateria);
            this.panel1.Controls.Add(this.label);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.ForeColor = System.Drawing.Color.Black;
            this.panel1.GradientAngle = 145F;
            this.panel1.GradientBottomColor = System.Drawing.Color.Goldenrod;
            this.panel1.GradientTopColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(-5, -4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(615, 580);
            this.panel1.TabIndex = 57;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // cBModalidad
            // 
            this.cBModalidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBModalidad.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.cBModalidad.Location = new System.Drawing.Point(190, 312);
            this.cBModalidad.MaxLength = 255;
            this.cBModalidad.Name = "cBModalidad";
            this.cBModalidad.ReadOnly = true;
            this.cBModalidad.Size = new System.Drawing.Size(393, 28);
            this.cBModalidad.TabIndex = 63;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(52, 312);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 25);
            this.label4.TabIndex = 62;
            this.label4.Text = "Modalidad:";
            // 
            // tBNumeroControl
            // 
            this.tBNumeroControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBNumeroControl.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.tBNumeroControl.Location = new System.Drawing.Point(191, 161);
            this.tBNumeroControl.MaxLength = 255;
            this.tBNumeroControl.Name = "tBNumeroControl";
            this.tBNumeroControl.ReadOnly = true;
            this.tBNumeroControl.Size = new System.Drawing.Size(393, 28);
            this.tBNumeroControl.TabIndex = 61;
            // 
            // tBProyecto
            // 
            this.tBProyecto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBProyecto.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.tBProyecto.Location = new System.Drawing.Point(191, 267);
            this.tBProyecto.MaxLength = 255;
            this.tBProyecto.Name = "tBProyecto";
            this.tBProyecto.ReadOnly = true;
            this.tBProyecto.Size = new System.Drawing.Size(393, 28);
            this.tBProyecto.TabIndex = 60;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(76, 267);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 25);
            this.label1.TabIndex = 58;
            this.label1.Text = "Proyecto:";
            // 
            // tBNombre
            // 
            this.tBNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBNombre.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.tBNombre.Location = new System.Drawing.Point(190, 108);
            this.tBNombre.MaxLength = 255;
            this.tBNombre.Name = "tBNombre";
            this.tBNombre.ReadOnly = true;
            this.tBNombre.Size = new System.Drawing.Size(393, 28);
            this.tBNombre.TabIndex = 57;
            // 
            // iconoCerrar
            // 
            this.iconoCerrar.BackColor = System.Drawing.Color.Transparent;
            this.iconoCerrar.CausesValidation = false;
            this.iconoCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconoCerrar.FlatAppearance.BorderSize = 0;
            this.iconoCerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.iconoCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.iconoCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconoCerrar.IconChar = FontAwesome.Sharp.IconChar.X;
            this.iconoCerrar.IconColor = System.Drawing.Color.Black;
            this.iconoCerrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconoCerrar.IconSize = 32;
            this.iconoCerrar.Location = new System.Drawing.Point(586, 4);
            this.iconoCerrar.Margin = new System.Windows.Forms.Padding(0);
            this.iconoCerrar.Name = "iconoCerrar";
            this.iconoCerrar.Size = new System.Drawing.Size(26, 26);
            this.iconoCerrar.TabIndex = 55;
            this.iconoCerrar.UseVisualStyleBackColor = false;
            this.iconoCerrar.Click += new System.EventHandler(this.registrateCerrar_Click);
            // 
            // icnonoMinimizar
            // 
            this.icnonoMinimizar.BackColor = System.Drawing.Color.Transparent;
            this.icnonoMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.icnonoMinimizar.FlatAppearance.BorderSize = 0;
            this.icnonoMinimizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.icnonoMinimizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.icnonoMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.icnonoMinimizar.IconChar = FontAwesome.Sharp.IconChar.Minus;
            this.icnonoMinimizar.IconColor = System.Drawing.Color.Black;
            this.icnonoMinimizar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icnonoMinimizar.IconSize = 32;
            this.icnonoMinimizar.Location = new System.Drawing.Point(557, 4);
            this.icnonoMinimizar.Name = "icnonoMinimizar";
            this.icnonoMinimizar.Size = new System.Drawing.Size(26, 26);
            this.icnonoMinimizar.TabIndex = 56;
            this.icnonoMinimizar.UseVisualStyleBackColor = false;
            this.icnonoMinimizar.Click += new System.EventHandler(this.registrateMinimizar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.Black;
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(197, 508);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(236, 34);
            this.btnGuardar.TabIndex = 1;
            this.btnGuardar.Text = "GUARDAR";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // tBId
            // 
            this.tBId.BackColor = System.Drawing.Color.Goldenrod;
            this.tBId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tBId.Enabled = false;
            this.tBId.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBId.ForeColor = System.Drawing.Color.Black;
            this.tBId.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.tBId.Location = new System.Drawing.Point(32, 25);
            this.tBId.MaxLength = 255;
            this.tBId.Multiline = true;
            this.tBId.Name = "tBId";
            this.tBId.Size = new System.Drawing.Size(43, 37);
            this.tBId.TabIndex = 32;
            this.tBId.Visible = false;
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.Black;
            this.btnAceptar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAceptar.FlatAppearance.BorderSize = 0;
            this.btnAceptar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnAceptar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.ForeColor = System.Drawing.Color.White;
            this.btnAceptar.Location = new System.Drawing.Point(197, 508);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(236, 34);
            this.btnAceptar.TabIndex = 27;
            this.btnAceptar.Text = "ACEPTAR";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // tBMateria
            // 
            this.tBMateria.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBMateria.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.tBMateria.Location = new System.Drawing.Point(191, 215);
            this.tBMateria.MaxLength = 255;
            this.tBMateria.Name = "tBMateria";
            this.tBMateria.ReadOnly = true;
            this.tBMateria.Size = new System.Drawing.Size(393, 28);
            this.tBMateria.TabIndex = 20;
            this.tBMateria.Validating += new System.ComponentModel.CancelEventHandler(this.validarTextBox);
            this.tBMateria.Validated += new System.EventHandler(this.validandoTextBox);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.BackColor = System.Drawing.Color.Transparent;
            this.label.Font = new System.Drawing.Font("Century Schoolbook", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.label.ForeColor = System.Drawing.Color.Black;
            this.label.Location = new System.Drawing.Point(237, 25);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(155, 35);
            this.label.TabIndex = 14;
            this.label.Text = "ALUMNO";
            this.label.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label1_MouseDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(86, 218);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 25);
            this.label5.TabIndex = 21;
            this.label5.Text = "Materia:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(84, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 25);
            this.label2.TabIndex = 16;
            this.label2.Text = "Nombre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(2, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(190, 25);
            this.label3.TabIndex = 17;
            this.label3.Text = "Número Control:";
            // 
            // formInfoAlumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.Goldenrod;
            this.ClientSize = new System.Drawing.Size(606, 573);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formInfoAlumno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "formInsertarPropuesta";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.formInsertarPropuesta_MouseDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Label label;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Button btnAceptar;
        public System.Windows.Forms.Button btnGuardar;
        public System.Windows.Forms.TextBox tBId;
        public System.Windows.Forms.TextBox tBMateria;
        private FontAwesome.Sharp.IconButton icnonoMinimizar;
        private FontAwesome.Sharp.IconButton iconoCerrar;
        private panel panel1;
        public System.Windows.Forms.TextBox tBNombre;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox tBNumeroControl;
        public System.Windows.Forms.TextBox tBProyecto;
        public System.Windows.Forms.TextBox cBModalidad;
        public System.Windows.Forms.Label label4;
    }
}