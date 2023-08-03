namespace RJM.formRJM
{
    partial class formProyectoIntegrador
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvIntegrador = new System.Windows.Forms.DataGridView();
            this.agregarProyectoIntegrador = new FontAwesome.Sharp.IconButton();
            this.cBModalidad = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cBNombre = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelTitulo = new System.Windows.Forms.Label();
            this.borrarProyecto = new FontAwesome.Sharp.IconButton();
            this.cBAlumno = new System.Windows.Forms.ComboBox();
            this.cBCategoria = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.idTable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alumno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeroControl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modalidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.borrarButton = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIntegrador)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvIntegrador
            // 
            this.dgvIntegrador.AllowUserToAddRows = false;
            this.dgvIntegrador.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.dgvIntegrador.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvIntegrador.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvIntegrador.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvIntegrador.BackgroundColor = System.Drawing.Color.White;
            this.dgvIntegrador.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvIntegrador.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dgvIntegrador.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dgvIntegrador.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvIntegrador.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvIntegrador.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIntegrador.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idTable,
            this.nombre,
            this.alumno,
            this.numeroControl,
            this.modalidad,
            this.categoria,
            this.borrarButton});
            this.dgvIntegrador.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvIntegrador.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvIntegrador.GridColor = System.Drawing.Color.Black;
            this.dgvIntegrador.Location = new System.Drawing.Point(8, 206);
            this.dgvIntegrador.MultiSelect = false;
            this.dgvIntegrador.Name = "dgvIntegrador";
            this.dgvIntegrador.ReadOnly = true;
            this.dgvIntegrador.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvIntegrador.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvIntegrador.RowHeadersVisible = false;
            this.dgvIntegrador.RowHeadersWidth = 51;
            this.dgvIntegrador.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            this.dgvIntegrador.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvIntegrador.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.dgvIntegrador.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvIntegrador.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Goldenrod;
            this.dgvIntegrador.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvIntegrador.RowTemplate.Height = 28;
            this.dgvIntegrador.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvIntegrador.ShowEditingIcon = false;
            this.dgvIntegrador.Size = new System.Drawing.Size(1305, 360);
            this.dgvIntegrador.TabIndex = 27;
            this.dgvIntegrador.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvIntegrador_CellContentClick);
            this.dgvIntegrador.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgvIntegrador_CellPainting);
            // 
            // agregarProyectoIntegrador
            // 
            this.agregarProyectoIntegrador.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.agregarProyectoIntegrador.BackColor = System.Drawing.Color.Transparent;
            this.agregarProyectoIntegrador.Cursor = System.Windows.Forms.Cursors.Hand;
            this.agregarProyectoIntegrador.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.agregarProyectoIntegrador.FlatAppearance.BorderSize = 0;
            this.agregarProyectoIntegrador.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Goldenrod;
            this.agregarProyectoIntegrador.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Goldenrod;
            this.agregarProyectoIntegrador.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.agregarProyectoIntegrador.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Italic);
            this.agregarProyectoIntegrador.ForeColor = System.Drawing.Color.Black;
            this.agregarProyectoIntegrador.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.agregarProyectoIntegrador.IconColor = System.Drawing.Color.Black;
            this.agregarProyectoIntegrador.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.agregarProyectoIntegrador.IconSize = 26;
            this.agregarProyectoIntegrador.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.agregarProyectoIntegrador.Location = new System.Drawing.Point(1099, 65);
            this.agregarProyectoIntegrador.Margin = new System.Windows.Forms.Padding(0);
            this.agregarProyectoIntegrador.Name = "agregarProyectoIntegrador";
            this.agregarProyectoIntegrador.Size = new System.Drawing.Size(210, 34);
            this.agregarProyectoIntegrador.TabIndex = 41;
            this.agregarProyectoIntegrador.Text = "Asignar Proyecto";
            this.agregarProyectoIntegrador.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.agregarProyectoIntegrador.UseVisualStyleBackColor = false;
            this.agregarProyectoIntegrador.Click += new System.EventHandler(this.agregarProyectoIntegrador_Click_1);
            // 
            // cBModalidad
            // 
            this.cBModalidad.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cBModalidad.BackColor = System.Drawing.Color.White;
            this.cBModalidad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cBModalidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBModalidad.FormattingEnabled = true;
            this.cBModalidad.Location = new System.Drawing.Point(685, 152);
            this.cBModalidad.Name = "cBModalidad";
            this.cBModalidad.Size = new System.Drawing.Size(165, 33);
            this.cBModalidad.TabIndex = 40;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label3.Location = new System.Drawing.Point(556, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 29);
            this.label3.TabIndex = 39;
            this.label3.Text = "Modalidad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label2.Location = new System.Drawing.Point(30, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 29);
            this.label2.TabIndex = 37;
            this.label2.Text = "Alumno:";
            // 
            // cBNombre
            // 
            this.cBNombre.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cBNombre.BackColor = System.Drawing.Color.White;
            this.cBNombre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cBNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBNombre.FormattingEnabled = true;
            this.cBNombre.Location = new System.Drawing.Point(126, 97);
            this.cBNombre.Name = "cBNombre";
            this.cBNombre.Size = new System.Drawing.Size(413, 33);
            this.cBNombre.TabIndex = 36;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.Location = new System.Drawing.Point(4, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 29);
            this.label1.TabIndex = 35;
            this.label1.Text = "Programa:";
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitulo.ForeColor = System.Drawing.Color.Black;
            this.labelTitulo.Location = new System.Drawing.Point(3, 18);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(434, 42);
            this.labelTitulo.TabIndex = 34;
            this.labelTitulo.Text = "Asignación de Proyecto";
            this.labelTitulo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // borrarProyecto
            // 
            this.borrarProyecto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.borrarProyecto.BackColor = System.Drawing.Color.Transparent;
            this.borrarProyecto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.borrarProyecto.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.borrarProyecto.FlatAppearance.BorderSize = 0;
            this.borrarProyecto.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Goldenrod;
            this.borrarProyecto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Goldenrod;
            this.borrarProyecto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.borrarProyecto.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Italic);
            this.borrarProyecto.ForeColor = System.Drawing.Color.Black;
            this.borrarProyecto.IconChar = FontAwesome.Sharp.IconChar.Minus;
            this.borrarProyecto.IconColor = System.Drawing.Color.Black;
            this.borrarProyecto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.borrarProyecto.IconSize = 26;
            this.borrarProyecto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.borrarProyecto.Location = new System.Drawing.Point(1099, 103);
            this.borrarProyecto.Margin = new System.Windows.Forms.Padding(0);
            this.borrarProyecto.Name = "borrarProyecto";
            this.borrarProyecto.Size = new System.Drawing.Size(210, 34);
            this.borrarProyecto.TabIndex = 42;
            this.borrarProyecto.Text = "Borrar Proyecto";
            this.borrarProyecto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.borrarProyecto.UseVisualStyleBackColor = false;
            this.borrarProyecto.Click += new System.EventHandler(this.borrarProyecto_Click);
            // 
            // cBAlumno
            // 
            this.cBAlumno.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cBAlumno.BackColor = System.Drawing.Color.White;
            this.cBAlumno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cBAlumno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBAlumno.FormattingEnabled = true;
            this.cBAlumno.Location = new System.Drawing.Point(126, 153);
            this.cBAlumno.Name = "cBAlumno";
            this.cBAlumno.Size = new System.Drawing.Size(413, 33);
            this.cBAlumno.TabIndex = 45;
            // 
            // cBCategoria
            // 
            this.cBCategoria.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cBCategoria.BackColor = System.Drawing.Color.White;
            this.cBCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cBCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBCategoria.FormattingEnabled = true;
            this.cBCategoria.Location = new System.Drawing.Point(1005, 152);
            this.cBCategoria.Name = "cBCategoria";
            this.cBCategoria.Size = new System.Drawing.Size(302, 33);
            this.cBCategoria.TabIndex = 47;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label4.Location = new System.Drawing.Point(876, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 29);
            this.label4.TabIndex = 46;
            this.label4.Text = "Categoria:";
            // 
            // idTable
            // 
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Goldenrod;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Goldenrod;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.idTable.DefaultCellStyle = dataGridViewCellStyle3;
            this.idTable.FillWeight = 14F;
            this.idTable.HeaderText = "No.";
            this.idTable.MinimumWidth = 6;
            this.idTable.Name = "idTable";
            this.idTable.ReadOnly = true;
            // 
            // nombre
            // 
            this.nombre.FillWeight = 87.33805F;
            this.nombre.HeaderText = "Programa";
            this.nombre.MinimumWidth = 6;
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            // 
            // alumno
            // 
            this.alumno.HeaderText = "Alumno";
            this.alumno.MinimumWidth = 6;
            this.alumno.Name = "alumno";
            this.alumno.ReadOnly = true;
            // 
            // numeroControl
            // 
            this.numeroControl.HeaderText = "Numero Control";
            this.numeroControl.MinimumWidth = 6;
            this.numeroControl.Name = "numeroControl";
            this.numeroControl.ReadOnly = true;
            // 
            // modalidad
            // 
            this.modalidad.HeaderText = "Modalidad";
            this.modalidad.MinimumWidth = 6;
            this.modalidad.Name = "modalidad";
            this.modalidad.ReadOnly = true;
            // 
            // categoria
            // 
            this.categoria.HeaderText = "Categoria";
            this.categoria.MinimumWidth = 6;
            this.categoria.Name = "categoria";
            this.categoria.ReadOnly = true;
            // 
            // borrarButton
            // 
            this.borrarButton.FillWeight = 12F;
            this.borrarButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.borrarButton.HeaderText = "";
            this.borrarButton.MinimumWidth = 6;
            this.borrarButton.Name = "borrarButton";
            this.borrarButton.ReadOnly = true;
            // 
            // formProyectoIntegrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1319, 578);
            this.Controls.Add(this.cBCategoria);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cBAlumno);
            this.Controls.Add(this.borrarProyecto);
            this.Controls.Add(this.agregarProyectoIntegrador);
            this.Controls.Add(this.cBModalidad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cBNombre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelTitulo);
            this.Controls.Add(this.dgvIntegrador);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formProyectoIntegrador";
            this.Text = "formProyectoIntegrador";
            this.Load += new System.EventHandler(this.formProyectoIntegrador_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvIntegrador)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvIntegrador;
        private FontAwesome.Sharp.IconButton agregarProyectoIntegrador;
        private System.Windows.Forms.ComboBox cBModalidad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cBNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelTitulo;
        private FontAwesome.Sharp.IconButton borrarProyecto;
        private System.Windows.Forms.ComboBox cBAlumno;
        private System.Windows.Forms.ComboBox cBCategoria;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn idTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn alumno;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroControl;
        private System.Windows.Forms.DataGridViewTextBoxColumn modalidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoria;
        private System.Windows.Forms.DataGridViewButtonColumn borrarButton;
    }
}