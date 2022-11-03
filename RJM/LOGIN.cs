﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using CapaNegocio;
using CapaEntidad;
namespace RJM
{
    public partial class LOGIN : Form
    {
        public LOGIN()
        {
            InitializeComponent();

        }
        //Mover Panel Titulo
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        //MOVER LA VENTANA
        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void pictureBox2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }


        private void textUser_Enter(object sender, EventArgs e)
        {
            if (textUser.Text == "USUARIO")
            {
                textUser.Text = "";
                textUser.ForeColor = Color.LightGray;
            }
        }

        private void textUser_Leave(object sender, EventArgs e)
        {
            if (textUser.Text == "")
            {
                textUser.ForeColor = Color.DimGray;
                textUser.Text = "USUARIO";

            }
        }

        private void textPassword_Enter(object sender, EventArgs e)
        {
            if (textPassword.Text == "PASSWORD")
            {
                textPassword.ForeColor = Color.LightGray;
                textPassword.Text = "";
                textPassword.UseSystemPasswordChar = true;
            }
        }

        private void textPassword_Leave(object sender, EventArgs e)
        {
            if (textPassword.Text == "")
            {
                textPassword.UseSystemPasswordChar = false;
                textPassword.ForeColor = Color.DimGray;
                textPassword.Text = "PASSWORD";
            }
        }

        private void loginCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void loginMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnAcceder_Click(object sender, EventArgs e)
        {
            List<Usuario> TESTE = new CN_Usuario().Listar();

            Usuario ousuario = new CN_Usuario().Listar().Where(u => u.numeroControl == textUser.Text && u.clave == textPassword.Text).FirstOrDefault();

            if(ousuario != null)
            {
                PRINCIPAL form = new PRINCIPAL(ousuario);
                form.Show();
                this.Hide();
                form.FormClosing += formRegresarLoginPrincipal;
            }

            else
            {
                MessageBox.Show("No se ha encontrado el Usuario", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void formRegresarLoginPrincipal(object sender, FormClosingEventArgs e)
        {



            textUser.Text = "USUARIO";
            textPassword.UseSystemPasswordChar = false;
            textPassword.Text = "PASSWORD";
            this.Show();

        }

        private void formRegresarLoginRegistro(object sender, FormClosingEventArgs e)
        {
            textUser.Text = "USUARIO";
            textPassword.UseSystemPasswordChar = false;
            textPassword.Text = "PASSWORD";
            this.Show();

        }


        private void linkRegistrarme_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkRegistrarme.LinkVisited = true;
            REGISTRO registro = new REGISTRO();
            this.Hide();
            registro.Show();
            registro.FormClosing += formRegresarLoginRegistro;
        }


    }
}