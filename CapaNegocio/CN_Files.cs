using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidad;

namespace CapaNegocio
{
    public class CN_Files
    {
        public CD_Files obj = new CD_Files();

        public void SaveFileToDatabase(string path, string programa, string alumno, string numeroControl, string maestro)
        {

            obj.SaveFileToDatabase(path, programa, alumno, numeroControl, maestro);
        }

        public List<Files> LoadFilesFromDatabaseAlumno(String numeroControl)
        {
            return obj.LoadFilesFromDatabaseAlumno(numeroControl);
        }


        public void SaveFileToDatabaseAlumno(string path, string programa, string alumno, string numeroControl, string maestro)
        {
            obj.SaveFileToDatabaseAlumno(path, programa, alumno, numeroControl, maestro);
        }
        public List<Files> LoadFilesFromDatabase(String maestro)
        {            
            return obj.LoadFilesFromDatabase(maestro);
        }

        public List<Files> BuscarPalabra(String numeroControl)
        {
            return obj.BuscarPalabra(numeroControl);
        }

        public List<Files> FilesAlumnos(String numeroControl)
        {
            return obj.AlumnosFiles(numeroControl);
        }

        public List<Files> MostrarAlumnoFilesSelectIndexChanged(String alumno, String maestro)
        {
            return obj.MostrarAlumnoFilesSelectIndexChanged(alumno, maestro);
        }

        public List<Files> MostrarAlumnos()
        {
            return obj.MostrarAlumnos();
        }

        public void Delete(int id)
        {
            obj.Delete(id);
        }

        public void DeleteAlumno(int id)
        {
            obj.DeleteAlumno(id);
        }

        public DataTable CargarAlumno()
        {
            DataTable dt = new DataTable();
            dt = obj.CargarAlumno();
            return dt;
        }

        public DataTable CargarProgramaAlumno(String numeroControl)
        {
            DataTable dt = new DataTable();
            dt = obj.CargarProgramaAlumno(numeroControl);
            return dt;
        }


        public DataTable CargarMaestro()
        {
            DataTable dt = new DataTable();
            dt = obj.CargarMaestro();
            return dt;
        }

        public DataTable CargarPrograma()
        {
            DataTable dt = new DataTable();
            dt = obj.CargarPrograma();
            return dt;
        }

        public void GuardarEncuesta(string nombrealumno, string numeroControl, string maestro, string java, string python, string cmasmas, string javascript, string csharp,
                                    string visualbasic, string ruby, string matlab, string r, string c, string php, string perl, string html, string jquery,
                                     string css, string nodejs, string asp, string react, string typescript, string angular, string ajax, string view, string glade, string kotlin,
                                     string reactnative, string oracle, string mysql, string postgres, string sqllite, string mongodb,
                                     string access, string mariadb, string redis, string casandra, string azure, string amazon, string amazonddb)
        {

            obj.GuardarEncuesta(nombrealumno, numeroControl, maestro, java, python, cmasmas, javascript, csharp, visualbasic, ruby, matlab, r, c, php, perl, html, jquery,
                                     css, nodejs, asp, react, typescript, angular, ajax, view, glade, kotlin, reactnative, oracle, mysql, postgres, sqllite, mongodb,
                                     access, mariadb, redis, casandra, azure, amazon, amazonddb);
        }

        public List<Encuesta> ObtenerEncuestas(String numeroControl)
        {
            return obj.ObtenerEncuestas(numeroControl);
        }
    }
}
