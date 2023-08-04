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
using System.Runtime.Remoting.Messaging;

namespace RJM
{ 
    public partial class formAlumnos : Form
    {
        private String maestro = ConfigurationManager.AppSettings["maestro"];
        private CN_Alumno alumno = new CN_Alumno();
        private List<Alumno> listAlumno;

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

            listAlumno = alumno.Listar_X_Maestro(maestro);
            foreach (Alumno item in listAlumno)
            {
                dgvTodas.Rows.Add(new object[] {item.id, item.nombre, item.numeroControl,item.telefono, item.materia, item.proyecto, item.email,
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
                    dgvTodas.Rows.Add(new object[] {item.id,item.nombre, item.numeroControl,item.telefono, item.materia, item.proyecto, item.email,
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

            if (e.ColumnIndex == 8)
            {

                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                var w2 = Properties.Resources.reload.Width;
                var h2 = Properties.Resources.reload.Height;

                var x2 = e.CellBounds.Left + (e.CellBounds.Width - w2) / 2;
                var y2 = e.CellBounds.Top + (e.CellBounds.Height - h2) / 2;

                e.Graphics.DrawImage(Properties.Resources.reload, new Rectangle(x2, y2, w2, h2));
                e.Handled = true;
            }
            if (e.ColumnIndex == 9)
            {

                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                var w = Properties.Resources.x_button.Width;
                var h = Properties.Resources.x_button.Height;

                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                e.Graphics.DrawImage(Properties.Resources.x_button, new Rectangle(x, y, w, h));
                e.Handled = true;
            }
        }

        private void dgvTodas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            CN_Alumno alumno = new CN_Alumno();

            String numeroControl = "";
            if (dgvTodas.Columns[e.ColumnIndex].Name == "eliminar")
            {
                int indice = e.RowIndex;
                if (indice >= 0)
                {
                    numeroControl = dgvTodas.Rows[indice].Cells["numeroControl"].Value?.ToString();
                    if (numeroControl != null)
                    {
                        if (MessageBox.Show("¿Estas seguro que deseas eliminar a este alumno del Sistema?", "Warning",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                        {
                            alumno.Delete(numeroControl);
                            dgvTodas.Rows.RemoveAt(e.RowIndex);
                            MessageBox.Show("Se ha eliminado correctamente actualice la tabla para ver los resultados");
                        }
                            
                    }
                    else
                    {
                        MessageBox.Show("No ha seleccionado ninguna propuesta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }           

            if (dgvTodas.Columns[e.ColumnIndex].Name == "informacionAlumno")
            {
                formInfoAlumno form = new formInfoAlumno();
                int indice = e.RowIndex;                
                if (indice >= 0)
                {
                    String id = dgvTodas.Rows[indice].Cells["id"].Value?.ToString();                    
                    numeroControl = dgvTodas.Rows[indice].Cells["numeroControl"].Value.ToString();
                    if (id != null)
                    {
                        String categoria = "";
                        foreach(Alumno item in listAlumno)
                        {
                            if(numeroControl == item.numeroControl)
                            {
                                categoria = item.categoria;
                                break;
                            }
                        }


                        form.tBId.Text = dgvTodas.Rows[indice].Cells["id"].Value.ToString();
                        form.tBNombre.Text = dgvTodas.Rows[indice].Cells["nombre"].Value.ToString();
                        form.tBMateria.Text = dgvTodas.Rows[indice].Cells["materia"].Value.ToString();
                        form.tBNumeroControl.Text = dgvTodas.Rows[indice].Cells["numeroControl"].Value.ToString();
                        form.tBProyecto.Text = dgvTodas.Rows[indice].Cells["proyecto"].Value.ToString();
                        form.cBModalidad.Text = categoria;



                        form.Show();

                        //MostrarDatos();
                    }
                    else
                    {
                        MessageBox.Show("No ha seleccionado ninguna propuesta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            
            if (dgvTodas.Columns[e.ColumnIndex].Name == "imprimir")
            {
                int indice = e.RowIndex;
                if (indice >= 0)
                {
                    numeroControl = dgvTodas.Rows[indice].Cells["numeroControl"].Value?.ToString();
                    if (numeroControl != null)
                    {
                        SaveFileDialog savefile = new SaveFileDialog();
                        savefile.FileName = string.Format("{0}.pdf", DateTime.Now.ToString("ddMMyyyyHHmmss"));

                        List<Encuesta> encuestas = new CN_Files().ObtenerEncuestas(numeroControl);    

                        foreach(Encuesta item in encuestas)
                        {
                            //string PaginaHTML_Texto = Properties.Resources.PlantillaEncuesta.ToString();
                            //PaginaHTML_Texto = PaginaHTML_Texto.Replace("@DEPARTAMENTO", tBDepartamento.Text);
                            //PaginaHTML_Texto = PaginaHTML_Texto.Replace("@R_DEPARTAMENTO", tBResponsableDepartamento.Text);
                            //PaginaHTML_Texto = PaginaHTML_Texto.Replace("@R_PROGRAMA", tbResponsable.Text);
                            //PaginaHTML_Texto = PaginaHTML_Texto.Replace("@DOCENTE", tBPuesto.Text);
                            //PaginaHTML_Texto = PaginaHTML_Texto.Replace("@NOMBRE", cBNombre.Text);
                            //PaginaHTML_Texto = PaginaHTML_Texto.Replace("@CANTIDAD", tBNumero.Text);
                            //PaginaHTML_Texto = PaginaHTML_Texto.Replace("@A1", tBActividad1.Text);
                            //PaginaHTML_Texto = PaginaHTML_Texto.Replace("@A2", tBActividad2.Text);
                            //PaginaHTML_Texto = PaginaHTML_Texto.Replace("@A3", tBActividad3.Text);
                            //PaginaHTML_Texto = PaginaHTML_Texto.Replace("@A4", tBActividad4.Text);
                            //PaginaHTML_Texto = PaginaHTML_Texto.Replace("@A5", tBActividad5.Text);
                            //PaginaHTML_Texto = PaginaHTML_Texto.Replace("@FECHA", DateTime.Now.ToString("dd/MM/yyyy"));
                        }
                    }
                    else
                    {
                        MessageBox.Show("No se ha podido imprimir", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

        }
    }
}
