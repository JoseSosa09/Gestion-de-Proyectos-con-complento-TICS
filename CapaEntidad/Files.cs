using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Files
    {
        public int ID { get; set; }
        public string NombreArchivo { get; set; }
        public byte[] ContenidoArchivo { get; set; }
        public string programa { get; set; }
        public string alumno { get; set; }
        public string numeroControl { get; set; }
        public string maestro { get; set; }

    }
}
