using CapaEntidad;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RJM.formProyecto.formAlumno_Proyecto
{
    public partial class formProyectosAlumnos : Form
    {
        private static Button MenuActivo = null;
        private static Form FormularioActivo = null;
        private static bool Help = false;
        public Alumno usuario; 

        public formProyectosAlumnos(Alumno usuario)
        {
            InitializeComponent();
            SidePanel.Width = btnBajarArchivos.Width;
            SidePanel.Left = btnBajarArchivos.Left;
            this.usuario = usuario;
        }

        public void abrirFormulario(Button menu, Form form)
        {

            if (Help == false)
            {
                btnBajarArchivos.BackColor = Color.Black;
                btnBajarArchivos.ForeColor = Color.Gold;
            }

            if (MenuActivo != null)
            {
                MenuActivo.BackColor = Color.Black;
                MenuActivo.ForeColor = Color.Gold;
            }

            if (menu != null)
            {
                menu.BackColor = Color.White;
                menu.ForeColor = Color.Black;
                MenuActivo = menu;
                Help = true;
            }


            if (FormularioActivo != null)
            {
                FormularioActivo.Close();
            }

            FormularioActivo = form;
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            form.BackColor = Color.GhostWhite;
            contenedor.Controls.Add(form);
            form.Show();
        }

        private void inicioFormulario(Form form)
        {
            FormularioActivo = form;
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            form.BackColor = Color.GhostWhite;

            contenedor.Controls.Add(form);
            form.Show();
        }

        private void btnBajarArchivos_Click(object sender, EventArgs e)
        {
            abrirFormulario((Button)sender, new formBajarArchivos(usuario));
            SidePanel.Width = btnBajarArchivos.Width;
            SidePanel.Left = btnBajarArchivos.Left;
        }

        private void btnSubirArchivos_Click(object sender, EventArgs e)
        {
            abrirFormulario((Button)sender, new formSubirArchivos(usuario));
            SidePanel.Width = btnSubirArchivos.Width;
            SidePanel.Left = btnSubirArchivos.Left;
        }

        private void formProyectosAlumnos_Load(object sender, EventArgs e)
        {
            inicioFormulario(new formBajarArchivos(usuario));       
        }
    }
}
