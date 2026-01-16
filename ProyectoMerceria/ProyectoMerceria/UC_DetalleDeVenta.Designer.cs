namespace ProyectoMerceria
{
    partial class UC_DetalleDeVenta
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
            this.dGridViewDetalles = new System.Windows.Forms.DataGridView();
            this.NombreProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTotalDetalle = new System.Windows.Forms.Label();
            this.tBoxTotal = new System.Windows.Forms.TextBox();
            this.btnVolver = new System.Windows.Forms.Button();
            this.lblDetalles = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dGridViewDetalles)).BeginInit();
            this.SuspendLayout();
            // 
            // dGridViewDetalles
            // 
            this.dGridViewDetalles.AllowUserToAddRows = false;
            this.dGridViewDetalles.AllowUserToDeleteRows = false;
            this.dGridViewDetalles.AllowUserToResizeColumns = false;
            this.dGridViewDetalles.AllowUserToResizeRows = false;
            this.dGridViewDetalles.BackgroundColor = System.Drawing.Color.White;
            this.dGridViewDetalles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGridViewDetalles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NombreProducto,
            this.Cantidad,
            this.SubTotal});
            this.dGridViewDetalles.Location = new System.Drawing.Point(96, 118);
            this.dGridViewDetalles.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dGridViewDetalles.Name = "dGridViewDetalles";
            this.dGridViewDetalles.ReadOnly = true;
            this.dGridViewDetalles.RowHeadersVisible = false;
            this.dGridViewDetalles.RowHeadersWidth = 51;
            this.dGridViewDetalles.Size = new System.Drawing.Size(523, 261);
            this.dGridViewDetalles.TabIndex = 0;
            // 
            // NombreProducto
            // 
            this.NombreProducto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NombreProducto.HeaderText = "Producto";
            this.NombreProducto.MinimumWidth = 6;
            this.NombreProducto.Name = "NombreProducto";
            this.NombreProducto.ReadOnly = true;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.MinimumWidth = 6;
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            this.Cantidad.Width = 125;
            // 
            // SubTotal
            // 
            this.SubTotal.HeaderText = "SubTotal";
            this.SubTotal.MinimumWidth = 6;
            this.SubTotal.Name = "SubTotal";
            this.SubTotal.ReadOnly = true;
            this.SubTotal.Width = 80;
            // 
            // lblTotalDetalle
            // 
            this.lblTotalDetalle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTotalDetalle.AutoSize = true;
            this.lblTotalDetalle.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalDetalle.Location = new System.Drawing.Point(92, 405);
            this.lblTotalDetalle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalDetalle.Name = "lblTotalDetalle";
            this.lblTotalDetalle.Size = new System.Drawing.Size(36, 17);
            this.lblTotalDetalle.TabIndex = 4;
            this.lblTotalDetalle.Text = "Total";
            // 
            // tBoxTotal
            // 
            this.tBoxTotal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tBoxTotal.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tBoxTotal.Location = new System.Drawing.Point(96, 425);
            this.tBoxTotal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tBoxTotal.Name = "tBoxTotal";
            this.tBoxTotal.ReadOnly = true;
            this.tBoxTotal.Size = new System.Drawing.Size(132, 22);
            this.tBoxTotal.TabIndex = 3;
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(158)))), ((int)(((byte)(11)))));
            this.btnVolver.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolver.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.Location = new System.Drawing.Point(668, 55);
            this.btnVolver.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(100, 31);
            this.btnVolver.TabIndex = 5;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // lblDetalles
            // 
            this.lblDetalles.AutoSize = true;
            this.lblDetalles.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetalles.Location = new System.Drawing.Point(29, 55);
            this.lblDetalles.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDetalles.Name = "lblDetalles";
            this.lblDetalles.Size = new System.Drawing.Size(100, 31);
            this.lblDetalles.TabIndex = 85;
            this.lblDetalles.Text = "Detalles";
            // 
            // UC_DetalleDeVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(248)))));
            this.Controls.Add(this.lblDetalles);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.lblTotalDetalle);
            this.Controls.Add(this.tBoxTotal);
            this.Controls.Add(this.dGridViewDetalles);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "UC_DetalleDeVenta";
            this.Size = new System.Drawing.Size(800, 554);
            this.Load += new System.EventHandler(this.UC_DetalleDeVenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGridViewDetalles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dGridViewDetalles;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubTotal;
        private System.Windows.Forms.Label lblTotalDetalle;
        private System.Windows.Forms.TextBox tBoxTotal;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Label lblDetalles;
    }
}
