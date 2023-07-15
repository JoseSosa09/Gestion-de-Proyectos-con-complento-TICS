using System;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using CapaNegocio;
using CapaEntidad;
using System.Text.RegularExpressions;

namespace RJM
{
    public partial class REGISTRO : Form
    {
        private ErrorProvider errorProvider;

        public REGISTRO()
        {
            InitializeComponent();            
            errorProvider = new ErrorProvider();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            bool nombre = validarNombre(textNombre.Text);
            bool apellido = validarNombre(textApellido.Text);
            bool email = validarEmail(textEmail.Text);
            bool telefono = validarNumeroTelefono(textTelefono.Text);

            if (nombre && apellido && email && telefono)
            {
                MessageBox.Show("Con madres padrino");
            }

            try
            {
                //LOGIN login = new LOGIN();
                //CN_Usuario ousuario = new CN_Usuario();
                //CN_Alumno oalumno = new CN_Alumno();
                //oalumno.RegistrarAlumno(textNombre.Text, textApellido.Text, textTelefono.Text, textNumeroControl.Text, textPassword.Text);
                //MessageBox.Show("Se ha insertado de manera correcta", "CORRECTO", MessageBoxButtons.OK);
                //this.Hide();
                //login.Show();


            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo insertar" + ex.Message);
            }

        }

        private void validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            string id = textBox.Name; 
            string texto = textBox.Text;

            switch (id)
            {
                case "textNombre":
                    if(!validarNombre(texto) || texto=="NOMBRE")
                    {
                        errorProvider.SetError(textBox, "Nombre Incorrecto");
                        e.Cancel = true;
                    }
                    else
                    {
                        errorProvider.SetError(textBox, ""); // Eliminar el mensaje de error
                        e.Cancel= false;
                    }
                    break;
                case "textApellido":
                    if (!validarNombre(texto) || texto == "APELLIDO")
                    {
                        errorProvider.SetError(textBox, "Apellido Incorrecto");
                        e.Cancel = true;                        
                    }
                    else
                    {
                        errorProvider.SetError(textBox, ""); // Eliminar el mensaje de error
                        e.Cancel = false;
                    }
                    break;                    
                case "textTelefono":
                    if (!validarNumeroTelefono(texto) || texto == "TELEFONO")
                    {
                        errorProvider.SetError(textBox, "Numero Telefono Incorrecto");
                        e.Cancel = true;
                    }
                    else
                    {
                        errorProvider.SetError(textBox, ""); // Eliminar el mensaje de error
                        e.Cancel = false;
                    }
                    break;
                case "textNumeroControl":
                    if (!validarNumeroControl(texto) || texto == "NUMERO CONTORL")
                    {
                        errorProvider.SetError(textBox, "Numero Control Incorrecto");
                        e.Cancel = true;
                    }
                    else
                    {
                        errorProvider.SetError(textBox, ""); // Eliminar el mensaje de error
                        e.Cancel = false;
                    }
                    break;
                case "textEmail":
                    if (!validarEmail(texto) || texto == "EMAIL")
                    {
                        errorProvider.SetError(textBox, "Email Incorrecto");
                        e.Cancel = true;
                    }
                    else
                    {
                        errorProvider.SetError(textBox, ""); // Eliminar el mensaje de error
                        e.Cancel = false;
                    }
                    break;
            }        
        }

        private bool validarNombre(String nombre)
        {
            string patron = @"^[\p{L}\s\-']+$";
            return Regex.IsMatch(nombre, patron);
        }

        private bool validarEmail(String email)
        {
            string patron = @"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$";
            return Regex.IsMatch(email, patron);
        }

        private bool validarNumeroTelefono(String numeroTelefono)
        {
            string patron = @"^[0-9()+-]+$";
            return Regex.IsMatch(numeroTelefono, patron);
        }
        private bool validarNumeroControl(String numeroTelefono)
        {
            string patron = @"^\d{8}$";
            return Regex.IsMatch(numeroTelefono, patron);
        }


