using CapaEntidad;
using CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RJM.formProyecto
{
    public partial class formAlumnosArchivos : Form
    {
        CN_Files objFiles = new CN_Files();
        public Maestro maestro;

        public formAlumnosArchivos(Maestro maestro)
        {
            InitializeComponent();
            this.maestro = maestro; 
        }

        private void formAlumnosArchivos_Load(object sender, EventArgs e)
        {
            MostrarDatos();
        }

        public void MostrarDatos()
        {            
            CN_Files files = new CN_Files();
            cBAlumno.DisplayMember = "nombre";
            cBAlumno.DataSource = files.CargarAlumno();
            cBAlumno.DropDownStyle = ComboBoxStyle.DropDownList;            
        }

        public void MostrarBusqueda(string dato)
        {
            dgvFiles.Rows.Clear();
            List<Files> list = new List<Files>();
            list = objFiles.BuscarPalabra(dato);

            foreach (Files item in list)
            {
                dgvFiles.Rows.Add(new object[] { item.ID, item.NombreArchivo, item.ContenidoArchivo, item.programa, item.alumno });
            }
        }
        private void textBoxBuscar_KeyUp(object sender, KeyEventArgs e)
        {
            string dato = "%" + textBoxBuscar.Text + "%";
            MostrarBusqueda(dato);
        }

        private void cBAlumno_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvFiles.Rows.Clear();
            List<Files> list = new List<Files>();

            string[] alumnoNombre = cBAlumno.Text.Split('-');
            string numeroControl = alumnoNombre[1].Substring(1, alumnoNombre[1].Length - 1);
            string maestroNombre = maestro.nombreCompleto.ToString();

            list = objFiles.MostrarAlumnoFilesSelectIndexChanged(numeroControl, maestroNombre);

            foreach (Files item in list)
            {
                dgvFiles.Rows.Add(new object[] { item.ID, item.NombreArchivo, item.ContenidoArchivo, item.programa, item.alumno });
            }
        }


        private void dgvFiles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verificar si el clic se realizó en la columna de descarga y no en otra parte del DataGridView
            if (dgvFiles.Columns[e.ColumnIndex].Name == "descargar")
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
        }

        private void dgvFiles_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            if (e.ColumnIndex == 5)
            {

                e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                
                var w = Properties.Resources.apuntar_hacia_abajo.Width;
                var h = Properties.Resources.apuntar_hacia_abajo.Height;

                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                e.Graphics.DrawImage(Properties.Resources.apuntar_hacia_abajo, new Rectangle(x, y, w, h));
                e.Handled = true;
            }
        }

        
    }
}
