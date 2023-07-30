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

namespace RJM.formsRJM.ControlProyectoIntegrador
{
    public partial class formEditar : Form
    {
        public formEditar()
        {
            InitializeComponent();
        }
        public void actualizar()
        {
            CN_ProyectoIntegrador integrador = new CN_ProyectoIntegrador();
            cBNombre.DisplayMember = "nombre";
            cBNombre.DataSource = integrador.CargarProgramaIntegrador();

            cBAlumno.DisplayMember = "nombre";
            cBAlumno.DataSource = integrador.CargarAlumno();

            cBModalidad.DisplayMember = "modalidad";
            cBModalidad.DataSource = integrador.CargarModalidad();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        //Mover Panel Titulo
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void label_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void bGuardar_Click(object sender, EventArgs e)
        {
            CN_ControlProyectoIntegrador editar = new CN_ControlProyectoIntegrador();

            try
            {
                editar.Update(cBAlumno.Text, cBModalidad.Text, cBNombre.Text);
                MessageBox.Show("Se ha actualizado de manera correcta", "Actualización Correcta!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void formEditar_Load(object sender, EventArgs e)
        {
            actualizar();
        }

        private void iconoCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void icnonoMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
