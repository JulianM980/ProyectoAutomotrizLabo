using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoAutomotriz.Presentacion.FrmConsulta8_Auxiliar
{
    public partial class FrmAutopartesVehiculo : Form
    {
        private DataTable ap;
        private string nombre;
        public FrmAutopartesVehiculo(DataTable dt,string nombreVehiculo)
        {
            InitializeComponent();
            ap = dt;
            nombre = nombreVehiculo;
        }

        private void FrmAutopartesVehiculo_Load(object sender, EventArgs e)
        {
            lblTitulo.Text = $"Autopartes: {nombre}";
            dgvAutopartes.ClearSelection();
            foreach (DataRow row in ap.Rows) {
                string nombre = row["nombreComercial"].ToString();
                string marca = row["nombre"].ToString();
                double precio = Convert.ToDouble(row["preUnitario"]);
                dgvAutopartes.Rows.Add(new object[] { nombre,marca,precio});
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
