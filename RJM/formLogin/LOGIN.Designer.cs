namespace RJM
{
    partial class LOGIN
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LOGIN));
            this.panel1 = new System.Windows.Forms.Panel();
            this.linkRegistrarme = new System.Windows.Forms.LinkLabel();
            this.loginMinimizar = new FontAwesome.Sharp.IconPictureBox();
            this.loginCerrar = new FontAwesome.Sharp.IconPictureBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.btnAcceder = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textUser = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textPassword = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loginMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginCerrar)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.panel1.Controls.Add(this.textPassword);
            this.panel1.Controls.Add(this.linkRegistrarme);
            this.panel1.Controls.Add(this.loginMinimizar);
            this.panel1.Controls.Add(this.loginCerrar);
            this.panel1.Controls.Add(this.linkLabel1);
            this.panel1.Controls.Add(this.btnAcceder);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBox3);
            this.panel1.Controls.Add(this.textUser);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Location = new System.Drawing.Point(334, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(466, 373);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // linkRegistrarme
            // 
            this.linkRegistrarme.ActiveLinkColor = System.Drawing.SystemColors.MenuHighlight;
            this.linkRegistrarme.AutoSize = true;
            this.linkRegistrarme.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkRegistrarme.LinkColor = System.Drawing.Color.Red;
            this.linkRegistrarme.Location = new System.Drawing.Point(193, 328);
            this.linkRegistrarme.Name = "linkRegistrarme";
            this.linkRegistrarme.Size = new System.Drawing.Size(81, 16);
            this.linkRegistrarme.TabIndex = 0;
            this.linkRegistrarme.TabStop = true;
            this.linkRegistrarme.Text = "Registrarme";
            this.linkRegistrarme.VisitedLinkColor = System.Drawing.Color.Red;
            this.linkRegistrarme.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkRegistrarme_LinkClicked);
            // 
            // loginMinimizar
            // 
            this.loginMinimizar.BackColor = System.Drawing.Color.Transparent;
            this.loginMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginMinimizar.ForeColor = System.Drawing.Color.DarkGray;
            this.loginMinimizar.IconChar = FontAwesome.Sharp.IconChar.Minus;
            this.loginMinimizar.IconColor = System.Drawing.Color.DarkGray;
            this.loginMinimizar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.loginMinimizar.Location = new System.Drawing.Point(397, 2);
            this.loginMinimizar.Name = "loginMinimizar";
            this.loginMinimizar.Size = new System.Drawing.Size(32, 32);
            this.loginMinimizar.TabIndex = 8;
            this.loginMinimizar.TabStop = false;
            this.loginMinimizar.Click += new System.EventHandler(this.loginMinimizar_Click);
            // 
            // loginCerrar
            // 
            this.loginCerrar.BackColor = System.Drawing.Color.Transparent;
            this.loginCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginCerrar.ForeColor = System.Drawing.Color.DarkGray;
            this.loginCerrar.IconChar = FontAwesome.Sharp.IconChar.X;
            this.loginCerrar.IconColor = System.Drawing.Color.DarkGray;
            this.loginCerrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.loginCerrar.Location = new System.Drawing.Point(431, 2);
            this.loginCerrar.Name = "loginCerrar";
            this.loginCerrar.Size = new System.Drawing.Size(32, 32);
            this.loginCerrar.TabIndex = 7;
            this.loginCerrar.TabStop = false;
            this.loginCerrar.Click += new System.EventHandler(this.loginCerrar_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.ActiveLinkColor = System.Drawing.SystemColors.MenuHighlight;
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkLabel1.LinkColor = System.Drawing.Color.DarkGray;
            this.linkLabel1.Location = new System.Drawing.Point(141, 291);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(186, 16);
            this.linkLabel1.TabIndex = 4;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "¿Has olvidado la contraseña?";
            this.linkLabel1.VisitedLinkColor = System.Drawing.Color.Red;
            // 
            // btnAcceder
            // 
            this.btnAcceder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnAcceder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAcceder.FlatAppearance.BorderSize = 0;
            this.btnAcceder.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnAcceder.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAcceder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAcceder.ForeColor = System.Drawing.Color.LightGray;
            this.btnAcceder.Location = new System.Drawing.Point(98, 230);
            this.btnAcceder.Name = "btnAcceder";
            this.btnAcceder.Size = new System.Drawing.Size(289, 35);
            this.btnAcceder.TabIndex = 3;
            this.btnAcceder.Text = "ACCEDER";
            this.btnAcceder.UseVisualStyleBackColor = false;
            this.btnAcceder.Click += new System.EventHandler(this.btnAcceder_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightGray;
            this.label1.Location = new System.Drawing.Point(153, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 57);
            this.label1.TabIndex = 0;
            this.label1.Text = "LOGIN";
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label1_MouseDown);
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Enabled = false;
            this.textBox3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.ForeColor = System.Drawing.Color.DarkGray;
            this.textBox3.Location = new System.Drawing.Point(98, 171);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(341, 25);
            this.textBox3.TabIndex = 6;
            this.textBox3.TabStop = false;
            this.textBox3.Text = "____________________________________";
            // 
            // textUser
            // 
            this.textUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.textUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textUser.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textUser.ForeColor = System.Drawing.Color.DimGray;
            this.textUser.Location = new System.Drawing.Point(98, 106);
            this.textUser.Name = "textUser";
            this.textUser.Size = new System.Drawing.Size(289, 25);
            this.textUser.TabIndex = 1;
            this.textUser.Text = "USUARIO";
            this.textUser.Enter += new System.EventHandler(this.textUser_Enter);
            this.textUser.Leave += new System.EventHandler(this.textUser_Leave);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(337, 369);
            this.panel2.TabIndex = 9;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(-97, -1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(505, 135);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox2_MouseDown);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 106);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(334, 343);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            // 
            // textPassword
            // 
            this.textPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.textPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textPassword.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textPassword.ForeColor = System.Drawing.Color.DimGray;
            this.textPassword.Location = new System.Drawing.Point(98, 167);
            this.textPassword.Name = "textPassword";
            this.textPassword.Size = new System.Drawing.Size(289, 25);
            this.textPassword.TabIndex = 2;
            this.textPassword.Text = "PASSWORD";
            this.textPassword.Enter += new System.EventHandler(this.textPassword_Enter);
            this.textPassword.Leave += new System.EventHandler(this.textPassword_Leave);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.DarkGray;
            this.textBox1.Location = new System.Drawing.Point(98, 110);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(341, 25);
            this.textBox1.TabIndex = 9;
            this.textBox1.TabStop = false;
            this.textBox1.Text = "____________________________________";
            // 
            // LOGIN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 369);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LOGIN";
            this.Opacity = 0.85D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LOGIN";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loginMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginCerrar)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button btnAcceder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textUser;
        private FontAwesome.Sharp.IconPictureBox loginCerrar;
        private FontAwesome.Sharp.IconPictureBox loginMinimizar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.LinkLabel linkRegistrarme;
        private System.Windows.Forms.TextBox textPassword;
        private System.Windows.Forms.TextBox textBox1;
    }
}