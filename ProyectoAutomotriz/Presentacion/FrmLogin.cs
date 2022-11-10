using ProyectoAutomotriz.Datos;
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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            lblError.Visible = false;
            pictureBox2.Parent = pictureBox1;
            Usuario.Parent = pictureBox1;
            Contraseña.Parent = pictureBox1;
            lblError.Parent = pictureBox1;
        }

        private void btnIniciar_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUsuario.Text))
            {
                MessageBox.Show("Debe ingresar usuario y contraseña", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (string.IsNullOrEmpty(txtContraseña.Text))
            {
                MessageBox.Show("Debe ingresar usuario y contraseña", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            string usuario = txtUsuario.Text;
            string contrasenia = txtContraseña.Text;

            bool usuarioOk = ConsultarCredenciales(usuario, contrasenia);
            if (usuarioOk)
            {
                new FrmIndex().Show();
                this.Hide();
            }
            else
            {
                lblError.Text = "Usuario o contraseña incorrectos";
                lblError.Visible = true;
                txtContraseña.Text = "";
            }
        }
        private bool ConsultarCredenciales(string user, string pass)
        {
            string sp = "Sp_Login";
            var result = HelperDB.ObtenerInstancia().Login(user, pass, sp);
            return result;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void lblError_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void Usuario_Click(object sender, EventArgs e)
        {

        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void Contraseña_Click(object sender, EventArgs e)
        {

        }
    }
}
