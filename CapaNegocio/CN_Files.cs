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

        public List<Files> LoadFilesFromDatabaseAlumno(String numeroControl)
        {
            return obj.LoadFilesFromDatabaseAlumno(numeroControl);
        }


        public void SaveFileToDatabaseAlumno(string path, string programa, string alumno, string numeroControl, string maestro)
        {
            obj.SaveFileToDatabaseAlumno(path, programa, alumno, numeroControl, maestro);
        }
        public List<Files> LoadFilesFromDatabase()
        {            
            return obj.LoadFilesFromDatabase();
        }

        public List<Files> BuscarPalabra(String numeroControl)
        {
            return obj.BuscarPalabra(numeroControl);
        }

        public List<Files> FilesAlumnos(String numeroControl)
        {
            return obj.AlumnosFiles(numeroControl);
        }

        public List<Files> MostrarAlumnoFilesSelectIndexChanged(String alumno)
        {
            return obj.MostrarAlumnoFilesSelectIndexChanged(alumno);
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

    }
}
