namespace ProyectoMerceria
{
    partial class UC_VentasDiarias
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.dGridViewVentasDiarias = new System.Windows.Forms.DataGridView();
            this.IDVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MetodoPago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VerDetalle = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tBoxTotalDiario = new System.Windows.Forms.TextBox();
            this.lblTotalDiario = new System.Windows.Forms.Label();
            this.dTPDia = new System.Windows.Forms.DateTimePicker();
            this.lblVentasDiarias = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dGridViewVentasDiarias)).BeginInit();
            this.SuspendLayout();
            // 
            // dGridViewVentasDiarias
            // 
            this.dGridViewVentasDiarias.AllowUserToAddRows = false;
            this.dGridViewVentasDiarias.AllowUserToDeleteRows = false;
            this.dGridViewVentasDiarias.AllowUserToResizeColumns = false;
            this.dGridViewVentasDiarias.AllowUserToResizeRows = false;
            this.dGridViewVentasDiarias.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dGridViewVentasDiarias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGridViewVentasDiarias.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDVenta,
            this.fecha,
            this.MetodoPago,
            this.Total,
            this.VerDetalle});
            this.dGridViewVentasDiarias.Location = new System.Drawing.Point(52, 60);
            this.dGridViewVentasDiarias.Name = "dGridViewVentasDiarias";
            this.dGridViewVentasDiarias.ReadOnly = true;
            this.dGridViewVentasDiarias.RowHeadersVisible = false;
            this.dGridViewVentasDiarias.Size = new System.Drawing.Size(403, 285);
            this.dGridViewVentasDiarias.TabIndex = 0;
            this.dGridViewVentasDiarias.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGridViewVentasDiarias_CellContentClick);
            // 
            // IDVenta
            // 
            this.IDVenta.HeaderText = "ID";
            this.IDVenta.Name = "IDVenta";
            this.IDVenta.ReadOnly = true;
            this.IDVenta.Width = 30;
            // 
            // fecha
            // 
            this.fecha.HeaderText = "Fecha";
            this.fecha.Name = "fecha";
            this.fecha.ReadOnly = true;
            // 
            // MetodoPago
            // 
            this.MetodoPago.HeaderText = "Metodo de pago";
            this.MetodoPago.Name = "MetodoPago";
            this.MetodoPago.ReadOnly = true;
            this.MetodoPago.Width = 80;
            // 
            // Total
            // 
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            this.Total.Width = 80;
            // 
            // VerDetalle
            // 
            this.VerDetalle.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.VerDetalle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.VerDetalle.HeaderText = "";
            this.VerDetalle.Name = "VerDetalle";
            this.VerDetalle.ReadOnly = true;
            this.VerDetalle.Text = "Ver Detalles";
            this.VerDetalle.UseColumnTextForButtonValue = true;
            // 
            // tBoxTotalDiario
            // 
            this.tBoxTotalDiario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tBoxTotalDiario.Cursor = System.Windows.Forms.Cursors.Default;
            this.tBoxTotalDiario.Location = new System.Drawing.Point(52, 391);
            this.tBoxTotalDiario.Name = "tBoxTotalDiario";
            this.tBoxTotalDiario.ReadOnly = true;
            this.tBoxTotalDiario.Size = new System.Drawing.Size(100, 20);
            this.tBoxTotalDiario.TabIndex = 1;
            // 
            // lblTotalDiario
            // 
            this.lblTotalDiario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTotalDiario.AutoSize = true;
            this.lblTotalDiario.Location = new System.Drawing.Point(49, 375);
            this.lblTotalDiario.Name = "lblTotalDiario";
            this.lblTotalDiario.Size = new System.Drawing.Size(65, 13);
            this.lblTotalDiario.TabIndex = 2;
            this.lblTotalDiario.Text = "Total del dia";
            // 
            // dTPDia
            // 
            this.dTPDia.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dTPDia.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dTPDia.CustomFormat = "dd/MM/yyyy";
            this.dTPDia.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dTPDia.Location = new System.Drawing.Point(484, 40);
            this.dTPDia.Name = "dTPDia";
            this.dTPDia.Size = new System.Drawing.Size(101, 20);
            this.dTPDia.TabIndex = 3;
            this.dTPDia.ValueChanged += new System.EventHandler(this.dTPDia_ValueChanged);
            // 
            // lblVentasDiarias
            // 
            this.lblVentasDiarias.AutoSize = true;
            this.lblVentasDiarias.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVentasDiarias.Location = new System.Drawing.Point(21, 23);
            this.lblVentasDiarias.Name = "lblVentasDiarias";
            this.lblVentasDiarias.Size = new System.Drawing.Size(141, 24);
            this.lblVentasDiarias.TabIndex = 85;
            this.lblVentasDiarias.Text = "Ventas diarias";
            // 
            // UC_VentasDiarias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(121)))), ((int)(((byte)(85)))));
            this.Controls.Add(this.lblVentasDiarias);
            this.Controls.Add(this.dTPDia);
            this.Controls.Add(this.lblTotalDiario);
            this.Controls.Add(this.tBoxTotalDiario);
            this.Controls.Add(this.dGridViewVentasDiarias);
            this.Name = "UC_VentasDiarias";
            this.Size = new System.Drawing.Size(600, 450);
            ((System.ComponentModel.ISupportInitialize)(this.dGridViewVentasDiarias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dGridViewVentasDiarias;
        private System.Windows.Forms.TextBox tBoxTotalDiario;
        private System.Windows.Forms.Label lblTotalDiario;
        private System.Windows.Forms.DateTimePicker dTPDia;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn MetodoPago;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.DataGridViewButtonColumn VerDetalle;
        private System.Windows.Forms.Label lblVentasDiarias;
    }
}
