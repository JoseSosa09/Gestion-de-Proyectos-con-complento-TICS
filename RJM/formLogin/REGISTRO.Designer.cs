namespace RJM
{
    partial class REGISTRO
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
            this.textNombre = new System.Windows.Forms.TextBox();
            this.textTelefono = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textApellido = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textNumeroControl = new System.Windows.Forms.TextBox();
            this.btnContinuar = new System.Windows.Forms.Button();
            this.registrateMinimizar = new FontAwesome.Sharp.IconPictureBox();
            this.registrateCerrar = new FontAwesome.Sharp.IconPictureBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textEmail = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.panelDPersonales = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.registrateMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.registrateCerrar)).BeginInit();
            this.panelDPersonales.SuspendLayout();
            this.SuspendLayout();
            // 
            // textNombre
            // 
            this.textNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.textNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textNombre.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textNombre.ForeColor = System.Drawing.Color.Gold;
            this.textNombre.Location = new System.Drawing.Point(49, 96);
            this.textNombre.MaxLength = 35;
            this.textNombre.Name = "textNombre";
            this.textNombre.Size = new System.Drawing.Size(169, 25);
            this.textNombre.TabIndex = 1;
            this.textNombre.Text = "NOMBRE";
            this.textNombre.Enter += new System.EventHandler(this.textNombre_Enter);
            this.textNombre.Leave += new System.EventHandler(this.textNombre_Leave);
            this.textNombre.Validating += new System.ComponentModel.CancelEventHandler(this.validating);
            // 
            // textTelefono
            // 
            this.textTelefono.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.textTelefono.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textTelefono.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textTelefono.ForeColor = System.Drawing.Color.Gold;
            this.textTelefono.Location = new System.Drawing.Point(49, 160);
            this.textTelefono.MaxLength = 10;
            this.textTelefono.Name = "textTelefono";
            this.textTelefono.Size = new System.Drawing.Size(376, 25);
            this.textTelefono.TabIndex = 3;
            this.textTelefono.Text = "TELEFONO";
            this.textTelefono.Enter += new System.EventHandler(this.textTelefono_Enter);
            this.textTelefono.Leave += new System.EventHandler(this.textTelefono_Leave);
            this.textTelefono.Validating += new System.ComponentModel.CancelEventHandler(this.validating);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Enabled = false;
            this.textBox2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.Color.DarkGray;
            this.textBox2.Location = new System.Drawing.Point(49, 100);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(182, 25);
            this.textBox2.TabIndex = 10;
            this.textBox2.TabStop = false;
            this.textBox2.Text = "_________________________________";
            // 
            // textPassword
            // 
            this.textPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.textPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textPassword.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textPassword.ForeColor = System.Drawing.Color.Gold;
            this.textPassword.Location = new System.Drawing.Point(48, 334);
            this.textPassword.MaxLength = 15;
            this.textPassword.Name = "textPassword";
            this.textPassword.Size = new System.Drawing.Size(376, 25);
            this.textPassword.TabIndex = 6;
            this.textPassword.Text = "PASSWORD";
            this.textPassword.Enter += new System.EventHandler(this.textPassword_Enter);
            this.textPassword.Leave += new System.EventHandler(this.textPassword_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(137, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 34);
            this.label1.TabIndex = 13;
            this.label1.Text = "REGISTRATE";
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label1_MouseDown);
            // 
            // textApellido
            // 
            this.textApellido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.textApellido.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textApellido.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textApellido.ForeColor = System.Drawing.Color.Gold;
            this.textApellido.Location = new System.Drawing.Point(240, 96);
            this.textApellido.MaxLength = 45;
            this.textApellido.Name = "textApellido";
            this.textApellido.Size = new System.Drawing.Size(188, 25);
            this.textApellido.TabIndex = 2;
            this.textApellido.Text = "APELLIDO";
            this.textApellido.Enter += new System.EventHandler(this.textApellido_Enter);
            this.textApellido.Leave += new System.EventHandler(this.textApellido_Leave);
            this.textApellido.Validating += new System.ComponentModel.CancelEventHandler(this.validating);
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox6.Enabled = false;
            this.textBox6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox6.ForeColor = System.Drawing.Color.DarkGray;
            this.textBox6.Location = new System.Drawing.Point(49, 164);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(417, 25);
            this.textBox6.TabIndex = 16;
            this.textBox6.TabStop = false;
            this.textBox6.Text = "_______________________________________________";
            // 
            // textBox7
            // 
            this.textBox7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.textBox7.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox7.Enabled = false;
            this.textBox7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox7.ForeColor = System.Drawing.Color.DarkGray;
            this.textBox7.Location = new System.Drawing.Point(237, 100);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(188, 25);
            this.textBox7.TabIndex = 17;
            this.textBox7.TabStop = false;
            this.textBox7.Text = "_________________________________";
            // 
            // textNumeroControl
            // 
            this.textNumeroControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.textNumeroControl.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textNumeroControl.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textNumeroControl.ForeColor = System.Drawing.Color.Gold;
            this.textNumeroControl.Location = new System.Drawing.Point(49, 216);
            this.textNumeroControl.MaxLength = 8;
            this.textNumeroControl.Name = "textNumeroControl";
            this.textNumeroControl.Size = new System.Drawing.Size(376, 25);
            this.textNumeroControl.TabIndex = 4;
            this.textNumeroControl.Text = "NUMERO CONTROL";
            this.textNumeroControl.Enter += new System.EventHandler(this.textNumeroControl_Enter);
            this.textNumeroControl.Leave += new System.EventHandler(this.textNumeroControl_Leave);
            this.textNumeroControl.Validating += new System.ComponentModel.CancelEventHandler(this.validating);
            // 
            // btnContinuar
            // 
            this.btnContinuar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnContinuar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnContinuar.FlatAppearance.BorderSize = 0;
            this.btnContinuar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnContinuar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnContinuar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnContinuar.ForeColor = System.Drawing.Color.Transparent;
            this.btnContinuar.Location = new System.Drawing.Point(87, 411);
            this.btnContinuar.Name = "btnContinuar";
            this.btnContinuar.Size = new System.Drawing.Size(289, 35);
            this.btnContinuar.TabIndex = 0;
            this.btnContinuar.Text = "CONTINUAR";
            this.btnContinuar.UseVisualStyleBackColor = false;
            this.btnContinuar.Click += new System.EventHandler(this.btnContinuar_Click);
            // 
            // registrateMinimizar
            // 
            this.registrateMinimizar.BackColor = System.Drawing.Color.Transparent;
            this.registrateMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.registrateMinimizar.ForeColor = System.Drawing.Color.DarkGray;
            this.registrateMinimizar.IconChar = FontAwesome.Sharp.IconChar.Minus;
            this.registrateMinimizar.IconColor = System.Drawing.Color.DarkGray;
            this.registrateMinimizar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.registrateMinimizar.Location = new System.Drawing.Point(400, 1);
            this.registrateMinimizar.Name = "registrateMinimizar";
            this.registrateMinimizar.Size = new System.Drawing.Size(32, 32);
            this.registrateMinimizar.TabIndex = 22;
            this.registrateMinimizar.TabStop = false;
            this.registrateMinimizar.Click += new System.EventHandler(this.registrateMinimizar_Click);
            // 
            // registrateCerrar
            // 
            this.registrateCerrar.BackColor = System.Drawing.Color.Transparent;
            this.registrateCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.registrateCerrar.ForeColor = System.Drawing.Color.DarkGray;
            this.registrateCerrar.IconChar = FontAwesome.Sharp.IconChar.X;
            this.registrateCerrar.IconColor = System.Drawing.Color.DarkGray;
            this.registrateCerrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.registrateCerrar.Location = new System.Drawing.Point(434, 1);
            this.registrateCerrar.Name = "registrateCerrar";
            this.registrateCerrar.Size = new System.Drawing.Size(32, 32);
            this.registrateCerrar.TabIndex = 21;
            this.registrateCerrar.TabStop = false;
            this.registrateCerrar.Click += new System.EventHandler(this.registrateCerrar_Click);
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox5.Enabled = false;
            this.textBox5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.ForeColor = System.Drawing.Color.DarkGray;
            this.textBox5.Location = new System.Drawing.Point(49, 220);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(417, 25);
            this.textBox5.TabIndex = 23;
            this.textBox5.TabStop = false;
            this.textBox5.Text = "_______________________________________________";
            // 
            // textBox9
            // 
            this.textBox9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.textBox9.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox9.Enabled = false;
            this.textBox9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox9.ForeColor = System.Drawing.Color.DarkGray;
            this.textBox9.Location = new System.Drawing.Point(48, 338);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(417, 25);
            this.textBox9.TabIndex = 24;
            this.textBox9.TabStop = false;
            this.textBox9.Text = "_______________________________________________";
            // 
            // textEmail
            // 
            this.textEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.textEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textEmail.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEmail.ForeColor = System.Drawing.Color.Gold;
            this.textEmail.Location = new System.Drawing.Point(48, 272);
            this.textEmail.MaxLength = 32;
            this.textEmail.Name = "textEmail";
            this.textEmail.Size = new System.Drawing.Size(376, 25);
            this.textEmail.TabIndex = 5;
            this.textEmail.Text = "EMAIL";
            this.textEmail.Enter += new System.EventHandler(this.tBEmail_Enter);
            this.textEmail.Leave += new System.EventHandler(this.tBEmail_Leave);
            this.textEmail.Validating += new System.ComponentModel.CancelEventHandler(this.validating);
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Enabled = false;
            this.textBox3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.ForeColor = System.Drawing.Color.DarkGray;
            this.textBox3.Location = new System.Drawing.Point(48, 276);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(417, 25);
            this.textBox3.TabIndex = 26;
            this.textBox3.TabStop = false;
            this.textBox3.Text = "_______________________________________________";
            // 
            // panelDPersonales
            // 
            this.panelDPersonales.Controls.Add(this.textApellido);
            this.panelDPersonales.Controls.Add(this.registrateCerrar);
            this.panelDPersonales.Controls.Add(this.textEmail);
            this.panelDPersonales.Controls.Add(this.textBox3);
            this.panelDPersonales.Controls.Add(this.registrateMinimizar);
            this.panelDPersonales.Controls.Add(this.label1);
            this.panelDPersonales.Controls.Add(this.btnContinuar);
            this.panelDPersonales.Controls.Add(this.textTelefono);
            this.panelDPersonales.Controls.Add(this.textNumeroControl);
            this.panelDPersonales.Controls.Add(this.textNombre);
            this.panelDPersonales.Controls.Add(this.textBox7);
            this.panelDPersonales.Controls.Add(this.textPassword);
            this.panelDPersonales.Controls.Add(this.textBox6);
            this.panelDPersonales.Controls.Add(this.textBox2);
            this.panelDPersonales.Controls.Add(this.textBox5);
            this.panelDPersonales.Controls.Add(this.textBox9);
            this.panelDPersonales.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDPersonales.Location = new System.Drawing.Point(0, 0);
            this.panelDPersonales.Name = "panelDPersonales";
            this.panelDPersonales.Size = new System.Drawing.Size(465, 489);
            this.panelDPersonales.TabIndex = 27;
            this.panelDPersonales.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label1_MouseDown);
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(465, 489);
            this.panel1.TabIndex = 27;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label1_MouseDown);
            // 
            // REGISTRO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(465, 489);
            this.Controls.Add(this.panelDPersonales);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "REGISTRO";
            this.Opacity = 0.85D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "REGISTRO";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.REGISTRO_FormClosing);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.REGISTRO_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.registrateMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.registrateCerrar)).EndInit();
            this.panelDPersonales.ResumeLayout(false);
            this.panelDPersonales.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox textNombre;
        private System.Windows.Forms.TextBox textTelefono;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textApellido;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textNumeroControl;
        private System.Windows.Forms.Button btnContinuar;
        private FontAwesome.Sharp.IconPictureBox registrateMinimizar;
        private FontAwesome.Sharp.IconPictureBox registrateCerrar;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textEmail;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Panel panelDPersonales;
        private System.Windows.Forms.Panel panel1;
    }
}