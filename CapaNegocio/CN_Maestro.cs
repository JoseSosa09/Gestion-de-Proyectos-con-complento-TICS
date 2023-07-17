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
    public class CN_Maestro
    {
        private CD_Maestro objcd_Maestro = new CD_Maestro();
        private CD_Materia objcd_Materia = new CD_Materia();

        public List<Maestro> Listar()
        {

            return objcd_Maestro.Listar();
        }

        public DataTable dataTableMaterias()
        {
            DataTable dt = new DataTable();
            dt = objcd_Materia.cargarMaterias();
            return dt;            
        }

        public DataTable dataTableMaestros()
        {
            DataTable dt = new DataTable();
            dt = objcd_Maestro.cargarMaestros();
            return dt;
        }
    }
}