        private void textNombre_Enter(object sender, EventArgs e)
        {
            if (textNombre.Text == "NOMBRE")
            {
                textNombre.Text = "";
                textNombre.ForeColor = Color.White;
            }
            else
            {
                textNombre.ForeColor = Color.White;
            }
        }

        private void textNombre_Leave(object sender, EventArgs e)
        {
            if (textNombre.Text == "")
            {
                textNombre.Text = "NOMBRE";
                textNombre.ForeColor = Color.Gold;
            }
            else
            {
                textNombre.ForeColor = Color.White;
            }
        }

        private void textApellido_Enter(object sender, EventArgs e)
        {
            if (textApellido.Text == "APELLIDO")
            {
                textApellido.Text = "";
                textApellido.ForeColor = Color.White;
            }
            else
            {
                textApellido.ForeColor = Color.White;
            }
        }

        private void textApellido_Leave(object sender, EventArgs e)
        {
            if (textApellido.Text == "")
            {
                textApellido.Text = "APELLIDO";
                textApellido.ForeColor = Color.Gold;
            }
            else
            {
                textApellido.ForeColor = Color.White;
            }
        }

        private void textTelefono_Enter(object sender, EventArgs e)
        {
            if (textTelefono.Text == "TELEFONO")
            {
                textTelefono.Text = "";
                textTelefono.ForeColor = Color.White;
            }
            else
            {
                textTelefono.ForeColor = Color.White;
            }
        }

        private void textTelefono_Leave(object sender, EventArgs e)
        {
            if (textTelefono.Text == "")
            {
                textTelefono.Text = "TELEFONO";
                textTelefono.ForeColor = Color.Gold;
            }
            else
            {
                textTelefono.ForeColor = Color.White;
            }
        }

        private void textNumeroControl_Enter(object sender, EventArgs e)
        {
            if (textNumeroControl.Text == "NUMERO CONTROL")
            {
                textNumeroControl.Text = "";
                textNumeroControl.ForeColor = Color.White;
            }
            else
            {
                textNumeroControl.ForeColor = Color.White;
            }
        }

        private void textNumeroControl_Leave(object sender, EventArgs e)
        {
            if (textNumeroControl.Text == "")
            {
                textNumeroControl.Text = "NUMERO CONTROL";
                textNumeroControl.ForeColor = Color.Gold;
            }
            else
            {
                textNumeroControl.ForeColor = Color.White;
            }
        }
        private void tBEmail_Enter(object sender, EventArgs e)
        {
            if (textEmail.Text == "EMAIL")
            {
                textEmail.Text = "";
                textEmail.ForeColor = Color.White;
            }
            else
            {
                textEmail.ForeColor = Color.White;
            }
        }

        private void tBEmail_Leave(object sender, EventArgs e)
        {
            if (textEmail.Text == "")
            {
                textEmail.Text = "EMAIL";
                textEmail.ForeColor = Color.Gold;
            }
            else
            {
                textEmail.ForeColor = Color.White;
            }
        }

        private void textPassword_Enter(object sender, EventArgs e)
        {
            if (textPassword.Text == "PASSWORD")
            {
                textPassword.Text = "";
                textPassword.ForeColor = Color.White;
                textPassword.UseSystemPasswordChar = true;
            }
            else
            {
                textPassword.ForeColor = Color.White;
                textPassword.UseSystemPasswordChar = true;
            }
        }

        private void textPassword_Leave(object sender, EventArgs e)
        {
            if (textPassword.Text == "")
            {
                textPassword.Text = "PASSWORD";
                textPassword.ForeColor = Color.Gold;
                textPassword.UseSystemPasswordChar = false;
            }
            else
            {
                textPassword.ForeColor = Color.White;
                textPassword.UseSystemPasswordChar = true;
            }
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

        private void REGISTRO_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (errorProvider.GetError(textNombre) != "" ||
                errorProvider.GetError(textApellido) != "" ||
                errorProvider.GetError(textTelefono) != "" ||
                errorProvider.GetError(textNumeroControl) != "" ||
                errorProvider.GetError(textEmail) != "")
            {
                // Hay errores presentes en el ErrorProvider, cancelar el cierre del formulario
                e.Cancel = false;
            }
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

    }
}
