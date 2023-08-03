namespace RJM
{
    partial class formProyectos
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
            this.panelSuperior = new System.Windows.Forms.Panel();
            this.SidePanel = new System.Windows.Forms.Panel();
            this.btnArchivos = new System.Windows.Forms.Button();
            this.btnAlumnos = new System.Windows.Forms.Button();
            this.contenedor = new System.Windows.Forms.Panel();
            this.panelSuperior.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSuperior
            // 
            this.panelSuperior.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelSuperior.BackColor = System.Drawing.Color.Black;
            this.panelSuperior.Controls.Add(this.SidePanel);
            this.panelSuperior.Controls.Add(this.btnArchivos);
            this.panelSuperior.Controls.Add(this.btnAlumnos);
            this.panelSuperior.ForeColor = System.Drawing.Color.Black;
            this.panelSuperior.Location = new System.Drawing.Point(0, 0);
            this.panelSuperior.Name = "panelSuperior";
            this.panelSuperior.Size = new System.Drawing.Size(1319, 58);
            this.panelSuperior.TabIndex = 2;
            // 
            // SidePanel
            // 
            this.SidePanel.BackColor = System.Drawing.Color.Black;
            this.SidePanel.Enabled = false;
            this.SidePanel.Location = new System.Drawing.Point(3, 55);
            this.SidePanel.Name = "SidePanel";
            this.SidePanel.Size = new System.Drawing.Size(128, 3);
            this.SidePanel.TabIndex = 0;
            // 
            // btnArchivos
            // 
            this.btnArchivos.BackColor = System.Drawing.Color.Black;
            this.btnArchivos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnArchivos.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnArchivos.FlatAppearance.BorderSize = 0;
            this.btnArchivos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnArchivos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnArchivos.ForeColor = System.Drawing.Color.Gold;
            this.btnArchivos.Location = new System.Drawing.Point(131, 0);
            this.btnArchivos.Name = "btnArchivos";
            this.btnArchivos.Size = new System.Drawing.Size(245, 58);
            this.btnArchivos.TabIndex = 2;
            this.btnArchivos.Text = "Archivos";
            this.btnArchivos.UseVisualStyleBackColor = false;
            // 
            // btnAlumnos
            // 
            this.btnAlumnos.BackColor = System.Drawing.Color.White;
            this.btnAlumnos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAlumnos.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnAlumnos.FlatAppearance.BorderSize = 0;
            this.btnAlumnos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlumnos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlumnos.ForeColor = System.Drawing.Color.Black;
            this.btnAlumnos.Location = new System.Drawing.Point(0, 0);
            this.btnAlumnos.Name = "btnAlumnos";
            this.btnAlumnos.Size = new System.Drawing.Size(131, 58);
            this.btnAlumnos.TabIndex = 1;
            this.btnAlumnos.Text = "Alumnos";
            this.btnAlumnos.UseVisualStyleBackColor = false;
            // 
            // contenedor
            // 
            this.contenedor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.contenedor.BackColor = System.Drawing.Color.White;
            this.contenedor.Location = new System.Drawing.Point(0, 58);
            this.contenedor.Name = "contenedor";
            this.contenedor.Size = new System.Drawing.Size(1319, 585);
            this.contenedor.TabIndex = 3;
            // 
            // formProyectos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.Coral;
            this.ClientSize = new System.Drawing.Size(1319, 639);
            this.Controls.Add(this.contenedor);
            this.Controls.Add(this.panelSuperior);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formProyectos";
            this.Text = "formProyecto";
            this.Load += new System.EventHandler(this.formProyecto_Load);
            this.panelSuperior.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSuperior;
        private System.Windows.Forms.Panel SidePanel;
        private System.Windows.Forms.Button btnArchivos;
        private System.Windows.Forms.Button btnAlumnos;
        private System.Windows.Forms.Panel contenedor;
    }
}