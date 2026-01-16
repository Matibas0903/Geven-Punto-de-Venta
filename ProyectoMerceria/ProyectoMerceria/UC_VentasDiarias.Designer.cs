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
            this.dGridViewVentasDiarias.BackgroundColor = System.Drawing.Color.White;
            this.dGridViewVentasDiarias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGridViewVentasDiarias.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDVenta,
            this.fecha,
            this.MetodoPago,
            this.Total,
            this.VerDetalle});
            this.dGridViewVentasDiarias.Location = new System.Drawing.Point(69, 74);
            this.dGridViewVentasDiarias.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dGridViewVentasDiarias.Name = "dGridViewVentasDiarias";
            this.dGridViewVentasDiarias.ReadOnly = true;
            this.dGridViewVentasDiarias.RowHeadersVisible = false;
            this.dGridViewVentasDiarias.RowHeadersWidth = 51;
            this.dGridViewVentasDiarias.Size = new System.Drawing.Size(537, 351);
            this.dGridViewVentasDiarias.TabIndex = 0;
            this.dGridViewVentasDiarias.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGridViewVentasDiarias_CellContentClick);
            // 
            // IDVenta
            // 
            this.IDVenta.HeaderText = "ID";
            this.IDVenta.MinimumWidth = 6;
            this.IDVenta.Name = "IDVenta";
            this.IDVenta.ReadOnly = true;
            this.IDVenta.Width = 30;
            // 
            // fecha
            // 
            this.fecha.HeaderText = "Fecha";
            this.fecha.MinimumWidth = 6;
            this.fecha.Name = "fecha";
            this.fecha.ReadOnly = true;
            this.fecha.Width = 125;
            // 
            // MetodoPago
            // 
            this.MetodoPago.HeaderText = "Metodo de pago";
            this.MetodoPago.MinimumWidth = 6;
            this.MetodoPago.Name = "MetodoPago";
            this.MetodoPago.ReadOnly = true;
            this.MetodoPago.Width = 80;
            // 
            // Total
            // 
            this.Total.HeaderText = "Total";
            this.Total.MinimumWidth = 6;
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            this.Total.Width = 80;
            // 
            // VerDetalle
            // 
            this.VerDetalle.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.VerDetalle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.VerDetalle.HeaderText = "";
            this.VerDetalle.MinimumWidth = 6;
            this.VerDetalle.Name = "VerDetalle";
            this.VerDetalle.ReadOnly = true;
            this.VerDetalle.Text = "Ver Detalles";
            this.VerDetalle.UseColumnTextForButtonValue = true;
            // 
            // tBoxTotalDiario
            // 
            this.tBoxTotalDiario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tBoxTotalDiario.Cursor = System.Windows.Forms.Cursors.Default;
            this.tBoxTotalDiario.Location = new System.Drawing.Point(69, 481);
            this.tBoxTotalDiario.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tBoxTotalDiario.Name = "tBoxTotalDiario";
            this.tBoxTotalDiario.ReadOnly = true;
            this.tBoxTotalDiario.Size = new System.Drawing.Size(132, 22);
            this.tBoxTotalDiario.TabIndex = 1;
            // 
            // lblTotalDiario
            // 
            this.lblTotalDiario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTotalDiario.AutoSize = true;
            this.lblTotalDiario.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalDiario.Location = new System.Drawing.Point(65, 454);
            this.lblTotalDiario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalDiario.Name = "lblTotalDiario";
            this.lblTotalDiario.Size = new System.Drawing.Size(102, 23);
            this.lblTotalDiario.TabIndex = 2;
            this.lblTotalDiario.Text = "Total del dia";
            // 
            // dTPDia
            // 
            this.dTPDia.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dTPDia.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dTPDia.CustomFormat = "dd/MM/yyyy";
            this.dTPDia.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dTPDia.Location = new System.Drawing.Point(645, 49);
            this.dTPDia.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dTPDia.Name = "dTPDia";
            this.dTPDia.Size = new System.Drawing.Size(133, 22);
            this.dTPDia.TabIndex = 3;
            this.dTPDia.ValueChanged += new System.EventHandler(this.dTPDia_ValueChanged);
            // 
            // lblVentasDiarias
            // 
            this.lblVentasDiarias.AutoSize = true;
            this.lblVentasDiarias.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVentasDiarias.Location = new System.Drawing.Point(28, 28);
            this.lblVentasDiarias.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVentasDiarias.Name = "lblVentasDiarias";
            this.lblVentasDiarias.Size = new System.Drawing.Size(162, 31);
            this.lblVentasDiarias.TabIndex = 85;
            this.lblVentasDiarias.Text = "Ventas diarias";
            // 
            // UC_VentasDiarias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(248)))));
            this.Controls.Add(this.lblVentasDiarias);
            this.Controls.Add(this.dTPDia);
            this.Controls.Add(this.lblTotalDiario);
            this.Controls.Add(this.tBoxTotalDiario);
            this.Controls.Add(this.dGridViewVentasDiarias);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "UC_VentasDiarias";
            this.Size = new System.Drawing.Size(800, 554);
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
