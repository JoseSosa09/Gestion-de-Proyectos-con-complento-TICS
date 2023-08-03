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
using System.Windows.Forms;

namespace RJM.formProyecto.formAlumno_Proyecto
{    
    public partial class formSubirArchivos : Form
    {
        CN_Files objFiles = new CN_Files();
        private Alumno usuario;        

        public formSubirArchivos(Alumno usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
        }
        

        private void formSubirArchivos_Load(object sender, EventArgs e)
        {
            MostrarDatos();
            MostrarInfo();
        }

        public void MostrarInfo()
        {
            CN_Files files = new CN_Files();
            cBMaestro.DisplayMember = "nombre";
            cBMaestro.DataSource = files.CargarMaestro();
            cBMaestro.DropDownStyle = ComboBoxStyle.DropDownList;

            cBPrograma.DisplayMember = "nombre";
            cBPrograma.DataSource = files.CargarProgramaAlumno(usuario.numeroControl.ToString());
            cBPrograma.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        public void MostrarDatos()
        {
            string numeroControl = usuario.numeroControl.ToString();
            dgvFiles.Rows.Clear();

            // Actualizar la vista en el DataGridView
            List<Files> list = new List<Files>();
            list = objFiles.LoadFilesFromDatabaseAlumno(numeroControl);

            foreach (Files item in list)
            {
                dgvFiles.Rows.Add(new object[] { item.ID, item.NombreArchivo, "", item.programa, "" });
            }
        }


        private void agregarArchivoAlumno_Click(object sender, EventArgs e)
        {
            // Abrir un cuadro de diálogo para que el usuario seleccione múltiples archivos de Word
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Archivos de Word|*.doc;*.docx";
            openFileDialog.Multiselect = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Obtener la lista de nombres de archivos seleccionados
                string[] fileNames = openFileDialog.FileNames;
                string maestro = cBMaestro.Text;
                string programa = cBPrograma.Text;
                string alumno = usuario.nombre.ToString();
                string numeroControl = usuario.numeroControl.ToString();

                if (programa.Length < 1)
                {
                    MessageBox.Show("No cuentas con un proyecto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    // Guardar los archivos en la base de datos y cargar los datos en el DataGridView
                    foreach (string fileName in fileNames)
                    {
                        objFiles.SaveFileToDatabaseAlumno(fileName, programa, alumno, numeroControl, maestro);
                    }
                    dgvFiles.Rows.Clear();
                    MostrarDatos();
                }                
            }
        }

        private void dgvFiles_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            if (e.ColumnIndex == 4)
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

        private void dgvFiles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvFiles.Columns[e.ColumnIndex].Name == "borrar")
            {
                int indice = e.RowIndex;
                if (indice >= 0)
                {
                    string id = dgvFiles.Rows[indice].Cells["id"].Value?.ToString();
                    if (id != null)
                    {
                        if (MessageBox.Show("¿Estas seguro que deseas eliminarlo?", "Warning",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                        {
                            objFiles.DeleteAlumno(Convert.ToInt32(id));
                            dgvFiles.Rows.RemoveAt(e.RowIndex);
                            MessageBox.Show("Se ha eliminado correctamente", "Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }

                    }
                    else
                    {
                        MessageBox.Show("No se pudo eliminar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
