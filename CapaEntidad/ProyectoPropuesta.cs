using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class ProyectoPropuesta
    {
        public int idProyectoPropuesta { get; set; }
        public string categoria { get; set; }
        public string estatus { get; set; }
        public string nombre { get; set; }
        public string responsable { get; set; }
        public string colaboradores { get; set; }
        public int numAlumnos { get; set; }
        public string descripcion { get; set; }        
    }
}
