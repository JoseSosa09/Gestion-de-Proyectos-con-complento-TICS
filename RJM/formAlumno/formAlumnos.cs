using CapaEntidad;
using CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Windows.Forms;
using RJM.formsRJM;

namespace RJM
{
    public partial class formAlumnos : Form
    {
        public formAlumnos()
        {
            InitializeComponent();
        }

        private void formAlumnos_Load(object sender, EventArgs e)
        {
            cargarDatos();
        }

        public void cargarDatos()
        {
            String maestro = ConfigurationManager.AppSettings["maestro"];
            CN_Alumno alumno = new CN_Alumno();           
            List<Alumno> listAlumno = alumno.Listar_X_Maestro(maestro);

            foreach (Alumno item in listAlumno)
            {
                dgvTodas.Rows.Add(new object[] {item.id, item.nombre, item.numeroControl,item.telefono, item.materia, item.email,
                    item.fechaCreacion,""});
            }
        }

        private void textBoxBuscar_KeyUp(object sender, KeyEventArgs e)
        {
            string dato = "%" + textBoxBuscar.Text + "%";
            MostrarBusqueda(dato);
        }
        public void MostrarBusqueda(string dato)
        {
            if(textBoxBuscar.Text.Length > 1)
            {
                dgvTodas.Rows.Clear();
                List<Alumno> lista = new CN_Alumno().Listar_X_Palabra(dato);

                foreach (Alumno item in lista)
                {
                    dgvTodas.Rows.Add(new object[] {item.id,item.nombre, item.numeroControl,item.telefono, item.materia, item.email,
                    item.fechaCreacion,""});
                }
            }

            else
            {
                dgvTodas.Rows.Clear();

                cargarDatos();
            }
            
        }

        private void dgvTodas_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            if (e.ColumnIndex == 7)
            {

                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                var w2 = Properties.Resources.reload.Width;
                var h2 = Properties.Resources.reload.Height;

                var x2 = e.CellBounds.Left + (e.CellBounds.Width - w2) / 2;
                var y2 = e.CellBounds.Top + (e.CellBounds.Height - h2) / 2;

                e.Graphics.DrawImage(Properties.Resources.reload, new Rectangle(x2, y2, w2, h2));
                e.Handled = true;
            }
        }

        private void dgvTodas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvTodas.Columns[e.ColumnIndex].Name == "informacionAlumno")
            {
                formInfoAlumno form = new formInfoAlumno();
                int indice = e.RowIndex;                
                if (indice >= 0)
                {
                    String id = dgvTodas.Rows[indice].Cells["id"].Value?.ToString();

                    if (id != null)
                    {
                        form.tBId.Text = dgvTodas.Rows[indice].Cells["id"].Value.ToString();                        
                        form.tBNombre.Text = dgvTodas.Rows[indice].Cells["nombre"].Value.ToString();
                        form.tBMateria.Text = dgvTodas.Rows[indice].Cells["materia"].Value.ToString();
                        form.tBNumeroControl.Text = dgvTodas.Rows[indice].Cells["numeroControl"].Value.ToString();
                        

                        form.Show();

                        //MostrarDatos();
                    }
                    else
                    {
                        MessageBox.Show("No ha seleccionado ninguna propuesta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
