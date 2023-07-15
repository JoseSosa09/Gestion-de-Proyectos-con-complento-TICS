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

    public class CN_ProyectoPropuesta
    {
        public List<ProyectoPropuesta> leer_datos(string query)
        {
            List<ProyectoPropuesta> lista = new CD_ProyectoPropuesta().leer_datos(query);
            foreach (ProyectoPropuesta item in lista)
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
        public List<ProyectoPropuesta> MostrarTodo()
        {
            List<ProyectoPropuesta> lista = new CD_ProyectoPropuesta().MostrarTodo();

            foreach (ProyectoPropuesta item in lista)
            {
                if(item.categoria == "*/*")
                {
                    item.categoria = "Residencia y Servicio Social";
                }
                else if(item.categoria == "***")
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
        public List<ProyectoPropuesta> MostrarServicio()
        {
            List<ProyectoPropuesta> lista = new CD_ProyectoPropuesta().MostrarServicio();

            foreach (ProyectoPropuesta item in lista)
            {
                if (item.categoria == "*/*")
                {
                    item.categoria = "Residencia y Servicio Social";
                }
                else if (item.categoria == "***")
                {
                    item.categoria = "Residencia, Proyecto Integrador y Servicio Social";
                }
            }

            return lista;

        }

        public List<ProyectoPropuesta> MostrarIntegrador()
        {
            List<ProyectoPropuesta> lista = new CD_ProyectoPropuesta().MostrarIntegrador();

            foreach (ProyectoPropuesta item in lista)
            {
                if (item.categoria == "**")
                {
                    item.categoria = "Residencia y Proyecto integrador";
                }
                else if (item.categoria == "***")
                {
                    item.categoria = "Residencia, Proyecto Integrador y Servicio Social";
                }
            }

            return lista;

        }

        public List<ProyectoPropuesta> RegistrarPropuesta(String categoria, String status, String nombre, String responsable, String colaboradores, String numeroAlumnos, String descripcion)
        {
            List<ProyectoPropuesta> lista = new CD_ProyectoPropuesta().RegistrarPropuesta(categoria, status, nombre, responsable, colaboradores, Convert.ToInt32(numeroAlumnos), descripcion);

            return lista;

        }
        public void Delete(int id)
        {
            CD_ProyectoPropuesta propuesta = new CD_ProyectoPropuesta();
            propuesta.Delete(id);
        }

        public void Update(string id, String categoria, String status, String nombre, String responsable, String colaboradores, String numeroAlumnos, String descripcion)
        {
            CD_ProyectoPropuesta lista = new CD_ProyectoPropuesta(); 
            lista.Update(Convert.ToInt32(id), categoria, status, nombre, responsable, colaboradores, Convert.ToInt32(numeroAlumnos), descripcion);
            
        }

    }
}
