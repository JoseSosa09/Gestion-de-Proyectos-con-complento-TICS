﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidad;

namespace CapaNegocio
{
    public class CN_Permiso
    {
        private CD_Permiso objcd_Permiso = new CD_Permiso();

        public List<Permiso> ListarUsuario(string numeroControl)
        {

            return objcd_Permiso.ListarUsuario(numeroControl);
        }

        public List<Permiso> ListarMaestro(string rfc)
        {

            return objcd_Permiso.ListarMaestro(rfc);
        }

    }
}
