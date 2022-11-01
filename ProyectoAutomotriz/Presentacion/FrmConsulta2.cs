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
    public partial class FrmConsulta2 : Form
    {
        public FrmConsulta2()
        {
            InitializeComponent();
            CargarCombo();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmConsulta2_Load(object sender, EventArgs e)
        {
            cboMarca.SelectedIndex = -1;
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if (cboMarca.SelectedIndex == -1)
            {
                MessageBox.Show("Debe ingresar una marca", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            string sp = "SP_Empresas_Fiat";
            List<Parametro> lst = new List<Parametro>();
            lst.Add(new Parametro("@fecha", dtpDesde.Value));
            lst.Add(new Parametro("@marca", cboMarca.Text.ToString()));
            dgvConsulta2.Rows.Clear();
            DataTable DT = HelperDB.ObtenerInstancia().ConsultarSp(sp, lst);

            foreach (DataRow fila in DT.Rows)
            {
                dgvConsulta2.Rows.Add(new object[] { fila["CodCliente"].ToString(),
                fila["Cliente"].ToString(),
                fila["Tipo Cliente"].ToString(),
                fila["Marca"].ToString(),
                fila["Email"].ToString(),
                fila["nroTel"].ToString(),
                fila["Importe Pagado"].ToString()});
            }
        }
        private void CargarCombo()
        {
            cboMarca.DataSource = HelperDB.ObtenerInstancia().ConsultarSp("SP_MARCAS");
            cboMarca.DisplayMember = "nombre";
            cboMarca.ValueMember = "idMarca";
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

        private void iconButton1_Click(object sender, EventArgs e)
        {
            string msg = "";
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
    }
}
