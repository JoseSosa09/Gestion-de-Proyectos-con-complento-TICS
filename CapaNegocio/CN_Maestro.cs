using System;
using System.Collections.Generic;
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

        public List<Maestro> Listar()
        {

            return objcd_Maestro.Listar();
        }

    }
}
