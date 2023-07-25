using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidad;

namespace CapaNegocio
{
    public class CN_Alumno
    {
        CD_Alumno objcd_alumno = new CD_Alumno();

        public List<Alumno> Listar()
        {
            return objcd_alumno.Listar();
        }

        public List<Alumno> Listar_X_Maestro(String maestro)
        {
            return objcd_alumno.Listar_X_Maestro(maestro);
        }

        public List<Alumno> Listar_X_Palabra(String query)
        {
            return objcd_alumno.leer_datos(query);
        }

        public void RegistrarAlumno(String nombre, String apellido, String telefono, String email, String numeroControl, String password)
        {
            objcd_alumno.RegistrarAlumno(nombre, apellido, telefono, email, numeroControl, password);
        }
    }
}
