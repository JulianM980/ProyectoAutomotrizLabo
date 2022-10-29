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
            cboMarca.DataSource = HelperDB.ObtenerInstancia().ConsultarSp("SP_MARCAS");
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

        private void FrmConsulta3_Load_1(object sender, EventArgs e)
        {

        }
    }
}
