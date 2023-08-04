using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaEntidad;
using CapaNegocio;
using RJM.formProyecto;

namespace RJM
{
    public partial class formProyectos : Form
    {
        private static Button MenuActivo = null;
        private static Form FormularioActivo = null;
        private static bool Help = false;
        public Maestro maestro;

        public formProyectos(Maestro maestro)
        {
            InitializeComponent();
            SidePanel.Width = btnAlumnos.Width;
            SidePanel.Left = btnAlumnos.Left;
            this.maestro = maestro; 
        }

        public void abrirFormulario(Button menu, Form form)
        {

            if (Help == false)
            {
                btnAlumnos.BackColor = Color.Black;
                btnAlumnos.ForeColor = Color.Gold;
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

        private void btnAlumnos_Click(object sender, EventArgs e)
        {
            abrirFormulario((Button)sender, new formAlumnosArchivos(maestro));
            SidePanel.Width = btnAlumnos.Width;
            SidePanel.Left = btnAlumnos.Left;
        }

        private void btnArchivos_Click(object sender, EventArgs e)
        {
            abrirFormulario((Button)sender, new RJM.formProyecto.formArchivos(maestro));
            SidePanel.Width = btnArchivos.Width;
            SidePanel.Left = btnArchivos.Left;
        }

        private void formProyecto_Load(object sender, EventArgs e)
        {
            inicioFormulario(new RJM.formProyecto.formAlumnosArchivos(maestro));
        }
    }
}
