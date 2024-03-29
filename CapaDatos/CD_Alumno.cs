﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using CapaEntidad;

namespace CapaDatos
{
    public class CD_Alumno
    {


        public List<Alumno> leer_datos(String dato, String maestro)
        {   List<Alumno> lista = new List<Alumno>();            

            try
            {
                using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
                {
                    String query = "SELECT ALUMNO.nombre, ALUMNO.numeroControl, ALUMNO.telefono, " +
    "ALUMNO_MAESTRO_MATERIA.materia, ALUMNO_MAESTRO_MATERIA.maestro, " +
    "ALUMNO.email, ALUMNO_MAESTRO_MATERIA.fechaCreacion, ALUMNO_MAESTRO_MATERIA.id, " +
    "CONTROL_PROYECTO_INTEGRADOR.categoria, CONTROL_PROYECTO_INTEGRADOR.nombre AS nombreProyecto " +
    "FROM ALUMNO_MAESTRO_MATERIA " +
    "INNER JOIN MAESTRO ON ALUMNO_MAESTRO_MATERIA.maestro = MAESTRO.nombreCompleto " +
    "INNER JOIN ALUMNO ON ALUMNO_MAESTRO_MATERIA.numeroControl = ALUMNO.numeroControl " +
    "LEFT JOIN CONTROL_PROYECTO_INTEGRADOR ON ALUMNO.numeroControl = CONTROL_PROYECTO_INTEGRADOR.numeroControl " +
    "WHERE MAESTRO.nombreCompleto = '" + maestro + "' " +
    "AND (ALUMNO.numeroControl LIKE '%" + dato + "%' OR " +
    "ALUMNO_MAESTRO_MATERIA.materia LIKE '%" + dato + "%' OR " +
    "ALUMNO.telefono LIKE '%" + dato + "%' OR " +
    "ALUMNO.email LIKE '%" + dato + "%' OR " +
    "ALUMNO.nombre LIKE '%" + dato + "%')";

                    //string query = "SELECT * FROM PROYECTO_PROPUESTA WHERE idProyectoPropuesta like '" + dato.ToString() + "' OR categoria like '" + dato.ToString() + "' OR estatus like '" + dato.ToString() + "'OR nombre like '" + dato.ToString() + "'OR responsable like '" + dato.ToString() + "'OR colaboradores like '" + dato.ToString() + "'or numAlumnos like '" + dato.ToString() + "'OR descripcion like '" + dato.ToString() + "'";

                    SqlCommand cmd = new SqlCommand(query, oconexion);
                    cmd.CommandType = CommandType.Text;
                    oconexion.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lista.Add(new Alumno()
                            {                                
                                nombre = reader["nombre"].ToString(),
                                numeroControl = reader["numeroControl"].ToString(),
                                telefono = reader["telefono"].ToString(),
                                materia = reader["materia"].ToString(),
                                email = reader["email"].ToString(),
                                fechaCreacion = reader["fechaCreacion"].ToString()
                            });
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return lista;
        }

        public List<Alumno> Listar()
            {
                List<Alumno> lista = new List<Alumno>();

                using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
                {
                    try
                    {
                        SqlCommand cmd = new SqlCommand("SP_SELECT_ALUMNOS", oconexion);
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
                                    email = reader["email"].ToString(),
                                    fechaCreacion = reader["fechaCreacion"].ToString(),
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

        public List<Alumno> Listar_X_Maestro(String maestro)
            {
                List<Alumno> lista = new List<Alumno>();

                using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
                {
                    try
                    {
                        SqlCommand cmd = new SqlCommand("SP_SELECT_ALUMNOS_X_MAESTRO", oconexion);
                        cmd.Parameters.AddWithValue("@maestro", maestro);
                        cmd.CommandType = CommandType.StoredProcedure;
                        oconexion.Open();

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                lista.Add(new Alumno()
                                {
                                    id = Convert.ToInt32(reader["id"].ToString()),
                                    numeroControl = reader["numeroControl"].ToString(),
                                    nombre = reader["nombre"].ToString(),
                                    telefono = reader["telefono"].ToString(),                                    
                                    email = reader["email"].ToString(),
                                    materia= reader["materia"].ToString(),
                                    categoria = reader["categoria"].ToString(),
                                    proyecto= reader["nombreProyecto"].ToString(),
                                    maestro= reader["maestro"].ToString(),
                                    fechaCreacion = reader["fechaCreacion"].ToString(),
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

        public void Delete(String numeroControl)
        {            

            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("EliminarAlumno", oconexion);
                    cmd.Parameters.AddWithValue("@numeroControlEliminar", numeroControl);
                    cmd.CommandType = CommandType.StoredProcedure;
                    oconexion.Open();
                    SqlDataReader reader = cmd.ExecuteReader();


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }            
        }

        public void RegistrarAlumno(String nombre, String apellido, String telefono, String email, String numeroControl, String password)
            {
                String nombreCompleto = nombre + " " + apellido;
                using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
                {
                    SqlCommand comando = new SqlCommand("SP_REGISTRAR_ALUMNO", oconexion);
                    oconexion.Open();
                    comando.CommandText = "SP_REGISTRAR_ALUMNO";
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Parameters.AddWithValue("@nombre", nombreCompleto);
                    comando.Parameters.AddWithValue("@email", email);
                    comando.Parameters.AddWithValue("@telefono", telefono);
                    comando.Parameters.AddWithValue("@numeroControl", numeroControl);
                    comando.Parameters.AddWithValue("@clave", password);
                    comando.ExecuteNonQuery();
                    comando.Parameters.Clear();
                }

            } //RegistrarUsuario        
    }
}
