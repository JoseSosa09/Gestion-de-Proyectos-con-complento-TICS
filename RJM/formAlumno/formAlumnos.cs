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
using iTextSharp.text.pdf;
using iTextSharp.text;
using iTextSharp.tool.xml;
using System.IO;

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

                e.Graphics.DrawImage(Properties.Resources.reload, new System.Drawing.Rectangle(x2, y2, w2, h2));
                e.Handled = true;
            }
            if (e.ColumnIndex == 9)
            {

                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                var w = Properties.Resources.x_button.Width;
                var h = Properties.Resources.x_button.Height;

                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                e.Graphics.DrawImage(Properties.Resources.x_button, new System.Drawing.Rectangle(x, y, w, h));
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
                        string PaginaHTML_Texto = Properties.Resources.PlantillaEncuesta.ToString();

                        foreach (Encuesta item in encuestas)
                        {
                            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@Alumno", item.Alumno);
                            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@NumeroControl", item.NumeroControl);
                            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@Maestro", item.Maestro);
                            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@Java", item.Java);
                            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@Python", item.Python);
                            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@Cplusplus", item.Cmasmas);
                            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@JavaScript", item.Javascript);
                            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@CSharp", item.Csharp);
                            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@VisualBasic", item.VisualBasic);
                            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@Ruby", item.Ruby);
                            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@MATLAB", item.Matlab);
                            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@R", item.R);
                            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@C", item.C);
                            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@PHP", item.Php);
                            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@Perl", item.Perl);
                            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@HTML", item.Html);
                            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@jQuery", item.Jquery);
                            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@CSS", item.Css);
                            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@Node.js", item.NodeJs);
                            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@ASP", item.AspNet);
                            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@React", item.React);
                            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@TypeScript", item.Typescript);
                            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@Angular", item.Angular);
                            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@AJAX", item.Ajax);                                                        
                            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@Kotlin", item.Kotlin);
                            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@ReactNative", item.ReactNative);
                            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@Oracle", item.Oracle);
                            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@MySQL", item.MySQL);
                            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@PostgreSQL", item.PostgreSQL);
                            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@SQLite", item.SqlLite);
                            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@MongoDB", item.MongoDB);
                            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@MicrosoftAccess", item.Access);
                            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@MariaDB", item.MariaDB);
                            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@Redis", item.Redis);
                            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@Cassandra", item.Casandra);
                            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@MicrosoftAzure", item.Azure);
                            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@AmazonWebServices", item.Amazon);
                            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@AmazonDynamoDB", item.AmazonDDB);
                            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@FECHA", DateTime.Now.ToString("dd/MM/yyyy"));

                        }

                        if (savefile.ShowDialog() == DialogResult.OK)
                        {
                            using (FileStream stream = new FileStream(savefile.FileName, FileMode.Create))
                            {
                                //Creamos un nuevo documento y lo definimos como PDF
                                Document pdfDoc = new Document(PageSize.A4, 25, 25, 25, 25);

                                PdfWriter writer = PdfWriter.GetInstance(pdfDoc, stream);
                                pdfDoc.Open();
                                pdfDoc.Add(new Phrase(""));

                                //Agregamos la imagen del banner al documento
                                iTextSharp.text.Image img = iTextSharp.text.Image.GetInstance(Properties.Resources.tec, System.Drawing.Imaging.ImageFormat.Png);
                                img.ScaleToFit(80, 80);
                                img.Alignment = iTextSharp.text.Image.UNDERLYING;

                                //img.SetAbsolutePosition(10,100);
                                img.SetAbsolutePosition(pdfDoc.LeftMargin, pdfDoc.Top - 60);
                                pdfDoc.Add(img);


                                //pdfDoc.Add(new Phrase("Hola Mundo"));
                                using (StringReader sr = new StringReader(PaginaHTML_Texto))
                                {
                                    XMLWorkerHelper.GetInstance().ParseXHtml(writer, pdfDoc, sr);
                                }

                                pdfDoc.Close();
                                stream.Close();
                            }

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
