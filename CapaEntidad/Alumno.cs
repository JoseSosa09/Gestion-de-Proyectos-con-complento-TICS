using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Alumno
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public string clave { get; set; }
        public string numeroControl { get; set; }
        public string telefono { get; set; }
        public string maestro { get; set; }
        public string email{ get; set; }
        public string materia{ get; set; }
        public string fechaCreacion { get; set; }
        public int idrol { get; set; }
        
    }
}
