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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.labelTitulo = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.agregarProyectoIntegrador = new FontAwesome.Sharp.IconButton();
            this.agregarServicioSocial = new FontAwesome.Sharp.IconButton();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.agregarPropuesta = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.SidePanel = new System.Windows.Forms.Panel();
            this.btnProyectoIntegrador = new System.Windows.Forms.Button();
            this.btnServicioSocial = new System.Windows.Forms.Button();
            this.btnResidencias = new System.Windows.Forms.Button();
            this.btnTodas = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgvTodas = new System.Windows.Forms.DataGridView();
            this.IdCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreMaestro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colaboradores = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numAlumnos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreAlumno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.editarButton = new System.Windows.Forms.DataGridViewButtonColumn();
            this.borrarButton = new System.Windows.Forms.DataGridViewButtonColumn();
            this.textBoxBuscar = new System.Windows.Forms.TextBox();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.btnAgregarPropuesta = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTodas)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitulo.ForeColor = System.Drawing.Color.Black;
            this.labelTitulo.Location = new System.Drawing.Point(3, 3);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(440, 42);
            this.labelTitulo.TabIndex = 10;
            this.labelTitulo.Text = "Propuestas de Proyecto";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.agregarProyectoIntegrador);
            this.panel1.Controls.Add(this.agregarServicioSocial);
            this.panel1.Controls.Add(this.iconButton2);
            this.panel1.Controls.Add(this.labelTitulo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1319, 100);
            this.panel1.TabIndex = 17;
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
            this.agregarProyectoIntegrador.Location = new System.Drawing.Point(999, 66);
            this.agregarProyectoIntegrador.Margin = new System.Windows.Forms.Padding(0);
            this.agregarProyectoIntegrador.Name = "agregarProyectoIntegrador";
            this.agregarProyectoIntegrador.Size = new System.Drawing.Size(320, 34);
            this.agregarProyectoIntegrador.TabIndex = 24;
            this.agregarProyectoIntegrador.Text = "Agregar Proyecto Integrador";
            this.agregarProyectoIntegrador.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.agregarProyectoIntegrador.UseVisualStyleBackColor = false;
            this.agregarProyectoIntegrador.Visible = false;
            this.agregarProyectoIntegrador.Click += new System.EventHandler(this.iconButton3_Click);
            // 
            // agregarServicioSocial
            // 
            this.agregarServicioSocial.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.agregarServicioSocial.BackColor = System.Drawing.Color.Transparent;
            this.agregarServicioSocial.Cursor = System.Windows.Forms.Cursors.Hand;
            this.agregarServicioSocial.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.agregarServicioSocial.FlatAppearance.BorderSize = 0;
            this.agregarServicioSocial.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Goldenrod;
            this.agregarServicioSocial.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Goldenrod;
            this.agregarServicioSocial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.agregarServicioSocial.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Italic);
            this.agregarServicioSocial.ForeColor = System.Drawing.Color.Black;
            this.agregarServicioSocial.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.agregarServicioSocial.IconColor = System.Drawing.Color.Black;
            this.agregarServicioSocial.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.agregarServicioSocial.IconSize = 26;
            this.agregarServicioSocial.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.agregarServicioSocial.Location = new System.Drawing.Point(1016, 66);
            this.agregarServicioSocial.Margin = new System.Windows.Forms.Padding(0);
            this.agregarServicioSocial.Name = "agregarServicioSocial";
            this.agregarServicioSocial.Size = new System.Drawing.Size(301, 34);
            this.agregarServicioSocial.TabIndex = 23;
            this.agregarServicioSocial.Text = "Agregar a Servicio Social";
            this.agregarServicioSocial.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.agregarServicioSocial.UseVisualStyleBackColor = false;
            this.agregarServicioSocial.Visible = false;
            this.agregarServicioSocial.Click += new System.EventHandler(this.agregarServicioSocial_Click);
            // 
            // iconButton2
            // 
            this.iconButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconButton2.BackColor = System.Drawing.Color.Transparent;
            this.iconButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButton2.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.iconButton2.FlatAppearance.BorderSize = 0;
            this.iconButton2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Goldenrod;
            this.iconButton2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Goldenrod;
            this.iconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Italic);
            this.iconButton2.ForeColor = System.Drawing.Color.Black;
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.iconButton2.IconColor = System.Drawing.Color.Black;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.IconSize = 26;
            this.iconButton2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton2.Location = new System.Drawing.Point(1087, 66);
            this.iconButton2.Margin = new System.Windows.Forms.Padding(0);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Size = new System.Drawing.Size(230, 34);
            this.iconButton2.TabIndex = 22;
            this.iconButton2.Text = "Agregar Propuesta";
            this.iconButton2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButton2.UseVisualStyleBackColor = false;
            this.iconButton2.Click += new System.EventHandler(this.agregarPropuesta_Click);
            // 
            // agregarPropuesta
            // 
            this.agregarPropuesta.BackColor = System.Drawing.Color.Transparent;
            this.agregarPropuesta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.agregarPropuesta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.agregarPropuesta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.agregarPropuesta.Location = new System.Drawing.Point(0, 0);
            this.agregarPropuesta.Name = "agregarPropuesta";
            this.agregarPropuesta.Size = new System.Drawing.Size(137, 51);
            this.agregarPropuesta.TabIndex = 0;
            this.agregarPropuesta.Text = "++Agregar Propuesta";
            this.agregarPropuesta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.agregarPropuesta.Click += new System.EventHandler(this.agregarPropuesta_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.SidePanel);
            this.panel2.Controls.Add(this.btnProyectoIntegrador);
            this.panel2.Controls.Add(this.btnServicioSocial);
            this.panel2.Controls.Add(this.btnResidencias);
            this.panel2.Controls.Add(this.btnTodas);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1319, 58);
            this.panel2.TabIndex = 19;
            // 
            // SidePanel
            // 
            this.SidePanel.BackColor = System.Drawing.Color.Black;
            this.SidePanel.Location = new System.Drawing.Point(3, 52);
            this.SidePanel.Margin = new System.Windows.Forms.Padding(0);
            this.SidePanel.Name = "SidePanel";
            this.SidePanel.Size = new System.Drawing.Size(128, 1);
            this.SidePanel.TabIndex = 22;
            // 
            // btnProyectoIntegrador
            // 
            this.btnProyectoIntegrador.BackColor = System.Drawing.Color.Transparent;
            this.btnProyectoIntegrador.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProyectoIntegrador.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnProyectoIntegrador.FlatAppearance.BorderSize = 0;
            this.btnProyectoIntegrador.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnProyectoIntegrador.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnProyectoIntegrador.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProyectoIntegrador.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProyectoIntegrador.Location = new System.Drawing.Point(471, 0);
            this.btnProyectoIntegrador.Margin = new System.Windows.Forms.Padding(5);
            this.btnProyectoIntegrador.Name = "btnProyectoIntegrador";
            this.btnProyectoIntegrador.Size = new System.Drawing.Size(236, 58);
            this.btnProyectoIntegrador.TabIndex = 22;
            this.btnProyectoIntegrador.Text = "Proyecto Integrador";
            this.btnProyectoIntegrador.UseVisualStyleBackColor = false;
            this.btnProyectoIntegrador.Click += new System.EventHandler(this.btnProyectoIntegrador_Click);
            // 
            // btnServicioSocial
            // 
            this.btnServicioSocial.BackColor = System.Drawing.Color.Transparent;
            this.btnServicioSocial.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnServicioSocial.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnServicioSocial.FlatAppearance.BorderSize = 0;
            this.btnServicioSocial.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnServicioSocial.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnServicioSocial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnServicioSocial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnServicioSocial.Location = new System.Drawing.Point(280, 0);
            this.btnServicioSocial.Margin = new System.Windows.Forms.Padding(5);
            this.btnServicioSocial.Name = "btnServicioSocial";
            this.btnServicioSocial.Size = new System.Drawing.Size(191, 58);
            this.btnServicioSocial.TabIndex = 21;
            this.btnServicioSocial.Text = "Servicio Social";
            this.btnServicioSocial.UseVisualStyleBackColor = false;
            this.btnServicioSocial.Click += new System.EventHandler(this.btnServicioSocial_Click);
            // 
            // btnResidencias
            // 
            this.btnResidencias.BackColor = System.Drawing.Color.Transparent;
            this.btnResidencias.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnResidencias.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnResidencias.FlatAppearance.BorderSize = 0;
            this.btnResidencias.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnResidencias.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnResidencias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResidencias.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResidencias.Location = new System.Drawing.Point(125, 0);
            this.btnResidencias.Margin = new System.Windows.Forms.Padding(5);
            this.btnResidencias.Name = "btnResidencias";
            this.btnResidencias.Size = new System.Drawing.Size(155, 58);
            this.btnResidencias.TabIndex = 20;
            this.btnResidencias.Text = "Residencias";
            this.btnResidencias.UseVisualStyleBackColor = false;
            this.btnResidencias.Click += new System.EventHandler(this.btnResidencias_Click_1);
            // 
            // btnTodas
            // 
            this.btnTodas.BackColor = System.Drawing.Color.Transparent;
            this.btnTodas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTodas.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnTodas.FlatAppearance.BorderSize = 0;
            this.btnTodas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnTodas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnTodas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTodas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTodas.Location = new System.Drawing.Point(0, 0);
            this.btnTodas.Margin = new System.Windows.Forms.Padding(5);
            this.btnTodas.Name = "btnTodas";
            this.btnTodas.Size = new System.Drawing.Size(125, 58);
            this.btnTodas.TabIndex = 19;
            this.btnTodas.Text = "Todas";
            this.btnTodas.UseVisualStyleBackColor = false;
            this.btnTodas.Click += new System.EventHandler(this.btnTodas_Click_1);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.dgvTodas);
            this.panel3.Controls.Add(this.textBoxBuscar);
            this.panel3.Controls.Add(this.iconButton1);
            this.panel3.Location = new System.Drawing.Point(0, 155);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1319, 426);
            this.panel3.TabIndex = 20;
            // 
            // dgvTodas
            // 
            this.dgvTodas.AllowUserToAddRows = false;
            this.dgvTodas.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.dgvTodas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTodas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTodas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTodas.BackgroundColor = System.Drawing.Color.White;
            this.dgvTodas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvTodas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dgvTodas.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dgvTodas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTodas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvTodas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTodas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdCategoria,
            this.categoria,
            this.estatus,
            this.nombre,
            this.nombreMaestro,
            this.colaboradores,
            this.numAlumnos,
            this.nombreAlumno,
            this.editarButton,
            this.borrarButton});
            this.dgvTodas.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTodas.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvTodas.GridColor = System.Drawing.Color.Black;
            this.dgvTodas.Location = new System.Drawing.Point(19, 55);
            this.dgvTodas.MultiSelect = false;
            this.dgvTodas.Name = "dgvTodas";
            this.dgvTodas.ReadOnly = true;
            this.dgvTodas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTodas.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvTodas.RowHeadersWidth = 51;
            this.dgvTodas.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            this.dgvTodas.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvTodas.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.dgvTodas.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvTodas.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Goldenrod;
            this.dgvTodas.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvTodas.RowTemplate.Height = 28;
            this.dgvTodas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTodas.ShowEditingIcon = false;
            this.dgvTodas.Size = new System.Drawing.Size(1285, 321);
            this.dgvTodas.TabIndex = 21;
            this.dgvTodas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellContentClick);
            this.dgvTodas.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgv_CellPainting);
            // 
            // IdCategoria
            // 
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Goldenrod;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Goldenrod;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.IdCategoria.DefaultCellStyle = dataGridViewCellStyle3;
            this.IdCategoria.FillWeight = 14F;
            this.IdCategoria.HeaderText = "No.";
            this.IdCategoria.MinimumWidth = 6;
            this.IdCategoria.Name = "IdCategoria";
            this.IdCategoria.ReadOnly = true;
            // 
            // categoria
            // 
            this.categoria.FillWeight = 95F;
            this.categoria.HeaderText = "Categoria";
            this.categoria.MinimumWidth = 6;
            this.categoria.Name = "categoria";
            this.categoria.ReadOnly = true;
            // 
            // estatus
            // 
            this.estatus.FillWeight = 22F;
            this.estatus.HeaderText = "Estatus";
            this.estatus.MinimumWidth = 6;
            this.estatus.Name = "estatus";
            this.estatus.ReadOnly = true;
            // 
            // nombre
            // 
            this.nombre.FillWeight = 87.33805F;
            this.nombre.HeaderText = "Nombre";
            this.nombre.MinimumWidth = 6;
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            // 
            // nombreMaestro
            // 
            this.nombreMaestro.FillWeight = 55F;
            this.nombreMaestro.HeaderText = "Responsable (Asesor Interno)";
            this.nombreMaestro.MinimumWidth = 6;
            this.nombreMaestro.Name = "nombreMaestro";
            this.nombreMaestro.ReadOnly = true;
            // 
            // colaboradores
            // 
            this.colaboradores.FillWeight = 87.33805F;
            this.colaboradores.HeaderText = "Colaboradores";
            this.colaboradores.MinimumWidth = 6;
            this.colaboradores.Name = "colaboradores";
            this.colaboradores.ReadOnly = true;
            // 
            // numAlumnos
            // 
            this.numAlumnos.FillWeight = 24F;
            this.numAlumnos.HeaderText = "Número Alumnos";
            this.numAlumnos.MinimumWidth = 6;
            this.numAlumnos.Name = "numAlumnos";
            this.numAlumnos.ReadOnly = true;
            // 
            // nombreAlumno
            // 
            this.nombreAlumno.HeaderText = "Descripcion";
            this.nombreAlumno.MinimumWidth = 6;
            this.nombreAlumno.Name = "nombreAlumno";
            this.nombreAlumno.ReadOnly = true;
            // 
            // editarButton
            // 
            this.editarButton.FillWeight = 12F;
            this.editarButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editarButton.HeaderText = "";
            this.editarButton.MinimumWidth = 6;
            this.editarButton.Name = "editarButton";
            this.editarButton.ReadOnly = true;
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
            // textBoxBuscar
            // 
            this.textBoxBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxBuscar.BackColor = System.Drawing.Color.White;
            this.textBoxBuscar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBuscar.Location = new System.Drawing.Point(1036, 1);
            this.textBoxBuscar.Margin = new System.Windows.Forms.Padding(0);
            this.textBoxBuscar.Name = "textBoxBuscar";
            this.textBoxBuscar.Size = new System.Drawing.Size(253, 32);
            this.textBoxBuscar.TabIndex = 19;
            this.textBoxBuscar.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBoxBuscar_KeyUp);
            // 
            // iconButton1
            // 
            this.iconButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconButton1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.iconButton1.IconColor = System.Drawing.Color.Gold;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 26;
            this.iconButton1.Location = new System.Drawing.Point(1289, -1);
            this.iconButton1.Margin = new System.Windows.Forms.Padding(0);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(30, 30);
            this.iconButton1.TabIndex = 20;
            this.iconButton1.UseVisualStyleBackColor = false;
            // 
            // btnAgregarPropuesta
            // 
            this.btnAgregarPropuesta.BackColor = System.Drawing.Color.Transparent;
            this.btnAgregarPropuesta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAgregarPropuesta.FlatAppearance.BorderSize = 0;
            this.btnAgregarPropuesta.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnAgregarPropuesta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnAgregarPropuesta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarPropuesta.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarPropuesta.ForeColor = System.Drawing.Color.Gold;
            this.btnAgregarPropuesta.Location = new System.Drawing.Point(0, 0);
            this.btnAgregarPropuesta.Name = "btnAgregarPropuesta";
            this.btnAgregarPropuesta.Size = new System.Drawing.Size(199, 45);
            this.btnAgregarPropuesta.TabIndex = 11;
            this.btnAgregarPropuesta.Text = "+ Agregar Propuesta";
            this.btnAgregarPropuesta.UseVisualStyleBackColor = false;
            // 
            // formPropuestas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1319, 580);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formPropuestas";
            this.Text = "formPropuestas";
            this.Load += new System.EventHandler(this.formPropuestas_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTodas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private panel panelButton;
        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.Button btnAgregarPropuesta;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnProyectoIntegrador;
        private System.Windows.Forms.Button btnServicioSocial;
        private System.Windows.Forms.Button btnResidencias;
        private System.Windows.Forms.Button btnTodas;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgvTodas;
        private System.Windows.Forms.TextBox textBoxBuscar;
        private FontAwesome.Sharp.IconButton iconButton1;
        private panel panelAgregarPropuesta;
        private System.Windows.Forms.Label agregarPropuesta;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdCategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn estatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreMaestro;
        private System.Windows.Forms.DataGridViewTextBoxColumn colaboradores;
        private System.Windows.Forms.DataGridViewTextBoxColumn numAlumnos;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreAlumno;
        private System.Windows.Forms.DataGridViewButtonColumn editarButton;
        private System.Windows.Forms.DataGridViewButtonColumn borrarButton;
        private System.Windows.Forms.Panel SidePanel;
        private FontAwesome.Sharp.IconButton iconButton2;
        private FontAwesome.Sharp.IconButton agregarServicioSocial;
        private FontAwesome.Sharp.IconButton agregarProyectoIntegrador;
    }
}