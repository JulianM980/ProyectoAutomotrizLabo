﻿using ProyectoAutomotriz.Presentacion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        private void FormatoBotones(Button btn) { 
            
        }
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

        #endregion
        #region EVENTOS
        private void FrmIndex_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
        }
        private void Consulta1_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmConsulta1());
        }
        private void Consulta2_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmConsulta2());

        }
        private void Consulta3_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmConsulta3());

        }

        private void Consulta4_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmConsulta4());

        }

        private void Consulta5_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmConsulta5());

        }

        private void Consulta6_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmConsulta6());

        }

        private void Consulta7_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmConsulta7());

        }

        private void Consulta8_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmConsulta8());

        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult msg = MessageBox.Show("¿Desea salir de la aplicacion?", "Saliendo formulario", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (msg == DialogResult.Yes) this.Dispose();
        }
        #endregion
    }
}