using ProyectoAutomotriz.Datos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoAutomotriz.Presentacion
{
    public partial class FrmConsulta3 : Form
    {
        public FrmConsulta3()
        {
            InitializeComponent();
            CargarCombo();
            cboMarca.SelectedIndex = -1;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void CargarCombo()
        {
            cboMarca.DataSource = HelperDB.ObtenerInstancia().ConsultarSp("Cargar_Marca");
            cboMarca.DisplayMember = "nombre";
            cboMarca.ValueMember = "idMarca";
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if (cboMarca.SelectedIndex == -1)
            {
                MessageBox.Show("Debe ingresar una marca", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string sp = "SP_AUTOPARTES_FALTANTES";
            List<Parametro> lst = new List<Parametro>();
            lst.Add(new Parametro("@marca", cboMarca.Text.ToString()));
            dgvConsulta3.Rows.Clear();
            DataTable DT = HelperDB.ObtenerInstancia().ConsultarSp(sp, lst);

            foreach (DataRow fila in DT.Rows)
            {
                dgvConsulta3.Rows.Add(new object[] { fila["Codigo autoparte"].ToString(),
                fila["Autoparte"].ToString(),
                fila["Marca"].ToString(),
                fila["Stock"].ToString(),
                fila["Stock Minimo"].ToString(),
                fila["Cantidad Fabricar"].ToString()});
            }
        }

        private void FrmConsulta3_Load(object sender, EventArgs e)
        {

        }
    }
}
