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
            this.dGridViewDetalles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGridViewDetalles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NombreProducto,
            this.Cantidad,
            this.SubTotal});
            this.dGridViewDetalles.Location = new System.Drawing.Point(72, 96);
            this.dGridViewDetalles.Name = "dGridViewDetalles";
            this.dGridViewDetalles.ReadOnly = true;
            this.dGridViewDetalles.RowHeadersVisible = false;
            this.dGridViewDetalles.Size = new System.Drawing.Size(392, 212);
            this.dGridViewDetalles.TabIndex = 0;
            // 
            // NombreProducto
            // 
            this.NombreProducto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NombreProducto.HeaderText = "Producto";
            this.NombreProducto.Name = "NombreProducto";
            this.NombreProducto.ReadOnly = true;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            // 
            // SubTotal
            // 
            this.SubTotal.HeaderText = "SubTotal";
            this.SubTotal.Name = "SubTotal";
            this.SubTotal.ReadOnly = true;
            this.SubTotal.Width = 80;
            // 
            // lblTotalDetalle
            // 
            this.lblTotalDetalle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTotalDetalle.AutoSize = true;
            this.lblTotalDetalle.Location = new System.Drawing.Point(69, 329);
            this.lblTotalDetalle.Name = "lblTotalDetalle";
            this.lblTotalDetalle.Size = new System.Drawing.Size(31, 13);
            this.lblTotalDetalle.TabIndex = 4;
            this.lblTotalDetalle.Text = "Total";
            // 
            // tBoxTotal
            // 
            this.tBoxTotal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tBoxTotal.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tBoxTotal.Location = new System.Drawing.Point(72, 345);
            this.tBoxTotal.Name = "tBoxTotal";
            this.tBoxTotal.ReadOnly = true;
            this.tBoxTotal.Size = new System.Drawing.Size(100, 20);
            this.tBoxTotal.TabIndex = 3;
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(196)))), ((int)(((byte)(69)))));
            this.btnVolver.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolver.Location = new System.Drawing.Point(501, 48);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(75, 23);
            this.btnVolver.TabIndex = 5;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // lblDetalles
            // 
            this.lblDetalles.AutoSize = true;
            this.lblDetalles.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetalles.Location = new System.Drawing.Point(22, 45);
            this.lblDetalles.Name = "lblDetalles";
            this.lblDetalles.Size = new System.Drawing.Size(84, 24);
            this.lblDetalles.TabIndex = 85;
            this.lblDetalles.Text = "Detalles";
            // 
            // UC_DetalleDeVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(121)))), ((int)(((byte)(85)))));
            this.Controls.Add(this.lblDetalles);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.lblTotalDetalle);
            this.Controls.Add(this.tBoxTotal);
            this.Controls.Add(this.dGridViewDetalles);
            this.Name = "UC_DetalleDeVenta";
            this.Size = new System.Drawing.Size(600, 450);
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
