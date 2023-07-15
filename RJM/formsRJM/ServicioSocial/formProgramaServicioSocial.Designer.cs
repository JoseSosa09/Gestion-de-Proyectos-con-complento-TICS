namespace RJM.formRJM
{
    partial class formProgramaServicioSocial
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
            this.label1 = new System.Windows.Forms.Label();
            this.mid = new System.Windows.Forms.Panel();
            this.cBNombre = new System.Windows.Forms.ComboBox();
            this.top = new System.Windows.Forms.Panel();
            this.labelTitulo = new System.Windows.Forms.Label();
            this.bottom = new System.Windows.Forms.Panel();
            this.tBResponsableDepartamento = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tBDepartamento = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.tBActividad5 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tBActividad4 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tBActividad3 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tBActividad2 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tBActividad1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tBNumero = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tBPuesto = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbResponsable = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.mid.SuspendLayout();
            this.top.SuspendLayout();
            this.bottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.Location = new System.Drawing.Point(11, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 29);
            this.label1.TabIndex = 12;
            this.label1.Text = "Nombre del Programa:";
            // 
            // mid
            // 
            this.mid.BackColor = System.Drawing.Color.Transparent;
            this.mid.Controls.Add(this.cBNombre);
            this.mid.Controls.Add(this.label1);
            this.mid.Dock = System.Windows.Forms.DockStyle.Top;
            this.mid.Location = new System.Drawing.Point(0, 54);
            this.mid.Name = "mid";
            this.mid.Size = new System.Drawing.Size(1319, 78);
            this.mid.TabIndex = 13;
            // 
            // cBNombre
            // 
            this.cBNombre.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cBNombre.BackColor = System.Drawing.Color.White;
            this.cBNombre.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cBNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBNombre.FormattingEnabled = true;
            this.cBNombre.Location = new System.Drawing.Point(276, 30);
            this.cBNombre.Name = "cBNombre";
            this.cBNombre.Size = new System.Drawing.Size(539, 28);
            this.cBNombre.TabIndex = 13;
            this.cBNombre.SelectedIndexChanged += new System.EventHandler(this.cBNombre_SelectedIndexChanged);
            this.cBNombre.SelectionChangeCommitted += new System.EventHandler(this.cBNombre_SelectionChangeCommitted);
            // 
            // top
            // 
            this.top.BackColor = System.Drawing.Color.Transparent;
            this.top.Controls.Add(this.labelTitulo);
            this.top.Dock = System.Windows.Forms.DockStyle.Top;
            this.top.Location = new System.Drawing.Point(0, 0);
            this.top.Name = "top";
            this.top.Size = new System.Drawing.Size(1319, 54);
            this.top.TabIndex = 14;
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitulo.ForeColor = System.Drawing.Color.Black;
            this.labelTitulo.Location = new System.Drawing.Point(9, 9);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(460, 42);
            this.labelTitulo.TabIndex = 11;
            this.labelTitulo.Text = "Programa Servicio Social";
            // 
            // bottom
            // 
            this.bottom.BackColor = System.Drawing.Color.Transparent;
            this.bottom.Controls.Add(this.tBResponsableDepartamento);
            this.bottom.Controls.Add(this.label3);
            this.bottom.Controls.Add(this.tBDepartamento);
            this.bottom.Controls.Add(this.label2);
            this.bottom.Controls.Add(this.flowLayoutPanel1);
            this.bottom.Controls.Add(this.button1);
            this.bottom.Controls.Add(this.tBActividad5);
            this.bottom.Controls.Add(this.label11);
            this.bottom.Controls.Add(this.tBActividad4);
            this.bottom.Controls.Add(this.label10);
            this.bottom.Controls.Add(this.tBActividad3);
            this.bottom.Controls.Add(this.label9);
            this.bottom.Controls.Add(this.tBActividad2);
            this.bottom.Controls.Add(this.label8);
            this.bottom.Controls.Add(this.tBActividad1);
            this.bottom.Controls.Add(this.label7);
            this.bottom.Controls.Add(this.tBNumero);
            this.bottom.Controls.Add(this.label6);
            this.bottom.Controls.Add(this.tBPuesto);
            this.bottom.Controls.Add(this.label4);
            this.bottom.Controls.Add(this.tbResponsable);
            this.bottom.Controls.Add(this.label5);
            this.bottom.Dock = System.Windows.Forms.DockStyle.Top;
            this.bottom.Location = new System.Drawing.Point(0, 132);
            this.bottom.Name = "bottom";
            this.bottom.Size = new System.Drawing.Size(1319, 448);
            this.bottom.TabIndex = 15;
            // 
            // tBResponsableDepartamento
            // 
            this.tBResponsableDepartamento.BackColor = System.Drawing.Color.White;
            this.tBResponsableDepartamento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tBResponsableDepartamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBResponsableDepartamento.ForeColor = System.Drawing.Color.Black;
            this.tBResponsableDepartamento.Location = new System.Drawing.Point(942, 54);
            this.tBResponsableDepartamento.MaximumSize = new System.Drawing.Size(652, 26);
            this.tBResponsableDepartamento.MinimumSize = new System.Drawing.Size(352, 26);
            this.tBResponsableDepartamento.Name = "tBResponsableDepartamento";
            this.tBResponsableDepartamento.Size = new System.Drawing.Size(352, 26);
            this.tBResponsableDepartamento.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label3.Location = new System.Drawing.Point(642, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(289, 26);
            this.label3.TabIndex = 16;
            this.label3.Text = "Responsable Departamento:";
            // 
            // tBDepartamento
            // 
            this.tBDepartamento.AcceptsTab = true;
            this.tBDepartamento.BackColor = System.Drawing.Color.White;
            this.tBDepartamento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tBDepartamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBDepartamento.ForeColor = System.Drawing.Color.Black;
            this.tBDepartamento.Location = new System.Drawing.Point(284, 51);
            this.tBDepartamento.Name = "tBDepartamento";
            this.tBDepartamento.Size = new System.Drawing.Size(352, 26);
            this.tBDepartamento.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label2.Location = new System.Drawing.Point(3, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(275, 26);
            this.label2.TabIndex = 14;
            this.label2.Text = "Nombre del Departamento:";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Turquoise;
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1319, 0);
            this.flowLayoutPanel1.TabIndex = 37;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Goldenrod;
            this.button1.Location = new System.Drawing.Point(621, 398);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 38);
            this.button1.TabIndex = 14;
            this.button1.Text = "IMPRIMIR";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tBActividad5
            // 
            this.tBActividad5.BackColor = System.Drawing.Color.White;
            this.tBActividad5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tBActividad5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBActividad5.ForeColor = System.Drawing.Color.Black;
            this.tBActividad5.Location = new System.Drawing.Point(942, 323);
            this.tBActividad5.MinimumSize = new System.Drawing.Size(352, 26);
            this.tBActividad5.Name = "tBActividad5";
            this.tBActividad5.Size = new System.Drawing.Size(352, 26);
            this.tBActividad5.TabIndex = 36;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label11.Location = new System.Drawing.Point(702, 323);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(229, 26);
            this.label11.TabIndex = 35;
            this.label11.Text = "Actividad a Realizar 5:";
            // 
            // tBActividad4
            // 
            this.tBActividad4.BackColor = System.Drawing.Color.White;
            this.tBActividad4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tBActividad4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBActividad4.ForeColor = System.Drawing.Color.Black;
            this.tBActividad4.Location = new System.Drawing.Point(286, 326);
            this.tBActividad4.Name = "tBActividad4";
            this.tBActividad4.Size = new System.Drawing.Size(352, 26);
            this.tBActividad4.TabIndex = 34;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label10.Location = new System.Drawing.Point(56, 326);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(229, 26);
            this.label10.TabIndex = 33;
            this.label10.Text = "Actividad a Realizar 4:";
            // 
            // tBActividad3
            // 
            this.tBActividad3.BackColor = System.Drawing.Color.White;
            this.tBActividad3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tBActividad3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBActividad3.ForeColor = System.Drawing.Color.Black;
            this.tBActividad3.Location = new System.Drawing.Point(942, 253);
            this.tBActividad3.MaximumSize = new System.Drawing.Size(652, 26);
            this.tBActividad3.MinimumSize = new System.Drawing.Size(352, 26);
            this.tBActividad3.Name = "tBActividad3";
            this.tBActividad3.Size = new System.Drawing.Size(352, 26);
            this.tBActividad3.TabIndex = 32;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label9.Location = new System.Drawing.Point(702, 253);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(229, 26);
            this.label9.TabIndex = 31;
            this.label9.Text = "Actividad a Realizar 3:";
            // 
            // tBActividad2
            // 
            this.tBActividad2.BackColor = System.Drawing.Color.White;
            this.tBActividad2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tBActividad2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBActividad2.ForeColor = System.Drawing.Color.Black;
            this.tBActividad2.Location = new System.Drawing.Point(286, 253);
            this.tBActividad2.Name = "tBActividad2";
            this.tBActividad2.Size = new System.Drawing.Size(352, 26);
            this.tBActividad2.TabIndex = 30;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label8.Location = new System.Drawing.Point(56, 253);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(229, 26);
            this.label8.TabIndex = 29;
            this.label8.Text = "Actividad a Realizar 2:";
            // 
            // tBActividad1
            // 
            this.tBActividad1.BackColor = System.Drawing.Color.White;
            this.tBActividad1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tBActividad1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBActividad1.ForeColor = System.Drawing.Color.Black;
            this.tBActividad1.Location = new System.Drawing.Point(942, 176);
            this.tBActividad1.MaximumSize = new System.Drawing.Size(652, 26);
            this.tBActividad1.MinimumSize = new System.Drawing.Size(352, 26);
            this.tBActividad1.Name = "tBActividad1";
            this.tBActividad1.Size = new System.Drawing.Size(352, 26);
            this.tBActividad1.TabIndex = 28;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label7.Location = new System.Drawing.Point(720, 177);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(211, 26);
            this.label7.TabIndex = 27;
            this.label7.Text = "Actividad a Realizar:";
            // 
            // tBNumero
            // 
            this.tBNumero.BackColor = System.Drawing.Color.White;
            this.tBNumero.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tBNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBNumero.ForeColor = System.Drawing.Color.Black;
            this.tBNumero.Location = new System.Drawing.Point(286, 179);
            this.tBNumero.Name = "tBNumero";
            this.tBNumero.Size = new System.Drawing.Size(352, 26);
            this.tBNumero.TabIndex = 26;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label6.Location = new System.Drawing.Point(65, 176);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(215, 26);
            this.label6.TabIndex = 25;
            this.label6.Text = "Numero de alumnos:";
            // 
            // tBPuesto
            // 
            this.tBPuesto.BackColor = System.Drawing.Color.White;
            this.tBPuesto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tBPuesto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBPuesto.ForeColor = System.Drawing.Color.Black;
            this.tBPuesto.Location = new System.Drawing.Point(942, 103);
            this.tBPuesto.MaximumSize = new System.Drawing.Size(652, 26);
            this.tBPuesto.MinimumSize = new System.Drawing.Size(352, 26);
            this.tBPuesto.Name = "tBPuesto";
            this.tBPuesto.Size = new System.Drawing.Size(352, 26);
            this.tBPuesto.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label4.Location = new System.Drawing.Point(677, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(254, 26);
            this.label4.TabIndex = 21;
            this.label4.Text = "Puesto del Responsable:";
            // 
            // tbResponsable
            // 
            this.tbResponsable.BackColor = System.Drawing.Color.White;
            this.tbResponsable.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbResponsable.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbResponsable.ForeColor = System.Drawing.Color.Black;
            this.tbResponsable.Location = new System.Drawing.Point(286, 104);
            this.tbResponsable.Name = "tbResponsable";
            this.tbResponsable.Size = new System.Drawing.Size(352, 26);
            this.tbResponsable.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label5.Location = new System.Drawing.Point(1, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(282, 26);
            this.label5.TabIndex = 19;
            this.label5.Text = "Responsable del Programa:";
            // 
            // formProgramaServicioSocial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1319, 580);
            this.Controls.Add(this.bottom);
            this.Controls.Add(this.mid);
            this.Controls.Add(this.top);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formProgramaServicioSocial";
            this.Text = "formProgramaServicioSocial";
            this.Load += new System.EventHandler(this.formProgramaServicioSocial_Load);
            this.mid.ResumeLayout(false);
            this.mid.PerformLayout();
            this.top.ResumeLayout(false);
            this.top.PerformLayout();
            this.bottom.ResumeLayout(false);
            this.bottom.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel mid;
        private System.Windows.Forms.ComboBox cBNombre;
        private System.Windows.Forms.Panel top;
        private System.Windows.Forms.Panel bottom;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.TextBox tBActividad5;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tBActividad4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tBActividad3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tBActividad2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tBActividad1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tBNumero;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tBResponsableDepartamento;
        private System.Windows.Forms.TextBox tBPuesto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbResponsable;
        private System.Windows.Forms.TextBox tBDepartamento;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}