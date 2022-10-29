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
        private const string labelOriginal = "muestra la cantidad, la descripción, total vendido, el precio unitario y su stock actual";
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

        private void filtros_Click(object sender, EventArgs e)
        {
            if (filtros.Text == "Aplicar Filtros")
            {
                AutoPartes1.Enabled = true;
                AutoPartes2.Enabled = true;
                Fecha1.Enabled = true;
                Fecha2.Enabled = true;
                filtros.Text = "Desactivar Filtros";
            }
            else if (filtros.Text == "Desactivar Filtros") {
                filtros.Text = "Aplicar Filtros";
                DataGridInitial();
            }
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

            if (isAutoParte) {
                
                where += " and ";
            }
            label += "entre el" + fechaComparar1 + " y " + fechaComparar2;
            where += " f.fecha  between Parse(' " + fechaComparar1 + "' as Datetime   USING 'es-es') and Parse('" + fechaComparar1 + "' as Datetime  USING 'es-es')";

            titlePrincipal.Text = label;
            string consulta = consultaSelectAutoParte + where + groupByAutoParte;
            DataTable table = HelperDB.ObtenerInstancia().ConsultarSelect(consulta);
            FormatearDatagrid(table);

        }


        private void Volver_Click(object sender, EventArgs e)
        {
           this.Close();
        }


    }
}
