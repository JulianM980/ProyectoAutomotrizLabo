using ProyectoAutomotriz.Datos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoAutomotriz.Presentacion
{
    public partial class FrmConsulta1 : Form
    {
        public FrmConsulta1()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmConsulta1_Load(object sender, EventArgs e)
        {
            this.rvOrdenesCompra.RefreshReport();
        }

        private void btnObtener_Click(object sender, EventArgs e)
        {
            List<Parametro> lst = new List<Parametro>();
            lst.Add(new Parametro("@anioAntiguedad",nupAntiguedad.Value));
            lst.Add(new Parametro("@anioOrdenes",txtAnio.Text));
            DataTable dt = HelperDB.ObtenerInstancia().ConsultarSp("SP_ORDENES_COMPRA",lst);

            this.rvOrdenesCompra.LocalReport.DataSources.Clear();
            this.rvOrdenesCompra.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DataSet1",dt));
            this.rvOrdenesCompra.RefreshReport();


        }
    }
}

