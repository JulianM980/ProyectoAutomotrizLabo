namespace ProyectoAutomotriz.Presentacion
{
    partial class FrmConsulta1
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
            this.components = new System.ComponentModel.Container();
            this.btnSalir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAnio = new System.Windows.Forms.TextBox();
            this.btnObtener = new System.Windows.Forms.Button();
            this.nupAntiguedad = new System.Windows.Forms.NumericUpDown();
            this.rvOrdenesCompra = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dSOrdenesCompra = new ProyectoAutomotriz.Reportes.DSOrdenesCompra();
            this.dTOrdenesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.nupAntiguedad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSOrdenesCompra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dTOrdenesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalir.Location = new System.Drawing.Point(612, 454);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 6;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Años antguedad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(278, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Año";
            // 
            // txtAnio
            // 
            this.txtAnio.Location = new System.Drawing.Point(310, 22);
            this.txtAnio.Name = "txtAnio";
            this.txtAnio.Size = new System.Drawing.Size(100, 20);
            this.txtAnio.TabIndex = 3;
            // 
            // btnObtener
            // 
            this.btnObtener.Location = new System.Drawing.Point(491, 17);
            this.btnObtener.Name = "btnObtener";
            this.btnObtener.Size = new System.Drawing.Size(75, 23);
            this.btnObtener.TabIndex = 4;
            this.btnObtener.Text = "Obtener Reporte";
            this.btnObtener.UseVisualStyleBackColor = true;
            this.btnObtener.Click += new System.EventHandler(this.btnObtener_Click);
            // 
            // nupAntiguedad
            // 
            this.nupAntiguedad.Location = new System.Drawing.Point(134, 20);
            this.nupAntiguedad.Name = "nupAntiguedad";
            this.nupAntiguedad.Size = new System.Drawing.Size(120, 20);
            this.nupAntiguedad.TabIndex = 1;
            // 
            // rvOrdenesCompra
            // 
            this.rvOrdenesCompra.LocalReport.ReportEmbeddedResource = "ProyectoAutomotriz.Reportes.RepOrdenesCompra.rdlc";
            this.rvOrdenesCompra.Location = new System.Drawing.Point(46, 57);
            this.rvOrdenesCompra.Name = "rvOrdenesCompra";
            this.rvOrdenesCompra.ServerReport.BearerToken = null;
            this.rvOrdenesCompra.Size = new System.Drawing.Size(624, 361);
            this.rvOrdenesCompra.TabIndex = 5;
            // 
            // dSOrdenesCompra
            // 
            this.dSOrdenesCompra.DataSetName = "DSOrdenesCompra";
            this.dSOrdenesCompra.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dTOrdenesBindingSource
            // 
            this.dTOrdenesBindingSource.DataMember = "DTOrdenes";
            this.dTOrdenesBindingSource.DataSource = this.dSOrdenesCompra;
            // 
            // FrmConsulta1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 489);
            this.Controls.Add(this.rvOrdenesCompra);
            this.Controls.Add(this.nupAntiguedad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnObtener);
            this.Controls.Add(this.txtAnio);
            this.Controls.Add(this.btnSalir);
            this.MinimumSize = new System.Drawing.Size(724, 528);
            this.Name = "FrmConsulta1";
            this.Text = "Consulta 1";
            this.Load += new System.EventHandler(this.FrmConsulta1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nupAntiguedad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSOrdenesCompra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dTOrdenesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAnio;
        private System.Windows.Forms.Button btnObtener;
        private System.Windows.Forms.NumericUpDown nupAntiguedad;
        private Microsoft.Reporting.WinForms.ReportViewer rvOrdenesCompra;
        private System.Windows.Forms.BindingSource dTOrdenesBindingSource;
        private Reportes.DSOrdenesCompra dSOrdenesCompra;
    }
}