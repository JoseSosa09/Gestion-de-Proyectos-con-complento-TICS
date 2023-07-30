using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaEntidad;
using CapaNegocio;
using RJM.formsRJM.ControlProyectoIntegrador;

namespace RJM.formRJM
{
    public partial class formProyectoIntegrador : Form
    {
        public formProyectoIntegrador()
        {
            InitializeComponent();
        }

        private void formProyectoIntegrador_Load(object sender, EventArgs e)
        {
            actualizar();
            MostrarDatos();
        }

        public void actualizar()
        {
            CN_ProyectoIntegrador integrador = new CN_ProyectoIntegrador();
            cBNombre.DisplayMember = "nombre";
            cBNombre.DataSource = integrador.CargarProgramaIntegrador();
            cBNombre.DropDownStyle = ComboBoxStyle.DropDownList;

            cBAlumno.DisplayMember = "nombre";
            cBAlumno.DataSource = integrador.CargarAlumno();
            cBAlumno.DropDownStyle = ComboBoxStyle.DropDownList;

            cBModalidad.DisplayMember = "modalidad";
            cBModalidad.DataSource = integrador.CargarModalidad();
            cBModalidad.DropDownStyle = ComboBoxStyle.DropDownList;

            cBCategoria.DisplayMember = "nombre";
            cBCategoria.DataSource = integrador.CargarCategoria();
            cBCategoria.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        public void MostrarDatos()
        {
            dgvIntegrador.Rows.Clear();
            List<ControlProyectoIntegrador> lista = new CN_ControlProyectoIntegrador().MostrarTodo();

            foreach (ControlProyectoIntegrador item in lista)
            {
                dgvIntegrador.Rows.Add(new object[] { item.idTable, item.nombre, item.alumno, item.numeroControl, item.modalidad, item.categoria, "", "" });
            }
        }

        private void borrarProyecto_Click(object sender, EventArgs e)
        {                        
            if (MessageBox.Show("¿Estas seguro que deseas eliminarlo?", "Warning",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            try
            {
                CN_ControlProyectoIntegrador delete = new CN_ControlProyectoIntegrador();
                MessageBox.Show("Se ha eliminado correctamente actualice la tabla para ver los resultados");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            MostrarDatos();
        }

        private void agregarProyectoIntegrador_Click_1(object sender, EventArgs e)
        {
            //Solamente se le asigna el proyecto, para ver que proyecto tendrá cada alumno y en el apartado de proyectos el alumno vera toda la información
            //Proyecto
            List<ProyectoIntegrador> lista = new CN_ProyectoIntegrador().MostrarIntegrador();            
            int idProyectoPropuesta = 0;
            string nombre = cBNombre.Text, responsable = "";

            foreach (ProyectoIntegrador item in lista)
            {
                if(nombre == item.nombre)
                {
                    idProyectoPropuesta = item.idProyectoPropuesta;                    
                    responsable = item.responsable;
                    break;
                }
            }

            //Alumno
            List<Alumno> list = new CN_Alumno().Listar();
            string [] alumnoNombre = cBAlumno.Text.Split('-');
            string alumno = "";
            string modalidad = cBModalidad.Text;

            foreach (var word in alumnoNombre)
            {
                alumno = word;  //Guarda el numeroControl
            }
                
            try
            {
                bool vAlumno = verificarAlumno(alumno); //Verificar que el alumno no tenga proyecto 
                bool vProyecto = verificarProyecto(cBNombre.Text, cBModalidad.Text); //Verificar que el proyecto no tenga un alumno

                CN_ControlProyectoIntegrador controlIntegrador = new CN_ControlProyectoIntegrador();
                if(cBAlumno.Text != "" && cBNombre.Text != "" && cBModalidad.Text != "")
                {
                    if (vAlumno)
                    {
                        if (vProyecto)
                        {
                            controlIntegrador.Insertar(idProyectoPropuesta, nombre, alumnoNombre[0].Trim(), alumno.Trim(), modalidad, responsable, cBCategoria.Text);
                            MessageBox.Show("Se ha asignado de manera correcta", "Asignación Completa!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Ya ha sido asignado este proyecto en esa modalidad", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    
                    else
                    {
                        MessageBox.Show("Un alumno no puede tener dos programas", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Seleccione todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            MostrarDatos();
        }

        private void dgvIntegrador_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            if (e.ColumnIndex == 6)
            {

                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                var w2 = Properties.Resources.reload.Width;
                var h2 = Properties.Resources.reload.Height;

                var x2 = e.CellBounds.Left + (e.CellBounds.Width - w2) / 2;
                var y2 = e.CellBounds.Top + (e.CellBounds.Height - h2) / 2;

                e.Graphics.DrawImage(Properties.Resources.reload, new Rectangle(x2, y2, w2, h2));
                e.Handled = true;
            }

            if (e.ColumnIndex == 7)
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

        private void dgvIntegrador_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            CN_ControlProyectoIntegrador integrador = new CN_ControlProyectoIntegrador();
            string id;


            if (dgvIntegrador.Columns[e.ColumnIndex].Name == "borrarButton")
            {
                int indice = e.RowIndex;
                if (indice >= 0)
                {
                    id = dgvIntegrador.Rows[indice].Cells["idTable"].Value?.ToString();
                    if (id != null)
                    {
                        if (MessageBox.Show("¿Estas seguro que deseas eliminarlo?", "Warning",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                        integrador.Delete(Convert.ToInt32(id));
                        dgvIntegrador.Rows.RemoveAt(e.RowIndex);                        
                        MessageBox.Show("Se ha eliminado correctamente");
                    }
                    else
                    {
                        MessageBox.Show("No ha seleccionado ninguna propuesta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

            if (dgvIntegrador.Columns[e.ColumnIndex].Name == "editarButton")
            {
                formEditar form = new formEditar();
                int indice = e.RowIndex;

                if (indice >= 0)
                {
                    id = dgvIntegrador.Rows[indice].Cells["idTable"].Value?.ToString();

                    if (id != null)
                    {                                                
                        form.tBId.Text = dgvIntegrador.Rows[indice].Cells["idTable"].Value.ToString();
                        form.cBAlumno.Text = dgvIntegrador.Rows[indice].Cells["alumno"].Value.ToString();
                        form.cBModalidad.Text = dgvIntegrador.Rows[indice].Cells["modalidad"].Value.ToString();
                        form.cBNombre.Text = dgvIntegrador.Rows[indice].Cells["nombre"].Value.ToString();

                        form.Show();
                    }
                    else
                    {
                        MessageBox.Show("No ha seleccionado ninguna propuesta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            MostrarDatos();
        }

        private bool verificarAlumno(String numeroControl) //Recibe el numeroControl
        {            
            bool verificado = true;
            List<Alumno> alumnoProyecto = new CN_ControlProyectoIntegrador().BuscarAlumno(); //Obtiene la información de los alumnos inscrito en la entidad
            //List<Alumno> alumnosSistema = new CN_Alumno().Listar(); //Obtiene la información de los alumnos en el sistema            
                        
            foreach (Alumno alumnoControl in alumnoProyecto) //Busca si ya está en un proyecto
            {
                if (numeroControl.Trim() == alumnoControl.numeroControl)
                {
                    verificado = false;
                    break;
                }
            }
            
            return verificado;
        }   

        private bool verificarProyecto(String nombreProyecto, String modalidad) //Recibe el nombreProyecto y modalidad (PK_TABLA)
        {
            bool verificar = true;
            List<ControlProyectoIntegrador> proyectos = new CN_ControlProyectoIntegrador().ProyectoRepetido();

            foreach(ControlProyectoIntegrador proyecto in proyectos)
            {
                if(proyecto.nombre == nombreProyecto && proyecto.modalidad == modalidad)
                {
                    verificar = false;
                    break;
                }
            }

            return verificar;
        }
    }
}
