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
    public class CD_ControlProyectoIntegrador
    {
        public List<ControlProyectoIntegrador> Insertar(int idProyectoPropuesta, string nombre, string alumno, string numeroControl, string modalidad, string responsable)
        {
            List<ControlProyectoIntegrador> lista = new List<ControlProyectoIntegrador>();

            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("SP_INSERT_CONTROL_PROYECTO_INTEGRADOR", oconexion);
                    cmd.Parameters.AddWithValue("@idProyectoPropuesta", idProyectoPropuesta);                    
                    cmd.Parameters.AddWithValue("@nombre", nombre);
                    cmd.Parameters.AddWithValue("@alumno", alumno);
                    cmd.Parameters.AddWithValue("@numeroControl", numeroControl);                                       
                    cmd.Parameters.AddWithValue("@modalidad", modalidad);
                    cmd.Parameters.AddWithValue("@responsable", responsable);
                    cmd.CommandType = CommandType.StoredProcedure;
                    oconexion.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {

                        while (reader.Read())
                        {
                            lista.Add(new ControlProyectoIntegrador()
                            {
                                idProyectoPropuesta = Convert.ToInt32(reader["idProyectoPropuesta"]),
                                nombre = reader["nombre"].ToString(),
                                alumno = reader["alumno"].ToString(),
                                numeroControl = reader["numeroControl"].ToString(),
                                modalidad = reader["modalidad"].ToString(),                                
                                responsable = reader["responsable"].ToString(),
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

        public List<ControlProyectoIntegrador> Delete(int idTable)
        {                        
            List<ControlProyectoIntegrador> lista = new List<ControlProyectoIntegrador>();

            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("SP_DELETE_CONTROL_PROYECTO_INTEGRADOR", oconexion);
                    cmd.Parameters.AddWithValue("@idTable", idTable);
                    cmd.CommandType = CommandType.StoredProcedure;
                    oconexion.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lista.Add(new ControlProyectoIntegrador()
                            {
                                idProyectoPropuesta = Convert.ToInt32(reader["idProyectoPropuesta"]),                                
                                nombre = reader["nombre"].ToString(),
                                responsable = reader["responsable"].ToString(),                                
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
    
        public void Update(string alumno, string nombre, string modalidad)
        {
            using(SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("SP_UPDATE_CONTROL_PROYECTO_INTEGRADOR", oconexion);
                    cmd.Parameters.AddWithValue("@alumno", alumno);
                    cmd.Parameters.AddWithValue("@nombre", nombre);
                    cmd.Parameters.AddWithValue("@modalidad", modalidad);
                    cmd.CommandType = CommandType.StoredProcedure;
                    oconexion.Open();                    
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        public List<ControlProyectoIntegrador> MostrarTodo()
        {
            List<ControlProyectoIntegrador> lista = new List<ControlProyectoIntegrador>();

            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("SP_SELECT_CONTROL_PROYECTO_INTEGRADOR", oconexion);                    
                    cmd.CommandType = CommandType.StoredProcedure;
                    oconexion.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {

                        while (reader.Read())
                        {
                            lista.Add(new ControlProyectoIntegrador()
                            {
                                idTable = Convert.ToInt32(reader["idTable"]),
                                nombre = reader["nombre"].ToString(),
                                alumno = reader["alumno"].ToString(),                                
                                numeroControl = reader["numeroControl"].ToString(),
                                modalidad = reader["modalidad"].ToString(),                                
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

        public List<Alumno> BuscarAlumno()
        {
            List<Alumno> lista = new List<Alumno>();

            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("SP_SELECT_CONTROL_PROYECTO_INTEGRADOR", oconexion);
                    cmd.CommandType = CommandType.StoredProcedure;
                    oconexion.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {

                        while (reader.Read())
                        {
                            lista.Add(new Alumno()
                            {                                
                                numeroControl = reader["numeroControl"].ToString(),                             
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
        
        public List<Alumno> NombreRepetidoAlumnos(String nombre)
        {
            List<Alumno> lista = new List<Alumno>();
            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("SP_SELECT_ESPECIFIC_ALUMNO", oconexion);
                    cmd.Parameters.AddWithValue("@nombre", nombre);                    
                    cmd.CommandType = CommandType.StoredProcedure;
                    oconexion.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {

                        while (reader.Read())
                        {
                            lista.Add(new Alumno()
                            {
                                numeroControl = reader["numeroControl"].ToString(),
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

        public List<ControlProyectoIntegrador> ProyectoRepetido()
        {
            List<ControlProyectoIntegrador> lista = new List<ControlProyectoIntegrador>();
            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("SP_SELECT_CONTROL_PROYECTO_INTEGRADOR", oconexion);
                    cmd.CommandType = CommandType.StoredProcedure;
                    oconexion.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {

                        while (reader.Read())
                        {
                            lista.Add(new ControlProyectoIntegrador()
                            {
                                nombre = reader["nombre"].ToString(),
                                modalidad = reader["modalidad"].ToString(),
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
