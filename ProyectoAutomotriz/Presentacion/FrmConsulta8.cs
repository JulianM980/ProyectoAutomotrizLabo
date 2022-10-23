using ProyectoAutomotriz.Datos;
using ProyectoAutomotriz.Presentacion.FrmConsulta8_Auxiliar;
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
    public partial class FrmConsulta8 : Form
    {
        public FrmConsulta8()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #region METODOS PRIVADOS
        public void CargarCombo(ComboBox cb,string dMember,string vMember,string nombreSp) {
            DataTable dt = HelperDB.ObtenerInstancia().ConsultarSp(nombreSp);
            cb.DataSource = dt;
            cb.DisplayMember = dMember;
            cb.ValueMember = vMember;
            cb.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        #endregion
        private void FrmConsulta8_Load(object sender, EventArgs e)
        {
            CargarCombo(cbMarcas,"nombre","idMarca","SP_MARCAS");
        }
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(txtPorcentaje.Text, out _)) {
                MessageBox.Show("No puede ingresar letras como porcentaje. Intente de nuevo");
                return;
            }
            if (Convert.ToDouble(txtPorcentaje.Text) < 0) {
                MessageBox.Show("No puede ingresar valores menores a cero");
                return;
            }
            List<Parametro> lst = new List<Parametro>();
            lst.Add(new Parametro("@aumento",Convert.ToDecimal(txtPorcentaje.Text)));
            lst.Add(new Parametro("@marca", cbMarcas.Text.ToString()));
            DataTable dt = HelperDB.ObtenerInstancia().ConsultarSp("SP_AUMENTO_VEHICULOS",lst);
            dgvVehiculos.Rows.Clear();
            foreach (DataRow row in dt.Rows) {
                int id = Convert.ToInt32(row["idVehiculo"]);
                string nombre = row["nombre"].ToString();
                string marca = row["marca"].ToString();
                decimal precioActual = Convert.ToDecimal(row["precio"]);
                decimal preConAumento = Convert.ToDecimal(row[4]);
                dgvVehiculos.Rows.Add(new object[] { id,nombre,marca,precioActual,preConAumento});
            }
        }

        private void dgvVehiculos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvVehiculos.CurrentCell.ColumnIndex == 5)
            {
                SqlConnection cnn = new SqlConnection(Properties.Resources.CadenaAxel);
                cnn.Open();
                SqlCommand cmd = new SqlCommand("select nombreComercial,m.nombre,preUnitario" +
                    " from VEHICULOS_AUTOPARTES va" +
                    " join autopartes a on va.idAutoparte = a.idAutoparte" +
                    " join productos p on a.idProducto = p.idProducto" +
                    " join marcas m on p.idMarca = m.idMarca" +
                    " where idVehiculo = @id", cnn);
                cmd.Parameters.AddWithValue("@id", Convert.ToInt16(dgvVehiculos.CurrentRow.Cells["colId"].Value.ToString()));
                DataTable dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                cnn.Close();
                new FrmAutopartesVehiculo(dt, dgvVehiculos.CurrentRow.Cells["colNombre"].Value.ToString()).ShowDialog();
            }
        }
    }
}
