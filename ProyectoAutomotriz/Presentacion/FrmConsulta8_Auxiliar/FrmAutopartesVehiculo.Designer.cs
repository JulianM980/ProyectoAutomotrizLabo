namespace ProyectoAutomotriz.Presentacion.FrmConsulta8_Auxiliar
{
    partial class FrmAutopartesVehiculo
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
            this.dgvAutopartes = new System.Windows.Forms.DataGridView();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.colNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMarca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAutopartes)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAutopartes
            // 
            this.dgvAutopartes.AllowUserToAddRows = false;
            this.dgvAutopartes.AllowUserToDeleteRows = false;
            this.dgvAutopartes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAutopartes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNombre,
            this.colMarca,
            this.colPrecio});
            this.dgvAutopartes.Location = new System.Drawing.Point(27, 90);
            this.dgvAutopartes.Name = "dgvAutopartes";
            this.dgvAutopartes.ReadOnly = true;
            this.dgvAutopartes.Size = new System.Drawing.Size(343, 150);
            this.dgvAutopartes.TabIndex = 0;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(42, 36);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(89, 19);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Autopartes";
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalir.Location = new System.Drawing.Point(295, 273);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // colNombre
            // 
            this.colNombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colNombre.HeaderText = "Nombre";
            this.colNombre.Name = "colNombre";
            this.colNombre.ReadOnly = true;
            // 
            // colMarca
            // 
            this.colMarca.HeaderText = "Marca";
            this.colMarca.Name = "colMarca";
            this.colMarca.ReadOnly = true;
            // 
            // colPrecio
            // 
            this.colPrecio.HeaderText = "Preio Unitario";
            this.colPrecio.Name = "colPrecio";
            this.colPrecio.ReadOnly = true;
            // 
            // FrmAutopartesVehiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 308);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.dgvAutopartes);
            this.Name = "FrmAutopartesVehiculo";
            this.Text = "FrmAutopartesVehiculo";
            this.Load += new System.EventHandler(this.FrmAutopartesVehiculo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAutopartes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAutopartes;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMarca;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrecio;
    }
}