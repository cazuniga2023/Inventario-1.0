using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySqlConnector;

namespace Inventario
{
    class CBusqueda
    {
        public void buscarmodelo(TextBox txtmodelo,TextBox txtsuministro, NumericUpDown numericUpDown1)
        {
            string sql = "select modelo, suministro, cantidad from despachos where modelo='" + txtmodelo.Text + "'";

            MySqlConnection conexionBD = Conexion.conexion();
            conexionBD.Open();
            try
            {
                MySqlCommand comando = new MySqlCommand(sql, conexionBD);
                comando.ExecuteNonQuery();
                MySqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    txtmodelo.Text = reader[0].ToString();
                    txtsuministro.Text = reader[1].ToString();

                    numericUpDown1.Value = Convert.ToInt32(reader[2]);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se puede visualizar: " + ex.Message);
            }
            finally
            {
                conexionBD.Close();
            }
        }
    }
}
