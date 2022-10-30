using Microsoft.ReportingServices.Diagnostics.Internal;
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
using static System.Net.Mime.MediaTypeNames;
using Application = System.Windows.Forms.Application;

namespace ProyectoAutomotriz.Presentacion
{
    public partial class FrmConsulta4 : Form
    {

        public FrmConsulta4()
        {
            InitializeComponent();
            DataTable dt = HelperDB.ObtenerInstancia().ConsultarSp("Sp_Tipo_cliente");

            CmbTC.DataSource = dt;
            CmbTC.DisplayMember = "nombre";
            CmbTC.ValueMember = "idTipoCliente";
            CmbTC.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void FrmConsulta4_Load(object sender, EventArgs e)
        {

        }

        private void BtnMostrar_Click(object sender, EventArgs e)
        {


            string sp = "sp_Pg_TipoCliente";
            List<Parametro> lst = new List<Parametro>();
            lst.Add(new Parametro("@TipoCliente", CmbTC.SelectedValue));

            string Año1 = TxtAño1.Text;
            string Año2 = TxtAño2.Text;
            if (Año1 == string.Empty && Año2 != string.Empty)
            {
                MessageBox.Show("Debe ingresar un año en la segunda casilla para hacer una busqueda correcta", "Aviso");
                return;
            }
            if (Año1 != string.Empty && Año2 == string.Empty)
            {
                MessageBox.Show("Debe ingresar un año en la primera casilla para hacer una busqueda correcta", "Aviso");
                return;
            }
            if (Año1 == string.Empty && Año2 == string.Empty)
            {
                lst.Add(new Parametro("@año1", 0));
                lst.Add(new Parametro("@año2", 3000));
            }
            else
            {
                lst.Add(new Parametro("@año1", Año1));
                lst.Add(new Parametro("@año2", Año2));
            }

            DgvTipoCliente.Rows.Clear();
            DataTable DT = HelperDB.ObtenerInstancia().ConsultarSp(sp, lst);

            foreach (DataRow fila in DT.Rows)
            {
                DgvTipoCliente.Rows.Add(new object[] {
                fila["IdFactura"].ToString(),
                fila["Nombre"].ToString(),
                fila["Importe"].ToString(),
                fila["Fecha"].ToString(),
                fila["Cantidad"].ToString()});
            }
        }
    }
}
