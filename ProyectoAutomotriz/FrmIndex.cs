using ProyectoAutomotriz.Presentacion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using MessageBox = System.Windows.Forms.MessageBox;

namespace ProyectoAutomotriz
{
    public partial class FrmIndex : Form
    {
        private Form formularioActivo = null;
        public FrmIndex()
        {
            InitializeComponent();
        }
        #region METODOS PRIVADOS
        
        private void AbrirFormulario(Form nuevoFormulario) {
            if (formularioActivo != null) formularioActivo.Close();
            formularioActivo = nuevoFormulario;
            nuevoFormulario.TopLevel = false;
            nuevoFormulario.FormBorderStyle = FormBorderStyle.None;
            nuevoFormulario.Dock = DockStyle.Fill;
            panelContenedor.Controls.Add(nuevoFormulario);
            panelContenedor.Tag = nuevoFormulario;
            nuevoFormulario.BringToFront();
            nuevoFormulario.Show();
        }
        private void Paneles()
        {
            panelAcciones.Visible = false;
            panelAyuda.Visible = false;
            panelSalir.Visible = false;
        }
        private void EsconderSubMenu()
        {
            if (panelAcciones.Visible == true) panelAcciones.Visible = false;
            if (panelAyuda.Visible == true) panelAyuda.Visible = false;
            if (panelSalir.Visible == true) panelSalir.Visible = false;
        }
        private void MostrarSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                EsconderSubMenu();
                subMenu.Visible = true;
            }
            else subMenu.Visible = false;
        }
        private void BotonSeleccionado(Button btn) {
            btn.BackColor = Color.FromArgb(240, 240, 240);
            btn.ForeColor = Color.FromArgb(28, 28, 28);
        }
        private void BotonDesleccionado(Button btn)
        {
            btn.BackColor = Color.FromArgb(28, 28, 28);
            btn.ForeColor = Color.FromArgb(240, 240, 240);

        }
        #endregion
        #region EVENTOS
        private void FrmIndex_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            this.lblTituloPrincipal.Parent = pictureBox1;
            this.iconPictureBox1.Parent = pictureBox1;
            this.iconPictureBox2.Parent = pictureBox1;
            Paneles();
            
        }
       
       
       
        #endregion

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void iconPictureBox2_Click(object sender, EventArgs e)
        {
            DialogResult msg = MessageBox.Show("¿Desea salir de la aplicacion?", "Saliendo formulario", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (msg == DialogResult.Yes) this.Dispose();
        }

        
        private void iconPictureBox1_Click_1(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized) this.WindowState = FormWindowState.Minimized;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MostrarSubMenu(panelAcciones);
            BotonSeleccionado(button1);
            BotonDesleccionado(button2);
            BotonDesleccionado(button7);

        }

        private void Consulta1_Click_1(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmConsulta1());
            EsconderSubMenu();
        }

        private void Consulta2_Click_1(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmConsulta2());
            EsconderSubMenu();

        }

        private void Consulta3_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmConsulta3());
            EsconderSubMenu();

        }

        private void Consulta4_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmConsulta4());
            EsconderSubMenu();

        }

        private void Consulta5_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmConsulta5());
            EsconderSubMenu();

        }

        private void Consulta6_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmConsulta6());
            EsconderSubMenu();

        }

        private void Consulta7_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmConsulta7());
            EsconderSubMenu();

        }

        private void Consulta8_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmConsulta8());
            EsconderSubMenu();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MostrarSubMenu(panelAyuda);
            BotonDesleccionado(button1);
            BotonSeleccionado(button2);
            BotonDesleccionado(button7);
        }

        private void panelAyuda_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            MostrarSubMenu(panelSalir);
            BotonDesleccionado(button1);
            BotonDesleccionado(button2);
            BotonSeleccionado(button7);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            DialogResult msg = MessageBox.Show("Esta seguro que desea cerrar sesion","Cerrando sesion",MessageBoxButtons.YesNo);
            if (msg == DialogResult.Yes) { 
                new FrmLogin().Show();
                this.Dispose();
            }
        }
    }
}
