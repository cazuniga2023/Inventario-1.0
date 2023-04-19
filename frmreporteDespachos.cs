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
using Microsoft.Reporting.WinForms;
using System.Configuration;


namespace Inventario
{
    public partial class frmreporteDespachos : Form
    {
        public frmreporteDespachos()
        {
            InitializeComponent();
        }


        private void frmreporteDespachos_Load(object sender, EventArgs e)
        {

            this.rptinformedespachos.RefreshReport();
            
        }

        private void btnInforme_Click(object sender, EventArgs e)
        {
            string consulta = "select modelo,suministro,cantidad from despachos order by modelo desc";

            MySqlConnection ConexionBD = Conexion.conexion();
            ConexionBD.Open();

            MySqlDataAdapter da = new MySqlDataAdapter(consulta, ConexionBD);
            DataSet ds = new DataSet();
            da.Fill(ds);

            ReportDataSource fuente;
            fuente = new ReportDataSource("despachos", ds.Tables[0]);

            rptinformedespachos.LocalReport.DataSources.Clear();
            rptinformedespachos.LocalReport.DataSources.Add(fuente);
            rptinformedespachos.LocalReport.ReportEmbeddedResource = "Inventario.reportesuministros.rdlc";

            rptinformedespachos.LocalReport.Refresh();
            rptinformedespachos.Refresh();
            rptinformedespachos.RefreshReport();

            ConexionBD.Close();
        }

        private void btnvolver_Click(object sender, EventArgs e)
        {
            Form1 menu = new Form1();
            menu.Show();
            this.Hide();
        }
    }
}
