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
using RJM.formsRJM;

namespace RJM.formRJM
{


    public partial class formPropuestas : Form
    {
        private CN_ProyectoPropuesta propuesta = new CN_ProyectoPropuesta();

            
        public formPropuestas()
        {
               InitializeComponent();
        }

        private void formPropuestas_Load(object sender, EventArgs e)
        {
            MostrarDatos();
        }

        public void MostrarDatos()
         {
            dgvTodas.Rows.Clear();
            List<ProyectoPropuesta> lista = new CN_ProyectoPropuesta().MostrarTodo();
            
            foreach(ProyectoPropuesta item in lista)
            {                
                dgvTodas.Rows.Add(new object[] {item.idProyectoPropuesta, item.categoria,item.estatus, item.nombre, item.responsable,
                item.colaboradores, item.numAlumnos, item.descripcion, "", ""});
            }
        }

        public void MostrarServicio()
        {
            dgvTodas.Rows.Clear();
            List<ProyectoPropuesta> lista = new CN_ProyectoPropuesta().MostrarServicio();

            foreach (ProyectoPropuesta item in lista)
            {
                dgvTodas.Rows.Add(new object[] {item.idProyectoPropuesta, item.categoria,item.estatus, item.nombre, item.responsable,
                item.colaboradores, item.numAlumnos, item.descripcion, "", ""});
            }
        }

        public void MostrarIntegrador()
        {
            dgvTodas.Rows.Clear();
            List<ProyectoPropuesta> lista = new CN_ProyectoPropuesta().MostrarIntegrador();

            foreach (ProyectoPropuesta item in lista)
            {
                dgvTodas.Rows.Add(new object[] {item.idProyectoPropuesta, item.categoria,item.estatus, item.nombre, item.responsable,
                item.colaboradores, item.numAlumnos, item.descripcion, "", ""});
            }
        }
      
