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
        public string RecuperarClave(string telefono, string numeroControl, string email)
        {
            string clave = "";
            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                oconexion.Open();

                try
                {
                    // Corregir la consulta SQL utilizando parámetros
                    string query = "SELECT clave FROM Alumno WHERE telefono = @Telefono AND numeroControl = @NumeroControl AND email = @Email";
                    using (SqlCommand command = new SqlCommand(query, oconexion))
                    {
                        // Agregar los parámetros a la consulta
                        command.Parameters.AddWithValue("@Telefono", telefono);
                        command.Parameters.AddWithValue("@NumeroControl", numeroControl);
                        command.Parameters.AddWithValue("@Email", email);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            // Cargar los datos en la lista de objetos "Files"
                            while (reader.Read())
                            {
                                clave = (string)reader["clave"];
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Manejo de excepciones (opcional)
                }
            }
            return clave;
        }


        public void SaveFileToDatabase(string filePath, String programa, string alumno, string numeroControl, string maestro)
        {
            byte[] fileBytes = File.ReadAllBytes(filePath);
            string fileName = Path.GetFileName(filePath);

            // Conexión a la base de datos (ajusta la cadena de conexión según tu configuración)
            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                oconexion.Open();

                // Insertar el archivo en la tabla de la base de datos
                string query = "INSERT INTO ArchivosWord (NombreArchivo, ContenidoArchivo, Programa, Alumno, NumeroControl, Maestro) VALUES (@NombreArchivo, @ContenidoArchivo, @Programa, @Alumno, @NumeroControl, @Maestro)";
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

        public List<Files> LoadFilesFromDatabase(String maestro)
        {
            List<Files> list = new List<Files>();

            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                oconexion.Open();

                try
                {
                    // Obtener los datos de los archivos de la base de datos
                    string query = "SELECT * FROM ArchivosWord where Maestro = '"+maestro+"'";
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
                    
                    SqlCommand cmd = new SqlCommand("SP_SELECT_ALUMNOS_ARCHIVO_WORD_NUMCONT", oconexion);
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

        public List<Files> MostrarAlumnoFilesSelectIndexChanged(String buscar, String maestro)
        {
            List<Files> list = new List<Files>();

            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {

                    SqlCommand cmd = new SqlCommand("SP_SELECT_ALUMNOS_ARCHIVO_WORD_NUMCONTROL", oconexion);
                    cmd.Parameters.AddWithValue("@numeroControl", buscar);
                    cmd.Parameters.AddWithValue("@maestro", maestro);
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

        public void GuardarEncuesta(string nombrealumno, string numeroControl, string maestro, string java, string python, string cmasmas, string javascript, string csharp, string visualbasic, string ruby, string matlab, string r, string c, string php, string perl, string html, string jquery, string css, string nodejs, string asp, string react, string typescript, string angular, string ajax, string view, string glade, string kotlin, string reactnative, string oracle, string mysql, string postgres, string sqllite, string mongodb, string access, string mariadb, string redis, string casandra, string azure, string amazon, string amazonddb)
        {
            // Conexión a la base de datos (ajusta la cadena de conexión según tu configuración)
            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                oconexion.Open();

                // Insertar el archivo en la tabla de la base de datos
                string query = "INSERT INTO Encuesta (Alumno, NumeroControl, Maestro, Java, Python, Cmasmas, Javascript, Csharp, VisualBasic, Ruby, Matlab, R, C, Php, Perl, Html, Jquery, Css, NodeJs, AspNet, React, Typescript, Angular, Ajax, Vue, Kotlin, ReactNative, Oracle, MySQL, PostgreSQL, SqlLite, MongoDB, Access, MariaDB, Redis, Casandra, Azure, Amazon, AmazonDDB) VALUES (@1, @2, @3, @4, @5, @6, @7, @8, @9, @10, @11, @12, @13, @14, @15, @16, @17, @18, @19, @20, @21, @22, @23, @24, @25, @27, @28, @29, @30, @31, @32, @33, @34, @35, @36, @37, @38, @39, @40)";

                using (SqlCommand command = new SqlCommand(query, oconexion))
                {
                    command.Parameters.AddWithValue("@1", nombrealumno);
                    command.Parameters.AddWithValue("@2", numeroControl);
                    command.Parameters.AddWithValue("@3", maestro);
                    command.Parameters.AddWithValue("@4", java);
                    command.Parameters.AddWithValue("@5", python);
                    command.Parameters.AddWithValue("@6", cmasmas);
                    command.Parameters.AddWithValue("@7", javascript);
                    command.Parameters.AddWithValue("@8", csharp);
                    command.Parameters.AddWithValue("@9", visualbasic);
                    command.Parameters.AddWithValue("@10", ruby);
                    command.Parameters.AddWithValue("@11", matlab);
                    command.Parameters.AddWithValue("@12", r);
                    command.Parameters.AddWithValue("@13", c);
                    command.Parameters.AddWithValue("@14", php);
                    command.Parameters.AddWithValue("@15", perl);
                    command.Parameters.AddWithValue("@16", html);
                    command.Parameters.AddWithValue("@17", jquery);
                    command.Parameters.AddWithValue("@18", css);
                    command.Parameters.AddWithValue("@19", nodejs);
                    command.Parameters.AddWithValue("@20", asp);
                    command.Parameters.AddWithValue("@21", react);
                    command.Parameters.AddWithValue("@22", typescript);
                    command.Parameters.AddWithValue("@23", angular);
                    command.Parameters.AddWithValue("@24", ajax);
                    command.Parameters.AddWithValue("@25", view);                    ;
                    command.Parameters.AddWithValue("@27", kotlin);
                    command.Parameters.AddWithValue("@28", reactnative);
                    command.Parameters.AddWithValue("@29", oracle);
                    command.Parameters.AddWithValue("@30", mysql);
                    command.Parameters.AddWithValue("@31", postgres);
                    command.Parameters.AddWithValue("@32", sqllite);
                    command.Parameters.AddWithValue("@33", mongodb);
                    command.Parameters.AddWithValue("@34", access);
                    command.Parameters.AddWithValue("@35", mariadb);
                    command.Parameters.AddWithValue("@36", redis);
                    command.Parameters.AddWithValue("@37", casandra);
                    command.Parameters.AddWithValue("@38", azure);
                    command.Parameters.AddWithValue("@39", amazon);
                    command.Parameters.AddWithValue("@40", amazonddb);

                    command.ExecuteNonQuery();
                }
            }
        }

        public List<Encuesta> ObtenerEncuestas(String numeroControl)
        {
            List<Encuesta> encuestas = new List<Encuesta>();

            // Conexión a la base de datos (ajusta la cadena de conexión según tu configuración)
            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                oconexion.Open();

                // Consulta SELECT para obtener todos los registros de la tabla Encuesta
                string query = "SELECT * FROM Encuesta where NumeroControl = '"+numeroControl+"'";

                using (SqlCommand command = new SqlCommand(query, oconexion))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Encuesta encuesta = new Encuesta();
                            encuesta.Alumno = reader["Alumno"].ToString();
                            encuesta.NumeroControl = reader["NumeroControl"].ToString();
                            encuesta.Maestro = reader["Maestro"].ToString();
                            encuesta.Java = reader["Java"].ToString();
                            encuesta.Python = reader["Python"].ToString();
                            encuesta.Cmasmas = reader["Cmasmas"].ToString();
                            encuesta.Javascript = reader["Javascript"].ToString();
                            encuesta.Csharp = reader["Csharp"].ToString();
                            encuesta.VisualBasic = reader["VisualBasic"].ToString();
                            encuesta.Ruby = reader["Ruby"].ToString();
                            encuesta.Matlab = reader["Matlab"].ToString();
                            encuesta.R = reader["R"].ToString();
                            encuesta.C = reader["C"].ToString();
                            encuesta.Php = reader["Php"].ToString();
                            encuesta.Perl = reader["Perl"].ToString();
                            encuesta.Html = reader["Html"].ToString();
                            encuesta.Jquery = reader["Jquery"].ToString();
                            encuesta.Css = reader["Css"].ToString();
                            encuesta.NodeJs = reader["NodeJs"].ToString();
                            encuesta.AspNet = reader["AspNet"].ToString();
                            encuesta.React = reader["React"].ToString();
                            encuesta.Typescript = reader["Typescript"].ToString();
                            encuesta.Angular = reader["Angular"].ToString();
                            encuesta.Ajax = reader["Ajax"].ToString();
                            encuesta.Vue = reader["Vue"].ToString();
                            encuesta.Kotlin = reader["Kotlin"].ToString();
                            encuesta.ReactNative = reader["ReactNative"].ToString();
                            encuesta.Oracle = reader["Oracle"].ToString();
                            encuesta.MySQL = reader["MySQL"].ToString();
                            encuesta.PostgreSQL = reader["PostgreSQL"].ToString();
                            encuesta.SqlLite = reader["SqlLite"].ToString();
                            encuesta.MongoDB = reader["MongoDB"].ToString();
                            encuesta.Access = reader["Access"].ToString();
                            encuesta.MariaDB = reader["MariaDB"].ToString();
                            encuesta.Redis = reader["Redis"].ToString();
                            encuesta.Casandra = reader["Casandra"].ToString();
                            encuesta.Azure = reader["Azure"].ToString();
                            encuesta.Amazon = reader["Amazon"].ToString();
                            encuesta.AmazonDDB = reader["AmazonDDB"].ToString();

                            encuestas.Add(encuesta);
                        }
                    }
                }
            }

            return encuestas;
        }


    }
}    


