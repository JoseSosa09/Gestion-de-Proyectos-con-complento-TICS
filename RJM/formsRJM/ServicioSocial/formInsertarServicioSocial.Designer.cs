namespace RJM.formsRJM
{
    partial class formInsertarServicioSocial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formInsertarServicioSocial));
            this.label = new System.Windows.Forms.Label();
            this.tBJefe = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbDepartamento = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tBId = new System.Windows.Forms.TextBox();
            this.tBResponsable = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tBPuesto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tBNombre = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.tBCategoria = new System.Windows.Forms.TextBox();
            this.icnonoMinimizar = new FontAwesome.Sharp.IconButton();
            this.iconoCerrar = new FontAwesome.Sharp.IconButton();
            this.panel1 = new RJM.panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.BackColor = System.Drawing.Color.Transparent;
            this.label.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.ForeColor = System.Drawing.Color.Black;
            this.label.Location = new System.Drawing.Point(118, 9);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(454, 37);
            this.label.TabIndex = 15;
            this.label.Text = "PROGRAMA SERVICIO SOCIAL";
            // 
            // tBJefe
            // 
            this.tBJefe.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBJefe.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.tBJefe.Location = new System.Drawing.Point(276, 130);
            this.tBJefe.MaxLength = 255;
            this.tBJefe.Name = "tBJefe";
            this.tBJefe.Size = new System.Drawing.Size(394, 28);
            this.tBJefe.TabIndex = 1;
            this.tBJefe.Validating += new System.ComponentModel.CancelEventHandler(this.validarTextBox);
            this.tBJefe.Validated += new System.EventHandler(this.validandoTextBox);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(39, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(231, 25);
            this.label5.TabIndex = 27;
            this.label5.Text = "Jefe Departamento:";
            // 
            // tbDepartamento
            // 
            this.tbDepartamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDepartamento.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.tbDepartamento.Location = new System.Drawing.Point(276, 81);
            this.tbDepartamento.MaxLength = 255;
            this.tbDepartamento.Name = "tbDepartamento";
            this.tbDepartamento.Size = new System.Drawing.Size(393, 28);
            this.tbDepartamento.TabIndex = 0;
            this.tbDepartamento.Validating += new System.ComponentModel.CancelEventHandler(this.validarTextBox);
            this.tbDepartamento.Validated += new System.EventHandler(this.validandoTextBox);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(91, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(179, 25);
            this.label4.TabIndex = 25;
            this.label4.Text = "Departamento:";
            // 
            // tBId
            // 
            this.tBId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBId.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.tBId.Location = new System.Drawing.Point(678, 406);
            this.tBId.MaxLength = 255;
            this.tBId.Name = "tBId";
            this.tBId.Size = new System.Drawing.Size(22, 28);
            this.tBId.TabIndex = 6;
            this.tBId.Visible = false;
            // 
            // tBResponsable
            // 
            this.tBResponsable.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBResponsable.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.tBResponsable.Location = new System.Drawing.Point(276, 178);
            this.tBResponsable.MaxLength = 255;
            this.tBResponsable.Name = "tBResponsable";
            this.tBResponsable.Size = new System.Drawing.Size(394, 28);
            this.tBResponsable.TabIndex = 2;
            this.tBResponsable.Validating += new System.ComponentModel.CancelEventHandler(this.validarTextBox);
            this.tBResponsable.Validated += new System.EventHandler(this.validandoTextBox);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(5, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(269, 25);
            this.label2.TabIndex = 33;
            this.label2.Text = "Responsable Programa:";
            // 
            // tBPuesto
            // 
            this.tBPuesto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBPuesto.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.tBPuesto.Location = new System.Drawing.Point(276, 224);
            this.tBPuesto.MaxLength = 255;
            this.tBPuesto.Name = "tBPuesto";
            this.tBPuesto.Size = new System.Drawing.Size(394, 28);
            this.tBPuesto.TabIndex = 3;
            this.tBPuesto.Validating += new System.ComponentModel.CancelEventHandler(this.validarTextBox);
            this.tBPuesto.Validated += new System.EventHandler(this.validandoTextBox);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(39, 227);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(232, 25);
            this.label3.TabIndex = 35;
            this.label3.Text = "Puesto Responsable:";
            // 
            // tBNombre
            // 
            this.tBNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBNombre.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.tBNombre.Location = new System.Drawing.Point(276, 268);
            this.tBNombre.MaxLength = 255;
            this.tBNombre.Name = "tBNombre";
            this.tBNombre.Size = new System.Drawing.Size(394, 28);
            this.tBNombre.TabIndex = 4;
            this.tBNombre.Validating += new System.ComponentModel.CancelEventHandler(this.validarTextBox);
            this.tBNombre.Validated += new System.EventHandler(this.validandoTextBox);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(48, 271);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(220, 25);
            this.label7.TabIndex = 37;
            this.label7.Text = "Nombre Programa:";
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
            this.btnAceptar.Location = new System.Drawing.Point(228, 372);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(236, 34);
            this.btnAceptar.TabIndex = 8;
            this.btnAceptar.Text = "ACEPTAR";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // tBCategoria
            // 
            this.tBCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBCategoria.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.tBCategoria.Location = new System.Drawing.Point(690, 372);
            this.tBCategoria.MaxLength = 255;
            this.tBCategoria.Name = "tBCategoria";
            this.tBCategoria.Size = new System.Drawing.Size(10, 28);
            this.tBCategoria.TabIndex = 7;
            this.tBCategoria.Visible = false;
            this.tBCategoria.Validating += new System.ComponentModel.CancelEventHandler(this.validarTextBox);
            this.tBCategoria.Validated += new System.EventHandler(this.validandoTextBox);
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
            this.icnonoMinimizar.Location = new System.Drawing.Point(647, 1);
            this.icnonoMinimizar.Name = "icnonoMinimizar";
            this.icnonoMinimizar.Size = new System.Drawing.Size(26, 26);
            this.icnonoMinimizar.TabIndex = 56;
            this.icnonoMinimizar.UseVisualStyleBackColor = false;
            this.icnonoMinimizar.Click += new System.EventHandler(this.registrateMinimizar_Click);
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
            this.iconoCerrar.Location = new System.Drawing.Point(673, 2);
            this.iconoCerrar.Margin = new System.Windows.Forms.Padding(0);
            this.iconoCerrar.Name = "iconoCerrar";
            this.iconoCerrar.Size = new System.Drawing.Size(26, 26);
            this.iconoCerrar.TabIndex = 55;
            this.iconoCerrar.UseVisualStyleBackColor = true;
            this.iconoCerrar.Click += new System.EventHandler(this.registrateCerrar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderRadius = 0;
            this.panel1.Controls.Add(this.icnonoMinimizar);
            this.panel1.Controls.Add(this.iconoCerrar);
            this.panel1.Controls.Add(this.label);
            this.panel1.Controls.Add(this.btnAceptar);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.tBNombre);
            this.panel1.Controls.Add(this.tbDepartamento);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.tBPuesto);
            this.panel1.Controls.Add(this.tBJefe);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.tBResponsable);
            this.panel1.Controls.Add(this.label2);
            this.panel1.ForeColor = System.Drawing.Color.Black;
            this.panel1.GradientAngle = 145F;
            this.panel1.GradientBottomColor = System.Drawing.Color.Goldenrod;
            this.panel1.GradientTopColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(701, 434);
            this.panel1.TabIndex = 59;
            // 
            // formInsertarServicioSocial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.Goldenrod;
            this.ClientSize = new System.Drawing.Size(700, 436);
            this.Controls.Add(this.tBCategoria);
            this.Controls.Add(this.tBId);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "formInsertarServicioSocial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "formInsertarServicioSocial";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.formInsertarServicioSocial_MouseDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label label;
        public System.Windows.Forms.TextBox tBJefe;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox tbDepartamento;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox tBId;
        public System.Windows.Forms.TextBox tBResponsable;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox tBPuesto;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox tBNombre;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.Button btnAceptar;
        public System.Windows.Forms.TextBox tBCategoria;
        private FontAwesome.Sharp.IconButton icnonoMinimizar;
        private FontAwesome.Sharp.IconButton iconoCerrar;
        private panel panel1;
    }
}