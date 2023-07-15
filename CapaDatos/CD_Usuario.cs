using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using CapaEntidad;

namespace CapaDatos
{
    public class CD_Usuario
    {

        public List<Usuario> Listar()
        {
            List<Usuario> lista = new List<Usuario>();

            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    string query = "Select numeroControl, nombreCompleto, correo, clave from usuario";
                    SqlCommand cmd = new SqlCommand(query, oconexion);
                    cmd.CommandType = CommandType.Text;
                    oconexion.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lista.Add(new Usuario()
                            {
                                numeroControl = reader["numeroControl"].ToString(),
                                nombreCompleto = reader["nombreCompleto"].ToString(),
                                correo = reader["correo"].ToString(),
                                clave = reader["clave"].ToString(),
                            });

                        }

                    }

                }
                catch (Exception ex)
                {
                    lista = new List<Usuario>();
                }
            }
            return lista;
        }

        public void RegistrarUsuario(String nombre, String apellido, String email, String numeroControl, String password)
        {
            String nombreCompleto = nombre + " " + apellido;
            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                SqlCommand comando = new SqlCommand("REGISTRAR_USUARIO", oconexion);
                oconexion.Open();
                comando.CommandText = "REGISTRAR_USUARIO";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@nombreCompleto", nombreCompleto);
                comando.Parameters.AddWithValue("@correo", email);
                comando.Parameters.AddWithValue("@numeroControl", numeroControl);
                comando.Parameters.AddWithValue("@clave", password);
                comando.ExecuteNonQuery();
                comando.Parameters.Clear();
            }

        } //RegistrarUsuario
    }
}
