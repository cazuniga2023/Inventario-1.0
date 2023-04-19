using Microsoft.Reporting.WinForms;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventario
{
    public partial class frmreporteTicket : Form
    {
        public frmreporteTicket()
        {
            InitializeComponent();
        }

        private void frmreporteTicket_Load(object sender, EventArgs e)
        {

            this.rptInformeTicket.RefreshReport();
            this.rptInformeTicket.RefreshReport();
        }

        private void btn_generarreporteticket_Click(object sender, EventArgs e)
        {
            string consulta;
            DateTime fechaInicio = dateTimePicker1.Value;
            DateTime fechaFin = dateTimePicker2.Value;




            ////if (DateTime.Compare(fechaInicio, fechaFin) <= 0)
            ////{
            ////    consulta = "select Modelo,numero_serie,numero_ticket,partnumber, Numero_Guia,cantidad_despachada, Date_Format(Fecha,'%m/%d/%Y') AS F from serie_ticket where Fecha >= '" + fechaInicio.ToString("yyyy-MM-dd") + "' and Fecha <= '" + fechaFin.ToString("yyyy-MM-dd") + "'";
            ////}
            ////else
            ////{
            ////    consulta = "select Modelo,numero_serie,numero_ticket,partnumber, Numero_Guia,cantidad_despachada,Fecha from serie_ticket order by numero_serie asc";
            ////}



            MySqlConnection ConexionBD = Conexion.conexion();
            ConexionBD.Open();

            consulta = $"select * from serie_ticket where (Fecha BETWEEN '{fechaInicio.ToString("yyyy-MM-dd")}' AND '{fechaFin.ToString("yyyy-MM-dd")}') OR (Fecha_despacho BETWEEN '{fechaInicio.ToString("yyyy-MM-dd")}' AND '{fechaFin.ToString("yyyy-MM-dd")}') ORDER BY Fecha ASC";


            MySqlDataAdapter da = new MySqlDataAdapter(consulta, ConexionBD);
            DataSet ds = new DataSet();
            da.Fill(ds);

            ReportDataSource fuente;
            fuente = new ReportDataSource("serie_ticket", ds.Tables[0]);

            rptInformeTicket.LocalReport.DataSources.Clear();
            rptInformeTicket.LocalReport.DataSources.Add(fuente);
            rptInformeTicket.LocalReport.ReportEmbeddedResource = "Inventario.reporteticket.rdlc";

            rptInformeTicket.LocalReport.Refresh();
            rptInformeTicket.Refresh();
            rptInformeTicket.RefreshReport();

            

            ConexionBD.Close();
        }

        private void btnvolver_Click(object sender, EventArgs e)
        {
            Form1 menu = new Form1();
            menu.Show();
            this.Hide();
        }

        private void cbxbusqueda_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void rptInformeTicket_Load(object sender, EventArgs e)
        {
            
        }
    }
}
