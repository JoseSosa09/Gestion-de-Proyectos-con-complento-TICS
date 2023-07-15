namespace RJM.formRJM
{
    partial class formPropuestas
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.labelTitulo = new System.Windows.Forms.Label();
            this.panelButton = new RJM.panel();
            this.btnAgregarPropuesta = new System.Windows.Forms.Button();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.textBoxBuscar = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnProyectoIntegrador = new System.Windows.Forms.Button();
            this.btnServicioSocial = new System.Windows.Forms.Button();
            this.btnResidencias = new System.Windows.Forms.Button();
            this.btnTodas = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.flowLayoutPanel1.SuspendLayout();
            this.panelButton.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Wheat;
            this.flowLayoutPanel1.Controls.Add(this.labelTitulo);
            this.flowLayoutPanel1.Controls.Add(this.panelButton);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1319, 87);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // labelTitulo
            // 
            this.labelTitulo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitulo.ForeColor = System.Drawing.Color.Black;
            this.labelTitulo.Location = new System.Drawing.Point(3, 0);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(401, 45);
            this.labelTitulo.TabIndex = 10;
            this.labelTitulo.Text = "Propuestas de Proyecto";
            // 
            // panelButton
            // 
            this.panelButton.BackColor = System.Drawing.Color.White;
            this.panelButton.BorderRadius = 30;
            this.panelButton.Controls.Add(this.btnAgregarPropuesta);
            this.panelButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelButton.ForeColor = System.Drawing.Color.White;
            this.panelButton.GradientAngle = 90F;
            this.panelButton.GradientBottomColor = System.Drawing.Color.Black;
            this.panelButton.GradientTopColor = System.Drawing.Color.Black;
            this.panelButton.Location = new System.Drawing.Point(410, 3);
            this.panelButton.Name = "panelButton";
            this.panelButton.Size = new System.Drawing.Size(179, 39);
            this.panelButton.TabIndex = 4;
            // 
            // btnAgregarPropuesta
            // 
            this.btnAgregarPropuesta.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgregarPropuesta.BackColor = System.Drawing.Color.Transparent;
            this.btnAgregarPropuesta.FlatAppearance.BorderSize = 0;
            this.btnAgregarPropuesta.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnAgregarPropuesta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnAgregarPropuesta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarPropuesta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarPropuesta.ForeColor = System.Drawing.Color.Gold;
            this.btnAgregarPropuesta.Location = new System.Drawing.Point(0, 0);
            this.btnAgregarPropuesta.Name = "btnAgregarPropuesta";
            this.btnAgregarPropuesta.Size = new System.Drawing.Size(179, 39);
            this.btnAgregarPropuesta.TabIndex = 11;
            this.btnAgregarPropuesta.Text = "+ Agregar Propuesta";
            this.btnAgregarPropuesta.UseVisualStyleBackColor = false;
            // 
            // iconButton1
            // 
            this.iconButton1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.iconButton1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.iconButton1.IconColor = System.Drawing.Color.Gold;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 23;
            this.iconButton1.Location = new System.Drawing.Point(159, 0);
            this.iconButton1.Margin = new System.Windows.Forms.Padding(0);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(22, 26);
            this.iconButton1.TabIndex = 8;
            this.iconButton1.UseVisualStyleBackColor = false;
            // 
            // textBoxBuscar
            // 
            this.textBoxBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxBuscar.BackColor = System.Drawing.Color.White;
            this.textBoxBuscar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBuscar.Location = new System.Drawing.Point(0, 0);
            this.textBoxBuscar.Margin = new System.Windows.Forms.Padding(0);
            this.textBoxBuscar.Name = "textBoxBuscar";
            this.textBoxBuscar.Size = new System.Drawing.Size(159, 26);
            this.textBoxBuscar.TabIndex = 7;
            this.textBoxBuscar.Text = "Buscar..";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.flowLayoutPanel2.Controls.Add(this.textBoxBuscar);
            this.flowLayoutPanel2.Controls.Add(this.iconButton1);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 87);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(1319, 111);
            this.flowLayoutPanel2.TabIndex = 12;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.BackColor = System.Drawing.SystemColors.Window;
            this.flowLayoutPanel3.Controls.Add(this.btnProyectoIntegrador);
            this.flowLayoutPanel3.Controls.Add(this.btnServicioSocial);
            this.flowLayoutPanel3.Controls.Add(this.btnResidencias);
            this.flowLayoutPanel3.Controls.Add(this.btnTodas);
            this.flowLayoutPanel3.Controls.Add(this.dataGridView1);
            this.flowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(0, 198);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(1319, 380);
            this.flowLayoutPanel3.TabIndex = 13;
            // 
            // btnProyectoIntegrador
            // 
            this.btnProyectoIntegrador.BackColor = System.Drawing.Color.Transparent;
            this.btnProyectoIntegrador.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProyectoIntegrador.FlatAppearance.BorderSize = 0;
            this.btnProyectoIntegrador.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnProyectoIntegrador.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnProyectoIntegrador.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProyectoIntegrador.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProyectoIntegrador.Location = new System.Drawing.Point(5, 5);
            this.btnProyectoIntegrador.Margin = new System.Windows.Forms.Padding(5);
            this.btnProyectoIntegrador.Name = "btnProyectoIntegrador";
            this.btnProyectoIntegrador.Size = new System.Drawing.Size(176, 29);
            this.btnProyectoIntegrador.TabIndex = 15;
            this.btnProyectoIntegrador.Text = "Proyecto Integrador";
            this.btnProyectoIntegrador.UseVisualStyleBackColor = false;
            // 
            // btnServicioSocial
            // 
            this.btnServicioSocial.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnServicioSocial.BackColor = System.Drawing.Color.Transparent;
            this.btnServicioSocial.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnServicioSocial.FlatAppearance.BorderSize = 0;
            this.btnServicioSocial.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnServicioSocial.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnServicioSocial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnServicioSocial.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnServicioSocial.Location = new System.Drawing.Point(191, 5);
            this.btnServicioSocial.Margin = new System.Windows.Forms.Padding(5);
            this.btnServicioSocial.Name = "btnServicioSocial";
            this.btnServicioSocial.Size = new System.Drawing.Size(146, 29);
            this.btnServicioSocial.TabIndex = 14;
            this.btnServicioSocial.Text = "Servicio Social";
            this.btnServicioSocial.UseVisualStyleBackColor = false;
            // 
            // btnResidencias
            // 
            this.btnResidencias.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnResidencias.BackColor = System.Drawing.Color.Transparent;
            this.btnResidencias.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnResidencias.FlatAppearance.BorderSize = 0;
            this.btnResidencias.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnResidencias.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnResidencias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResidencias.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResidencias.Location = new System.Drawing.Point(347, 5);
            this.btnResidencias.Margin = new System.Windows.Forms.Padding(5);
            this.btnResidencias.Name = "btnResidencias";
            this.btnResidencias.Size = new System.Drawing.Size(294, 29);
            this.btnResidencias.TabIndex = 13;
            this.btnResidencias.Text = "Residencias";
            this.btnResidencias.UseVisualStyleBackColor = false;
            // 
            // btnTodas
            // 
            this.btnTodas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTodas.BackColor = System.Drawing.Color.Tomato;
            this.btnTodas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTodas.FlatAppearance.BorderSize = 0;
            this.btnTodas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnTodas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnTodas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTodas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTodas.Location = new System.Drawing.Point(5, 44);
            this.btnTodas.Margin = new System.Windows.Forms.Padding(5);
            this.btnTodas.Name = "btnTodas";
            this.btnTodas.Size = new System.Drawing.Size(839, 55);
            this.btnTodas.TabIndex = 12;
            this.btnTodas.Text = "Todas";
            this.btnTodas.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 107);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1221, 0);
            this.dataGridView1.TabIndex = 16;
            // 
            // formPropuestas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1319, 580);
            this.Controls.Add(this.flowLayoutPanel3);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formPropuestas";
            this.Text = "formPropuestas";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.panelButton.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.flowLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private panel panelButton;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.TextBox textBoxBuscar;
        private System.Windows.Forms.Button btnAgregarPropuesta;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.Button btnProyectoIntegrador;
        private System.Windows.Forms.Button btnServicioSocial;
        private System.Windows.Forms.Button btnResidencias;
        private System.Windows.Forms.Button btnTodas;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}