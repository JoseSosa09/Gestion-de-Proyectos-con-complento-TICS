namespace RJM.formsRJM.ControlProyectoIntegrador
{
    partial class formEditar
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
            this.icnonoMinimizar = new FontAwesome.Sharp.IconButton();
            this.bGuardar = new System.Windows.Forms.Button();
            this.cBAlumno = new System.Windows.Forms.ComboBox();
            this.cBModalidad = new System.Windows.Forms.ComboBox();
            this.tBId = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.label = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labl = new System.Windows.Forms.Label();
            this.cBNombre = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderRadius = 0;
            this.panel1.Controls.Add(this.iconoCerrar);
            this.panel1.Controls.Add(this.icnonoMinimizar);
            this.panel1.Controls.Add(this.bGuardar);
            this.panel1.Controls.Add(this.cBAlumno);
            this.panel1.Controls.Add(this.cBModalidad);
            this.panel1.Controls.Add(this.tBId);
            this.panel1.Controls.Add(this.btnAceptar);
            this.panel1.Controls.Add(this.label);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.labl);
            this.panel1.Controls.Add(this.cBNombre);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.ForeColor = System.Drawing.Color.Black;
            this.panel1.GradientAngle = 145F;
            this.panel1.GradientBottomColor = System.Drawing.Color.Goldenrod;
            this.panel1.GradientTopColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(658, 336);
            this.panel1.TabIndex = 58;
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
            this.iconoCerrar.Location = new System.Drawing.Point(632, 0);
            this.iconoCerrar.Margin = new System.Windows.Forms.Padding(0);
            this.iconoCerrar.Name = "iconoCerrar";
            this.iconoCerrar.Size = new System.Drawing.Size(26, 26);
            this.iconoCerrar.TabIndex = 57;
            this.iconoCerrar.UseVisualStyleBackColor = false;
            this.iconoCerrar.Click += new System.EventHandler(this.iconoCerrar_Click);
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
            this.icnonoMinimizar.Location = new System.Drawing.Point(603, 0);
            this.icnonoMinimizar.Name = "icnonoMinimizar";
            this.icnonoMinimizar.Size = new System.Drawing.Size(26, 26);
            this.icnonoMinimizar.TabIndex = 58;
            this.icnonoMinimizar.UseVisualStyleBackColor = false;
            this.icnonoMinimizar.Click += new System.EventHandler(this.icnonoMinimizar_Click);
            // 
            // bGuardar
            // 
            this.bGuardar.BackColor = System.Drawing.Color.Black;
            this.bGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bGuardar.FlatAppearance.BorderSize = 0;
            this.bGuardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.bGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bGuardar.ForeColor = System.Drawing.Color.White;
            this.bGuardar.Location = new System.Drawing.Point(210, 272);
            this.bGuardar.Name = "bGuardar";
            this.bGuardar.Size = new System.Drawing.Size(236, 34);
            this.bGuardar.TabIndex = 33;
            this.bGuardar.Text = "GUARDAR";
            this.bGuardar.UseVisualStyleBackColor = false;
            this.bGuardar.Click += new System.EventHandler(this.bGuardar_Click);
            // 
            // cBAlumno
            // 
            this.cBAlumno.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBAlumno.FormattingEnabled = true;
            this.cBAlumno.Items.AddRange(new object[] {
            "R",
            "A",
            "T"});
            this.cBAlumno.Location = new System.Drawing.Point(191, 160);
            this.cBAlumno.Name = "cBAlumno";
            this.cBAlumno.Size = new System.Drawing.Size(392, 30);
            this.cBAlumno.TabIndex = 16;
            // 
            // cBModalidad
            // 
            this.cBModalidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBModalidad.FormattingEnabled = true;
            this.cBModalidad.Items.AddRange(new object[] {
            "Rosa Delia Retiz Rivera",
            "Martha Laura Chuey Rubio"});
            this.cBModalidad.Location = new System.Drawing.Point(192, 214);
            this.cBModalidad.Name = "cBModalidad";
            this.cBModalidad.Size = new System.Drawing.Size(392, 30);
            this.cBModalidad.TabIndex = 21;
            // 
            // tBId
            // 
            this.tBId.BackColor = System.Drawing.Color.Goldenrod;
            this.tBId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tBId.Enabled = false;
            this.tBId.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBId.ForeColor = System.Drawing.Color.Black;
            this.tBId.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.tBId.Location = new System.Drawing.Point(32, 12);
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
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.BackColor = System.Drawing.Color.Transparent;
            this.label.Font = new System.Drawing.Font("Century Schoolbook", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.label.ForeColor = System.Drawing.Color.Black;
            this.label.Location = new System.Drawing.Point(135, 25);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(410, 35);
            this.label.TabIndex = 14;
            this.label.Text = "PROYECTO INTEGRADOR";
            this.label.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label_MouseDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(46, 214);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 25);
            this.label5.TabIndex = 21;
            this.label5.Text = "Modalidad:";
            // 
            // labl
            // 
            this.labl.AutoSize = true;
            this.labl.BackColor = System.Drawing.Color.Transparent;
            this.labl.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labl.ForeColor = System.Drawing.Color.Black;
            this.labl.Location = new System.Drawing.Point(80, 107);
            this.labl.Name = "labl";
            this.labl.Size = new System.Drawing.Size(106, 25);
            this.labl.TabIndex = 16;
            this.labl.Text = "Nombre:";
            // 
            // cBNombre
            // 
            this.cBNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBNombre.FormattingEnabled = true;
            this.cBNombre.Items.AddRange(new object[] {
            "Residencia y Servicio Social",
            "Residencia, Proyecto Integrador y Servicio Social",
            "Residencia y Proyecto integrador",
            "Residencia"});
            this.cBNombre.Location = new System.Drawing.Point(192, 107);
            this.cBNombre.Name = "cBNombre";
            this.cBNombre.Size = new System.Drawing.Size(393, 30);
            this.cBNombre.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(85, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 25);
            this.label3.TabIndex = 17;
            this.label3.Text = "Alumno:";
            // 
            // formEditar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(658, 336);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formEditar";
            this.ShowIcon = false;
            this.Load += new System.EventHandler(this.formEditar_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private panel panel1;
        public System.Windows.Forms.ComboBox cBAlumno;
        public System.Windows.Forms.ComboBox cBModalidad;
        public System.Windows.Forms.TextBox tBId;
        public System.Windows.Forms.Button btnAceptar;
        public System.Windows.Forms.Label label;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label labl;
        public System.Windows.Forms.ComboBox cBNombre;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Button bGuardar;
        private FontAwesome.Sharp.IconButton iconoCerrar;
        private FontAwesome.Sharp.IconButton icnonoMinimizar;
    }
}