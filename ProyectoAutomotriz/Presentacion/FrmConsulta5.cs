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
    public partial class FrmConsulta5 : Form
    {
        private const string Consulta5 = "SELECT SUM(df.cantidad * df.preUnitario)'Total de ventas', " +
                                            "dp.nombre + ' ' + dp.apellido 'Nombre Vendedor', " +
                                            "(0.{0} * SUM(df.cantidad * df.preUnitario)) 'Comision','Total' as 'Cantidad De comision' " +
                                            "FROM detalles_facturas df " +
                                            "JOIN facturas f ON df.idFactura = f.idFactura " +
                                            "JOIN Vendedores v ON v.idVendedor = f.idVendedor " +
                                            "JOIN DATOS_PERSONALES dp ON dp.idDatos = v.idDatosPersonales " +
                                            "where f.fecha between Parse('{1}' as Datetime USING 'es-es') and Parse('{2}' as Datetime USING 'es-es') " +
                                            "GROUP BY dp.nombre, dp.apellido, f.idVendedor " +
                                            "HAVING SUM(df.cantidad* df.preUnitario) >= {3} " +
                                            "UNION " +
                                            "SELECT SUM(df.cantidad* df.preUnitario)'Total de ventas', " +
                                            "dp.nombre + ' ' + dp.apellido 'Nombre Vendedor', " +
                                            "(0.0{4}  * SUM(df.cantidad * df.preUnitario)) ,'Mitad' " +
                                            "FROM detalles_facturas df " +
                                            "JOIN facturas f ON df.idFactura = f.idFactura " +
                                            "JOIN Vendedores v ON v.idVendedor = f.idVendedor " +
                                            "JOIN DATOS_PERSONALES dp ON dp.idDatos = v.idDatosPersonales " +
                                            "where f.fecha between Parse('{1}' as Datetime USING 'es-es') and Parse('{2}' as Datetime USING 'es-es') " +
                                            "GROUP BY dp.nombre, dp.apellido, f.idVendedor " +
                                            "HAVING SUM(df.cantidad* df.preUnitario) <= {3}";
        public FrmConsulta5()
        {
            InitializeComponent();
            Fecha1.Enabled = true;
            Fecha2.Enabled = true;
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

        private void iconButton1_Click(object sender, EventArgs e)
        {
            string msg = "Ingresando el porcentaje de Comisión y el objetivo que tienen que superar " +
                "los vendedores,podra calcular si la cantidad supera al objetivo.En tal caso cobrara " +
                "el total de la Comisión y si no cobrara la mitad esta muestra el total de\r\nventas, el nombre completo la cantidad total por cobrar por Comisión y si cobrara\r\nla mitad de la Comisión o la totalidad del último mes";
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

        private void Consultar_Click(object sender, EventArgs e)
        {

            string porcentaje = txtPorcentaje.Text;
            double porcentajeMitad = 0;
            string Objetivo = txtObjetivo.Text;
            var fechaComparar1 = Fecha1.Value.ToString().Split(' ')[0];
            var fechaComparar2 = Fecha2.Value.ToString().Split(' ')[0];
            bool banderaPorcentaje = true;
            bool banderaObjetivo = true;
            if (porcentaje == "")
            {
                banderaPorcentaje = false;
                labelPorcentaje.Text = "Debe ingresar un porcentaje";

            }
            else
            {
                banderaPorcentaje = true;
                labelPorcentaje.Text = "";
                porcentajeMitad = Double.Parse(txtPorcentaje.Text) / 2;
                string deci = porcentajeMitad.ToString().Split(',')[1];
                string uni = porcentajeMitad.ToString().Split(',')[0];

                porcentajeMitad = Double.Parse(uni + deci);
            }

            if (Objetivo == "")
            {
                banderaObjetivo = false;
                labelObjetivo.Text = "Debe ingresar un Objetivo";

            }
            else
            {
                banderaObjetivo = true;
                labelObjetivo.Text = "";
            }



            if (banderaPorcentaje && banderaObjetivo)
            {

                string Sql = string.Format(Consulta5, porcentaje, fechaComparar1, fechaComparar2, Objetivo, porcentajeMitad);

                DataTable table = HelperDB.ObtenerInstancia().ConsultarSelect(Sql);
                titlePrincipal.Text = "Empleados de que recibiran comisión segun por objetivo de $" + Objetivo + " vendidos desde " + fechaComparar1 + " hasta " + fechaComparar2;
                FormatearDatagrid(table);
            }
        }

        private void FormatearDatagrid(DataTable table)
        {
            dgvConsulta5.Rows.Clear();

            foreach (DataRow fila in table.Rows)
            {

                dgvConsulta5.Rows.Add(new object[] {
                fila["Total de ventas"].ToString(),
                fila["Nombre Vendedor"].ToString(),
                fila["Comision"].ToString(),
                fila["cantidad De comision"].ToString()
                });

            }
        }

        private void iconPictureBox3_Click(object sender, EventArgs e)
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

        private void iconPictureBox4_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            string msg = "Ingresando el porcentaje de Comisión y el objetivo que tienen que superar " +
                "los vendedores,podra calcular si la cantidad supera al objetivo.En tal caso cobrara " +
                "el total de la Comisión y si no cobrara la mitad esta muestra el total de ventas, el nombre completo la cantidad total por cobrar por Comisión y si cobrara la mitad de la Comisión o la totalidad del último mes";
            MessageBox.Show(msg, "Uso de herramienta", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panelSuperior_Paint(object sender, PaintEventArgs e)
        {
            panelSuperior.BackColor = Color.FromArgb(51, 102, 153);
        }

        private void Volver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Fecha1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtPorcentaje_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtObjetivo_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Fecha2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void titlePrincipal_Click(object sender, EventArgs e)
        {

        }
    }
}