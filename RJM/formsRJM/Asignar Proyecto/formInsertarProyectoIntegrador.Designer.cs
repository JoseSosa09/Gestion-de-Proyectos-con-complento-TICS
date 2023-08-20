namespace RJM.formsRJM
{
    partial class formInsertarProyectoIntegrador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formInsertarProyectoIntegrador));
            this.tBColaboradores = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tBDescripcion = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tBResponsable = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tBObjetivo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cBCategoria = new System.Windows.Forms.ComboBox();
            this.tBId = new System.Windows.Forms.TextBox();
            this.tBNombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tBDesarrollo = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tBAlcances = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.iconoCerrar = new FontAwesome.Sharp.IconButton();
            this.icnonoMinimizar = new FontAwesome.Sharp.IconButton();
            this.panel1 = new RJM.panel();
            this.label = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tBColaboradores
            // 
            this.tBColaboradores.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBColaboradores.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.tBColaboradores.Location = new System.Drawing.Point(203, 260);
            this.tBColaboradores.MaxLength = 255;
            this.tBColaboradores.Multiline = true;
            this.tBColaboradores.Name = "tBColaboradores";
            this.tBColaboradores.Size = new System.Drawing.Size(394, 55);
            this.tBColaboradores.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(12, 260);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(181, 25);
            this.label8.TabIndex = 42;
            this.label8.Text = "Colaboradores:";
            // 
            // tBDescripcion
            // 
            this.tBDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBDescripcion.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.tBDescripcion.Location = new System.Drawing.Point(202, 341);
            this.tBDescripcion.MaxLength = 255;
            this.tBDescripcion.Name = "tBDescripcion";
            this.tBDescripcion.Size = new System.Drawing.Size(394, 28);
            this.tBDescripcion.TabIndex = 4;
            this.tBDescripcion.Validating += new System.ComponentModel.CancelEventHandler(this.validarTextBox);
            this.tBDescripcion.Validated += new System.EventHandler(this.validandoTextBox);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(52, 344);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(142, 25);
            this.label7.TabIndex = 41;
            this.label7.Text = "Descripción:";
            // 
            // tBResponsable
            // 
            this.tBResponsable.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBResponsable.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.tBResponsable.Location = new System.Drawing.Point(202, 206);
            this.tBResponsable.MaxLength = 255;
            this.tBResponsable.Name = "tBResponsable";
            this.tBResponsable.Size = new System.Drawing.Size(394, 28);
            this.tBResponsable.TabIndex = 2;
            this.tBResponsable.Validating += new System.ComponentModel.CancelEventHandler(this.validarTextBox);
            this.tBResponsable.Validated += new System.EventHandler(this.validandoTextBox);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(38, 209);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(155, 25);
            this.label5.TabIndex = 35;
            this.label5.Text = "Responsable:";
            // 
            // tBObjetivo
            // 
            this.tBObjetivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBObjetivo.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.tBObjetivo.Location = new System.Drawing.Point(202, 156);
            this.tBObjetivo.MaxLength = 255;
            this.tBObjetivo.Name = "tBObjetivo";
            this.tBObjetivo.Size = new System.Drawing.Size(393, 28);
            this.tBObjetivo.TabIndex = 1;
            this.tBObjetivo.Validating += new System.ComponentModel.CancelEventHandler(this.validarTextBox);
            this.tBObjetivo.Validated += new System.EventHandler(this.validandoTextBox);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(84, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 25);
            this.label4.TabIndex = 33;
            this.label4.Text = "Objetivo:";
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
            this.cBCategoria.Location = new System.Drawing.Point(107, 0);
            this.cBCategoria.Name = "cBCategoria";
            this.cBCategoria.Size = new System.Drawing.Size(10, 30);
            this.cBCategoria.TabIndex = 31;
            this.cBCategoria.Visible = false;
            // 
            // tBId
            // 
            this.tBId.BackColor = System.Drawing.Color.Goldenrod;
            this.tBId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tBId.Enabled = false;
            this.tBId.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBId.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.tBId.Location = new System.Drawing.Point(3, 2);
            this.tBId.MaxLength = 255;
            this.tBId.Multiline = true;
            this.tBId.Name = "tBId";
            this.tBId.Size = new System.Drawing.Size(64, 42);
            this.tBId.TabIndex = 44;
            this.tBId.Visible = false;
            // 
            // tBNombre
            // 
            this.tBNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBNombre.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.tBNombre.Location = new System.Drawing.Point(203, 101);
            this.tBNombre.MaxLength = 255;
            this.tBNombre.Name = "tBNombre";
            this.tBNombre.Size = new System.Drawing.Size(393, 28);
            this.tBNombre.TabIndex = 0;
            this.tBNombre.Validating += new System.ComponentModel.CancelEventHandler(this.validarTextBox);
            this.tBNombre.Validated += new System.EventHandler(this.validandoTextBox);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(88, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 25);
            this.label3.TabIndex = 45;
            this.label3.Text = "Nombre:";
            // 
            // tBDesarrollo
            // 
            this.tBDesarrollo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBDesarrollo.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.tBDesarrollo.Location = new System.Drawing.Point(202, 391);
            this.tBDesarrollo.MaxLength = 255;
            this.tBDesarrollo.Multiline = true;
            this.tBDesarrollo.Name = "tBDesarrollo";
            this.tBDesarrollo.Size = new System.Drawing.Size(394, 55);
            this.tBDesarrollo.TabIndex = 5;
            this.tBDesarrollo.Validating += new System.ComponentModel.CancelEventHandler(this.validarTextBox);
            this.tBDesarrollo.Validated += new System.EventHandler(this.validandoTextBox);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(62, 391);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(126, 25);
            this.label9.TabIndex = 48;
            this.label9.Text = "Desarrollo:";
            // 
            // tBAlcances
            // 
            this.tBAlcances.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBAlcances.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.tBAlcances.Location = new System.Drawing.Point(201, 468);
            this.tBAlcances.MaxLength = 255;
            this.tBAlcances.Multiline = true;
            this.tBAlcances.Name = "tBAlcances";
            this.tBAlcances.Size = new System.Drawing.Size(394, 55);
            this.tBAlcances.TabIndex = 6;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(73, 468);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(120, 25);
            this.label10.TabIndex = 50;
            this.label10.Text = "Alcances:";
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
            this.btnAceptar.Location = new System.Drawing.Point(201, 554);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(236, 34);
            this.btnAceptar.TabIndex = 7;
            this.btnAceptar.Text = "ACEPTAR";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // iconoCerrar
            // 
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
            this.iconoCerrar.Location = new System.Drawing.Point(585, 2);
            this.iconoCerrar.Margin = new System.Windows.Forms.Padding(0);
            this.iconoCerrar.Name = "iconoCerrar";
            this.iconoCerrar.Size = new System.Drawing.Size(26, 26);
            this.iconoCerrar.TabIndex = 53;
            this.iconoCerrar.UseVisualStyleBackColor = true;
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
            this.icnonoMinimizar.Location = new System.Drawing.Point(559, 2);
            this.icnonoMinimizar.Name = "icnonoMinimizar";
            this.icnonoMinimizar.Size = new System.Drawing.Size(26, 26);
            this.icnonoMinimizar.TabIndex = 54;
            this.icnonoMinimizar.UseVisualStyleBackColor = false;
            this.icnonoMinimizar.Click += new System.EventHandler(this.registrateMinimizar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderRadius = 0;
            this.panel1.Controls.Add(this.icnonoMinimizar);
            this.panel1.Controls.Add(this.label);
            this.panel1.Controls.Add(this.iconoCerrar);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.btnAceptar);
            this.panel1.Controls.Add(this.tBObjetivo);
            this.panel1.Controls.Add(this.tBAlcances);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.tBResponsable);
            this.panel1.Controls.Add(this.tBDesarrollo);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.tBDescripcion);
            this.panel1.Controls.Add(this.tBNombre);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.tBColaboradores);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.ForeColor = System.Drawing.Color.Black;
            this.panel1.GradientAngle = 145F;
            this.panel1.GradientBottomColor = System.Drawing.Color.Goldenrod;
            this.panel1.GradientTopColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(611, 622);
            this.panel1.TabIndex = 59;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.BackColor = System.Drawing.Color.Transparent;
            this.label.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.ForeColor = System.Drawing.Color.Black;
            this.label.Location = new System.Drawing.Point(151, 32);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(337, 37);
            this.label.TabIndex = 15;
            this.label.Text = "REGISTRAR PROYECTO";
            this.label.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label_MouseDown);
            // 
            // formInsertarProyectoIntegrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.Goldenrod;
            this.ClientSize = new System.Drawing.Size(611, 622);
            this.Controls.Add(this.tBId);
            this.Controls.Add(this.cBCategoria);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "formInsertarProyectoIntegrador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "formInsertarProyectoIntegrador";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.formInsertarProyectoIntegrador_MouseDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.TextBox tBColaboradores;
        public System.Windows.Forms.Label label8;
        public System.Windows.Forms.TextBox tBDescripcion;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox tBResponsable;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox tBObjetivo;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.ComboBox cBCategoria;
        public System.Windows.Forms.TextBox tBId;
        public System.Windows.Forms.TextBox tBNombre;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox tBDesarrollo;
        public System.Windows.Forms.Label label9;
        public System.Windows.Forms.TextBox tBAlcances;
        public System.Windows.Forms.Label label10;
        public System.Windows.Forms.Button btnAceptar;
        private FontAwesome.Sharp.IconButton iconoCerrar;
        private FontAwesome.Sharp.IconButton icnonoMinimizar;
        private panel panel1;
        public System.Windows.Forms.Label label;
    }
}