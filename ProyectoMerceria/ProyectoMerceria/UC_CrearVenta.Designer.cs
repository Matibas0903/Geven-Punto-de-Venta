namespace ProyectoMerceria
{
    partial class UC_CrearVenta
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
            this.dGridViewProductos = new System.Windows.Forms.DataGridView();
            this.Agregar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Editar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ProductoID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCrearVenta = new System.Windows.Forms.Button();
            this.cBoxMetodoPago = new System.Windows.Forms.ComboBox();
            this.dGridViewVenta = new System.Windows.Forms.DataGridView();
            this.Restar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.CantidadProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sumar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tBoxBuscarProducto = new System.Windows.Forms.TextBox();
            this.lblBuscarProducto = new System.Windows.Forms.Label();
            this.btnLimpiarBusqueda = new System.Windows.Forms.Button();
            this.tBoxTotal = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblMetodoPago = new System.Windows.Forms.Label();
            this.lblCrearVenta = new System.Windows.Forms.Label();
            this.btnProductoLibre = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dGridViewProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGridViewVenta)).BeginInit();
            this.SuspendLayout();
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
            this.Agregar,
            this.Producto,
            this.Precio,
            this.Editar,
            this.ProductoID});
            this.dGridViewProductos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dGridViewProductos.Location = new System.Drawing.Point(24, 68);
            this.dGridViewProductos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dGridViewProductos.Name = "dGridViewProductos";
            this.dGridViewProductos.ReadOnly = true;
            this.dGridViewProductos.RowHeadersVisible = false;
            this.dGridViewProductos.RowHeadersWidth = 51;
            this.dGridViewProductos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dGridViewProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dGridViewProductos.Size = new System.Drawing.Size(407, 425);
            this.dGridViewProductos.TabIndex = 0;
            this.dGridViewProductos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGridViewProductos_CellClick);
            // 
            // Agregar
            // 
            this.Agregar.HeaderText = "";
            this.Agregar.MinimumWidth = 6;
            this.Agregar.Name = "Agregar";
            this.Agregar.ReadOnly = true;
            this.Agregar.Text = "+";
            this.Agregar.UseColumnTextForButtonValue = true;
            this.Agregar.Width = 20;
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
            // Editar
            // 
            this.Editar.HeaderText = "";
            this.Editar.MinimumWidth = 6;
            this.Editar.Name = "Editar";
            this.Editar.ReadOnly = true;
            this.Editar.Text = "Editar";
            this.Editar.UseColumnTextForButtonValue = true;
            this.Editar.Width = 60;
            // 
            // ProductoID
            // 
            this.ProductoID.HeaderText = "ProductoID";
            this.ProductoID.MinimumWidth = 6;
            this.ProductoID.Name = "ProductoID";
            this.ProductoID.ReadOnly = true;
            this.ProductoID.Visible = false;
            this.ProductoID.Width = 125;
            // 
            // btnCrearVenta
            // 
            this.btnCrearVenta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(158)))), ((int)(((byte)(11)))));
            this.btnCrearVenta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCrearVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrearVenta.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearVenta.Location = new System.Drawing.Point(572, 341);
            this.btnCrearVenta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCrearVenta.Name = "btnCrearVenta";
            this.btnCrearVenta.Size = new System.Drawing.Size(100, 28);
            this.btnCrearVenta.TabIndex = 2;
            this.btnCrearVenta.Text = "Crear venta";
            this.btnCrearVenta.UseVisualStyleBackColor = false;
            this.btnCrearVenta.Click += new System.EventHandler(this.btnCrearVenta_Click);
            // 
            // cBoxMetodoPago
            // 
            this.cBoxMetodoPago.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cBoxMetodoPago.FormattingEnabled = true;
            this.cBoxMetodoPago.Items.AddRange(new object[] {
            "Efectivo",
            "Transferencia"});
            this.cBoxMetodoPago.Location = new System.Drawing.Point(633, 281);
            this.cBoxMetodoPago.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cBoxMetodoPago.Name = "cBoxMetodoPago";
            this.cBoxMetodoPago.Size = new System.Drawing.Size(160, 24);
            this.cBoxMetodoPago.TabIndex = 3;
            // 
            // dGridViewVenta
            // 
            this.dGridViewVenta.AllowUserToAddRows = false;
            this.dGridViewVenta.AllowUserToDeleteRows = false;
            this.dGridViewVenta.AllowUserToResizeColumns = false;
            this.dGridViewVenta.AllowUserToResizeRows = false;
            this.dGridViewVenta.BackgroundColor = System.Drawing.Color.White;
            this.dGridViewVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGridViewVenta.ColumnHeadersVisible = false;
            this.dGridViewVenta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Restar,
            this.CantidadProducto,
            this.NombreProducto,
            this.Valor,
            this.Sumar,
            this.ID,
            this.precioUnitario});
            this.dGridViewVenta.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dGridViewVenta.Location = new System.Drawing.Point(475, 42);
            this.dGridViewVenta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dGridViewVenta.Name = "dGridViewVenta";
            this.dGridViewVenta.ReadOnly = true;
            this.dGridViewVenta.RowHeadersVisible = false;
            this.dGridViewVenta.RowHeadersWidth = 51;
            this.dGridViewVenta.Size = new System.Drawing.Size(320, 185);
            this.dGridViewVenta.TabIndex = 4;
            this.dGridViewVenta.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGridViewVenta_CellContentClick);
            // 
            // Restar
            // 
            this.Restar.HeaderText = "";
            this.Restar.MinimumWidth = 6;
            this.Restar.Name = "Restar";
            this.Restar.ReadOnly = true;
            this.Restar.Text = "-";
            this.Restar.UseColumnTextForButtonValue = true;
            this.Restar.Width = 20;
            // 
            // CantidadProducto
            // 
            this.CantidadProducto.HeaderText = "cantidad";
            this.CantidadProducto.MinimumWidth = 6;
            this.CantidadProducto.Name = "CantidadProducto";
            this.CantidadProducto.ReadOnly = true;
            this.CantidadProducto.Width = 30;
            // 
            // NombreProducto
            // 
            this.NombreProducto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NombreProducto.HeaderText = "Producto";
            this.NombreProducto.MinimumWidth = 6;
            this.NombreProducto.Name = "NombreProducto";
            this.NombreProducto.ReadOnly = true;
            // 
            // Valor
            // 
            this.Valor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Valor.HeaderText = "SubTotal";
            this.Valor.MinimumWidth = 6;
            this.Valor.Name = "Valor";
            this.Valor.ReadOnly = true;
            // 
            // Sumar
            // 
            this.Sumar.HeaderText = "";
            this.Sumar.MinimumWidth = 6;
            this.Sumar.Name = "Sumar";
            this.Sumar.ReadOnly = true;
            this.Sumar.Text = "+";
            this.Sumar.UseColumnTextForButtonValue = true;
            this.Sumar.Width = 20;
            // 
            // ID
            // 
            this.ID.HeaderText = "id";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            this.ID.Width = 125;
            // 
            // precioUnitario
            // 
            this.precioUnitario.HeaderText = "precioUnitario";
            this.precioUnitario.MinimumWidth = 6;
            this.precioUnitario.Name = "precioUnitario";
            this.precioUnitario.ReadOnly = true;
            this.precioUnitario.Visible = false;
            this.precioUnitario.Width = 125;
            // 
            // tBoxBuscarProducto
            // 
            this.tBoxBuscarProducto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tBoxBuscarProducto.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBoxBuscarProducto.ForeColor = System.Drawing.Color.Gray;
            this.tBoxBuscarProducto.Location = new System.Drawing.Point(24, 36);
            this.tBoxBuscarProducto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tBoxBuscarProducto.Name = "tBoxBuscarProducto";
            this.tBoxBuscarProducto.Size = new System.Drawing.Size(371, 25);
            this.tBoxBuscarProducto.TabIndex = 5;
            this.tBoxBuscarProducto.Text = "Buscar por \"Nombre\"";
            this.tBoxBuscarProducto.TextChanged += new System.EventHandler(this.tBoxBuscarProducto_TextChanged);
            this.tBoxBuscarProducto.Enter += new System.EventHandler(this.tBoxBuscarProducto_Enter);
            this.tBoxBuscarProducto.Leave += new System.EventHandler(this.tBoxBuscarProducto_Leave);
            // 
            // lblBuscarProducto
            // 
            this.lblBuscarProducto.AutoSize = true;
            this.lblBuscarProducto.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscarProducto.Location = new System.Drawing.Point(20, 12);
            this.lblBuscarProducto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBuscarProducto.Name = "lblBuscarProducto";
            this.lblBuscarProducto.Size = new System.Drawing.Size(141, 23);
            this.lblBuscarProducto.TabIndex = 6;
            this.lblBuscarProducto.Text = "Buscar producto";
            // 
            // btnLimpiarBusqueda
            // 
            this.btnLimpiarBusqueda.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLimpiarBusqueda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(158)))), ((int)(((byte)(11)))));
            this.btnLimpiarBusqueda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpiarBusqueda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiarBusqueda.Location = new System.Drawing.Point(404, 36);
            this.btnLimpiarBusqueda.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLimpiarBusqueda.Name = "btnLimpiarBusqueda";
            this.btnLimpiarBusqueda.Size = new System.Drawing.Size(27, 25);
            this.btnLimpiarBusqueda.TabIndex = 7;
            this.btnLimpiarBusqueda.Text = "X";
            this.btnLimpiarBusqueda.UseVisualStyleBackColor = false;
            this.btnLimpiarBusqueda.Click += new System.EventHandler(this.btnLimpiarBusqueda_Click_1);
            // 
            // tBoxTotal
            // 
            this.tBoxTotal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tBoxTotal.Location = new System.Drawing.Point(475, 281);
            this.tBoxTotal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tBoxTotal.Name = "tBoxTotal";
            this.tBoxTotal.ReadOnly = true;
            this.tBoxTotal.Size = new System.Drawing.Size(132, 22);
            this.tBoxTotal.TabIndex = 8;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(471, 256);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(49, 23);
            this.lblTotal.TabIndex = 9;
            this.lblTotal.Text = "Total";
            // 
            // lblMetodoPago
            // 
            this.lblMetodoPago.AutoSize = true;
            this.lblMetodoPago.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMetodoPago.Location = new System.Drawing.Point(629, 256);
            this.lblMetodoPago.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMetodoPago.Name = "lblMetodoPago";
            this.lblMetodoPago.Size = new System.Drawing.Size(144, 23);
            this.lblMetodoPago.TabIndex = 10;
            this.lblMetodoPago.Text = "Metodo de pago";
            // 
            // lblCrearVenta
            // 
            this.lblCrearVenta.AutoSize = true;
            this.lblCrearVenta.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCrearVenta.Location = new System.Drawing.Point(471, 18);
            this.lblCrearVenta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCrearVenta.Name = "lblCrearVenta";
            this.lblCrearVenta.Size = new System.Drawing.Size(102, 23);
            this.lblCrearVenta.TabIndex = 11;
            this.lblCrearVenta.Text = "Crear venta";
            // 
            // btnProductoLibre
            // 
            this.btnProductoLibre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(158)))), ((int)(((byte)(11)))));
            this.btnProductoLibre.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProductoLibre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProductoLibre.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProductoLibre.Location = new System.Drawing.Point(439, 446);
            this.btnProductoLibre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnProductoLibre.Name = "btnProductoLibre";
            this.btnProductoLibre.Size = new System.Drawing.Size(119, 47);
            this.btnProductoLibre.TabIndex = 12;
            this.btnProductoLibre.Text = "Producto libre";
            this.btnProductoLibre.UseVisualStyleBackColor = false;
            this.btnProductoLibre.Click += new System.EventHandler(this.btnProductoLibre_Click);
            // 
            // UC_CrearVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(248)))));
            this.Controls.Add(this.btnProductoLibre);
            this.Controls.Add(this.lblCrearVenta);
            this.Controls.Add(this.lblMetodoPago);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.tBoxTotal);
            this.Controls.Add(this.btnLimpiarBusqueda);
            this.Controls.Add(this.lblBuscarProducto);
            this.Controls.Add(this.tBoxBuscarProducto);
            this.Controls.Add(this.dGridViewVenta);
            this.Controls.Add(this.cBoxMetodoPago);
            this.Controls.Add(this.btnCrearVenta);
            this.Controls.Add(this.dGridViewProductos);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "UC_CrearVenta";
            this.Size = new System.Drawing.Size(808, 527);
            ((System.ComponentModel.ISupportInitialize)(this.dGridViewProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGridViewVenta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dGridViewProductos;
        private System.Windows.Forms.Button btnCrearVenta;
        private System.Windows.Forms.ComboBox cBoxMetodoPago;
        private System.Windows.Forms.DataGridView dGridViewVenta;
        private System.Windows.Forms.DataGridViewButtonColumn Agregar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewButtonColumn Editar;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductoID;
        private System.Windows.Forms.TextBox tBoxBuscarProducto;
        private System.Windows.Forms.Label lblBuscarProducto;
        private System.Windows.Forms.Button btnLimpiarBusqueda;
        private System.Windows.Forms.TextBox tBoxTotal;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblMetodoPago;
        private System.Windows.Forms.Label lblCrearVenta;
        private System.Windows.Forms.Button btnProductoLibre;
        private System.Windows.Forms.DataGridViewButtonColumn Restar;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantidadProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor;
        private System.Windows.Forms.DataGridViewButtonColumn Sumar;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioUnitario;
    }
}
