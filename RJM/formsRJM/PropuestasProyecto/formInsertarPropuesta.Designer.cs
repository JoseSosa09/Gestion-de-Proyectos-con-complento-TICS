namespace RJM.formsRJM
{
    partial class formInsertarPropuesta
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
            this.iconoCerrar = new FontAwesome.Sharp.IconButton();
            this.cBEstatus = new System.Windows.Forms.ComboBox();
            this.icnonoMinimizar = new FontAwesome.Sharp.IconButton();
            this.tBResponsable = new System.Windows.Forms.ComboBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.tBColaboradores = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tBId = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.tBAlumnos = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tBNombre = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cBCategoria = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tBDescripcion = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderRadius = 30;
            this.panel1.Controls.Add(this.iconoCerrar);
            this.panel1.Controls.Add(this.cBEstatus);
            this.panel1.Controls.Add(this.icnonoMinimizar);
            this.panel1.Controls.Add(this.tBResponsable);
            this.panel1.Controls.Add(this.btnGuardar);
            this.panel1.Controls.Add(this.tBColaboradores);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.tBId);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.btnAceptar);
            this.panel1.Controls.Add(this.tBAlumnos);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.tBNombre);
            this.panel1.Controls.Add(this.label);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cBCategoria);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.tBDescripcion);
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
            // cBEstatus
            // 
            this.cBEstatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBEstatus.FormattingEnabled = true;
            this.cBEstatus.Items.AddRange(new object[] {
            "R",
            "A",
            "T"});
            this.cBEstatus.Location = new System.Drawing.Point(191, 160);
            this.cBEstatus.Name = "cBEstatus";
            this.cBEstatus.Size = new System.Drawing.Size(392, 30);
            this.cBEstatus.TabIndex = 16;
            this.cBEstatus.Validating += new System.ComponentModel.CancelEventHandler(this.validarComboBox);
            this.cBEstatus.Validated += new System.EventHandler(this.validandoComboBox);
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
            // tBResponsable
            // 
            this.tBResponsable.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBResponsable.FormattingEnabled = true;
            this.tBResponsable.Items.AddRange(new object[] {
            "Rosa Delia Retiz Rivera",
            "Martha Laura Chuey Rubio"});
            this.tBResponsable.Location = new System.Drawing.Point(192, 262);
            this.tBResponsable.Name = "tBResponsable";
            this.tBResponsable.Size = new System.Drawing.Size(392, 30);
            this.tBResponsable.TabIndex = 21;
            this.tBResponsable.Validating += new System.ComponentModel.CancelEventHandler(this.validarComboBox);
            this.tBResponsable.Validated += new System.EventHandler(this.validandoComboBox);
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
            this.btnGuardar.Visible = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // tBColaboradores
            // 
            this.tBColaboradores.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBColaboradores.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.tBColaboradores.Location = new System.Drawing.Point(192, 321);
            this.tBColaboradores.MaxLength = 255;
            this.tBColaboradores.Multiline = true;
            this.tBColaboradores.Name = "tBColaboradores";
            this.tBColaboradores.Size = new System.Drawing.Size(394, 55);
            this.tBColaboradores.TabIndex = 23;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(1, 321);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(181, 25);
            this.label8.TabIndex = 30;
            this.label8.Text = "Colaboradores:";
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
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(41, 442);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(142, 25);
            this.label7.TabIndex = 28;
            this.label7.Text = "Descripción:";
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
            // tBAlumnos
            // 
            this.tBAlumnos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBAlumnos.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.tBAlumnos.Location = new System.Drawing.Point(192, 398);
            this.tBAlumnos.MaxLength = 255;
            this.tBAlumnos.Name = "tBAlumnos";
            this.tBAlumnos.Size = new System.Drawing.Size(113, 28);
            this.tBAlumnos.TabIndex = 24;
            this.tBAlumnos.Validating += new System.ComponentModel.CancelEventHandler(this.validarTextBox);
            this.tBAlumnos.Validated += new System.EventHandler(this.validandoTextBox);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(71, 398);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 25);
            this.label6.TabIndex = 23;
            this.label6.Text = "Alumnos:";
            // 
            // tBNombre
            // 
            this.tBNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBNombre.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.tBNombre.Location = new System.Drawing.Point(191, 215);
            this.tBNombre.MaxLength = 255;
            this.tBNombre.Name = "tBNombre";
            this.tBNombre.Size = new System.Drawing.Size(393, 28);
            this.tBNombre.TabIndex = 20;
            this.tBNombre.Validating += new System.ComponentModel.CancelEventHandler(this.validarTextBox);
            this.tBNombre.Validated += new System.EventHandler(this.validandoTextBox);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.BackColor = System.Drawing.Color.Transparent;
            this.label.Font = new System.Drawing.Font("Century Schoolbook", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.label.ForeColor = System.Drawing.Color.Black;
            this.label.Location = new System.Drawing.Point(135, 25);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(401, 35);
            this.label.TabIndex = 14;
            this.label.Text = "REGISTRAR PROPUESTA";
            this.label.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label1_MouseDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(27, 262);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(155, 25);
            this.label5.TabIndex = 21;
            this.label5.Text = "Responsable:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(49, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 25);
            this.label2.TabIndex = 16;
            this.label2.Text = "Categoria:";
            // 
            // cBCategoria
            // 
            this.cBCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBCategoria.FormattingEnabled = true;
            this.cBCategoria.Items.AddRange(new object[] {
            "Residencia y Servicio Social",
            "Residencia, Proyecto Integrador y Servicio Social",
            "Residencia y Proyecto integrador",
            "Residencia"});
            this.cBCategoria.Location = new System.Drawing.Point(192, 107);
            this.cBCategoria.Name = "cBCategoria";
            this.cBCategoria.Size = new System.Drawing.Size(393, 30);
            this.cBCategoria.TabIndex = 15;
            this.cBCategoria.Validating += new System.ComponentModel.CancelEventHandler(this.validarComboBox);
            this.cBCategoria.Validated += new System.EventHandler(this.validandoComboBox);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(85, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 25);
            this.label3.TabIndex = 17;
            this.label3.Text = "Estatus:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(76, 215);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 25);
            this.label4.TabIndex = 19;
            this.label4.Text = "Nombre:";
            // 
            // tBDescripcion
            // 
            this.tBDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBDescripcion.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.tBDescripcion.Location = new System.Drawing.Point(192, 444);
            this.tBDescripcion.MaxLength = 255;
            this.tBDescripcion.Name = "tBDescripcion";
            this.tBDescripcion.Size = new System.Drawing.Size(394, 28);
            this.tBDescripcion.TabIndex = 25;
            // 
            // formInsertarPropuesta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.Goldenrod;
            this.ClientSize = new System.Drawing.Size(606, 573);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formInsertarPropuesta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "formInsertarPropuesta";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.formInsertarPropuesta_MouseDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Label label;
        public System.Windows.Forms.ComboBox cBCategoria;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox tBAlumnos;
        public System.Windows.Forms.Button btnAceptar;
        public System.Windows.Forms.TextBox tBDescripcion;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox tBColaboradores;
        public System.Windows.Forms.Label label8;
        public System.Windows.Forms.Button btnGuardar;
        public System.Windows.Forms.TextBox tBId;
        public System.Windows.Forms.ComboBox cBEstatus;
        public System.Windows.Forms.TextBox tBNombre;
        public System.Windows.Forms.ComboBox tBResponsable;
        private FontAwesome.Sharp.IconButton icnonoMinimizar;
        private FontAwesome.Sharp.IconButton iconoCerrar;
        private panel panel1;
    }
}