namespace ProyectoAutomotriz.Presentacion
{
    partial class FrmConsulta7
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
            this.dgvConsulta7 = new System.Windows.Forms.DataGridView();
            this.colFacturaNro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLegajo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colImporteTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPromGralAnual = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnConsulta = new System.Windows.Forms.Button();
            this.lblAnio = new System.Windows.Forms.Label();
            this.txtAnio = new System.Windows.Forms.TextBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsulta7)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalir.Location = new System.Drawing.Point(607, 436);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 1;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // dgvConsulta7
            // 
            this.dgvConsulta7.AllowUserToAddRows = false;
            this.dgvConsulta7.AllowUserToDeleteRows = false;
            this.dgvConsulta7.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsulta7.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colFacturaNro,
            this.colLegajo,
            this.colNombre,
            this.colFecha,
            this.colImporteTotal,
            this.colPromGralAnual});
            this.dgvConsulta7.Location = new System.Drawing.Point(22, 105);
            this.dgvConsulta7.Name = "dgvConsulta7";
            this.dgvConsulta7.ReadOnly = true;
            this.dgvConsulta7.Size = new System.Drawing.Size(674, 325);
            this.dgvConsulta7.TabIndex = 2;
            // 
            // colFacturaNro
            // 
            this.colFacturaNro.HeaderText = "Factura Nro";
            this.colFacturaNro.Name = "colFacturaNro";
            this.colFacturaNro.ReadOnly = true;
            // 
            // colLegajo
            // 
            this.colLegajo.HeaderText = "Legajo";
            this.colLegajo.Name = "colLegajo";
            this.colLegajo.ReadOnly = true;
            // 
            // colNombre
            // 
            this.colNombre.HeaderText = "Nombre";
            this.colNombre.Name = "colNombre";
            this.colNombre.ReadOnly = true;
            // 
            // colFecha
            // 
            this.colFecha.HeaderText = "Fecha";
            this.colFecha.Name = "colFecha";
            this.colFecha.ReadOnly = true;
            // 
            // colImporteTotal
            // 
            this.colImporteTotal.HeaderText = "Importe total";
            this.colImporteTotal.Name = "colImporteTotal";
            this.colImporteTotal.ReadOnly = true;
            // 
            // colPromGralAnual
            // 
            this.colPromGralAnual.HeaderText = "Promedio general anual";
            this.colPromGralAnual.Name = "colPromGralAnual";
            this.colPromGralAnual.ReadOnly = true;
            // 
            // btnConsulta
            // 
            this.btnConsulta.Location = new System.Drawing.Point(564, 44);
            this.btnConsulta.Name = "btnConsulta";
            this.btnConsulta.Size = new System.Drawing.Size(118, 27);
            this.btnConsulta.TabIndex = 4;
            this.btnConsulta.Text = "Consultar";
            this.btnConsulta.UseVisualStyleBackColor = true;
            this.btnConsulta.Click += new System.EventHandler(this.btnConsulta_Click);
            // 
            // lblAnio
            // 
            this.lblAnio.AutoSize = true;
            this.lblAnio.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblAnio.Font = new System.Drawing.Font("Nirmala UI Semilight", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnio.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.lblAnio.Location = new System.Drawing.Point(24, 51);
            this.lblAnio.Name = "lblAnio";
            this.lblAnio.Size = new System.Drawing.Size(96, 13);
            this.lblAnio.TabIndex = 5;
            this.lblAnio.Text = "Año a consultar";
            // 
            // txtAnio
            // 
            this.txtAnio.Location = new System.Drawing.Point(126, 48);
            this.txtAnio.Name = "txtAnio";
            this.txtAnio.Size = new System.Drawing.Size(169, 20);
            this.txtAnio.TabIndex = 6;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLimpiar.Location = new System.Drawing.Point(526, 436);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 7;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // FrmConsulta7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 489);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.txtAnio);
            this.Controls.Add(this.lblAnio);
            this.Controls.Add(this.btnConsulta);
            this.Controls.Add(this.dgvConsulta7);
            this.Controls.Add(this.btnSalir);
            this.MinimumSize = new System.Drawing.Size(724, 528);
            this.Name = "FrmConsulta7";
            this.Text = "Consulta 7";
            this.Load += new System.EventHandler(this.FrmConsulta7_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsulta7)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.DataGridView dgvConsulta7;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFacturaNro;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLegajo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn colImporteTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPromGralAnual;
        private System.Windows.Forms.Button btnConsulta;
        private System.Windows.Forms.Label lblAnio;
        private System.Windows.Forms.TextBox txtAnio;
        private System.Windows.Forms.Button btnLimpiar;
    }
}