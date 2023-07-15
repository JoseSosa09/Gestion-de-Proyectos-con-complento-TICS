using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace CapaDatos
{
    public class Conexion
    {
        public static string cadena = ConfigurationManager.ConnectionStrings["cadena_conexion"].ToString();

        private SqlConnection conexion = new SqlConnection(cadena);

        public SqlConnection AbrirConexion()
        {

            if (conexion.State == ConnectionState.Closed)

                conexion.Open();
            return conexion;

        }

        public SqlConnection CerrarConexion()
        {

            if (conexion.State == ConnectionState.Open)

                conexion.Close();
            return conexion;

        }
    }
}

