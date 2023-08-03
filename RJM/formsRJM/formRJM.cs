using RJM.formRJM;
using System;
using System.Drawing;
using System.Windows.Forms;


namespace RJM
{
    public partial class FormRJM : Form
    {
        private static Button MenuActivo = null;
        private static Form FormularioActivo = null;
        private static bool Help = false;

        public FormRJM()
        {
            InitializeComponent();
            SidePanel.Width = btnPropuestas.Width;
            SidePanel.Left = btnPropuestas.Left;
        }

        public void abrirFormulario(Button menu, Form form)
        {            
                
            if( Help == false)
            {
                btnPropuestas.BackColor = Color.Black;
                btnPropuestas.ForeColor = Color.Gold;
            }

            if (MenuActivo != null)
            {
                MenuActivo.BackColor = Color.Black;
                MenuActivo.ForeColor = Color.Gold;                
            }

            if(menu != null)
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
        private void btnPropuestas_Click(object sender, EventArgs e)
        {            
            abrirFormulario((Button)sender, new formPropuestas());
            SidePanel.Width = btnPropuestas.Width;
            SidePanel.Left = btnPropuestas.Left;
        }

        private void btnResidencias_Click(object sender, EventArgs e)
        {         
            abrirFormulario((Button)sender, new formProgramaResidencias());
            SidePanel.Width = btnResidencias.Width;
            SidePanel.Left = btnResidencias.Left;
        }

        private void btnServicioSocial_Click(object sender, EventArgs e)
        {         
            abrirFormulario((Button)sender, new formProgramaServicioSocial());
            SidePanel.Width = btnServicioSocial.Width;
            SidePanel.Left = btnServicioSocial.Left;
        }

        private void btnProyectoIntegrador_Click(object sender, EventArgs e)
        {            
            abrirFormulario((Button)sender, new formProyectoIntegrador());
            SidePanel.Width = btnProyectoIntegrador.Width;
            SidePanel.Left = btnProyectoIntegrador.Left;
        }

        private void FormRJM_Load(object sender, EventArgs e)
        {
            inicioFormulario(new formPropuestas());
        }
    }
}
