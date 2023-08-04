using CapaEntidad;
using CapaNegocio;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;


namespace RJM.formProyecto
{
    public partial class formArchivos : Form
    {
        CN_Files objFiles = new CN_Files();
        Maestro maestro;

        public formArchivos(Maestro maestro)
        {
            InitializeComponent();
            this.maestro = maestro; 
        }

        private void formArchivos_Load(object sender, EventArgs e)
        {
            MostrarDatos();
            Actualizar();
        }

        public void Actualizar()
        {
            CN_Files files = new CN_Files();
            cBAlumno.DisplayMember = "nombre";
            cBAlumno.DataSource = files.CargarAlumno();
            cBAlumno.DropDownStyle = ComboBoxStyle.DropDownList;

            cBPrograma.DisplayMember = "nombre";
            cBPrograma.DataSource = files.CargarPrograma();
            cBPrograma.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        public void MostrarDatos()
        {
            dgvFiles.Rows.Clear();
            
            // Actualizar la vista en el DataGridView
            List<Files> list = new List<Files>();
            list = objFiles.LoadFilesFromDatabase(maestro.nombreCompleto.ToString());

            foreach (Files item in list)
            {
                dgvFiles.Rows.Add(new object[] { item.ID, item.NombreArchivo, item.ContenidoArchivo, item.programa, item.alumno });
            }
        }

        private void agregarProyectoIntegrador_Click(object sender, EventArgs e)
        {

            string[] alumnoNombre = cBAlumno.Text.Split('-');


            // Abrir un cuadro de diálogo para que el usuario seleccione múltiples archivos de Word
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Archivos de Word|*.doc;*.docx";
            openFileDialog.Multiselect = true;



            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Obtener la lista de nombres de archivos seleccionados
                string[] fileNames = openFileDialog.FileNames;
                string programa = cBPrograma.Text;
                string alumno = alumnoNombre[0].Substring(0, alumnoNombre[0].Length - 1);
                string numeroControl = alumnoNombre[1].Substring(1, alumnoNombre[1].Length - 1);

                // Guardar los archivos en la base de datos y cargar los datos en el DataGridView
                foreach (string fileName in fileNames)
                {
                    objFiles.SaveFileToDatabase(fileName, programa, alumno, numeroControl, maestro.nombreCompleto.ToString());
                }
                dgvFiles.Rows.Clear();
                MostrarDatos();
            }
        }

        private void dgvFiles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verificar si el clic se realizó en la columna de descarga y no en otra parte del DataGridView
            if (dgvFiles.Columns[e.ColumnIndex].Name == "borrarButton")
            {
                // Obtener el nombre del archivo seleccionado
                string fileName = dgvFiles.Rows[e.RowIndex].Cells["archivo"].Value.ToString();

                // Obtener la ruta completa de la carpeta de descargas del usuario actual
                string downloadsFolder = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

                // Combinar la ruta de descargas con el nombre del archivo seleccionado
                string filePath = Path.Combine(downloadsFolder, fileName);

                // Verificar si el archivo existe antes de intentar descargarlo
                if (File.Exists(filePath))
                {
                    try
                    {
                        // Descargar el archivo
                        byte[] fileBytes = File.ReadAllBytes(filePath);
                        SaveFileDialog saveFileDialog = new SaveFileDialog
                        {
                            FileName = fileName,
                            Filter = "Archivos de Word|*.doc;*.docx"
                        };
                        if (saveFileDialog.ShowDialog() == DialogResult.OK)
                        {
                            File.WriteAllBytes(saveFileDialog.FileName, fileBytes);
                            MessageBox.Show("Descarga completada exitosamente.", "Descarga completada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al descargar el archivo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("El archivo seleccionado no existe.", "Archivo no encontrado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

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
                            objFiles.Delete(Convert.ToInt32(id));
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

        private void dgvFiles_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            if (e.ColumnIndex == 5)
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
    }
}

