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
    public class CD_ProyectoPropuesta
    {        

        public List<ProyectoPropuesta> leer_datos(string dato)
        {
            List<ProyectoPropuesta> lista = new List<ProyectoPropuesta>();

            try
            {
                using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
                {
                    string query = "SELECT* FROM PROYECTO_PROPUESTA WHERE idProyectoPropuesta like '" + dato.ToString() + "' OR categoria like '" + dato.ToString() + "' OR estatus like '" + dato.ToString() + "'OR nombre like '" + dato.ToString() + "'OR responsable like '" + dato.ToString() + "'OR colaboradores like '" + dato.ToString() + "'or numAlumnos like '" + dato.ToString() + "'OR descripcion like '" + dato.ToString()+"'";



                    SqlCommand cmd = new SqlCommand(query, oconexion);
                    cmd.CommandType = CommandType.Text;
                    oconexion.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lista.Add(new ProyectoPropuesta()
                            {
                                idProyectoPropuesta = Convert.ToInt32(reader["idProyectoPropuesta"]),
                                categoria = reader["categoria"].ToString(),
                                estatus = reader["estatus"].ToString(),
                                nombre = reader["nombre"].ToString(),
                                responsable = reader["responsable"].ToString(),
                                colaboradores = reader["colaboradores"].ToString(),
                                numAlumnos = Convert.ToInt32(reader["numAlumnos"]),
                                descripcion = reader["descripcion"].ToString()
                            });

                        }

                    }

                }

            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return lista;
        }
        public List<ProyectoPropuesta> MostrarTodo()
        {
            List<ProyectoPropuesta> lista = new List<ProyectoPropuesta>();

            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {

                    SqlCommand cmd = new SqlCommand("SELECT * FROM PROYECTO_PROPUESTA", oconexion);                    
                    cmd.CommandType = CommandType.Text;
                    oconexion.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lista.Add(new ProyectoPropuesta()
                            {    
                                idProyectoPropuesta = Convert.ToInt32(reader["idProyectoPropuesta"]),
                                categoria = reader["categoria"].ToString(),
                                estatus = reader["estatus"].ToString(),
                                nombre = reader["nombre"].ToString(),
                                responsable = reader["responsable"].ToString(),
                                colaboradores = reader["colaboradores"].ToString(),
                                numAlumnos = Convert.ToInt32(reader["numAlumnos"]),
                                descripcion = reader["descripcion"].ToString(),
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

        public List<ProyectoPropuesta> MostrarServicio()
        {
            List<ProyectoPropuesta> lista = new List<ProyectoPropuesta>();

            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("SP_SELECT_SERVICIO_PROYECTO_PROPUESTA", oconexion);
                    cmd.CommandType = CommandType.StoredProcedure;
                    oconexion.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lista.Add(new ProyectoPropuesta()
                            {
                                idProyectoPropuesta = Convert.ToInt32(reader["idProyectoPropuesta"]),
                                categoria = reader["categoria"].ToString(),
                                estatus = reader["estatus"].ToString(),
                                nombre = reader["nombre"].ToString(),
                                responsable = reader["responsable"].ToString(),
                                colaboradores = reader["colaboradores"].ToString(),
                                numAlumnos = Convert.ToInt32(reader["numAlumnos"]),
                                descripcion = reader["descripcion"].ToString()
                            });

                        }

                    }

                }
                catch (Exception ex)
                {
                    lista = new List<ProyectoPropuesta>();
                }
            }
            return lista;
        }

        public List<ProyectoPropuesta> MostrarIntegrador()
        {
            List<ProyectoPropuesta> lista = new List<ProyectoPropuesta>();

            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("SP_SELECT_INTEGRADOR_PROYECTO_PROPUESTA", oconexion);
                    cmd.CommandType = CommandType.StoredProcedure;
                    oconexion.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lista.Add(new ProyectoPropuesta()
                            {
                                idProyectoPropuesta = Convert.ToInt32(reader["idProyectoPropuesta"]),
                                categoria = reader["categoria"].ToString(),
                                estatus = reader["estatus"].ToString(),
                                nombre = reader["nombre"].ToString(),
                                responsable = reader["responsable"].ToString(),
                                colaboradores = reader["colaboradores"].ToString(),
                                numAlumnos = Convert.ToInt32(reader["numAlumnos"]),
                                descripcion = reader["descripcion"].ToString()
                            });

                        }

                    }

                }
                catch (Exception ex)
                {
                    lista = new List<ProyectoPropuesta>();
                }
            }
            return lista;
        }


        public List<ProyectoPropuesta> RegistrarPropuesta(String categoria, String status, String nombre, String responsable, String colaboradores, int numeroAlumnos, String descripcion)
        {
            List<ProyectoPropuesta> lista = new List<ProyectoPropuesta>();

            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("SP_INSERT_PROYECTO_PROPUESTA", oconexion);
                    cmd.Parameters.AddWithValue("@categoria", categoria);
                    cmd.Parameters.AddWithValue("@estatus", status);
                    cmd.Parameters.AddWithValue("@nombre", nombre);
                    cmd.Parameters.AddWithValue("@responsable", responsable);
                    cmd.Parameters.AddWithValue("@colaboradores", colaboradores);
                    cmd.Parameters.AddWithValue("@numAlumnos", numeroAlumnos);
                    cmd.Parameters.AddWithValue("@descripcion", descripcion);                    
                    cmd.CommandType = CommandType.StoredProcedure;                    
                    oconexion.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        
                        while (reader.Read())
                        {
                            lista.Add(new ProyectoPropuesta()
                            {
                                categoria = reader["categoria"].ToString(),
                                estatus = reader["estatus"].ToString(),
                                nombre = reader["nombre"].ToString(),
                                responsable = reader["responsable"].ToString(),
                                colaboradores = reader["colaboradores"].ToString(),
                                numAlumnos = Convert.ToInt32(reader["numAlumnos"]),
                                descripcion = reader["descripcion"].ToString()
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

        public List<ProyectoPropuesta> Delete(int id)
        {
            List<ProyectoPropuesta> lista = new List<ProyectoPropuesta>();

            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("SP_DELETE_PROYECTO_PROPUESTA", oconexion);
                    cmd.Parameters.AddWithValue("@idProyectoPropuesta", id);
                    cmd.CommandType = CommandType.StoredProcedure;
                    oconexion.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lista.Add(new ProyectoPropuesta()
                            {
                                idProyectoPropuesta = Convert.ToInt32(reader["idProyectoPropuesta"]),
                                categoria = reader["categoria"].ToString(),
                                estatus = reader["estatus"].ToString(),
                                nombre = reader["nombre"].ToString(),
                                responsable = reader["responsable"].ToString(),
                                colaboradores = reader["colaboradores"].ToString(),
                                numAlumnos = Convert.ToInt32(reader["numAlumnos"]),
                                descripcion = reader["descripcion"].ToString()
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

        public List<ProyectoPropuesta> Update (int id, String categoria, String status, String nombre, String responsable, String colaboradores, int numeroAlumnos, String descripcion)
        {
            List<ProyectoPropuesta> lista = new List<ProyectoPropuesta>();

            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("SP_UPDATE_PROYECTO_PROPUESTA", oconexion);
                    cmd.Parameters.AddWithValue("@idProyectoPropuesta", id);
                    cmd.Parameters.AddWithValue("@categoria", categoria);
                    cmd.Parameters.AddWithValue("@estatus", status);
                    cmd.Parameters.AddWithValue("@nombre", nombre);
                    cmd.Parameters.AddWithValue("@responsable", responsable);
                    cmd.Parameters.AddWithValue("@colaboradores", colaboradores);
                    cmd.Parameters.AddWithValue("@numAlumnos", numeroAlumnos);
                    cmd.Parameters.AddWithValue("@descripcion", descripcion);
                    cmd.CommandType = CommandType.StoredProcedure;

                    oconexion.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {

                        while (reader.Read())
                        {
                            lista.Add(new ProyectoPropuesta()
                            {
                                idProyectoPropuesta = Convert.ToInt32(reader["idProyectoPropuesta"]),
                                categoria = reader["categoria"].ToString(),
                                estatus = reader["estatus"].ToString(),
                                nombre = reader["nombre"].ToString(),
                                responsable = reader["responsable"].ToString(),
                                colaboradores = reader["colaboradores"].ToString(),
                                numAlumnos = Convert.ToInt32(reader["numAlumnos"]),
                                descripcion = reader["descripcion"].ToString()
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