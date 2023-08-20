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
using RJM.formRJM;

namespace RJM.formsRJM
{
    public partial class formInsertarPropuesta : Form
    {
        ErrorProvider errorProvider1 = new ErrorProvider();

        public formInsertarPropuesta()
        {
            InitializeComponent();
            cBCategoria.DropDownStyle = ComboBoxStyle.DropDownList;
            cBEstatus.DropDownStyle = ComboBoxStyle.DropDownList;
            tBResponsable.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        //Mover Panel Titulo
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        
        
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            CN_ProyectoPropuesta propuesta = new CN_ProyectoPropuesta();            

            string categoria = validarCategoria(cBCategoria.Text);
            string responsable = validarResponsable(tBResponsable.Text);
            string estatus = validarEstatus(cBEstatus.Text);

             if(categoria != "false" & responsable != "false" & estatus != "false")
            {
                try
                {
                    propuesta.RegistrarPropuesta(categoria, cBEstatus.Text, tBNombre.Text, responsable, tBColaboradores.Text, tBDescripcion.Text);
                    MessageBox.Show("Se ha insertado de manera correcta", "CORRECTO", MessageBoxButtons.OK);
                    limpiar();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Complete los campos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }                     
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            CN_ProyectoPropuesta propuesta = new CN_ProyectoPropuesta();
            string categoria = validarCategoria(cBCategoria.Text);
            string responsable = validarResponsable(tBResponsable.Text);
            string estatus = validarEstatus(cBEstatus.Text);

            if (categoria != "false" & responsable != "false" & estatus != "false")
            {
                try
                {
                    propuesta.Update(tBId.Text, categoria, estatus, tBNombre.Text, responsable, tBColaboradores.Text,  tBDescripcion.Text);
                    MessageBox.Show("Se ha actualizado de manera correcta", "CORRECTO", MessageBoxButtons.OK);
                    limpiar();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Complete los campos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private string validarCategoria(string categoria)
        {            
            if (categoria == "Residencia y Servicio Social")
            {
                return "*/*";
            }
            else if (categoria == "Residencia y Proyecto integrador")
            {
                return "**";
            }
            else if (categoria == "Residencia, Proyecto Integrador y Servicio Social")
            {
                return "***";
            }

            else if (categoria == "Residencia")
            {
                return "*";
            }
            else
            {
                MessageBox.Show("CATEGORIA Solo se admite las opciones de la lista ", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private string validarEstatus(string estatus)
        {
            if (estatus != "R" & estatus != "A" & estatus != "T")
            {
                MessageBox.Show("Solo se admite T, A y R (Terminado, Activo y Registrado)", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return "false";
            }

            return "true";
        }
        private void limpiar()
        {
            cBCategoria.Text = "";
            cBEstatus.Text = "";
            tBNombre.Text = "";
            tBResponsable.Text = "";
            tBColaboradores.Text = "";
            tBAlumnos.Text = "";
            tBDescripcion.Text = "";
        }

        


        private void validarComboBox(object sender, CancelEventArgs e)
        {
            ComboBox tB = (ComboBox)sender;

            if (tB.Text == "")
            {                
                e.Cancel = true;
                tB.Select(0, tB.Text.Length);
                errorProvider1.SetError(tB, "Debe rellenar este campo");
            }
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

        private void formInsertarPropuesta_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);

        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void registrateMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void registrateCerrar_Click(object sender, EventArgs e)
        {
            this.AutoValidate = AutoValidate.Disable;
            Close();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
