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
    public class CN_ControlProyectoIntegrador
    {
        public List<ControlProyectoIntegrador> Insertar(int idProyectoPropuesta, string nombre, string alumno, string numeroControl, string modalidad, string responsable)
        {
            List<ControlProyectoIntegrador> lista = new CD_ControlProyectoIntegrador().Insertar(idProyectoPropuesta, nombre, alumno, numeroControl, modalidad, responsable);

            return lista;
        }
       

        public void Delete(int idTable)
        {
            CD_ControlProyectoIntegrador delete = new CD_ControlProyectoIntegrador();
            delete.Delete(idTable);
        }

        public void Update(string alumno, string nombre, string modalidad)
        {
            CD_ControlProyectoIntegrador update = new CD_ControlProyectoIntegrador();
            update.Update(alumno, nombre, modalidad);
        }

        public List<ControlProyectoIntegrador> MostrarTodo()
        {
            List<ControlProyectoIntegrador> lista = new CD_ControlProyectoIntegrador().MostrarTodo();

            return lista;
        }
        public List<Alumno> BuscarAlumno()
        {
            List<Alumno> lista = new CD_ControlProyectoIntegrador().BuscarAlumno();

            return lista;
        }
        public List<Alumno> NombreRepetidoAlumnos(String nombre)
        {
            List<Alumno> lista = new CD_ControlProyectoIntegrador().NombreRepetidoAlumnos(nombre);

            return lista;
        }

        public List<ControlProyectoIntegrador> ProyectoRepetido()
        {
            List<ControlProyectoIntegrador> lista = new CD_ControlProyectoIntegrador().ProyectoRepetido();

            return lista;
        }
    }
}
