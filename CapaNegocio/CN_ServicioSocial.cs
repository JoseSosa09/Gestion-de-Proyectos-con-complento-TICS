using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidad;

namespace CapaNegocio
{
    public class CN_ServicioSocial
    {
        public List<ServicioSocial> MostrarTodo()
        {
            List<ServicioSocial> lista = new CD_ServicioSocial().MostrarTodo();

            foreach (ServicioSocial item in lista)
            {
                if (item.categoria == "*/*")
                {
                    item.categoria = "Residencia y Servicio Social";
                }
                else if (item.categoria == "***")
                {
                    item.categoria = "Residencia, Proyecto Integrador y Servicio Social";
                }
                else if (item.categoria == "**")
                {
                    item.categoria = "Residencia y Proyecto Integrador";
                }
                else if (item.categoria == "*")
                {
                    item.categoria = "Residencia";
                }
            }

            return lista;
        }

        public List<ServicioSocial> RegistrarServicio(string idProyectoPropuesta, string nombreDepartamento, string responsableDepartamento, string responsablePrograma,  string puestoResponsable, string nombrePrograma, string numAlumnos, string categoria)
        {
            List<ServicioSocial> lista = new CD_ServicioSocial().RegistrarServicio(Convert.ToInt32(idProyectoPropuesta), nombreDepartamento, responsableDepartamento, responsablePrograma, puestoResponsable, nombrePrograma, Convert.ToInt32(numAlumnos), categoria);

            return lista;

        }
        public DataTable CargarComboBox()
        {
            CD_ServicioSocial social = new CD_ServicioSocial();
            DataTable dt = new DataTable();
            dt = social.ComboBox();
            return dt;
        }

        public List<ServicioSocial> Buscar(String buscar)
        {
            List<ServicioSocial> lista = new CD_ServicioSocial().Seleccionar(buscar);
            return lista;
        }
        public List<ServicioSocial> BuscarID(int idProyectoIntegrador)
        {
            List<ServicioSocial> lista = new CD_ServicioSocial().BuscarID(idProyectoIntegrador);
            return lista;
        }
    }
}
