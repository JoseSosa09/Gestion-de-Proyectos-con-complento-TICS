using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;
using CapaEntidad;

namespace CapaDatos
{
    public class CD_Files
    {
        public void SaveFileToDatabase(string filePath, String programa, string alumno, string numeroControl)
        {
            byte[] fileBytes = File.ReadAllBytes(filePath);
            string fileName = Path.GetFileName(filePath);

            // Conexión a la base de datos (ajusta la cadena de conexión según tu configuración)
            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                oconexion.Open();

                // Insertar el archivo en la tabla de la base de datos
                string query = "INSERT INTO ArchivosWord (NombreArchivo, ContenidoArchivo, Programa, Alumno, NumeroControl) VALUES (@NombreArchivo, @ContenidoArchivo, @Programa, @Alumno, @NumeroControl)";
                using (SqlCommand command = new SqlCommand(query, oconexion))
                {
                    command.Parameters.AddWithValue("@NombreArchivo", fileName);
                    command.Parameters.AddWithValue("@ContenidoArchivo", fileBytes);
                    command.Parameters.AddWithValue("@Programa", programa);
                    command.Parameters.AddWithValue("@Alumno", alumno);
                    command.Parameters.AddWithValue("@NumeroControl", numeroControl);
                    command.ExecuteNonQuery();
                }
            }
        }

