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

        private void iconButton1_Click(object sender, EventArgs e)
        {
            string msg = "Muestra aquellas autopartes que tienen que completar stock y la cantidad de autopartes a fabricar, " +
                "teniendo en cuenta que se debe fabricar 5 unidades extra sobre el mínimo establecido. Con la posibilidad de filtrar por marca.";
            MessageBox.Show(msg, "Uso de herramienta", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void iconButton1_MouseHover(object sender, EventArgs e)
        {
            iconButton1.IconColor = Color.FromArgb(150, 28, 28, 28);
        }

        private void iconButton1_MouseLeave(object sender, EventArgs e)
        {
            iconButton1.IconColor = Color.FromArgb(255, 28, 28, 28);
        }

        private void panelSuperior_Paint(object sender, PaintEventArgs e)
        {
            panelSuperior.BackColor = Color.FromArgb(51, 102, 153);
        }

        private void iconPictureBox1_Click_1(object sender, EventArgs e)
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

        private void iconPictureBox2_Click_1(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
