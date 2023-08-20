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
using CapaNegocio;
using CapaEntidad;


namespace RJM.formsRJM
{
    public partial class formInsertarServicioSocial : Form
    {
        ErrorProvider errorProvider1 = new ErrorProvider();
        public formInsertarServicioSocial()
        {
            InitializeComponent();
        }

        //Mover Panel Titulo
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
       
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            CN_ServicioSocial social = new CN_ServicioSocial();                        
            string responsable = validarResponsable(tBResponsable.Text);
            string categoria = validarCategoria(tBCategoria.Text);

            if (responsable != "false")
            {
                if (tBNombre.Text.Length > 0 && tBResponsable.Text.Length > 0 && tbDepartamento.Text.Length > 0 && tBPuesto.Text.Length > 0)
                {
                    int idPI = Convert.ToInt32(tBId.Text); //idProyectoIntegrador que se insertara
                    List<ServicioSocial> buscarID = social.BuscarID(idPI); //Verificando si se encuentra en la BD
                    int idForeach = 0;

                    foreach (ServicioSocial item in buscarID)
                    {
                        idForeach = item.idProyectoPropuesta;
                    }

                    if (idPI == idForeach)
                    {
                        MessageBox.Show("Este proyecto ya ha sido registrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);                                                                
                    }
                    else
                    {
                        try
                        {
                            social.RegistrarServicio(tBId.Text, tbDepartamento.Text, tBJefe.Text, tBResponsable.Text, tBPuesto.Text, tBNombre.Text, categoria);
                            MessageBox.Show("Se ha insertado de manera correcta", "CORRECTO", MessageBoxButtons.OK);
                            limpiar();
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Alumno solo acepta números", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Rellene todos los campos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
        private string validarCategoria(string categoria)
        {
            if (categoria == "Residencia y Servicio Social")
           {                
                return "*/*";
            }
            else if (categoria == "Residencia, Proyecto Integrador y Servicio Social")
            {
                return "***";
            }
            else
            {
                MessageBox.Show("No entra en la categoria de Proyecto Integrador ", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return "false";
            }
        }

        private string validarResponsable(string responsable)
        {
            if (responsable.ToLower() == "rosa delia retiz rivera")
            {
                return "Rosa Delia Retiz Rivera";
            }
            else if (tBResponsable.Text.ToLower() == "martha laura chuey rubio")
            {
                return "Martha Laura Chuey Rubio";
            }
            else
            {
                MessageBox.Show("Ese maestro no se encuentra en el sistema. Escriba el nombre completo (Rosa Delia Retiz Rivera)", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return "false";
            }
        }

        private void limpiar()
        {
            tBId.Text = "";
            tbDepartamento.Text = "";
            tBCategoria.Text = "";
            tBJefe.Text = "";            
            tBResponsable.Text = "";
            tBPuesto.Text = "";
            tBNombre.Text = "";
        }
        private void validarComboBox(object sender, CancelEventArgs e)
        {

        }

        private void validandoComboBox(object sender, EventArgs e)
        {
            ComboBox tB = (ComboBox)sender;
            errorProvider1.SetError(tB, "");
        }

        private void validarTextBox(object sender, CancelEventArgs e)
        {
            TextBox tB = (TextBox)sender;

            if (tB.Text == "")
            {
                e.Cancel = true;
                tB.Select(0, tB.Text.Length);
                errorProvider1.SetError(tB, "Debe rellenar este campo");
            }
        }

        private void validandoTextBox(object sender, EventArgs e)
        {
            TextBox tB = (TextBox)sender;
            errorProvider1.SetError(tB, "");
        }

        private void registrateCerrar_Click(object sender, EventArgs e)
        {
            this.AutoValidate = AutoValidate.EnableAllowFocusChange;
            Close();
        }

        private void registrateMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void formInsertarServicioSocial_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
     
    }
}
