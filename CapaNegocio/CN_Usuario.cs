using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidad;


namespace CapaNegocio
{
    public class CN_Usuario
    {
        private CD_Usuario objcd_Usuario = new CD_Usuario();

        public List<Usuario> Listar()
        {

            return objcd_Usuario.Listar();
        }

        public void RegistrarUsuario(String nombre, String apellido, String email, String numeroControl, String password)
        {
            objcd_Usuario.RegistrarUsuario(nombre, apellido, email, numeroControl, password);
        }
        public void RegistrarAlumno(String nombre, String apellido, String email, String numeroControl, String password)
        {
            objcd_Usuario.RegistrarAlumno(nombre, apellido, email, numeroControl, password);
        }
    }
}
