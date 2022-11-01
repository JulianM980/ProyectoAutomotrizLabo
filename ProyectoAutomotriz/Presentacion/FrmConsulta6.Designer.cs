namespace ProyectoAutomotriz.Presentacion
{
    partial class FrmConsulta6
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConsulta6));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnSalir = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dgvConsulta6 = new System.Windows.Forms.DataGridView();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total_Vendido_Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio_unitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stock_actual = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Volver = new System.Windows.Forms.Button();
            this.filtros = new System.Windows.Forms.Button();
            this.AutoPartes1 = new System.Windows.Forms.ComboBox();
            this.AutoPartes2 = new System.Windows.Forms.ComboBox();
            this.Fecha1 = new System.Windows.Forms.DateTimePicker();
            this.Fecha2 = new System.Windows.Forms.DateTimePicker();
            this.Consultar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsulta6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(0, 0);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 12;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(724, 528);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // dgvConsulta6
            // 
            this.dgvConsulta6.AllowUserToAddRows = false;
            this.dgvConsulta6.AllowUserToDeleteRows = false;
            this.dgvConsulta6.BackgroundColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgvConsulta6.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvConsulta6.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsulta6.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cantidad,
            this.Descripcion,
            this.Total_Vendido_Producto,
            this.Precio_unitario,
            this.Stock_actual});
            this.dgvConsulta6.Location = new System.Drawing.Point(17, 194);
            this.dgvConsulta6.Name = "dgvConsulta6";
            this.dgvConsulta6.ReadOnly = true;
            this.dgvConsulta6.Size = new System.Drawing.Size(674, 213);
            this.dgvConsulta6.TabIndex = 3;
            // 
            // Cantidad
            // 
            this.Cantidad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            this.Cantidad.Width = 86;
            // 
            // Descripcion
            // 
            this.Descripcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            this.Descripcion.Width = 104;
            // 
            // Total_Vendido_Producto
            // 
            this.Total_Vendido_Producto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Total_Vendido_Producto.HeaderText = "Total Vendido Producto";
            this.Total_Vendido_Producto.Name = "Total_Vendido_Producto";
            this.Total_Vendido_Producto.ReadOnly = true;
            this.Total_Vendido_Producto.Width = 174;
            // 
            // Precio_unitario
            // 
            this.Precio_unitario.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Precio_unitario.HeaderText = "Precio unitario";
            this.Precio_unitario.Name = "Precio_unitario";
            this.Precio_unitario.ReadOnly = true;
            this.Precio_unitario.Width = 117;
            // 
            // Stock_actual
            // 
            this.Stock_actual.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Stock_actual.HeaderText = "Stock Actual";
            this.Stock_actual.Name = "Stock_actual";
            this.Stock_actual.ReadOnly = true;
            this.Stock_actual.Width = 106;
            // 
            // Volver
            // 
            this.Volver.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Volver.Location = new System.Drawing.Point(607, 454);
            this.Volver.Name = "Volver";
            this.Volver.Size = new System.Drawing.Size(75, 23);
            this.Volver.TabIndex = 5;
            this.Volver.Text = "Volver";
            this.Volver.UseVisualStyleBackColor = true;
            this.Volver.Click += new System.EventHandler(this.Volver_Click);
            // 
            // filtros
            // 
            this.filtros.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.filtros.Location = new System.Drawing.Point(17, 454);
            this.filtros.Name = "filtros";
            this.filtros.Size = new System.Drawing.Size(141, 23);
            this.filtros.TabIndex = 6;
            this.filtros.Text = "Aplicar Filtros";
            this.filtros.UseVisualStyleBackColor = true;
            this.filtros.Click += new System.EventHandler(this.filtros_Click);
            // 
            // AutoPartes1
            // 
            this.AutoPartes1.Enabled = false;
            this.AutoPartes1.FormattingEnabled = true;
            this.AutoPartes1.Location = new System.Drawing.Point(164, 97);
            this.AutoPartes1.Name = "AutoPartes1";
            this.AutoPartes1.Size = new System.Drawing.Size(121, 21);
            this.AutoPartes1.TabIndex = 7;
            // 
            // AutoPartes2
            // 
            this.AutoPartes2.Enabled = false;
            this.AutoPartes2.FormattingEnabled = true;
            this.AutoPartes2.Location = new System.Drawing.Point(164, 154);
            this.AutoPartes2.Name = "AutoPartes2";
            this.AutoPartes2.Size = new System.Drawing.Size(121, 21);
            this.AutoPartes2.TabIndex = 8;
            // 
            // Fecha1
            // 
            this.Fecha1.Enabled = false;
            this.Fecha1.Location = new System.Drawing.Point(396, 98);
            this.Fecha1.Name = "Fecha1";
            this.Fecha1.Size = new System.Drawing.Size(200, 20);
            this.Fecha1.TabIndex = 9;
            // 
            // Fecha2
            // 
            this.Fecha2.Enabled = false;
            this.Fecha2.Location = new System.Drawing.Point(396, 155);
            this.Fecha2.Name = "Fecha2";
            this.Fecha2.Size = new System.Drawing.Size(200, 20);
            this.Fecha2.TabIndex = 10;
            // 
            // Consultar
            // 
            this.Consultar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Consultar.Location = new System.Drawing.Point(164, 454);
            this.Consultar.Name = "Consultar";
            this.Consultar.Size = new System.Drawing.Size(141, 23);
            this.Consultar.TabIndex = 11;
            this.Consultar.Text = "Consultar";
            this.Consultar.UseVisualStyleBackColor = true;
            this.Consultar.Click += new System.EventHandler(this.Consultar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(190, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "AutoPartes";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(190, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "AutoPartes";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(473, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Fecha Desde";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(470, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Fecha Hasta";
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
            this.iconPictureBox1.Location = new System.Drawing.Point(607, 12);
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
            this.iconPictureBox2.Location = new System.Drawing.Point(666, 12);
            this.iconPictureBox2.Name = "iconPictureBox2";
            this.iconPictureBox2.Size = new System.Drawing.Size(48, 48);
            this.iconPictureBox2.TabIndex = 9;
            this.iconPictureBox2.TabStop = false;
            this.iconPictureBox2.Click += new System.EventHandler(this.iconPictureBox2_Click);
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.Color.Transparent;
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.CircleInfo;
            this.iconButton1.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.Location = new System.Drawing.Point(12, 12);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(48, 48);
            this.iconButton1.TabIndex = 17;
            this.iconButton1.UseVisualStyleBackColor = false;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            this.iconButton1.MouseLeave += new System.EventHandler(this.iconButton1_MouseLeave);
            this.iconButton1.MouseHover += new System.EventHandler(this.iconButton1_MouseHover);
            // 
            // FrmConsulta6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 528);
            this.Controls.Add(this.iconButton1);
            this.Controls.Add(this.iconPictureBox1);
            this.Controls.Add(this.iconPictureBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Consultar);
            this.Controls.Add(this.Fecha2);
            this.Controls.Add(this.Fecha1);
            this.Controls.Add(this.AutoPartes2);
            this.Controls.Add(this.AutoPartes1);
            this.Controls.Add(this.filtros);
            this.Controls.Add(this.Volver);
            this.Controls.Add(this.dgvConsulta6);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnSalir);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(724, 528);
            this.Name = "FrmConsulta6";
            this.Text = "Consulta6";
            this.Load += new System.EventHandler(this.FrmConsulta6_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsulta6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dgvConsulta6;
        private System.Windows.Forms.Button Volver;
        private System.Windows.Forms.Button filtros;
        private System.Windows.Forms.ComboBox AutoPartes1;
        private System.Windows.Forms.ComboBox AutoPartes2;
        private System.Windows.Forms.DateTimePicker Fecha1;
        private System.Windows.Forms.DateTimePicker Fecha2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total_Vendido_Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio_unitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stock_actual;
        private System.Windows.Forms.Button Consultar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
        private FontAwesome.Sharp.IconButton iconButton1;
    }
}