        public void SaveFileToDatabaseAlumno(string filePath, String programa, string alumno, string numeroControl, string maestro)
        {
            byte[] fileBytes = File.ReadAllBytes(filePath);
            string fileName = Path.GetFileName(filePath);

            // Conexión a la base de datos (ajusta la cadena de conexión según tu configuración)
            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                oconexion.Open();

                // Insertar el archivo en la tabla de la base de datos
                string query = "INSERT INTO ArchivosAlumnoWord (NombreArchivo, ContenidoArchivo, Programa, Alumno, NumeroControl, Maestro) VALUES (@NombreArchivo, @ContenidoArchivo, @Programa, @Alumno, @NumeroControl, @Maestro)";
                using (SqlCommand command = new SqlCommand(query, oconexion))
                {
                    command.Parameters.AddWithValue("@NombreArchivo", fileName);
                    command.Parameters.AddWithValue("@ContenidoArchivo", fileBytes);
                    command.Parameters.AddWithValue("@Programa", programa);
                    command.Parameters.AddWithValue("@Alumno", alumno);
                    command.Parameters.AddWithValue("@NumeroControl", numeroControl);
                    command.Parameters.AddWithValue("@Maestro", maestro);
                    command.ExecuteNonQuery();
                }
            }
        }

        public List<Files> LoadFilesFromDatabase()
        {
            List<Files> list = new List<Files>();

            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                oconexion.Open();

                try
                {
                    // Obtener los datos de los archivos de la base de datos
                    string query = "SELECT * FROM ArchivosWord";
                    using (SqlCommand command = new SqlCommand(query, oconexion))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            // Cargar los datos en la lista de objetos "Files"
                            while (reader.Read())
                            {
                                int fileId = reader.GetInt32(0);
                                string fileName = reader.GetString(1);
                                string programa = (string)reader["Programa"];
                                string alumno = (string)reader["Alumno"];
                                byte[] fileContent = (byte[])reader["ContenidoArchivo"];


                                // Crear el objeto "Files" y agregarlo a la lista
                                Files archivo = new Files
                                {
                                    ID = fileId,
                                    NombreArchivo = fileName,
                                    ContenidoArchivo = fileContent,
                                    programa = programa,
                                    alumno = alumno,
                                };
                                list.Add(archivo);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {

                }
            }
            return list;
        }

        public List<Files> LoadFilesFromDatabaseAlumno(String numeroControl)
        {
            List<Files> list = new List<Files>();

            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                oconexion.Open();

                try
                {
                    // Obtener los datos de los archivos de la base de datos
                    string query = "SELECT * FROM ArchivosAlumnoWord where numeroControl = '"+numeroControl+"'";
                    using (SqlCommand command = new SqlCommand(query, oconexion))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            // Cargar los datos en la lista de objetos "Files"
                            while (reader.Read())
                            {
                                int fileId = reader.GetInt32(0);
                                string fileName = reader.GetString(1);
                                string programa = (string)reader["Programa"];
                                string alumno = (string)reader["Alumno"];
                                byte[] fileContent = (byte[])reader["ContenidoArchivo"];
                                string maestro = (string)reader["Maestro"];

                                // Crear el objeto "Files" y agregarlo a la lista
                                Files archivo = new Files
                                {
                                    ID = fileId,
                                    NombreArchivo = fileName,
                                    ContenidoArchivo = fileContent,
                                    programa = programa,
                                    alumno = alumno,
                                    maestro = maestro,
                                };
                                list.Add(archivo);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {

                }
            }
            return list;
        }
        public List<Files> AlumnosFiles(String numeroControl)
        {
            List<Files> list = new List<Files>();

            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {

                    SqlCommand cmd = new SqlCommand("SP_SELECT_ALUMNOS_ARCHIVO_WORD_NUMCONTROL", oconexion);
                    cmd.Parameters.AddWithValue("@numeroControl", numeroControl);
                    cmd.CommandType = CommandType.StoredProcedure;
                    oconexion.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        // Cargar los datos en la lista de objetos "Files"
                        while (reader.Read())
                        {
                            int fileId = reader.GetInt32(0);
                            string fileName = reader.GetString(1);
                            string programa = (string)reader["Programa"];
                            string alumno = (string)reader["Alumno"];
                            byte[] fileContent = (byte[])reader["ContenidoArchivo"];


                            // Crear el objeto "Files" y agregarlo a la lista
                            Files archivo = new Files
                            {
                                ID = fileId,
                                NombreArchivo = fileName,
                                ContenidoArchivo = fileContent,
                                programa = programa,
                                alumno = alumno,
                            };
                            list.Add(archivo);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            return list;
        }


        public List<Files> BuscarPalabra(String dat)
        {
            List<Files> list = new List<Files>();

            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {

                    string query = "SELECT * FROM ArchivosAlumnoWord WHERE Alumno LIKE '" + dat + "' OR NumeroControl LIKE '" + dat + "'";
                    SqlCommand cmd = new SqlCommand(query, oconexion);                    
                    cmd.CommandType = CommandType.Text;
                    oconexion.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        // Cargar los datos en la lista de objetos "Files"
                        while (reader.Read())
                        {
                            int fileId = reader.GetInt32(0);
                            string fileName = reader.GetString(1);
                            string programa = (string)reader["Programa"];
                            string alumno = (string)reader["Alumno"];
                            byte[] fileContent = (byte[])reader["ContenidoArchivo"];


                            // Crear el objeto "Files" y agregarlo a la lista
                            Files archivo = new Files
                            {
                                ID = fileId,
                                NombreArchivo = fileName,
                                ContenidoArchivo = fileContent,
                                programa = programa,
                                alumno = alumno,
                            };
                            list.Add(archivo);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            return list;
        }

        public List<Files> MostrarAlumnoFilesSelectIndexChanged(String buscar)
        {
            List<Files> list = new List<Files>();

            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {

                    SqlCommand cmd = new SqlCommand("SP_SELECT_ALUMNOS_ARCHIVO_WORD_NUMCONTROL", oconexion);
                    cmd.Parameters.AddWithValue("@numeroControl", buscar);
                    cmd.CommandType = CommandType.StoredProcedure;
                    oconexion.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        // Cargar los datos en la lista de objetos "Files"
                        while (reader.Read())
                        {
                            int fileId = reader.GetInt32(0);
                            string fileName = reader.GetString(1);
                            string programa = (string)reader["Programa"];
                            string alumno = (string)reader["Alumno"];
                            byte[] fileContent = (byte[])reader["ContenidoArchivo"];


                            // Crear el objeto "Files" y agregarlo a la lista
                            Files archivo = new Files
                            {
                                ID = fileId,
                                NombreArchivo = fileName,
                                ContenidoArchivo = fileContent,
                                programa = programa,
                                alumno = alumno,
                            };
                            list.Add(archivo);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            return list;
        }

        public List<Files> MostrarAlumnos()
        {
            List<Files> lista = new List<Files>();

            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("SP_SELECT_ALUMNOS_ARCHIVOSWORD", oconexion);
                    cmd.CommandType = CommandType.StoredProcedure;
                    oconexion.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {

                        while (reader.Read())
                        {
                            lista.Add(new Files()
                            {                                
                                ID = Convert.ToInt32(reader["ID"]),
                                alumno = reader["Alumno"].ToString(),
                                numeroControl = reader["NumeroControl"].ToString(),                             
                                programa = reader["Programa"].ToString(),
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


        public void Delete(int id)
        {

            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    oconexion.Open();
                    string query = "delete from ArchivosWord where ID = @id";
                    using (SqlCommand command = new SqlCommand(query, oconexion))
                    {
                        command.Parameters.AddWithValue("@id", id);        
                        command.ExecuteNonQuery();
                    }

                    oconexion.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        public void DeleteAlumno(int id)
        {

            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    oconexion.Open();
                    string query = "delete from ArchivosAlumnoWord where ID = @id";
                    using (SqlCommand command = new SqlCommand(query, oconexion))
                    {
                        command.Parameters.AddWithValue("@id", id);
                        command.ExecuteNonQuery();
                    }

                    oconexion.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        public DataTable CargarAlumno()
        {
            DataTable dt = new DataTable();
            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    string query = "select concat(CONTROL_PROYECTO_INTEGRADOR.alumno, ' - ' , CONTROL_PROYECTO_INTEGRADOR.numeroControl) as nombre from CONTROL_PROYECTO_INTEGRADOR";
                    SqlDataAdapter datos = new SqlDataAdapter(query, oconexion);
                    datos.SelectCommand.CommandType = CommandType.Text;
                    datos.Fill(dt);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
            return dt;
        }

        public DataTable CargarProgramaAlumno(String numeroControl)
        {
            DataTable dt = new DataTable();
            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    string query = "select nombre from CONTROL_PROYECTO_INTEGRADOR where numeroControl = '"+numeroControl +"'";
                    SqlDataAdapter datos = new SqlDataAdapter(query, oconexion);
                    datos.SelectCommand.CommandType = CommandType.Text;
                    datos.Fill(dt);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
            return dt;
        }

        public DataTable CargarMaestro()
        {
            DataTable dt = new DataTable();
            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    string query = "select nombreCompleto as nombre from maestro";
                    SqlDataAdapter datos = new SqlDataAdapter(query, oconexion);
                    datos.SelectCommand.CommandType = CommandType.Text;
                    datos.Fill(dt);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
            return dt;
        }

        public DataTable CargarPrograma()
        {
            DataTable dt = new DataTable();
            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    string query = "SELECT DISTINCT nombre FROM CONTROL_PROYECTO_INTEGRADOR;";
                    SqlDataAdapter datos = new SqlDataAdapter(query, oconexion);
                    datos.SelectCommand.CommandType = CommandType.Text;
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
