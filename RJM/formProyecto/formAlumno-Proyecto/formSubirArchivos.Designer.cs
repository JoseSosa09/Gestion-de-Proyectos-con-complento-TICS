namespace RJM.formProyecto.formAlumno_Proyecto
{
    partial class formSubirArchivos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelTop = new System.Windows.Forms.Panel();
            this.agregarArchivoAlumno = new FontAwesome.Sharp.IconButton();
            this.labelTitulo = new System.Windows.Forms.Label();
            this.contenedor = new System.Windows.Forms.Panel();
            this.dgvFiles = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.archivo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proyecto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.programa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.borrar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.cBMaestro = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cBPrograma = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panelTop.SuspendLayout();
            this.contenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFiles)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelTop.BackColor = System.Drawing.Color.White;
            this.panelTop.Controls.Add(this.cBPrograma);
            this.panelTop.Controls.Add(this.label2);
            this.panelTop.Controls.Add(this.cBMaestro);
            this.panelTop.Controls.Add(this.agregarArchivoAlumno);
            this.panelTop.Controls.Add(this.label1);
            this.panelTop.Controls.Add(this.labelTitulo);
            this.panelTop.Location = new System.Drawing.Point(0, -1);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1319, 128);
            this.panelTop.TabIndex = 2;
            // 
            // agregarArchivoAlumno
            // 
            this.agregarArchivoAlumno.BackColor = System.Drawing.SystemColors.Window;
            this.agregarArchivoAlumno.Cursor = System.Windows.Forms.Cursors.Hand;
            this.agregarArchivoAlumno.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.agregarArchivoAlumno.FlatAppearance.BorderSize = 0;
            this.agregarArchivoAlumno.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Goldenrod;
            this.agregarArchivoAlumno.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Goldenrod;
            this.agregarArchivoAlumno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.agregarArchivoAlumno.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Italic);
            this.agregarArchivoAlumno.ForeColor = System.Drawing.Color.Black;
            this.agregarArchivoAlumno.IconChar = FontAwesome.Sharp.IconChar.FileWord;
            this.agregarArchivoAlumno.IconColor = System.Drawing.Color.Black;
            this.agregarArchivoAlumno.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.agregarArchivoAlumno.IconSize = 26;
            this.agregarArchivoAlumno.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.agregarArchivoAlumno.Location = new System.Drawing.Point(1160, 81);
            this.agregarArchivoAlumno.Margin = new System.Windows.Forms.Padding(0);
            this.agregarArchivoAlumno.Name = "agregarArchivoAlumno";
            this.agregarArchivoAlumno.Size = new System.Drawing.Size(137, 34);
            this.agregarArchivoAlumno.TabIndex = 51;
            this.agregarArchivoAlumno.Text = "Archivo";
            this.agregarArchivoAlumno.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.agregarArchivoAlumno.UseVisualStyleBackColor = false;
            this.agregarArchivoAlumno.Click += new System.EventHandler(this.agregarArchivoAlumno_Click);
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitulo.ForeColor = System.Drawing.Color.Black;
            this.labelTitulo.Location = new System.Drawing.Point(32, 9);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(273, 42);
            this.labelTitulo.TabIndex = 50;
            this.labelTitulo.Text = "Subir Archivos";
            this.labelTitulo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // contenedor
            // 
            this.contenedor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.contenedor.BackColor = System.Drawing.Color.White;
            this.contenedor.Controls.Add(this.dgvFiles);
            this.contenedor.Location = new System.Drawing.Point(0, 132);
            this.contenedor.Name = "contenedor";
            this.contenedor.Size = new System.Drawing.Size(1319, 453);
            this.contenedor.TabIndex = 3;
            // 
            // dgvFiles
            // 
            this.dgvFiles.AllowUserToAddRows = false;
            this.dgvFiles.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.dgvFiles.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvFiles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFiles.BackgroundColor = System.Drawing.Color.White;
            this.dgvFiles.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvFiles.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dgvFiles.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            this.dgvFiles.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFiles.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvFiles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFiles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.archivo,
            this.proyecto,
            this.programa,
            this.borrar});
            this.dgvFiles.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvFiles.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvFiles.GridColor = System.Drawing.Color.Black;
            this.dgvFiles.Location = new System.Drawing.Point(39, 8);
            this.dgvFiles.MultiSelect = false;
            this.dgvFiles.Name = "dgvFiles";
            this.dgvFiles.ReadOnly = true;
            this.dgvFiles.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFiles.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvFiles.RowHeadersVisible = false;
            this.dgvFiles.RowHeadersWidth = 51;
            this.dgvFiles.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            this.dgvFiles.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvFiles.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.dgvFiles.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvFiles.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Goldenrod;
            this.dgvFiles.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvFiles.RowTemplate.Height = 28;
            this.dgvFiles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFiles.ShowEditingIcon = false;
            this.dgvFiles.Size = new System.Drawing.Size(1246, 432);
            this.dgvFiles.TabIndex = 23;
            this.dgvFiles.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFiles_CellContentClick);
            this.dgvFiles.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgvFiles_CellPainting);
            // 
            // id
            // 
            this.id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.id.HeaderText = "ID";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 35;
            // 
            // archivo
            // 
            this.archivo.FillWeight = 89.96139F;
            this.archivo.HeaderText = "Archivo";
            this.archivo.MinimumWidth = 6;
            this.archivo.Name = "archivo";
            this.archivo.ReadOnly = true;
            // 
            // proyecto
            // 
            this.proyecto.HeaderText = "Proyecto";
            this.proyecto.MinimumWidth = 6;
            this.proyecto.Name = "proyecto";
            this.proyecto.ReadOnly = true;
            this.proyecto.Visible = false;
            // 
            // programa
            // 
            this.programa.HeaderText = "Programa";
            this.programa.MinimumWidth = 6;
            this.programa.Name = "programa";
            this.programa.ReadOnly = true;
            // 
            // borrar
            // 
            this.borrar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.borrar.HeaderText = "";
            this.borrar.MinimumWidth = 6;
            this.borrar.Name = "borrar";
            this.borrar.ReadOnly = true;
            this.borrar.Width = 35;
            // 
            // cBMaestro
            // 
            this.cBMaestro.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cBMaestro.BackColor = System.Drawing.Color.White;
            this.cBMaestro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cBMaestro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cBMaestro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBMaestro.FormattingEnabled = true;
            this.cBMaestro.Location = new System.Drawing.Point(156, 81);
            this.cBMaestro.Name = "cBMaestro";
            this.cBMaestro.Size = new System.Drawing.Size(413, 33);
            this.cBMaestro.TabIndex = 49;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.Location = new System.Drawing.Point(34, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 29);
            this.label1.TabIndex = 48;
            this.label1.Text = "Maestro";
            // 
            // cBPrograma
            // 
            this.cBPrograma.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cBPrograma.BackColor = System.Drawing.Color.White;
            this.cBPrograma.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cBPrograma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cBPrograma.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBPrograma.FormattingEnabled = true;
            this.cBPrograma.Location = new System.Drawing.Point(716, 82);
            this.cBPrograma.Name = "cBPrograma";
            this.cBPrograma.Size = new System.Drawing.Size(413, 33);
            this.cBPrograma.TabIndex = 53;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label2.Location = new System.Drawing.Point(594, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 29);
            this.label2.TabIndex = 52;
            this.label2.Text = "Programa";
            // 
            // formSubirArchivos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1319, 585);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.contenedor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formSubirArchivos";
            this.Text = "formSubirArchivos";
            this.Load += new System.EventHandler(this.formSubirArchivos_Load);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.contenedor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFiles)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private FontAwesome.Sharp.IconButton agregarArchivoAlumno;
        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.Panel contenedor;
        private System.Windows.Forms.DataGridView dgvFiles;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn archivo;
        private System.Windows.Forms.DataGridViewTextBoxColumn proyecto;
        private System.Windows.Forms.DataGridViewTextBoxColumn programa;
        private System.Windows.Forms.DataGridViewButtonColumn borrar;
        private System.Windows.Forms.ComboBox cBMaestro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cBPrograma;
        private System.Windows.Forms.Label label2;
    }
}