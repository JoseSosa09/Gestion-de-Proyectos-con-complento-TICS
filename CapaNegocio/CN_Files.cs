using System;
using System.Collections.Generic;
using System.Data;
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

        public void SaveFileToDatabase(string path, string programa, string alumno, string numeroControl)
        {

            obj.SaveFileToDatabase(path, programa, alumno, numeroControl);
        }

        public List<Files> LoadFilesFromDatabase()
        {            
            return obj.LoadFilesFromDatabase();
        }

        public List<Files> FilesAlumnos(String query)
        {
            return obj.AlumnosFiles(query);
        }

        public List<Files> MostrarTodo(String alumno)
        {
            return obj.MostrarTodo(alumno);
        }

        public List<Files> MostrarAlumnos()
        {
            return obj.MostrarAlumnos();
        }

        public void Delete(int id)
        {
            obj.Delete(id);
        }

        public DataTable CargarAlumno()
        {
            DataTable dt = new DataTable();
            dt = obj.CargarAlumno();
            return dt;
        }        

        public DataTable CargarPrograma()
        {
            DataTable dt = new DataTable();
            dt = obj.CargarPrograma();
            return dt;
        }

    }
}
