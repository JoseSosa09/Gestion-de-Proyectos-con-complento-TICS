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
            this.components = new System.ComponentModel.Container();
            this.textNombre = new System.Windows.Forms.TextBox();
            this.textEmail = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textApellido = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textNumeroControl = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.registrateMinimizar = new FontAwesome.Sharp.IconPictureBox();
            this.registrateCerrar = new FontAwesome.Sharp.IconPictureBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.registrateMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.registrateCerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // textNombre
            // 
            this.textNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.textNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textNombre.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textNombre.ForeColor = System.Drawing.Color.Gold;
            this.textNombre.Location = new System.Drawing.Point(49, 96);
            this.textNombre.Name = "textNombre";
            this.textNombre.Size = new System.Drawing.Size(182, 25);
            this.textNombre.TabIndex = 1;
            this.textNombre.Text = "NOMBRE";
            this.textNombre.Enter += new System.EventHandler(this.textNombre_Enter);
            this.textNombre.Leave += new System.EventHandler(this.textNombre_Leave);
            // 
            // textEmail
            // 
            this.textEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.textEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textEmail.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEmail.ForeColor = System.Drawing.Color.Gold;
            this.textEmail.Location = new System.Drawing.Point(49, 160);
            this.textEmail.Name = "textEmail";
            this.textEmail.Size = new System.Drawing.Size(376, 25);
            this.textEmail.TabIndex = 3;
            this.textEmail.Text = "EMAIL";
            this.textEmail.Enter += new System.EventHandler(this.textEmail_Enter);
            this.textEmail.Leave += new System.EventHandler(this.textEmail_Leave);
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
            this.textPassword.Location = new System.Drawing.Point(49, 288);
            this.textPassword.Name = "textPassword";
            this.textPassword.Size = new System.Drawing.Size(376, 25);
            this.textPassword.TabIndex = 5;
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
            this.textApellido.Location = new System.Drawing.Point(243, 96);
            this.textApellido.Name = "textApellido";
            this.textApellido.Size = new System.Drawing.Size(182, 25);
            this.textApellido.TabIndex = 2;
            this.textApellido.Text = "APELLIDO";
            this.textApellido.Enter += new System.EventHandler(this.textApellido_Enter);
            this.textApellido.Leave += new System.EventHandler(this.textApellido_Leave);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
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
            this.textNumeroControl.Location = new System.Drawing.Point(49, 222);
            this.textNumeroControl.Name = "textNumeroControl";
            this.textNumeroControl.Size = new System.Drawing.Size(376, 25);
            this.textNumeroControl.TabIndex = 4;
            this.textNumeroControl.Text = "NUMERO CONTROL";
            this.textNumeroControl.Enter += new System.EventHandler(this.textNumeroControl_Enter);
            this.textNumeroControl.Leave += new System.EventHandler(this.textNumeroControl_Leave);
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnAceptar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAceptar.FlatAppearance.BorderSize = 0;
            this.btnAceptar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnAceptar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptar.ForeColor = System.Drawing.Color.Transparent;
            this.btnAceptar.Location = new System.Drawing.Point(87, 359);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(289, 35);
            this.btnAceptar.TabIndex = 0;
            this.btnAceptar.Text = "ACEPTAR";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
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
            this.textBox5.Location = new System.Drawing.Point(49, 226);
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
            this.textBox9.Location = new System.Drawing.Point(49, 292);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(417, 25);
            this.textBox9.TabIndex = 24;
            this.textBox9.TabStop = false;
            this.textBox9.Text = "_______________________________________________";
            // 
            // REGISTRO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(465, 489);
            this.Controls.Add(this.registrateMinimizar);
            this.Controls.Add(this.registrateCerrar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.textNumeroControl);
            this.Controls.Add(this.textApellido);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textPassword);
            this.Controls.Add(this.textEmail);
            this.Controls.Add(this.textNombre);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox9);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "REGISTRO";
            this.Opacity = 0.85D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "REGISTRO";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.REGISTRO_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.registrateMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.registrateCerrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textNombre;
        private System.Windows.Forms.TextBox textEmail;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textApellido;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textNumeroControl;
        private System.Windows.Forms.Button btnAceptar;
        private FontAwesome.Sharp.IconPictureBox registrateMinimizar;
        private FontAwesome.Sharp.IconPictureBox registrateCerrar;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox9;
    }
}