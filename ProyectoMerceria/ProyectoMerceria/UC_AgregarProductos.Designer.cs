namespace ProyectoMerceria
{
    partial class UC_AgregarProductos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.tboxNombreProducto = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.dGridViewProductos = new System.Windows.Forms.DataGridView();
            this.ProductoID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nUDPrecioProducto = new System.Windows.Forms.NumericUpDown();
            this.lblAgregarProducto = new System.Windows.Forms.Label();
            this.btnLimpiarBusqueda = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tBoxBuscarProducto = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dGridViewProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDPrecioProducto)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(158)))), ((int)(((byte)(11)))));
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(513, 356);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(133, 28);
            this.btnCancelar.TabIndex = 72;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(158)))), ((int)(((byte)(11)))));
            this.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(513, 273);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(133, 28);
            this.btnAgregar.TabIndex = 67;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecio.Location = new System.Drawing.Point(513, 188);
            this.lblPrecio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(57, 23);
            this.lblPrecio.TabIndex = 62;
            this.lblPrecio.Text = "Precio";
            // 
            // tboxNombreProducto
            // 
            this.tboxNombreProducto.Location = new System.Drawing.Point(513, 116);
            this.tboxNombreProducto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tboxNombreProducto.Name = "tboxNombreProducto";
            this.tboxNombreProducto.Size = new System.Drawing.Size(132, 22);
            this.tboxNombreProducto.TabIndex = 58;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(513, 86);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(73, 23);
            this.lblNombre.TabIndex = 57;
            this.lblNombre.Text = "Nombre";
            // 
            // dGridViewProductos
            // 
            this.dGridViewProductos.AllowUserToAddRows = false;
            this.dGridViewProductos.AllowUserToDeleteRows = false;
            this.dGridViewProductos.AllowUserToResizeColumns = false;
            this.dGridViewProductos.AllowUserToResizeRows = false;
            this.dGridViewProductos.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dGridViewProductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dGridViewProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGridViewProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductoID,
            this.Producto,
            this.Precio});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dGridViewProductos.DefaultCellStyle = dataGridViewCellStyle2;
            this.dGridViewProductos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dGridViewProductos.Location = new System.Drawing.Point(47, 116);
            this.dGridViewProductos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dGridViewProductos.Name = "dGridViewProductos";
            this.dGridViewProductos.ReadOnly = true;
            this.dGridViewProductos.RowHeadersVisible = false;
            this.dGridViewProductos.RowHeadersWidth = 51;
            this.dGridViewProductos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dGridViewProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dGridViewProductos.Size = new System.Drawing.Size(407, 425);
            this.dGridViewProductos.TabIndex = 73;
            // 
            // ProductoID
            // 
            this.ProductoID.HeaderText = "ID";
            this.ProductoID.MinimumWidth = 6;
            this.ProductoID.Name = "ProductoID";
            this.ProductoID.ReadOnly = true;
            this.ProductoID.Width = 30;
            // 
            // Producto
            // 
            this.Producto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Producto.DataPropertyName = "Producto";
            this.Producto.HeaderText = "Producto";
            this.Producto.MinimumWidth = 6;
            this.Producto.Name = "Producto";
            this.Producto.ReadOnly = true;
            // 
            // Precio
            // 
            this.Precio.DataPropertyName = "Precio";
            this.Precio.HeaderText = "Precio";
            this.Precio.MinimumWidth = 6;
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            this.Precio.Width = 60;
            // 
            // nUDPrecioProducto
            // 
            this.nUDPrecioProducto.DecimalPlaces = 2;
            this.nUDPrecioProducto.Location = new System.Drawing.Point(513, 219);
            this.nUDPrecioProducto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nUDPrecioProducto.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nUDPrecioProducto.Name = "nUDPrecioProducto";
            this.nUDPrecioProducto.Size = new System.Drawing.Size(133, 22);
            this.nUDPrecioProducto.TabIndex = 74;
            // 
            // lblAgregarProducto
            // 
            this.lblAgregarProducto.AutoSize = true;
            this.lblAgregarProducto.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgregarProducto.Location = new System.Drawing.Point(4, 0);
            this.lblAgregarProducto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAgregarProducto.Name = "lblAgregarProducto";
            this.lblAgregarProducto.Size = new System.Drawing.Size(205, 31);
            this.lblAgregarProducto.TabIndex = 84;
            this.lblAgregarProducto.Text = "Agregar producto";
            // 
            // btnLimpiarBusqueda
            // 
            this.btnLimpiarBusqueda.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLimpiarBusqueda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(158)))), ((int)(((byte)(11)))));
            this.btnLimpiarBusqueda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpiarBusqueda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiarBusqueda.Location = new System.Drawing.Point(427, 84);
            this.btnLimpiarBusqueda.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLimpiarBusqueda.Name = "btnLimpiarBusqueda";
            this.btnLimpiarBusqueda.Size = new System.Drawing.Size(27, 25);
            this.btnLimpiarBusqueda.TabIndex = 87;
            this.btnLimpiarBusqueda.Text = "X";
            this.btnLimpiarBusqueda.UseVisualStyleBackColor = false;
            this.btnLimpiarBusqueda.Click += new System.EventHandler(this.btnLimpiarBusqueda_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 57);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 23);
            this.label1.TabIndex = 86;
            this.label1.Text = "Buscar producto";
            // 
            // tBoxBuscarProducto
            // 
            this.tBoxBuscarProducto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tBoxBuscarProducto.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBoxBuscarProducto.ForeColor = System.Drawing.Color.Gray;
            this.tBoxBuscarProducto.Location = new System.Drawing.Point(47, 84);
            this.tBoxBuscarProducto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tBoxBuscarProducto.Name = "tBoxBuscarProducto";
            this.tBoxBuscarProducto.Size = new System.Drawing.Size(371, 25);
            this.tBoxBuscarProducto.TabIndex = 85;
            this.tBoxBuscarProducto.Text = "Buscar por \"Nombre\"";
            this.tBoxBuscarProducto.TextChanged += new System.EventHandler(this.tBoxBuscarProducto_TextChanged);
            this.tBoxBuscarProducto.Enter += new System.EventHandler(this.tBoxBuscarProducto_Enter);
            this.tBoxBuscarProducto.Leave += new System.EventHandler(this.tBoxBuscarProducto_Leave);
            // 
            // UC_AgregarProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(248)))));
            this.Controls.Add(this.btnLimpiarBusqueda);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tBoxBuscarProducto);
            this.Controls.Add(this.lblAgregarProducto);
            this.Controls.Add(this.nUDPrecioProducto);
            this.Controls.Add(this.dGridViewProductos);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.tboxNombreProducto);
            this.Controls.Add(this.lblNombre);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "UC_AgregarProductos";
            this.Size = new System.Drawing.Size(800, 554);
            ((System.ComponentModel.ISupportInitialize)(this.dGridViewProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDPrecioProducto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.TextBox tboxNombreProducto;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.DataGridView dGridViewProductos;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductoID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.NumericUpDown nUDPrecioProducto;
        private System.Windows.Forms.Label lblAgregarProducto;
        private System.Windows.Forms.Button btnLimpiarBusqueda;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tBoxBuscarProducto;
    }
}
