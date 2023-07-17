using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CD_AlumnoMateriaMaestro
    {

        public void Insert(String numeroControl, String materia, String maestro)
        {            
            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                SqlCommand comando = new SqlCommand("SP_INSERT_ALUMNO_MATERIA_MAESTRO", oconexion);
                oconexion.Open();
                comando.CommandText = "SP_INSERT_ALUMNO_MATERIA_MAESTRO";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@maestro", maestro);
                comando.Parameters.AddWithValue("@materia", materia);
                comando.Parameters.AddWithValue("@numeroControl", numeroControl);                
                comando.ExecuteNonQuery();
                comando.Parameters.Clear();
            }

        } //RegistrarUsuario        
    }
}
