﻿namespace ProyectoAutomotriz.Presentacion
{
    partial class FrmConsulta4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSalir = new System.Windows.Forms.Button();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            this.BtnMostrar = new System.Windows.Forms.Button();
            this.DgvTipoCliente = new System.Windows.Forms.DataGridView();
            this.IdFactura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Importe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CmbTC = new System.Windows.Forms.ComboBox();
            this.TxtAño1 = new System.Windows.Forms.TextBox();
            this.TxtAño2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvTipoCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalir.Location = new System.Drawing.Point(622, 482);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 1;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconPictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.iconPictureBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Minus;
            this.iconPictureBox1.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 48;
            this.iconPictureBox1.Location = new System.Drawing.Point(606, 10);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(48, 48);
            this.iconPictureBox1.TabIndex = 10;
            this.iconPictureBox1.TabStop = false;
            this.iconPictureBox1.Click += new System.EventHandler(this.iconPictureBox1_Click);
            // 
            // iconPictureBox2
            // 
            this.iconPictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconPictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.iconPictureBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.AngleDown;
            this.iconPictureBox2.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.iconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox2.IconSize = 48;
            this.iconPictureBox2.Location = new System.Drawing.Point(665, 10);
            this.iconPictureBox2.Name = "iconPictureBox2";
            this.iconPictureBox2.Size = new System.Drawing.Size(48, 48);
            this.iconPictureBox2.TabIndex = 9;
            this.iconPictureBox2.TabStop = false;
            this.iconPictureBox2.Click += new System.EventHandler(this.iconPictureBox2_Click);
            // 
            // BtnMostrar
            // 
            this.BtnMostrar.Location = new System.Drawing.Point(449, 87);
            this.BtnMostrar.Name = "BtnMostrar";
            this.BtnMostrar.Size = new System.Drawing.Size(75, 23);
            this.BtnMostrar.TabIndex = 11;
            this.BtnMostrar.Text = "Mostrar";
            this.BtnMostrar.UseVisualStyleBackColor = true;
            this.BtnMostrar.Click += new System.EventHandler(this.BtnMostrar_Click);
            // 
            // DgvTipoCliente
            // 
            this.DgvTipoCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvTipoCliente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdFactura,
            this.Cliente,
            this.Importe,
            this.Fecha,
            this.Cantidad});
            this.DgvTipoCliente.Location = new System.Drawing.Point(78, 139);
            this.DgvTipoCliente.Name = "DgvTipoCliente";
            this.DgvTipoCliente.Size = new System.Drawing.Size(444, 235);
            this.DgvTipoCliente.TabIndex = 12;
            // 
            // IdFactura
            // 
            this.IdFactura.HeaderText = "IdFactura";
            this.IdFactura.Name = "IdFactura";
            this.IdFactura.Visible = false;
            // 
            // Cliente
            // 
            this.Cliente.HeaderText = "Cliente";
            this.Cliente.Name = "Cliente";
            // 
            // Importe
            // 
            this.Importe.HeaderText = "Importe";
            this.Importe.Name = "Importe";
            // 
            // Fecha
            // 
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            // 
            // CmbTC
            // 
            this.CmbTC.FormattingEnabled = true;
            this.CmbTC.Location = new System.Drawing.Point(78, 87);
            this.CmbTC.Name = "CmbTC";
            this.CmbTC.Size = new System.Drawing.Size(145, 21);
            this.CmbTC.TabIndex = 13;
            // 
            // TxtAño1
            // 
            this.TxtAño1.Location = new System.Drawing.Point(237, 87);
            this.TxtAño1.Name = "TxtAño1";
            this.TxtAño1.Size = new System.Drawing.Size(100, 20);
            this.TxtAño1.TabIndex = 14;
            // 
            // TxtAño2
            // 
            this.TxtAño2.Location = new System.Drawing.Point(343, 87);
            this.TxtAño2.Name = "TxtAño2";
            this.TxtAño2.Size = new System.Drawing.Size(100, 20);
            this.TxtAño2.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(108, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Tipo de cliente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(357, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Segundo año";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(258, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Primer año";
            // 
            // FrmConsulta4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 528);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtAño2);
            this.Controls.Add(this.TxtAño1);
            this.Controls.Add(this.CmbTC);
            this.Controls.Add(this.DgvTipoCliente);
            this.Controls.Add(this.BtnMostrar);
            this.Controls.Add(this.iconPictureBox1);
            this.Controls.Add(this.iconPictureBox2);
            this.Controls.Add(this.btnSalir);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(724, 528);
            this.Name = "FrmConsulta4";
            this.Text = "  ";
            this.Load += new System.EventHandler(this.FrmConsulta4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvTipoCliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalir;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
        private System.Windows.Forms.Button BtnMostrar;
        private System.Windows.Forms.DataGridView DgvTipoCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdFactura;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Importe;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.ComboBox CmbTC;
        private System.Windows.Forms.TextBox TxtAño1;
        private System.Windows.Forms.TextBox TxtAño2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}