using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaEntidad;

namespace CapaDatos
{
    public class CD_Maestro
    {
        public List<Maestro> Listar()
        {
            List<Maestro> lista = new List<Maestro>();

            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {                    
                    SqlCommand cmd = new SqlCommand("SP_SELECT_MAESTRO", oconexion);
                    cmd.CommandType = CommandType.StoredProcedure;
                    oconexion.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lista.Add(new Maestro()
                            {
                                rfc = reader["rfc"].ToString(),
                                nombreCompleto = reader["nombreCompleto"].ToString(),
                                correo = reader["correo"].ToString(),
                                clave = reader["clave"].ToString()                                
                            });

                        }

                    }

                }
                catch (Exception ex)
                {
                    lista = new List<Maestro>();
                }
            }
            return lista;
        }

        public DataTable cargarMaestros()
        {
            DataTable dt = new DataTable();
            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    SqlDataAdapter datos = new SqlDataAdapter("SP_SELECT_MAESTRO", oconexion);
                    datos.SelectCommand.CommandType = CommandType.StoredProcedure;
                    datos.Fill(dt);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
            return dt;
        }
    }
}
