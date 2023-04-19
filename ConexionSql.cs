using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventario
{
    internal class ConexionSql
    {
        public static SqlConnection conexion()
        {
            string cadenaconexion = ConfigurationManager.ConnectionStrings["SQLServer"].ToString();

            try
            {
                SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder(cadenaconexion);
                SqlConnection conexionBD = new SqlConnection(builder.ConnectionString);
                return conexionBD;

            }
            catch(SqlException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                return null;
            }
        }
    }
}
