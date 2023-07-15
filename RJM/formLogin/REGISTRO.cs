using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using CapaNegocio;
using CapaEntidad;

namespace RJM
{
    public partial class REGISTRO : Form
    {
        public REGISTRO()
        {
            InitializeComponent();
        }

        //Mover Panel Titulo
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        private void registrateCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void registrateMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized; 
        }

        private void REGISTRO_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void textNombre_Enter(object sender, EventArgs e)
        {
            if (textNombre.Text == "NOMBRE")
            {
                textNombre.Text = "";
                textNombre.ForeColor = Color.Gold;
            }
        }

        private void textNombre_Leave(object sender, EventArgs e)
        {
            if (textNombre.Text == "")
            {
                textNombre.Text = "NOMBRE";
                textNombre.ForeColor = Color.Gold;
            }
        }

        private void textApellido_Enter(object sender, EventArgs e)
        {
            if (textApellido.Text == "APELLIDO")
            {
                textApellido.Text = "";
                textApellido.ForeColor = Color.Gold;
            }
        }

        private void textApellido_Leave(object sender, EventArgs e)
        {
            if (textApellido.Text == "")
            {
                textApellido.Text = "APELLIDO";
                textApellido.ForeColor = Color.Gold;
            }
        }

        private void textEmail_Enter(object sender, EventArgs e)
        {
            if (textEmail.Text == "EMAIL")
            {
                textEmail.Text = "";
                textEmail.ForeColor = Color.Gold;
            }
        }

        private void textEmail_Leave(object sender, EventArgs e)
        {
            if (textEmail.Text == "")
            {
                textEmail.Text = "EMAIL";
                textEmail.ForeColor = Color.Gold;
            }
        }

        private void textNumeroControl_Enter(object sender, EventArgs e)
        {
            if (textNumeroControl.Text == "NUMERO CONTROL")
            {
                textNumeroControl.Text = "";
                textNumeroControl.ForeColor = Color.Gold;
            }
        }

        private void textNumeroControl_Leave(object sender, EventArgs e)
        {
            if (textNumeroControl.Text == "")
            {
                textNumeroControl.Text = "NUMERO CONTROL";
                textNumeroControl.ForeColor = Color.Gold;
            }
        }

        private void textPassword_Enter(object sender, EventArgs e)
        {
            if (textPassword.Text == "PASSWORD")
            {
                textPassword.UseSystemPasswordChar = true;
                textPassword.ForeColor = Color.Gold;
                textPassword.Text = "";
            }
        }

        private void textPassword_Leave(object sender, EventArgs e)
        {
            if (textPassword.Text == "")
            {
                textPassword.UseSystemPasswordChar = false;
                textPassword.ForeColor = Color.Gold;
                textPassword.Text = "PASSWORD";
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                LOGIN login = new LOGIN();
                CN_Usuario ousuario = new CN_Usuario();
                ousuario.RegistrarUsuario(textNombre.Text, textApellido.Text, textEmail.Text, textNumeroControl.Text, textPassword.Text);
                MessageBox.Show("Se ha insertado de manera correcta", "CORRECTO", MessageBoxButtons.OK);
                this.Hide();
                login.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo insertar" + ex.Message);        
            }

        }
    }
}