        private void dgv_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
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

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            CN_ProyectoPropuesta propuesta = new CN_ProyectoPropuesta();
            string id;

            
            if (dgvTodas.Columns[e.ColumnIndex].Name == "borrarButton")
            {
                int indice = e.RowIndex;
                if (indice >= 0)
                {
                    id = dgvTodas.Rows[indice].Cells["IdCategoria"].Value?.ToString();
                    if (id != null)
                    {
                        if (MessageBox.Show("¿Estas seguro que deseas eliminarlo?", "Warning",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)                            
                        propuesta.Delete(Convert.ToInt32(id));
                        dgvTodas.Rows.RemoveAt(e.RowIndex);
                        MessageBox.Show("Se ha eliminado correctamente actualice la tabla para ver los resultados");
                    }
                    else
                    {
                        MessageBox.Show("No ha seleccionado ninguna propuesta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }                                                                                                  
                }                
            }

            if (dgvTodas.Columns[e.ColumnIndex].Name == "editarButton")
            {                
                formInsertarPropuesta form = new formInsertarPropuesta();
                int indice = e.RowIndex;

                if (indice >= 0)
                {
                    id = dgvTodas.Rows[indice].Cells["IdCategoria"].Value?.ToString();
                    
                    if(id != null)
                    {
                        form.btnGuardar.Visible = true;
                        form.label.Text = "Editar Propuesta";                        

                        form.tBId.Text = dgvTodas.Rows[indice].Cells["IdCategoria"].Value.ToString();
                        form.cBCategoria.Text = dgvTodas.Rows[indice].Cells["categoria"].Value.ToString();
                        form.cBEstatus.Text = dgvTodas.Rows[indice].Cells["estatus"].Value.ToString();
                        form.tBNombre.Text = dgvTodas.Rows[indice].Cells["nombre"].Value.ToString();
                        form.tBResponsable.Text = dgvTodas.Rows[indice].Cells["nombreMaestro"].Value.ToString();
                        form.tBColaboradores.Text = dgvTodas.Rows[indice].Cells["colaboradores"].Value.ToString();
                        form.tBAlumnos.Text = dgvTodas.Rows[indice].Cells["numAlumnos"].Value.ToString();
                        form.tBDescripcion.Text = dgvTodas.Rows[indice].Cells["nombreAlumno"].Value.ToString();

                        form.Show();
                        
                        MostrarDatos();
                    }                    
                    else
                    {
                        MessageBox.Show("No ha seleccionado ninguna propuesta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void agregarPropuesta_Click(object sender, EventArgs e)
        {
            formInsertarPropuesta form = new formInsertarPropuesta();
            form.Show();
        }

        private void btnTodas_Click_1(object sender, EventArgs e)
        {
            SidePanel.Visible = true;
            SidePanel.Width = btnTodas.Width;
            SidePanel.Left = btnTodas.Left;

            agregarServicioSocial.Visible = false;
            agregarProyectoIntegrador.Visible = false;
            agregarPropuesta.Visible = true;

            dgvTodas.Visible = false;                     
            MostrarDatos();
            dgvTodas.Visible = true;
        }

        private void btnResidencias_Click_1(object sender, EventArgs e)
        {
            SidePanel.Visible = true;
            SidePanel.Width = btnResidencias.Width;
            SidePanel.Left = btnResidencias.Left;

            agregarProyectoIntegrador.Visible = false;
            agregarServicioSocial.Visible = false;
            agregarPropuesta.Visible = true;                        

            dgvTodas.Visible = false; 
            MostrarDatos();
            dgvTodas.Visible = true;
        }

        private void btnServicioSocial_Click(object sender, EventArgs e)
        {
            SidePanel.Visible = true;
            SidePanel.Width = btnServicioSocial.Width;
            SidePanel.Left = btnServicioSocial.Left;
            

            agregarServicioSocial.Visible = true;
            agregarPropuesta.Visible = false;
            agregarProyectoIntegrador.Visible = false;
            
            dgvTodas.Visible = false;            
            MostrarServicio();
            dgvTodas.Visible = true;
        }

        private void btnProyectoIntegrador_Click(object sender, EventArgs e)
        {
            SidePanel.Visible = true;
            SidePanel.Width = btnProyectoIntegrador.Width;
            SidePanel.Left = btnProyectoIntegrador.Left;            

            agregarServicioSocial.Visible = false;
            agregarPropuesta.Visible = false;
            agregarProyectoIntegrador.Visible = true;

            dgvTodas.Visible = false;            
            MostrarIntegrador();
            dgvTodas.Visible = true;
        }
        
        public void MostrarBusqueda(string dato)
        {
            dgvTodas.Rows.Clear();
            List<ProyectoPropuesta> lista = new CN_ProyectoPropuesta().leer_datos(dato);

            foreach (ProyectoPropuesta item in lista)
            {
                dgvTodas.Rows.Add(new object[] {item.idProyectoPropuesta, item.categoria,item.estatus, item.nombre, item.responsable,
                item.colaboradores, item.numAlumnos, item.descripcion, "", ""});
            }
        }

        private void textBoxBuscar_KeyUp(object sender, KeyEventArgs e)
        {
            string dato = "%"+textBoxBuscar.Text+"%";
            MostrarBusqueda(dato);
        }

        private void agregarServicioSocial_Click(object sender, EventArgs e)
        {
            formInsertarServicioSocial form = new formInsertarServicioSocial();
            
            String IdCategoria = "", categoria = "", nombre = "", numAlumnos = "", nombreMaestro = "";

            if (dgvTodas.SelectedRows.Count > 0)
            {

                IdCategoria = dgvTodas.CurrentRow.Cells["IdCategoria"].Value?.ToString();                

                if(IdCategoria != null)
                { 
                    try
                    {
                        IdCategoria = dgvTodas.CurrentRow.Cells["IdCategoria"].Value.ToString();
                        categoria = dgvTodas.CurrentRow.Cells["categoria"].Value.ToString();
                        nombre = dgvTodas.CurrentRow.Cells["nombre"].Value.ToString(); 
                        nombreMaestro = dgvTodas.CurrentRow.Cells["nombreMaestro"].Value.ToString();
                        numAlumnos = dgvTodas.CurrentRow.Cells["numAlumnos"].Value.ToString();

                        form.tBResponsable.Text = nombreMaestro;
                        form.tBAlumnos.Text = numAlumnos;
                        form.tBNombre.Text = nombre;
                        form.tBCategoria.Text = categoria;
                        form.tBId.Text = IdCategoria;

                        form.Show();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }

                else
                {
                    MessageBox.Show("No ha seleccionado ninguna propuesta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Seleccione una fila por favor");
            }
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            String categoria = "", nombre = "", responsable = "", colaboradores = "", descripcion = "", IdCategoria = "";
            formInsertarProyectoIntegrador form = new formInsertarProyectoIntegrador();
                     

            if (dgvTodas.SelectedRows.Count > 0)
            {

                IdCategoria = dgvTodas.CurrentRow.Cells["IdCategoria"].Value?.ToString();

                if (IdCategoria != null)
                {
                    try
                    {
                        IdCategoria = dgvTodas.CurrentRow.Cells["IdCategoria"].Value.ToString();
                        categoria = dgvTodas.CurrentRow.Cells["categoria"].Value.ToString();
                        nombre = dgvTodas.CurrentRow.Cells["nombre"].Value.ToString();
                        responsable = dgvTodas.CurrentRow.Cells["nombreMaestro"].Value.ToString();                        
                        colaboradores = dgvTodas.CurrentRow.Cells["colaboradores"].Value.ToString();
                        descripcion = dgvTodas.CurrentRow.Cells["nombreAlumno"].Value.ToString();


                        form.tBResponsable.Text = responsable;                        
                        form.tBNombre.Text = nombre;
                        form.cBCategoria.Text = categoria;
                        form.tBId.Text = IdCategoria;
                        form.tBDescripcion.Text = descripcion;
                        form.tBColaboradores.Text = colaboradores;

                        form.Show();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }

                else
                {
                    MessageBox.Show("No ha seleccionado ninguna propuesta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Seleccione una fila por favor");
            }
        }
        
    }
}
