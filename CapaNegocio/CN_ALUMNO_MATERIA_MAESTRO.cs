using CapaDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_ALUMNO_MATERIA_MAESTRO
    {
        private CD_AlumnoMateriaMaestro objAMM = new CD_AlumnoMateriaMaestro();
        
        public void Insert(String numeroControl, String materia, String maestro)
        {
            objAMM.Insert(numeroControl, materia, maestro); 
        }
    }
}
