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
    public class CD_ProyectoIntegrador
    {
        public DataTable CargarIntegrador()
        {
            DataTable dt = new DataTable();
            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    SqlDataAdapter datos = new SqlDataAdapter("SP_SELECT_PROYECTO_INTEGRADOR", oconexion);
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

        public DataTable CargarModalidad()
        {
            DataTable dt = new DataTable();
            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    SqlDataAdapter datos = new SqlDataAdapter("SP_SELECT_MODALIDAD", oconexion);
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

        public DataTable CargarAlumnos()
        {
            DataTable dt = new DataTable();
            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    SqlDataAdapter datos = new SqlDataAdapter("SP_SELECT_NAME_NUMEROCONTROL_ALUMNO", oconexion);
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

        public List<ProyectoIntegrador> RegistrarServicio(int idProyectoPropuesta, string responsablePrograma, string colaboradores, string nombrePrograma, string descripcion, string categoria, string objetivo, string alcancesProyecto, string desarrollo)
        {
            List<ProyectoIntegrador> lista = new List<ProyectoIntegrador>();

            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("SP_INSERT_PROYECTO_INTEGRADOR", oconexion);
                    cmd.Parameters.AddWithValue("@idProyectoPropuesta", idProyectoPropuesta);
                    cmd.Parameters.AddWithValue("@responsable", responsablePrograma);
                    cmd.Parameters.AddWithValue("@nombre", nombrePrograma);
                    cmd.Parameters.AddWithValue("@categoria", categoria);
                    cmd.Parameters.AddWithValue("@colaboradores", colaboradores);
                    cmd.Parameters.AddWithValue("@descripcion", descripcion);
                    cmd.Parameters.AddWithValue("@alcancesProyecto", alcancesProyecto);
                    cmd.Parameters.AddWithValue("@objetivo", objetivo);
                    cmd.Parameters.AddWithValue("@desarrollo", desarrollo);
                    cmd.CommandType = CommandType.StoredProcedure;
                    oconexion.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {

                        while (reader.Read())
                        {
                            lista.Add(new ProyectoIntegrador()
                            {
                                idProyectoPropuesta = Convert.ToInt32(reader["idProyectoPropuesta"]),
                                responsable = reader["responsablePrograma"].ToString(),
                                nombre = reader["nombrePrograma"].ToString(),
                                categoria = reader["categoria"].ToString(),
                                colaboradores = reader["categoria"].ToString(),
                                descripcion = reader["categoria"].ToString(),
                                alcancesProyecto = reader["categoria"].ToString(),
                                objetivo = reader["categoria"].ToString(),
                                desarrollo = reader["categoria"].ToString(),
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

        public List<ProyectoIntegrador> MostrarIntegrador()
        {
            List<ProyectoIntegrador> lista = new List<ProyectoIntegrador>();

            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("SP_SELECT_PROYECTO_INTEGRADOR", oconexion);
                    cmd.CommandType = CommandType.StoredProcedure;
                    oconexion.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {

                        while (reader.Read())
                        {
                            lista.Add(new ProyectoIntegrador()
                            {
                                idProyectoPropuesta = Convert.ToInt32(reader["idProyectoPropuesta"]),
                                responsable = reader["responsable"].ToString(),
                                nombre = reader["nombre"].ToString(),
                                categoria = reader["categoria"].ToString(),
                                colaboradores = reader["colaboradores"].ToString(),
                                descripcion = reader["categoria"].ToString(),
                                alcancesProyecto = reader["alcancesProyecto"].ToString(),
                                objetivo = reader["objetivo"].ToString(),
                                desarrollo = reader["desarrollo"].ToString(),
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

        public List<ProyectoIntegrador> BuscarID(int idProyectoIntegrador)
        {
            List<ProyectoIntegrador> lista = new List<ProyectoIntegrador>();

            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("SP_SEARCH_PROYECTO_INTEGRADOR", oconexion);
                    cmd.Parameters.AddWithValue("@idProyectoPropuesta", idProyectoIntegrador);
                    cmd.CommandType = CommandType.StoredProcedure;
                    oconexion.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {

                        while (reader.Read())
                        {
                            lista.Add(new ProyectoIntegrador()
                            {
                                idProyectoPropuesta = Convert.ToInt32(reader["idProyectoPropuesta"]),                                
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
    
        public List<ProyectoIntegrador> Delete(string nombre){
            List<ProyectoIntegrador> lista = new List<ProyectoIntegrador>();

            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("SP_DELETE_PROYECTO_INTEGRADOR", oconexion);
                    cmd.Parameters.AddWithValue("@nombre", nombre);
                    cmd.CommandType = CommandType.StoredProcedure;
                    oconexion.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            return lista;
        }

        


    }
}
