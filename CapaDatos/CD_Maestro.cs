using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
                    string query = "Select rfc, nombreCompleto, correo, clave, estado from maestro";
                    SqlCommand cmd = new SqlCommand(query, oconexion);
                    cmd.CommandType = CommandType.Text;
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
                                clave = reader["clave"].ToString(),
                                estado = Convert.ToBoolean(reader["estado"])
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
    }
}
