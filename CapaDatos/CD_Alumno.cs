using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using CapaEntidad;

namespace CapaDatos
{
    public class CD_Alumno
    {
            public List<Alumno> Listar()
            {
                List<Alumno> lista = new List<Alumno>();

                using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
                {
                    try
                    {
                        SqlCommand cmd = new SqlCommand("SP_SELECT_ALUMNO", oconexion);
                        cmd.CommandType = CommandType.StoredProcedure;
                        oconexion.Open();

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                lista.Add(new Alumno()
                                {
                                    numeroControl = reader["numeroControl"].ToString(),
                                    nombre = reader["nombre"].ToString(),
                                    telefono = reader["telefono"].ToString(),
                                    clave = reader["clave"].ToString(),
                                });

                            }

                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                return lista;
            }

            public void RegistrarAlumno(String nombre, String apellido, String telefono, String numeroControl, String password)
            {
                String nombreCompleto = nombre + " " + apellido;
                using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
                {
                    SqlCommand comando = new SqlCommand("SP_REGISTRAR_ALUMNO", oconexion);
                    oconexion.Open();
                    comando.CommandText = "SP_REGISTRAR_ALUMNO";
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Parameters.AddWithValue("@nombre", nombreCompleto);
                    comando.Parameters.AddWithValue("@telefono", telefono);
                    comando.Parameters.AddWithValue("@numeroControl", numeroControl);
                    comando.Parameters.AddWithValue("@clave", password);
                    comando.ExecuteNonQuery();
                    comando.Parameters.Clear();
                }

            } //RegistrarUsuario        
    }
}
