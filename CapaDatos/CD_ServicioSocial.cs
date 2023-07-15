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
    public class CD_ServicioSocial
    {
        public DataTable ComboBox()
        {
            DataTable dt = new DataTable();
            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    SqlDataAdapter datos = new SqlDataAdapter("SP_SELECT_PROGRAMA_SERVICIO_SOCIAL", oconexion);
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
        public List<ServicioSocial> Seleccionar(string buscar)
        {
            List<ServicioSocial> lista = new List<ServicioSocial>();    

            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {                    
                    SqlCommand cmd = new SqlCommand("SP_SELECT_PROGRAMA_SERVICIO_SOCIAL_LISTA", oconexion);
                    cmd.Parameters.AddWithValue("@buscar", buscar);
                    cmd.CommandType = CommandType.StoredProcedure;
                    oconexion.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lista.Add(new ServicioSocial()
                            {
                                idProyectoPropuesta = Convert.ToInt32(reader["idProyectoPropuesta"]),
                                nombreDepartamento = reader["nombreDepartamento"].ToString(),
                                responsableDepartamento = reader["responsableDepartamento"].ToString(),
                                responsablePrograma = reader["responsablePrograma"].ToString(),
                                puestoResponsable = reader["puestoResponsable"].ToString(),
                                nombrePrograma = reader["nombrePrograma"].ToString(),
                                numAlumnos = Convert.ToInt32(reader["numAlumnos"]),
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
        
        public List<ServicioSocial> MostrarTodo()
        {
            List<ServicioSocial> lista = new List<ServicioSocial>();

            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("SP_SELECT_PROGRAMA_SERVICIO_SOCIAL", oconexion);
                    cmd.CommandType = CommandType.StoredProcedure;
                    oconexion.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lista.Add(new ServicioSocial()
                            {
                                idProyectoPropuesta = Convert.ToInt32(reader["idProyectoPropuesta"]),
                                nombreDepartamento = reader["nombreDepartamento"].ToString(),
                                responsableDepartamento = reader["responsableDepartamento"].ToString(),                                
                                responsablePrograma = reader["responsablePrograma"].ToString(),
                                puestoResponsable = reader["puestoResponsable"].ToString(),                                                                
                                nombrePrograma = reader["nombrePrograma"].ToString(),
                                numAlumnos = Convert.ToInt32(reader["numAlumnos"]),
                                actividadRealizar1= reader["actividadRealizar1"].ToString(),
                                actividadRealizar2= reader["actividadRealizar2"].ToString(),
                                actividadRealizar3= reader["actividadRealizar3"].ToString(),
                                actividadRealizar4= reader["actividadRealizar4"].ToString(),
                                actividadRealizar5= reader["actividadRealizar5"].ToString(),
                                categoria = reader["categoria"].ToString(),                                        
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

        public List<ServicioSocial> RegistrarServicio(int idProyectoPropuesta, string nombreDepartamento, string responsableDepartamento, string responsablePrograma, string puestoResponsable, string nombrePrograma, int numAlumnos, string categoria)
        {
            List<ServicioSocial> lista = new List<ServicioSocial>();

            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("SP_INSERT_PROGRAMA_SERVICIO_SOCIAL", oconexion);
                    cmd.Parameters.AddWithValue("@idProyectoPropuesta", idProyectoPropuesta);                                        
                    cmd.Parameters.AddWithValue("@nombreDepartamento", nombreDepartamento);
                    cmd.Parameters.AddWithValue("@responsableDepartamento", responsableDepartamento);
                    cmd.Parameters.AddWithValue("@responsablePrograma", responsablePrograma);                    
                    cmd.Parameters.AddWithValue("@puestoResponsable", puestoResponsable);
                    cmd.Parameters.AddWithValue("@nombrePrograma", nombrePrograma);
                    cmd.Parameters.AddWithValue("@numAlumnos", numAlumnos);
                    cmd.Parameters.AddWithValue("@categoria", categoria);
                    cmd.CommandType = CommandType.StoredProcedure;
                    oconexion.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {

                        while (reader.Read())
                        {
                            lista.Add(new ServicioSocial()
                            {
                                idProyectoPropuesta = Convert.ToInt32(reader["idProyectoPropuesta"]),
                                responsablePrograma = reader["responsablePrograma"].ToString(),                                
                                nombrePrograma = reader["nombrePrograma"].ToString(),
                                responsableDepartamento = reader["responsableDepartamento"].ToString(),
                                nombreDepartamento = reader["nombreDepartamento"].ToString(),                                
                                puestoResponsable = reader["puestoResponsable"].ToString(),
                                numAlumnos = Convert.ToInt32(reader["numAlumnos"]),
                                categoria = reader["categoria"].ToString(),                                                                
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

        public List<ServicioSocial> BuscarID(int idProyectoIntegrador)
        {
            List<ServicioSocial> lista = new List<ServicioSocial>();

            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("SP_SEARCH_PROGRAMA_SERVICIO_SOCIAL", oconexion);
                    cmd.Parameters.AddWithValue("@idProyectoPropuesta", idProyectoIntegrador);
                    cmd.CommandType = CommandType.StoredProcedure;
                    oconexion.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {

                        while (reader.Read())
                        {
                            lista.Add(new ServicioSocial()
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
    }
}
