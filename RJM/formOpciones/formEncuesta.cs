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
using System.Windows.Controls.Primitives;
using System.Windows.Forms;

namespace RJM
{
    public partial class formEncuesta : Form
    {
        Alumno alumno;
        public formEncuesta(Alumno alumno)
        {
            InitializeComponent();
            this.alumno = alumno;
        }

        private void formEncuesta_Load(object sender, EventArgs e)
        {
            MostrarInfo();
        }

        public void MostrarInfo()
        {
            CN_Files files = new CN_Files();
            cBMaestro.DisplayMember = "nombre";
            cBMaestro.DataSource = files.CargarMaestro();
            cBMaestro.DropDownStyle = ComboBoxStyle.DropDownList;            
        }

        private void enviarFormulario(object sender, EventArgs e)
        {
            CN_Files encuesta = new CN_Files();
            String numeroControl = alumno.numeroControl.ToString();
            String nombrealumno = alumno.nombre.ToString();
            String maestro = cBMaestro.Text;

            string java = ObtenerValorRadioButton(lenguajeProgramacion1.Name, "lenguajeProgramacion");
            string python = ObtenerValorRadioButton(lenguajeProgramacion2.Name, "lenguajeProgramacion");
            string cmasmas = ObtenerValorRadioButton(lenguajeProgramacion3.Name, "lenguajeProgramacion");
            string javascript = ObtenerValorRadioButton(lenguajeProgramacion4.Name, "lenguajeProgramacion");
            string csharp = ObtenerValorRadioButton(lenguajeProgramacion5.Name, "lenguajeProgramacion");
            string visualbasic = ObtenerValorRadioButton(lenguajeProgramacion6.Name, "lenguajeProgramacion");
            string ruby = ObtenerValorRadioButton(lenguajeProgramacion7.Name, "lenguajeProgramacion");
            string matlab = ObtenerValorRadioButton(lenguajeProgramacion8.Name, "lenguajeProgramacion");
            string r = ObtenerValorRadioButton(lenguajeProgramacion9.Name, "lenguajeProgramacion");
            string c = ObtenerValorRadioButton(lenguajeProgramacion10.Name, "lenguajeProgramacion");
            string php = ObtenerValorRadioButton(lenguajeProgramacion11.Name, "lenguajeProgramacion");
            string perl = ObtenerValorRadioButton(lenguajeProgramacion12.Name, "lenguajeProgramacion");

            string html = ObtenerValorRadioButton(programacionWeb1.Name, "programacionWeb");
            string jquery = ObtenerValorRadioButton(programacionWeb2.Name, "lenguajeProgramacion");
            string css = ObtenerValorRadioButton(programacionWeb3.Name, "lenguajeProgramacion");
            string nodejs = ObtenerValorRadioButton(programacionWeb4.Name, "lenguajeProgramacion");
            string asp = ObtenerValorRadioButton(programacionWeb5.Name, "lenguajeProgramacion");            
            string react = ObtenerValorRadioButton(programacionWeb8.Name, "lenguajeProgramacion");
            string typescript = ObtenerValorRadioButton(programacionWeb9.Name, "lenguajeProgramacion");
            string angular = ObtenerValorRadioButton(programacionWeb10.Name, "lenguajeProgramacion");
            string ajax = ObtenerValorRadioButton(programacionWeb11.Name, "lenguajeProgramacion");
            string view = ObtenerValorRadioButton(programacionWeb12.Name, "lenguajeProgramacion");

            string glade = ObtenerValorRadioButton(interfaces1.Name, "programacionGrafica");                        
            
            string kotlin = ObtenerValorRadioButton(movil2.Name, "programacionMovil");                        
            string reactnative = ObtenerValorRadioButton(movil3.Name, "programacionMovil");
            
            string oracle = ObtenerValorRadioButton(dB1.Name, "baseDatos");
            string mysql = ObtenerValorRadioButton(dB2.Name, "baseDatos");
            string postgres = ObtenerValorRadioButton(dB3.Name, "baseDatos");
            string sqllite = ObtenerValorRadioButton(dB4.Name, "baseDatos");
            string mongodb = ObtenerValorRadioButton(dB5.Name, "baseDatos");
            string access = ObtenerValorRadioButton(dB6.Name, "baseDatos");
            string mariadb = ObtenerValorRadioButton(dB7.Name, "baseDatos");
            string redis = ObtenerValorRadioButton(dB8.Name, "baseDatos");
            string casandra = ObtenerValorRadioButton(dB9.Name, "baseDatos");
            string azure = ObtenerValorRadioButton(dB10.Name, "baseDatos");
            string amazon = ObtenerValorRadioButton(dB11.Name, "baseDatos");
            string amazonddb = ObtenerValorRadioButton(dB12.Name, "baseDatos");


            try
            {
                encuesta.GuardarEncuesta(nombrealumno, numeroControl, maestro, java, python, cmasmas, javascript, csharp, visualbasic, ruby, matlab, r, c, php, perl, html, jquery,
                           css, nodejs, asp, react, typescript, angular, ajax, view, glade, kotlin, reactnative, oracle, mysql, postgres, sqllite, mongodb,
                           access, mariadb, redis, casandra, azure, amazon, amazonddb);
                MessageBox.Show("Se ha asignado de manera correcta", "Asignación Completa!", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
            catch (Exception ex)
            {

            }
               
        }


        // Para obtener el valor seleccionado de los RadioButton en tabPage1:
        private String ObtenerValorRadioButton(string nombrePanel, string nombrePage)
        {
            // Busca el TabPage en el TabControl
            TabPage tabPage = tabControl1.TabPages[nombrePage];

            if (tabPage != null)
            {
                // Busca el Panel dentro del TabPage con el nombre proporcionado
                Panel panel = tabPage.Controls.OfType<Panel>().FirstOrDefault(p => p.Name == nombrePanel);

                if (panel != null)
                {
                    // Encuentra el RadioButton seleccionado dentro del Panel
                    RadioButton radioButtonSeleccionado = panel.Controls.OfType<RadioButton>()
                                                             .FirstOrDefault(rb => rb.Checked);

                    if (radioButtonSeleccionado != null)
                    {
                        // Obtén el valor almacenado en la propiedad "Tag" del RadioButton
                        object valor = radioButtonSeleccionado.Text;                        

                        // O si almacenaste una cadena de texto:
                        string valorSeleccionadoStr = valor.ToString();

                        // Ahora puedes utilizar el valor seleccionado como desees.
                        // Por ejemplo, imprimirlo en la consola:
                        Console.WriteLine("Valor seleccionado: " + valorSeleccionadoStr);
                        return valorSeleccionadoStr;
                        
                    }
                    return "";

                }
                return "";

            }
            return "";
        }


    }
}
