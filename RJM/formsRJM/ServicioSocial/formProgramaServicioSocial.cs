using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;
using CapaEntidad;
using System.IO;
using iTextSharp.text.pdf;
using iTextSharp.text;
using iTextSharp.tool.xml;

namespace RJM.formRJM
{
    public partial class formProgramaServicioSocial : Form
    {
        public formProgramaServicioSocial()
        {
            InitializeComponent();
        }
        private void formProgramaServicioSocial_Load(object sender, EventArgs e)
        {
            actualizar();
        }

        public void actualizar()
        {
            CN_ServicioSocial social = new CN_ServicioSocial();
            cBNombre.DisplayMember = "nombrePrograma";
            cBNombre.DataSource = social.CargarComboBox(); 
        }

        private void cBNombre_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<ServicioSocial> social = new CN_ServicioSocial().Buscar(cBNombre.Text);
            
            foreach(ServicioSocial item in social)
            {
                tBDepartamento.Text = item.nombreDepartamento;
                tBResponsableDepartamento.Text = item.responsableDepartamento;
                tbResponsable.Text = item.responsablePrograma;
                tBPuesto.Text = item.puestoResponsable;
                tBNumero.Text = Convert.ToString(item.numAlumnos);  
            }
        }
        private void cBNombre_SelectionChangeCommitted(object sender, EventArgs e)
        {
            List<ServicioSocial> social = new CN_ServicioSocial().Buscar(cBNombre.Text);

            foreach (ServicioSocial item in social)
            {
                tBDepartamento.Text = item.nombreDepartamento;
                tBResponsableDepartamento.Text = item.responsableDepartamento;
                tbResponsable.Text = item.responsablePrograma;
                tBPuesto.Text = item.puestoResponsable;
                tBNumero.Text = Convert.ToString(item.numAlumnos);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveFileDialog savefile = new SaveFileDialog();
            savefile.FileName = string.Format("{0}.pdf", DateTime.Now.ToString("ddMMyyyyHHmmss"));



            //string PaginaHTML_Texto = "<table border=\"1\"><tr><td>HOLA MUNDO</td></tr></table>";
            string PaginaHTML_Texto = Properties.Resources.Plantilla.ToString();
            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@DEPARTAMENTO", tBDepartamento.Text);
            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@R_DEPARTAMENTO", tBResponsableDepartamento.Text);
            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@R_PROGRAMA", tbResponsable.Text);
            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@DOCENTE", tBPuesto.Text);
            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@NOMBRE", cBNombre.Text);
            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@CANTIDAD", tBNumero.Text);
            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@A1", tBActividad1.Text);
            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@A2", tBActividad2.Text);
            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@A3", tBActividad3.Text);
            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@A4", tBActividad4.Text);
            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@A5", tBActividad5.Text);
            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@FECHA", DateTime.Now.ToString("dd/MM/yyyy"));
                       

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
    }
}
