namespace RJM
{
    partial class FormRJM
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
            this.btnProyectoIntegrador = new System.Windows.Forms.Button();
            this.btnServicioSocial = new System.Windows.Forms.Button();
            this.btnResidencias = new System.Windows.Forms.Button();
            this.btnPropuestas = new System.Windows.Forms.Button();
            this.panelSuperior.SuspendLayout();
            this.SuspendLayout();
            // 
            // contenedor
            // 
            this.contenedor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.contenedor.BackColor = System.Drawing.Color.Transparent;
            this.contenedor.Location = new System.Drawing.Point(0, 58);
            this.contenedor.Name = "contenedor";
            this.contenedor.Size = new System.Drawing.Size(1319, 579);
            this.contenedor.TabIndex = 2;
            // 
            // panelSuperior
            // 
            this.panelSuperior.BackColor = System.Drawing.Color.Black;
            this.panelSuperior.Controls.Add(this.SidePanel);
            this.panelSuperior.Controls.Add(this.btnProyectoIntegrador);
            this.panelSuperior.Controls.Add(this.btnServicioSocial);
            this.panelSuperior.Controls.Add(this.btnResidencias);
            this.panelSuperior.Controls.Add(this.btnPropuestas);
            this.panelSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSuperior.ForeColor = System.Drawing.Color.Black;
            this.panelSuperior.Location = new System.Drawing.Point(0, 0);
            this.panelSuperior.Name = "panelSuperior";
            this.panelSuperior.Size = new System.Drawing.Size(1319, 58);
            this.panelSuperior.TabIndex = 1;
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
            // btnProyectoIntegrador
            // 
            this.btnProyectoIntegrador.BackColor = System.Drawing.Color.Black;
            this.btnProyectoIntegrador.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProyectoIntegrador.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnProyectoIntegrador.FlatAppearance.BorderSize = 0;
            this.btnProyectoIntegrador.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProyectoIntegrador.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProyectoIntegrador.ForeColor = System.Drawing.Color.Gold;
            this.btnProyectoIntegrador.Location = new System.Drawing.Point(647, 0);
            this.btnProyectoIntegrador.Name = "btnProyectoIntegrador";
            this.btnProyectoIntegrador.Size = new System.Drawing.Size(200, 58);
            this.btnProyectoIntegrador.TabIndex = 4;
            this.btnProyectoIntegrador.Text = "Asignar Proyecto";
            this.btnProyectoIntegrador.UseVisualStyleBackColor = false;
            this.btnProyectoIntegrador.Click += new System.EventHandler(this.btnProyectoIntegrador_Click);
            // 
            // btnServicioSocial
            // 
            this.btnServicioSocial.BackColor = System.Drawing.Color.Black;
            this.btnServicioSocial.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnServicioSocial.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnServicioSocial.FlatAppearance.BorderSize = 0;
            this.btnServicioSocial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnServicioSocial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnServicioSocial.ForeColor = System.Drawing.Color.Gold;
            this.btnServicioSocial.Location = new System.Drawing.Point(376, 0);
            this.btnServicioSocial.Name = "btnServicioSocial";
            this.btnServicioSocial.Size = new System.Drawing.Size(271, 58);
            this.btnServicioSocial.TabIndex = 3;
            this.btnServicioSocial.Text = "Programa de Servicio Social";
            this.btnServicioSocial.UseVisualStyleBackColor = false;
            this.btnServicioSocial.Click += new System.EventHandler(this.btnServicioSocial_Click);
            // 
            // btnResidencias
            // 
            this.btnResidencias.BackColor = System.Drawing.Color.Black;
            this.btnResidencias.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnResidencias.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnResidencias.FlatAppearance.BorderSize = 0;
            this.btnResidencias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResidencias.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResidencias.ForeColor = System.Drawing.Color.Gold;
            this.btnResidencias.Location = new System.Drawing.Point(131, 0);
            this.btnResidencias.Name = "btnResidencias";
            this.btnResidencias.Size = new System.Drawing.Size(245, 58);
            this.btnResidencias.TabIndex = 2;
            this.btnResidencias.Text = "Programa de Residencias";
            this.btnResidencias.UseVisualStyleBackColor = false;
            this.btnResidencias.Click += new System.EventHandler(this.btnResidencias_Click);
            // 
            // btnPropuestas
            // 
            this.btnPropuestas.BackColor = System.Drawing.Color.White;
            this.btnPropuestas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPropuestas.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnPropuestas.FlatAppearance.BorderSize = 0;
            this.btnPropuestas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPropuestas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPropuestas.ForeColor = System.Drawing.Color.Black;
            this.btnPropuestas.Location = new System.Drawing.Point(0, 0);
            this.btnPropuestas.Name = "btnPropuestas";
            this.btnPropuestas.Size = new System.Drawing.Size(131, 58);
            this.btnPropuestas.TabIndex = 1;
            this.btnPropuestas.Text = "Propuestas";
            this.btnPropuestas.UseVisualStyleBackColor = false;
            this.btnPropuestas.Click += new System.EventHandler(this.btnPropuestas_Click);
            // 
            // FormRJM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1319, 639);
            this.Controls.Add(this.contenedor);
            this.Controls.Add(this.panelSuperior);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormRJM";
            this.Text = "formRJM";
            this.Load += new System.EventHandler(this.FormRJM_Load);
            this.panelSuperior.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel contenedor;
        private System.Windows.Forms.Panel panelSuperior;
        private System.Windows.Forms.Button btnProyectoIntegrador;
        private System.Windows.Forms.Button btnServicioSocial;
        private System.Windows.Forms.Button btnResidencias;
        private System.Windows.Forms.Button btnPropuestas;
        private System.Windows.Forms.Panel SidePanel;
    }
}