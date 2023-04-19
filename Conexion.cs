using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySqlConnector;
using System.Configuration;

namespace Inventario
{
    internal class Conexion
    {
        public static MySqlConnection conexion()
        {
            string cadenaconexion = ConfigurationManager.ConnectionStrings["Inventario"].ToString();

            try
            {
                MySqlConnection conexionBD = new MySqlConnection(cadenaconexion);
                return conexionBD;

            }
            catch(MySqlException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                return null;
            }

        }
    }
}
