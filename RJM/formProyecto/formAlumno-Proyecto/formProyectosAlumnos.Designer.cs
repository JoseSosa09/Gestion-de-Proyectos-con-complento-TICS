namespace RJM.formProyecto.formAlumno_Proyecto
{
    partial class formProyectosAlumnos
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
            this.contenedor = new System.Windows.Forms.Panel();
            this.panelSuperior = new System.Windows.Forms.Panel();
            this.SidePanel = new System.Windows.Forms.Panel();
            this.btnSubirArchivos = new System.Windows.Forms.Button();
            this.btnBajarArchivos = new System.Windows.Forms.Button();
            this.panelSuperior.SuspendLayout();
            this.SuspendLayout();
            // 
            // contenedor
            // 
            this.contenedor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.contenedor.BackColor = System.Drawing.Color.White;
            this.contenedor.Location = new System.Drawing.Point(0, 56);
            this.contenedor.Name = "contenedor";
            this.contenedor.Size = new System.Drawing.Size(1319, 585);
            this.contenedor.TabIndex = 5;
            // 
            // panelSuperior
            // 
            this.panelSuperior.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelSuperior.BackColor = System.Drawing.Color.Black;
            this.panelSuperior.Controls.Add(this.SidePanel);
            this.panelSuperior.Controls.Add(this.btnSubirArchivos);
            this.panelSuperior.Controls.Add(this.btnBajarArchivos);
            this.panelSuperior.ForeColor = System.Drawing.Color.Black;
            this.panelSuperior.Location = new System.Drawing.Point(0, -2);
            this.panelSuperior.Name = "panelSuperior";
            this.panelSuperior.Size = new System.Drawing.Size(1319, 58);
            this.panelSuperior.TabIndex = 4;
            // 
            // SidePanel
            // 
            this.SidePanel.BackColor = System.Drawing.Color.Black;
            this.SidePanel.Enabled = false;
            this.SidePanel.Location = new System.Drawing.Point(3, 55);
            this.SidePanel.Name = "SidePanel";
            this.SidePanel.Size = new System.Drawing.Size(198, 10);
            this.SidePanel.TabIndex = 0;
            // 
            // btnSubirArchivos
            // 
            this.btnSubirArchivos.BackColor = System.Drawing.Color.Black;
            this.btnSubirArchivos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSubirArchivos.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnSubirArchivos.FlatAppearance.BorderSize = 0;
            this.btnSubirArchivos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubirArchivos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubirArchivos.ForeColor = System.Drawing.Color.Gold;
            this.btnSubirArchivos.Location = new System.Drawing.Point(202, 0);
            this.btnSubirArchivos.Name = "btnSubirArchivos";
            this.btnSubirArchivos.Size = new System.Drawing.Size(245, 58);
            this.btnSubirArchivos.TabIndex = 2;
            this.btnSubirArchivos.Text = "Subir Archivos";
            this.btnSubirArchivos.UseVisualStyleBackColor = false;
            this.btnSubirArchivos.Click += new System.EventHandler(this.btnSubirArchivos_Click);
            // 
            // btnBajarArchivos
            // 
            this.btnBajarArchivos.BackColor = System.Drawing.Color.White;
            this.btnBajarArchivos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBajarArchivos.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnBajarArchivos.FlatAppearance.BorderSize = 0;
            this.btnBajarArchivos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBajarArchivos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBajarArchivos.ForeColor = System.Drawing.Color.Black;
            this.btnBajarArchivos.Location = new System.Drawing.Point(0, 0);
            this.btnBajarArchivos.Name = "btnBajarArchivos";
            this.btnBajarArchivos.Size = new System.Drawing.Size(202, 58);
            this.btnBajarArchivos.TabIndex = 1;
            this.btnBajarArchivos.Text = "Descargar Archivos";
            this.btnBajarArchivos.UseVisualStyleBackColor = false;
            this.btnBajarArchivos.Click += new System.EventHandler(this.btnBajarArchivos_Click);
            // 
            // formProyectosAlumnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1319, 639);
            this.Controls.Add(this.contenedor);
            this.Controls.Add(this.panelSuperior);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formProyectosAlumnos";
            this.Text = "formProyectosAlumnos";
            this.Load += new System.EventHandler(this.formProyectosAlumnos_Load);
            this.panelSuperior.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel contenedor;
        private System.Windows.Forms.Panel panelSuperior;
        private System.Windows.Forms.Panel SidePanel;
        private System.Windows.Forms.Button btnSubirArchivos;
        private System.Windows.Forms.Button btnBajarArchivos;
    }
}