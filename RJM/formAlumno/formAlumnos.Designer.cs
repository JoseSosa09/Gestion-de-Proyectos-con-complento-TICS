namespace RJM
{
    partial class formAlumnos
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
            this.dgvTodas = new System.Windows.Forms.DataGridView();
            this.labelTitulo = new System.Windows.Forms.Label();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeroControl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaCreacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBoxBuscar = new System.Windows.Forms.TextBox();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.panelTop = new System.Windows.Forms.Panel();
            this.panelBottom = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTodas)).BeginInit();
            this.panelTop.SuspendLayout();
            this.panelBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvTodas
            // 
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
            this.nombre,
            this.numeroControl,
            this.telefono,
            this.fechaCreacion});
            this.dgvTodas.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTodas.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvTodas.GridColor = System.Drawing.Color.Black;
            this.dgvTodas.Location = new System.Drawing.Point(12, 9);
            this.dgvTodas.MultiSelect = false;
            this.dgvTodas.Name = "dgvTodas";
            this.dgvTodas.ReadOnly = true;
            this.dgvTodas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTodas.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvTodas.RowHeadersWidth = 51;
            this.dgvTodas.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            this.dgvTodas.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvTodas.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.dgvTodas.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvTodas.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Goldenrod;
            this.dgvTodas.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvTodas.RowTemplate.Height = 28;
            this.dgvTodas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTodas.ShowEditingIcon = false;
            this.dgvTodas.Size = new System.Drawing.Size(1295, 467);
            this.dgvTodas.TabIndex = 22;
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitulo.ForeColor = System.Drawing.Color.Black;
            this.labelTitulo.Location = new System.Drawing.Point(12, 9);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(170, 42);
            this.labelTitulo.TabIndex = 23;
            this.labelTitulo.Text = "Alumnos";
            // 
            // nombre
            // 
            this.nombre.FillWeight = 87.33805F;
            this.nombre.HeaderText = "Nombre";
            this.nombre.MinimumWidth = 6;
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            // 
            // numeroControl
            // 
            this.numeroControl.FillWeight = 95F;
            this.numeroControl.HeaderText = "Numero Control";
            this.numeroControl.MinimumWidth = 6;
            this.numeroControl.Name = "numeroControl";
            this.numeroControl.ReadOnly = true;
            // 
            // telefono
            // 
            this.telefono.FillWeight = 55F;
            this.telefono.HeaderText = "Teléfono";
            this.telefono.MinimumWidth = 6;
            this.telefono.Name = "telefono";
            this.telefono.ReadOnly = true;
            // 
            // fechaCreacion
            // 
            this.fechaCreacion.HeaderText = "Fecha de Creación";
            this.fechaCreacion.MinimumWidth = 6;
            this.fechaCreacion.Name = "fechaCreacion";
            this.fechaCreacion.ReadOnly = true;
            // 
            // textBoxBuscar
            // 
            this.textBoxBuscar.BackColor = System.Drawing.Color.White;
            this.textBoxBuscar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBuscar.Location = new System.Drawing.Point(99, 79);
            this.textBoxBuscar.Margin = new System.Windows.Forms.Padding(0);
            this.textBoxBuscar.Name = "textBoxBuscar";
            this.textBoxBuscar.Size = new System.Drawing.Size(253, 32);
            this.textBoxBuscar.TabIndex = 24;
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.iconButton1.IconColor = System.Drawing.Color.Gold;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 26;
            this.iconButton1.Location = new System.Drawing.Point(352, 78);
            this.iconButton1.Margin = new System.Windows.Forms.Padding(0);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(30, 33);
            this.iconButton1.TabIndex = 25;
            this.iconButton1.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 26);
            this.label1.TabIndex = 26;
            this.label1.Text = "Buscar:";
            // 
            // panelTop
            // 
            this.panelTop.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelTop.BackColor = System.Drawing.Color.White;
            this.panelTop.Controls.Add(this.iconButton1);
            this.panelTop.Controls.Add(this.textBoxBuscar);
            this.panelTop.Controls.Add(this.label1);
            this.panelTop.Controls.Add(this.labelTitulo);
            this.panelTop.Location = new System.Drawing.Point(2, 2);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1316, 148);
            this.panelTop.TabIndex = 27;
            // 
            // panelBottom
            // 
            this.panelBottom.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelBottom.BackColor = System.Drawing.Color.White;
            this.panelBottom.Controls.Add(this.dgvTodas);
            this.panelBottom.Location = new System.Drawing.Point(0, 150);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(1318, 488);
            this.panelBottom.TabIndex = 28;
            // 
            // formAlumnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1319, 638);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.panelBottom);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formAlumnos";
            this.Text = "formAlumnos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTodas)).EndInit();
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.panelBottom.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTodas;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroControl;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaCreacion;
        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.TextBox textBoxBuscar;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel panelBottom;
    }
}