namespace RJM
{
    partial class PRINCIPAL
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PRINCIPAL));
            this.barraTitulo = new System.Windows.Forms.Panel();
            this.panelBusqueda = new RJM.panel();
            this.textBoxBusqueda = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelUsuario = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.icnonoMinimizar = new FontAwesome.Sharp.IconButton();
            this.iconoRestaurar = new FontAwesome.Sharp.IconButton();
            this.iconoCerrar = new FontAwesome.Sharp.IconButton();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.CONFIG = new System.Windows.Forms.Button();
            this.RJM = new System.Windows.Forms.Button();
            this.TICS = new System.Windows.Forms.Button();
            this.ALUMNOS = new System.Windows.Forms.Button();
            this.SALIDA = new System.Windows.Forms.Button();
            this.PROYECTO = new System.Windows.Forms.Button();
            this.ENCUESTA = new System.Windows.Forms.Button();
            this.INICIO = new System.Windows.Forms.Button();
            this.contenedor = new System.Windows.Forms.Panel();
            this.barraTitulo.SuspendLayout();
            this.panelBusqueda.SuspendLayout();

            this.panelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // barraTitulo
            // 
            this.barraTitulo.BackColor = System.Drawing.Color.Black;
            this.barraTitulo.Controls.Add(this.panelBusqueda);
            this.barraTitulo.Controls.Add(this.panel1);
            this.barraTitulo.Controls.Add(this.icnonoMinimizar);
            this.barraTitulo.Controls.Add(this.iconoRestaurar);
            this.barraTitulo.Controls.Add(this.iconoCerrar);
            this.barraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.barraTitulo.Location = new System.Drawing.Point(0, 0);
            this.barraTitulo.Name = "barraTitulo";
            this.barraTitulo.Size = new System.Drawing.Size(1429, 51);
            this.barraTitulo.TabIndex = 1;
            this.barraTitulo.TabStop = true;
            this.barraTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.barraTitulo_MouseDown);
            // 
            // panelBusqueda
            // 
            this.panelBusqueda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelBusqueda.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelBusqueda.BorderRadius = 30;
            this.panelBusqueda.Controls.Add(this.textBoxBusqueda);
            this.panelBusqueda.ForeColor = System.Drawing.Color.Black;
            this.panelBusqueda.GradientAngle = 90F;
            this.panelBusqueda.GradientBottomColor = System.Drawing.Color.WhiteSmoke;
            this.panelBusqueda.GradientTopColor = System.Drawing.Color.WhiteSmoke;
            this.panelBusqueda.Location = new System.Drawing.Point(-356, 13);
            this.panelBusqueda.Name = "panelBusqueda";
            this.panelBusqueda.Size = new System.Drawing.Size(668, 30);
            this.panelBusqueda.TabIndex = 1;
            // 
            // textBoxBusqueda
            // 
            this.textBoxBusqueda.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBoxBusqueda.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxBusqueda.Location = new System.Drawing.Point(11, 9);
            this.textBoxBusqueda.Name = "textBoxBusqueda";
            this.textBoxBusqueda.Size = new System.Drawing.Size(574, 15);
            this.textBoxBusqueda.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelUsuario);
            this.panel1.Controls.Add(this.label);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(789, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(544, 51);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 

            // labelUsuario
            // 
            this.labelUsuario.AutoSize = true;
            this.labelUsuario.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsuario.ForeColor = System.Drawing.Color.White;
            this.labelUsuario.Location = new System.Drawing.Point(180, 12);
            this.labelUsuario.Name = "labelUsuario";
            this.labelUsuario.Size = new System.Drawing.Size(150, 23);
            this.labelUsuario.TabIndex = 31;
            this.labelUsuario.Text = "Emma Watson";
            this.labelUsuario.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelUsuario_MouseDown);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.ForeColor = System.Drawing.Color.White;
            this.label.Location = new System.Drawing.Point(88, 12);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(90, 23);
            this.label.TabIndex = 30;
            this.label.Text = "Usuario: ";
            this.label.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelUsuario_MouseDown);
            // 
            // icnonoMinimizar
            // 
            this.icnonoMinimizar.BackColor = System.Drawing.Color.Transparent;
            this.icnonoMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.icnonoMinimizar.Dock = System.Windows.Forms.DockStyle.Right;
            this.icnonoMinimizar.FlatAppearance.BorderSize = 0;
            this.icnonoMinimizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSlateBlue;
            this.icnonoMinimizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateBlue;
            this.icnonoMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.icnonoMinimizar.IconChar = FontAwesome.Sharp.IconChar.Minus;
            this.icnonoMinimizar.IconColor = System.Drawing.Color.White;
            this.icnonoMinimizar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icnonoMinimizar.IconSize = 32;
            this.icnonoMinimizar.Location = new System.Drawing.Point(1333, 0);
            this.icnonoMinimizar.Name = "icnonoMinimizar";
            this.icnonoMinimizar.Size = new System.Drawing.Size(32, 51);
            this.icnonoMinimizar.TabIndex = 26;
            this.icnonoMinimizar.UseVisualStyleBackColor = false;
            this.icnonoMinimizar.Click += new System.EventHandler(this.icnonoMinimizar_Click);
            // 
            // iconoRestaurar
            // 
            this.iconoRestaurar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconoRestaurar.Dock = System.Windows.Forms.DockStyle.Right;
            this.iconoRestaurar.FlatAppearance.BorderSize = 0;
            this.iconoRestaurar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSlateBlue;
            this.iconoRestaurar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateBlue;
            this.iconoRestaurar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconoRestaurar.IconChar = FontAwesome.Sharp.IconChar.WindowRestore;
            this.iconoRestaurar.IconColor = System.Drawing.Color.White;
            this.iconoRestaurar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconoRestaurar.IconSize = 32;
            this.iconoRestaurar.Location = new System.Drawing.Point(1365, 0);
            this.iconoRestaurar.Margin = new System.Windows.Forms.Padding(0);
            this.iconoRestaurar.Name = "iconoRestaurar";
            this.iconoRestaurar.Size = new System.Drawing.Size(32, 51);
            this.iconoRestaurar.TabIndex = 25;
            this.iconoRestaurar.UseVisualStyleBackColor = true;
            this.iconoRestaurar.Click += new System.EventHandler(this.iconoRestaurar_Click);
            // 
            // iconoCerrar
            // 
            this.iconoCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconoCerrar.Dock = System.Windows.Forms.DockStyle.Right;
            this.iconoCerrar.FlatAppearance.BorderSize = 0;
            this.iconoCerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSlateBlue;
            this.iconoCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconoCerrar.IconChar = FontAwesome.Sharp.IconChar.X;
            this.iconoCerrar.IconColor = System.Drawing.Color.White;
            this.iconoCerrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconoCerrar.IconSize = 32;
            this.iconoCerrar.Location = new System.Drawing.Point(1397, 0);
            this.iconoCerrar.Margin = new System.Windows.Forms.Padding(0);
            this.iconoCerrar.Name = "iconoCerrar";
            this.iconoCerrar.Size = new System.Drawing.Size(32, 51);
            this.iconoCerrar.TabIndex = 24;
            this.iconoCerrar.UseVisualStyleBackColor = true;
            this.iconoCerrar.Click += new System.EventHandler(this.iconoCerrar_Click);
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.Goldenrod;
            this.panelMenu.Controls.Add(this.CONFIG);
            this.panelMenu.Controls.Add(this.RJM);
            this.panelMenu.Controls.Add(this.TICS);
            this.panelMenu.Controls.Add(this.ALUMNOS);
            this.panelMenu.Controls.Add(this.SALIDA);
            this.panelMenu.Controls.Add(this.PROYECTO);
            this.panelMenu.Controls.Add(this.ENCUESTA);
            this.panelMenu.Controls.Add(this.INICIO);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 51);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(110, 639);
            this.panelMenu.TabIndex = 14;
            // 
            // CONFIG
            // 
            this.CONFIG.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CONFIG.Dock = System.Windows.Forms.DockStyle.Top;
            this.CONFIG.FlatAppearance.BorderSize = 0;
            this.CONFIG.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke;
            this.CONFIG.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.CONFIG.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CONFIG.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CONFIG.ForeColor = System.Drawing.Color.Black;
            this.CONFIG.Image = ((System.Drawing.Image)(resources.GetObject("CONFIG.Image")));
            this.CONFIG.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.CONFIG.Location = new System.Drawing.Point(0, 468);
            this.CONFIG.Margin = new System.Windows.Forms.Padding(0);
            this.CONFIG.Name = "CONFIG";
            this.CONFIG.Size = new System.Drawing.Size(110, 78);
            this.CONFIG.TabIndex = 28;
            this.CONFIG.Text = "Config";
            this.CONFIG.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.CONFIG.UseVisualStyleBackColor = true;
            this.CONFIG.Click += new System.EventHandler(this.btnConfig_Click);
            // 
            // RJM
            // 
            this.RJM.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RJM.Dock = System.Windows.Forms.DockStyle.Top;
            this.RJM.FlatAppearance.BorderSize = 0;
            this.RJM.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke;
            this.RJM.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.RJM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RJM.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RJM.ForeColor = System.Drawing.Color.Black;
            this.RJM.Image = ((System.Drawing.Image)(resources.GetObject("RJM.Image")));
            this.RJM.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.RJM.Location = new System.Drawing.Point(0, 390);
            this.RJM.Margin = new System.Windows.Forms.Padding(0);
            this.RJM.Name = "RJM";
            this.RJM.Size = new System.Drawing.Size(110, 78);
            this.RJM.TabIndex = 27;
            this.RJM.Text = "RJM";
            this.RJM.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.RJM.UseVisualStyleBackColor = true;
            this.RJM.Click += new System.EventHandler(this.btnRJM_Click);
            // 
            // TICS
            // 
            this.TICS.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TICS.Dock = System.Windows.Forms.DockStyle.Top;
            this.TICS.FlatAppearance.BorderSize = 0;
            this.TICS.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke;
            this.TICS.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.TICS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TICS.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TICS.ForeColor = System.Drawing.Color.Black;
            this.TICS.Image = ((System.Drawing.Image)(resources.GetObject("TICS.Image")));
            this.TICS.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.TICS.Location = new System.Drawing.Point(0, 312);
            this.TICS.Margin = new System.Windows.Forms.Padding(0);
            this.TICS.Name = "TICS";
            this.TICS.Size = new System.Drawing.Size(110, 78);
            this.TICS.TabIndex = 26;
            this.TICS.Text = "TIC\'S";
            this.TICS.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.TICS.UseVisualStyleBackColor = true;
            this.TICS.Click += new System.EventHandler(this.btnTics_Click);
            // 
            // ALUMNOS
            // 
            this.ALUMNOS.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ALUMNOS.Dock = System.Windows.Forms.DockStyle.Top;
            this.ALUMNOS.FlatAppearance.BorderSize = 0;
            this.ALUMNOS.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke;
            this.ALUMNOS.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.ALUMNOS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ALUMNOS.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ALUMNOS.ForeColor = System.Drawing.Color.Black;
            this.ALUMNOS.Image = ((System.Drawing.Image)(resources.GetObject("ALUMNOS.Image")));
            this.ALUMNOS.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ALUMNOS.Location = new System.Drawing.Point(0, 234);
            this.ALUMNOS.Margin = new System.Windows.Forms.Padding(0);
            this.ALUMNOS.Name = "ALUMNOS";
            this.ALUMNOS.Size = new System.Drawing.Size(110, 78);
            this.ALUMNOS.TabIndex = 25;
            this.ALUMNOS.Text = "Alumnos";
            this.ALUMNOS.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ALUMNOS.UseVisualStyleBackColor = true;
            // 
            // SALIDA
            // 
            this.SALIDA.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SALIDA.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.SALIDA.FlatAppearance.BorderSize = 0;
            this.SALIDA.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.SALIDA.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.SALIDA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SALIDA.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SALIDA.ForeColor = System.Drawing.Color.Black;
            this.SALIDA.Image = ((System.Drawing.Image)(resources.GetObject("SALIDA.Image")));
            this.SALIDA.Location = new System.Drawing.Point(0, 561);
            this.SALIDA.Name = "SALIDA";
            this.SALIDA.Size = new System.Drawing.Size(110, 78);
            this.SALIDA.TabIndex = 24;
            this.SALIDA.UseVisualStyleBackColor = true;
            // 
            // PROYECTO
            // 
            this.PROYECTO.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PROYECTO.Dock = System.Windows.Forms.DockStyle.Top;
            this.PROYECTO.FlatAppearance.BorderSize = 0;
            this.PROYECTO.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke;
            this.PROYECTO.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.PROYECTO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PROYECTO.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PROYECTO.ForeColor = System.Drawing.Color.Black;
            this.PROYECTO.Image = ((System.Drawing.Image)(resources.GetObject("PROYECTO.Image")));
            this.PROYECTO.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.PROYECTO.Location = new System.Drawing.Point(0, 156);
            this.PROYECTO.Margin = new System.Windows.Forms.Padding(0);
            this.PROYECTO.Name = "PROYECTO";
            this.PROYECTO.Size = new System.Drawing.Size(110, 78);
            this.PROYECTO.TabIndex = 17;
            this.PROYECTO.Text = "Proyecto";
            this.PROYECTO.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.PROYECTO.UseVisualStyleBackColor = true;
            this.PROYECTO.Click += new System.EventHandler(this.btnProyecto_Click);
            // 
            // ENCUESTA
            // 
            this.ENCUESTA.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ENCUESTA.Dock = System.Windows.Forms.DockStyle.Top;
            this.ENCUESTA.FlatAppearance.BorderSize = 0;
            this.ENCUESTA.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke;
            this.ENCUESTA.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.ENCUESTA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ENCUESTA.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ENCUESTA.ForeColor = System.Drawing.Color.Black;
            this.ENCUESTA.Image = ((System.Drawing.Image)(resources.GetObject("ENCUESTA.Image")));
            this.ENCUESTA.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ENCUESTA.Location = new System.Drawing.Point(0, 78);
            this.ENCUESTA.Margin = new System.Windows.Forms.Padding(0);
            this.ENCUESTA.Name = "ENCUESTA";
            this.ENCUESTA.Size = new System.Drawing.Size(110, 78);
            this.ENCUESTA.TabIndex = 16;
            this.ENCUESTA.Text = "Encuesta";
            this.ENCUESTA.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ENCUESTA.UseVisualStyleBackColor = true;
            this.ENCUESTA.Click += new System.EventHandler(this.btnEncuesta_Click);
            // 
            // INICIO
            // 
            this.INICIO.Cursor = System.Windows.Forms.Cursors.Hand;
            this.INICIO.Dock = System.Windows.Forms.DockStyle.Top;
            this.INICIO.FlatAppearance.BorderSize = 0;
            this.INICIO.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke;
            this.INICIO.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.INICIO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.INICIO.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.INICIO.ForeColor = System.Drawing.Color.Black;
            this.INICIO.Image = global::RJM.Properties.Resources.hogar;
            this.INICIO.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.INICIO.Location = new System.Drawing.Point(0, 0);
            this.INICIO.Margin = new System.Windows.Forms.Padding(0);
            this.INICIO.Name = "INICIO";
            this.INICIO.Size = new System.Drawing.Size(110, 78);
            this.INICIO.TabIndex = 1;
            this.INICIO.Text = "Inicio";
            this.INICIO.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.INICIO.UseVisualStyleBackColor = true;
            this.INICIO.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // contenedor
            // 
            this.contenedor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.contenedor.BackColor = System.Drawing.Color.Transparent;
            this.contenedor.Location = new System.Drawing.Point(110, 52);
            this.contenedor.Margin = new System.Windows.Forms.Padding(0);
            this.contenedor.Name = "contenedor";
            this.contenedor.Size = new System.Drawing.Size(870, 358);
            this.contenedor.TabIndex = 16;
            // 
            // PRINCIPAL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1429, 690);
            this.Controls.Add(this.contenedor);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.barraTitulo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1447, 737);
            this.Name = "PRINCIPAL";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.PRINCIPAL_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.barraTitulo.ResumeLayout(false);
            this.panelBusqueda.ResumeLayout(false);
            this.panelBusqueda.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel barraTitulo;
        private FontAwesome.Sharp.IconButton icnonoMinimizar;
        private FontAwesome.Sharp.IconButton iconoRestaurar;
        private FontAwesome.Sharp.IconButton iconoCerrar;
        private System.Windows.Forms.Button INICIO;
        private System.Windows.Forms.Button ENCUESTA;
        private System.Windows.Forms.Button PROYECTO;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelUsuario;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Button CONFIG;
        private System.Windows.Forms.Button RJM;
        private System.Windows.Forms.Button TICS;
        private System.Windows.Forms.Button ALUMNOS;
        private System.Windows.Forms.Button SALIDA;
        private panel panelBusqueda;
        private System.Windows.Forms.TextBox textBoxBusqueda;
        private System.Windows.Forms.Panel contenedor;
    }
}

