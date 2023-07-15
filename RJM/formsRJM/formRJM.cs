using RJM.formRJM;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace RJM
{
    public partial class FormRJM : Form
    {
        private static Button MenuActivo = null;
        private static Form FormularioActivo = null;

        public FormRJM()
        {
            InitializeComponent();
        }

        public void abrirFormulario(Button menu, Form form)
        {
            SidePanel.Visible = true;

            if (MenuActivo != null)
            {
                MenuActivo.BackColor = Color.Transparent;
                MenuActivo.ForeColor = Color.Gold;
                SidePanel.BackColor = Color.White;
                
            }
            menu.BackColor = Color.White;
            menu.ForeColor = Color.Black;
            SidePanel.BackColor = Color.Black;
            MenuActivo = menu;

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

        private void btnPropuestas_Click(object sender, EventArgs e)
        {
            SidePanel.Visible = true;
            abrirFormulario((Button)sender, new formPropuestas());
            SidePanel.Width = btnPropuestas.Width;
            SidePanel.Left = btnPropuestas.Left;
        }

        private void btnResidencias_Click(object sender, EventArgs e)
        {
            SidePanel.Visible = true;
            abrirFormulario((Button)sender, new formProgramaResidencias());
            SidePanel.Width = btnResidencias.Width;
            SidePanel.Left = btnResidencias.Left;
        }

        private void btnServicioSocial_Click(object sender, EventArgs e)
        {
            SidePanel.Visible = true;
            abrirFormulario((Button)sender, new formProgramaServicioSocial());
            SidePanel.Width = btnServicioSocial.Width;
            SidePanel.Left = btnServicioSocial.Left;
        }

        private void btnProyectoIntegrador_Click(object sender, EventArgs e)
        {
            SidePanel.Visible = true;
            abrirFormulario((Button)sender, new formProyectoIntegrador());
            SidePanel.Width = btnProyectoIntegrador.Width;
            SidePanel.Left = btnProyectoIntegrador.Left;
        }


    }
}
