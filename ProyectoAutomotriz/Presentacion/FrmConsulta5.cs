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
        public FrmConsulta5()
        {
            InitializeComponent();
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
    }
}
