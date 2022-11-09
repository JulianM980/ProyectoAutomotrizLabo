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
    public partial class FrmConsulta6 : Form
    {
        private const string consultaSelectAutoParte = "set DATEFORMAT  dMy " +
                                                "select SUM(df.cantidad)'cantidad', " +
                                                "p.descripcion, " +
                                                "sum(df.preUnitario * df.Cantidad)'total Vendido del producto', " +
                                                "p.preUnitario, " +
                                                "i.stockActual " +
                                                "from detalles_Facturas df " +
                                                "join facturas f on f.idFactura = df.idFactura join " +
                                                "productos p on p.idProducto = df.idProducto " +
                                                "join autoPartes ap on ap.idProducto = p.idProducto " +
                                                "join inventarios i on i.idAutoParte = ap.idAutoParte ";

        private const string groupByAutoParte = " GROUP BY p.descripcion, p.idProducto,p.preUnitario,i.stockActual order by cantidad desc";
        private const string labelOriginal = "muestra la cantidad, la descripción, total vendido, el precio unitario y su stock actual ";
        public FrmConsulta6()
        {

            InitializeComponent();
            CargarCombo(AutoPartes1);
            CargarCombo(AutoPartes2);
            DataGridInitial();
        }

        private void CargarCombo(ComboBox combo)
        {
            combo.DataSource = HelperDB.ObtenerInstancia().ConsultarSp("cboAutoPartes");
            combo.DisplayMember = "nombreComercial";
            combo.ValueMember = "idAutoparte";
            combo.SelectedIndex = -1;

        }

        private void DataGridInitial()
        {
            string consulta = consultaSelectAutoParte + groupByAutoParte;
            DataTable table =  HelperDB.ObtenerInstancia().ConsultarSelect(consulta);

            FormatearDatagrid(table);

        }
        private void FormatearDatagrid(DataTable table) {
            dgvConsulta6.Rows.Clear();

            foreach (DataRow fila in table.Rows)
            {
                
                dgvConsulta6.Rows.Add(new object[] {
                fila["cantidad"].ToString(),
                fila["Descripcion"].ToString(),
                fila["total Vendido del producto"].ToString(),
                fila["preUnitario"].ToString(),
                fila["stockActual"].ToString()
                });

            }
        }





        private void FrmConsulta6_Load(object sender, EventArgs e)
        {

        }

        private void Consultar_Click(object sender, EventArgs e)
        {
            string where = "";
            var valueAutoParte1 = AutoPartes1.SelectedValue;
            var valueAutoParte2 = AutoPartes2.SelectedValue;
            bool isAutoParte = false;
            var fechaComparar1 = Fecha1.Value.ToString().Split(' ')[0];
            var fechaComparar2 = Fecha2.Value.ToString().Split(' ')[0];
            string label = "";
            if (valueAutoParte1 != null && valueAutoParte2 == null) {
                label =  labelOriginal +" de " + AutoPartes1.Text ;
                isAutoParte = true;
                where = " where ap.idAutoparte = " + valueAutoParte1;
            }else if (valueAutoParte2 != null && valueAutoParte1 != null)
            {
                label = labelOriginal + " de " + AutoPartes1.Text + " y de " + AutoPartes2.Text;
                isAutoParte = true;
                where = " where ap.idAutoparte = " + valueAutoParte1 + " or ap.idAutoparte = " + valueAutoParte2;
            }
            else if (valueAutoParte2 != null && valueAutoParte1 == null) {
                label = labelOriginal + " de " + AutoPartes2.Text;
                isAutoParte = true;
                where = " where ap.idAutoparte = " + valueAutoParte2;
            }
            where += isAutoParte ? " and " : " where ";
            label += "entre el" + fechaComparar1 + " y " + fechaComparar2;
            where += " f.fecha  between Parse(' " + fechaComparar1 + "' as Datetime   USING 'es-es') and Parse('" + fechaComparar2 + "' as Datetime  USING 'es-es')";

            titlePrincipal.Text = label;
            string consulta = consultaSelectAutoParte + where + groupByAutoParte;
            DataTable table = HelperDB.ObtenerInstancia().ConsultarSelect(consulta);
            FormatearDatagrid(table);

        }


        private void Volver_Click(object sender, EventArgs e)
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
            this.Dispose();
        }

        private void filtros_Click(object sender, EventArgs e)
        {
            bool bandera = false;
            if (filtros.Text == "Aplicar Filtros")
            {
                bandera = true;
                filtros.Text = "Desactivar Filtros";
            }
            else if (filtros.Text == "Desactivar Filtros")
            {
                bandera = false;              
                filtros.Text = "Aplicar Filtros";
                AutoPartes1.SelectedIndex = -1;
                AutoPartes2.SelectedIndex = -1;
                DataGridInitial();
            }

            AutoPartes1.Enabled = bandera;
            AutoPartes2.Enabled = bandera;
            Fecha1.Enabled = bandera;
            Fecha2.Enabled = bandera;
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            string msg = "Lista de Autopartes más vendidas mostrando su cantidad, descripción," +
                " total vendido, precio unitario y stock actual";
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            panelSuperior.BackColor = Color.FromArgb(51, 102, 153);
        }
    }
}
