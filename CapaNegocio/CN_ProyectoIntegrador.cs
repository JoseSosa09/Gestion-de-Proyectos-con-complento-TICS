using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;
using CapaDatos;
using System.Data;

namespace CapaNegocio
{
    public class CN_ProyectoIntegrador
    {
        public List<ProyectoIntegrador> RegistrarServicio(string idProyectoPropuesta, string responsablePrograma, string colaboradores, string nombrePrograma, string descripcion, string categoria, string objetivo, string alcancesProyecto, string desarrollo) {

            List<ProyectoIntegrador> lista = new CD_ProyectoIntegrador().RegistrarServicio(Convert.ToInt32(idProyectoPropuesta), responsablePrograma, colaboradores, nombrePrograma, descripcion, categoria, objetivo, alcancesProyecto, desarrollo);

            return lista;
        }

        public List<ProyectoIntegrador> MostrarIntegrador()
        {
            List<ProyectoIntegrador> lista = new CD_ProyectoIntegrador().MostrarIntegrador();
            return lista;
        }

        public DataTable CargarProgramaIntegrador()
        {
            CD_ProyectoIntegrador integrador = new CD_ProyectoIntegrador();
            DataTable dt = new DataTable();
            dt = integrador.CargarIntegrador();
            return dt;
        }
        public DataTable CargarAlumno()
        {
            CD_ProyectoIntegrador integrador = new CD_ProyectoIntegrador();
            DataTable dt = new DataTable();
            dt = integrador.CargarAlumnos();
            return dt;
        }
        
        public DataTable CargarModalidad()
        {            
            CD_ProyectoIntegrador integrador = new CD_ProyectoIntegrador();
            DataTable dt = new DataTable();
            dt = integrador.CargarModalidad();
            return dt;

        }

        public DataTable CargarCategoria()
        {
            CD_ProyectoIntegrador integrador = new CD_ProyectoIntegrador();
            DataTable dt = new DataTable();
            dt = integrador.CargarCategoria();
            return dt;

        }

        public void Delete(string nombre)
        {
            CD_ProyectoIntegrador integrador = new CD_ProyectoIntegrador();
            integrador.Delete(nombre);            
        }
        public List<ProyectoIntegrador> BuscarID(int idProyectoIntegrador)
        {
            List<ProyectoIntegrador> lista = new CD_ProyectoIntegrador().BuscarID(idProyectoIntegrador);
            return lista;
        }

    }
}
