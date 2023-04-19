using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySqlConnector;
using System.Configuration;
using System.Data.SqlClient;
using System.IO;
using iText.StyledXmlParser.Jsoup.Select;
using System.Security.Cryptography;
using System.Timers;
using Timer = System.Windows.Forms.Timer;

namespace Inventario
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
       
        public Form1()
        {
            InitializeComponent();

            

        }

        private void btndespacho_Click(object sender, EventArgs e)
        {
            int cantidadADescontar = (int)numericUpDown1.Value;
            string modelo = txtmodelo.Text;

            using (MySqlConnection conexionBD = Conexion.conexion())
            {
                conexionBD.Open();

                MySqlCommand comando = new MySqlCommand("select cantidad from despachos where modelo=@modelo", conexionBD);
                comando.Parameters.AddWithValue("@modelo", modelo);

                //ejecuta la consulta de seleccion y obtiene la cantidad actual del producto

                int cantidadactual =(int) comando.ExecuteScalar();

                //si la cantidad actual del productoi es menor o igual a 5, muestra un mensaje de advertencia
                if(cantidadactual<=2)
                {
                    MessageBox.Show("Quedan pocas unidades del producto, informar a Gerencia de Compra.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                // Crea el comando con la consulta de actualización y los parámetros
                comando = new MySqlCommand("Update despachos set cantidad = cantidad - @cantidad_a_descontar where modelo =@modelo", conexionBD);
                comando.Parameters.AddWithValue("@cantidad_a_descontar", cantidadADescontar);
                comando.Parameters.AddWithValue("@modelo", modelo);

                // Ejecuta la consulta de actualización
                int rowsAffected = comando.ExecuteNonQuery();

                // Si se actualizó una fila, significa que se descontó la cantidad del producto
                if(rowsAffected ==1)
                {
                    MessageBox.Show("El despacho del suministro fue exitosa.", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error al descontar suministro.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                limpiar();
            }
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            CBusqueda testbusqueda = new CBusqueda();
            testbusqueda.buscarmodelo(txtmodelo, txtsuministro, numericUpDown1);

        }

        private void limpiar()
        {
            txtmodelo.Text = "";
            txtsuministro.Text = "";
            txtserie.Text = "";
            txtticket.Text = "";
            txtpartnumber.Text = "";
            txtcantidaddes.Text = "";
            txtguia.Text = "";
            txtcantidaddes.Text = "";
            
            numericUpDown1.Value = 0;
        }

        private void btncrearticket_Click(object sender, EventArgs e)
        {
            string modelo = txtmodelo.Text;
            string suministro = txtsuministro.Text;
            string numero_serie = txtserie.Text;
            string numero_ticket = txtticket.Text;
            string partnumber = txtpartnumber.Text;
            string numeroguia = txtguia.Text;
            string cdespachada = txtcantidaddes.Text;
            string fecha = fechacreacion.Value.ToString("yyyy-MM-dd");
            string fechadesP = fechadespacho.Value.ToString("yyyy-MM-dd");
            
            

            using (MySqlConnection conexionBD = Conexion.conexion())
            {
                conexionBD.Open();

                          

               

                string query2 = "Insert into serie_ticket(modelo,numero_serie,numero_ticket,partnumber,Numero_Guia,cantidad_despachada,Fecha,Fecha_Despacho) " + "values(@modelo,@numeroserie,@numeroticket,@partnumber,@numeroguia,@cantidades,@Fecha,@Fecha_Despacho)";
                using (MySqlCommand comando = new MySqlCommand(query2,conexionBD))
                {
                    comando.Parameters.AddWithValue("@modelo", modelo);
                    comando.Parameters.AddWithValue("@numeroserie",numero_serie);
                    comando.Parameters.AddWithValue("@numeroticket", numero_ticket);
                    comando.Parameters.AddWithValue("@partnumber", partnumber);
                    comando.Parameters.AddWithValue("@numeroguia", numeroguia);
                    comando.Parameters.AddWithValue("@cantidades", cdespachada);
                    comando.Parameters.AddWithValue("@Fecha", fecha);
                    comando.Parameters.AddWithValue("@Fecha_Despacho", fechadesP);
                    

                    MessageBox.Show("Creación de Ticket Existoso", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    comando.ExecuteNonQuery();


                    conexionBD.Close();
                }
                
                
            }
        }



        private void stockSuministrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmreporteDespachos desp = new frmreporteDespachos();
            desp.Show();
            this.Hide();
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void serieTicketToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmreporteTicket tk = new frmreporteTicket();
            tk.Show();
            this.Hide();
        }

        private void txtmodelo_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void comboBox1_TextUpdate(object sender, EventArgs e)
        {
            AutoCompleteStringCollection coleccion = new AutoCompleteStringCollection();

            //Aqui es donde se llena la coleccion con los datos que deseas desplegar
            string sql = "SELECT modelo FROM despachos ";
            MySqlConnection conexionBD = Conexion.conexion();
            conexionBD.Open();
            try
            {
                MySqlCommand comando = new MySqlCommand(sql, conexionBD);
                comando.ExecuteNonQuery();
                MySqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    coleccion.Add(reader[0].ToString());
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

            //comboBox1.AutoCompleteCustomSource = coleccion;
            //comboBox1.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            //comboBox1.AutoCompleteSource = AutoCompleteSource.CustomSource;
            //comboBox1.DropDownStyle = ComboBoxStyle.DropDown;

        }

        private void submenuCerrarSesion_Click(object sender, EventArgs e)
        {
            this.Close();

            Form1 frm = new Form1();
            frm.Visible = true;

        }

        

        

       



        //private DateTime ObtenerUltimaActualizacion()
        //{
        //    DateTime ultimaActualizacion = DateTime.MinValue;

        //    // Crear una conexión a la base de datos de SQL Server
        //    using (SqlConnection conexionSQLServer = new SqlConnection(ConfigurationManager.ConnectionStrings["SQLServer"].ConnectionString))
        //    {
        //        // Crear un comando SQL para seleccionar la última fecha de actualización de la tabla "serie_ticket"
        //        string sql = "SELECT MAX(fecha_actualizacion) FROM serie_ticket";
        //        SqlCommand comandoSQLServer = new SqlCommand(sql, conexionSQLServer);

        //        // Abrir la conexión y ejecutar el comando SQL
        //        conexionSQLServer.Open();
        //        object resultado = comandoSQLServer.ExecuteScalar();

        //        // Convertir el resultado a DateTime
        //        if (resultado != DBNull.Value)
        //        {
        //            ultimaActualizacion = Convert.ToDateTime(resultado);
        //        }
        //    }

        //    return ultimaActualizacion;
        //}


        private void button1_Click(object sender, EventArgs e)
        {
            // Consulta SELECT para obtener los datos del servidor de origen
            string selectQuery = "SELECT * FROM serie_ticket";

            try
            {
                // Conexión al servidor de origen (MySQL)
                using (MySqlConnection mysqlConexion = new MySqlConnection(ConfigurationManager.ConnectionStrings["Inventario"].ToString()))
                {
                    mysqlConexion.Open();

                    // Ejecución de la consulta SELECT
                    using (MySqlCommand cmd = new MySqlCommand(selectQuery, mysqlConexion))
                    {
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            // Conexión al servidor de destino (SQL Server)
                            using (SqlConnection sqlConexion = new SqlConnection(ConfigurationManager.ConnectionStrings["SQLServer"].ToString()))
                            {
                                sqlConexion.Open();

                                // Ciclo para insertar cada fila recuperada en el servidor de destino
                                while (reader.Read())
                                {
                                    // Consulta INSERT para insertar los datos en el servidor de destino


                                    string mergeQuery = "MERGE INTO serie_ticket AS target " +
                                               "USING (VALUES (@id, @modelo, @numeroserie, @numerot, @partnumber, @numeroguia, @cantidades, @Fecha, @Fecha_Despacho)) AS source (id, modelo, numeroserie, numerot, partnumber, numeroguia, cantidades, Fecha, Fecha_Despacho) " +
                                               "ON target.id = source.id " +
                                               "WHEN MATCHED THEN " +
                                               "UPDATE SET target.modelo = source.modelo, target.numero_serie = source.numeroserie, target.numero_ticket = source.numerot, target.Partnumber = source.partnumber, target.Numero_guia = source.numeroguia, target.cantidad_despachada = source.cantidades, target.Fecha = source.Fecha, target.Fecha_Despacho = source.Fecha_Despacho " +
                                               "WHEN NOT MATCHED THEN " +
                                               "INSERT (modelo, numero_serie, numero_ticket, Partnumber, Numero_guia, cantidad_despachada, Fecha, Fecha_Despacho) " +
                                               "VALUES (source.modelo, source.numeroserie, source.numerot, source.partnumber, source.numeroguia, source.cantidades, source.Fecha, source.Fecha_Despacho);";
                                    //string insertQuery = "INSERT INTO serie_ticket (modelo, numero_serie, numero_ticket, partnumber, Numero_Guia, cantidad_despachada, Fecha, Fecha_Despacho) " +
                                    //                       "SELECT @modelo, @numeroserie, @numerot, @partnumber, @numeroguia, @cantidades, @Fecha, @Fecha_Despacho " +
                                    //                       "WHERE NOT EXISTS (SELECT 1 FROM serie_ticket WHERE id = @id)";

                                    using (SqlCommand insertCommand = new SqlCommand(mergeQuery, sqlConexion))
                                    {
                                        insertCommand.Parameters.AddWithValue("@id", reader["id"]);
                                        insertCommand.Parameters.AddWithValue("@modelo", reader["Modelo"]);
                                        insertCommand.Parameters.AddWithValue("@numeroserie", reader["numero_serie"]);
                                        insertCommand.Parameters.AddWithValue("@numerot", reader["numero_ticket"]);
                                        insertCommand.Parameters.AddWithValue("@partnumber", reader["Partnumber"]);
                                        insertCommand.Parameters.AddWithValue("@numeroguia", reader["Numero_guia"]);
                                        insertCommand.Parameters.AddWithValue("@cantidades", reader["cantidad_despachada"]);
                                        insertCommand.Parameters.AddWithValue("@Fecha", reader["Fecha"]);
                                        insertCommand.Parameters.AddWithValue("@Fecha_despacho", reader["Fecha_Despacho"]);


                                        insertCommand.ExecuteNonQuery();
                                    }
                                }
                            }
                        }
                    }
                }

                MessageBox.Show("Actualización completada con éxito");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar los datos: " + ex.Message);
            }
        }

        
    }
}
