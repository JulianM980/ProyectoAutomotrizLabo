using FontAwesome.Sharp;
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
            //this.rvOrdenesCompra.RefreshReport();
            nupAntiguedad.Value = 1;
        }

        private void btnObtener_Click(object sender, EventArgs e)
        {
            if (nupAntiguedad.Value < 1) {
                MessageBox.Show("Debe ingresar un numero de antiguedad mayor o igual a 1");
                return;
            }
            if (!int.TryParse(txtAnio.Text, out _)) {
                MessageBox.Show("No puede ingresar letras como año. Intente de nuevo");
                return;
            }
            if (txtAnio.Text.Length != 4) {
                MessageBox.Show("Debe ingresar un año de 4 digitos");
                return;
            }
            List<Parametro> lst = new List<Parametro>();
            lst.Add(new Parametro("@anioAntiguedad",nupAntiguedad.Value));
            lst.Add(new Parametro("@anioOrdenes",txtAnio.Text));
            DataTable dt = HelperDB.ObtenerInstancia().ConsultarSp("SP_ORDENES_COMPRA",lst);

            this.rvOrdenesCompra.LocalReport.DataSources.Clear();
            this.rvOrdenesCompra.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DataSet1",dt));
            this.rvOrdenesCompra.RefreshReport();


        }

        private void iconPictureBox1_Click(object sender, EventArgs e)
        {
            foreach (Form frm in Application.OpenForms)
            {
                if (frm.GetType() == typeof(FrmIndex))
                {
                    frm.WindowState = FormWindowState.Minimized;
                    break;
                }
            }
        }

        private void iconPictureBox2_Click(object sender, EventArgs e)
        {
            DialogResult msg = MessageBox.Show("¿Desea salir de la aplicacion?", "Saliendo formulario", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (msg == DialogResult.Yes) Application.OpenForms[0].Dispose();
        }
    }
}

