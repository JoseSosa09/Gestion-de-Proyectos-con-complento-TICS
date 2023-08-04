using System.Net;
using System.Net.Mail;
using CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Word;
using System.Xml.Linq;

namespace RJM.formLogin
{
    public partial class formRecuperarContraseña : Form
    {
        public String clave = "";
        public formRecuperarContraseña()
        {
            InitializeComponent();
        }

        private void btnContinuar_Click(object sender, EventArgs e)
        {
            CN_Files recuperarclave = new CN_Files();
            LOGIN login = new LOGIN();
            
            try
            {
                clave = recuperarclave.RecuperarClave(textTelefono.Text, textNumeroControl.Text, textEmail.Text);

                if(clave.Length < 2)
                {
                    MessageBox.Show("No coninciden las credenciales", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {                    
                    MessageBox.Show("Tu contraseña es: " + clave, "Datos Correctos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch(Exception ex)
            {

            }
            this.Hide();
            login.Show();
        }


        private void registrateCerrar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Estás seguro de cerrar la ventana?", "Cerrar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                Close();
            }
        }

        private void registrateMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        //Mover Panel Titulo
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void panelDPersonales_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
