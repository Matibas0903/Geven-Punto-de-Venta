namespace ProyectoMerceria
{
    partial class UC_EditarProducto
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
            this.nUDPrecioProducto = new System.Windows.Forms.NumericUpDown();
            this.dGridViewProductos = new System.Windows.Forms.DataGridView();
            this.ProductoID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.tboxNombreProducto = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.lblEditarProducto = new System.Windows.Forms.Label();
            this.btnLimpiarBusqueda = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tBoxBuscarProducto = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nUDPrecioProducto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGridViewProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // nUDPrecioProducto
            // 
            this.nUDPrecioProducto.DecimalPlaces = 2;
            this.nUDPrecioProducto.Location = new System.Drawing.Point(533, 231);
            this.nUDPrecioProducto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nUDPrecioProducto.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nUDPrecioProducto.Name = "nUDPrecioProducto";
            this.nUDPrecioProducto.Size = new System.Drawing.Size(133, 22);
            this.nUDPrecioProducto.TabIndex = 81;
            // 
            // dGridViewProductos
            // 
            this.dGridViewProductos.AllowUserToAddRows = false;
            this.dGridViewProductos.AllowUserToDeleteRows = false;
            this.dGridViewProductos.AllowUserToResizeColumns = false;
            this.dGridViewProductos.AllowUserToResizeRows = false;
            this.dGridViewProductos.BackgroundColor = System.Drawing.Color.White;
            this.dGridViewProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGridViewProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductoID,
            this.Producto,
            this.Precio});
            this.dGridViewProductos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dGridViewProductos.Location = new System.Drawing.Point(67, 108);
            this.dGridViewProductos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dGridViewProductos.Name = "dGridViewProductos";
            this.dGridViewProductos.ReadOnly = true;
            this.dGridViewProductos.RowHeadersVisible = false;
            this.dGridViewProductos.RowHeadersWidth = 51;
            this.dGridViewProductos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dGridViewProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dGridViewProductos.Size = new System.Drawing.Size(407, 425);
            this.dGridViewProductos.TabIndex = 80;
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
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(158)))), ((int)(((byte)(11)))));
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(533, 411);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(133, 28);
            this.btnCancelar.TabIndex = 79;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(158)))), ((int)(((byte)(11)))));
            this.btnEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Location = new System.Drawing.Point(533, 286);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(133, 28);
            this.btnEditar.TabIndex = 78;
            this.btnEditar.Text = "Guardar cambios";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecio.Location = new System.Drawing.Point(533, 204);
            this.lblPrecio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(57, 23);
            this.lblPrecio.TabIndex = 77;
            this.lblPrecio.Text = "Precio";
            // 
            // tboxNombreProducto
            // 
            this.tboxNombreProducto.Location = new System.Drawing.Point(533, 128);
            this.tboxNombreProducto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tboxNombreProducto.Name = "tboxNombreProducto";
            this.tboxNombreProducto.Size = new System.Drawing.Size(132, 22);
            this.tboxNombreProducto.TabIndex = 76;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(533, 101);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(73, 23);
            this.lblNombre.TabIndex = 75;
            this.lblNombre.Text = "Nombre";
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(158)))), ((int)(((byte)(11)))));
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(533, 353);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(133, 28);
            this.btnEliminar.TabIndex = 82;
            this.btnEliminar.Text = "Eliminar producto";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // lblEditarProducto
            // 
            this.lblEditarProducto.AutoSize = true;
            this.lblEditarProducto.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditarProducto.Location = new System.Drawing.Point(27, 14);
            this.lblEditarProducto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEditarProducto.Name = "lblEditarProducto";
            this.lblEditarProducto.Size = new System.Drawing.Size(182, 31);
            this.lblEditarProducto.TabIndex = 83;
            this.lblEditarProducto.Text = "Editar producto";
            // 
            // btnLimpiarBusqueda
            // 
            this.btnLimpiarBusqueda.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLimpiarBusqueda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(158)))), ((int)(((byte)(11)))));
            this.btnLimpiarBusqueda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpiarBusqueda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiarBusqueda.Location = new System.Drawing.Point(447, 76);
            this.btnLimpiarBusqueda.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLimpiarBusqueda.Name = "btnLimpiarBusqueda";
            this.btnLimpiarBusqueda.Size = new System.Drawing.Size(27, 25);
            this.btnLimpiarBusqueda.TabIndex = 86;
            this.btnLimpiarBusqueda.Text = "X";
            this.btnLimpiarBusqueda.UseVisualStyleBackColor = false;
            this.btnLimpiarBusqueda.Click += new System.EventHandler(this.btnLimpiarBusqueda_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(63, 49);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 23);
            this.label1.TabIndex = 85;
            this.label1.Text = "Buscar producto";
            // 
            // tBoxBuscarProducto
            // 
            this.tBoxBuscarProducto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tBoxBuscarProducto.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBoxBuscarProducto.ForeColor = System.Drawing.Color.Gray;
            this.tBoxBuscarProducto.Location = new System.Drawing.Point(67, 76);
            this.tBoxBuscarProducto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tBoxBuscarProducto.Name = "tBoxBuscarProducto";
            this.tBoxBuscarProducto.Size = new System.Drawing.Size(371, 25);
            this.tBoxBuscarProducto.TabIndex = 84;
            this.tBoxBuscarProducto.Text = "Buscar por \"Nombre\"";
            this.tBoxBuscarProducto.TextChanged += new System.EventHandler(this.tBoxBuscarProducto_TextChanged);
            this.tBoxBuscarProducto.Enter += new System.EventHandler(this.tBoxBuscarProducto_Enter);
            this.tBoxBuscarProducto.Leave += new System.EventHandler(this.tBoxBuscarProducto_Leave);
            // 
            // UC_EditarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(248)))));
            this.Controls.Add(this.btnLimpiarBusqueda);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tBoxBuscarProducto);
            this.Controls.Add(this.lblEditarProducto);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.nUDPrecioProducto);
            this.Controls.Add(this.dGridViewProductos);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.tboxNombreProducto);
            this.Controls.Add(this.lblNombre);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "UC_EditarProducto";
            this.Size = new System.Drawing.Size(800, 554);
            ((System.ComponentModel.ISupportInitialize)(this.nUDPrecioProducto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGridViewProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nUDPrecioProducto;
        private System.Windows.Forms.DataGridView dGridViewProductos;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductoID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.TextBox tboxNombreProducto;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label lblEditarProducto;
        private System.Windows.Forms.Button btnLimpiarBusqueda;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tBoxBuscarProducto;
    }
}
