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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(196)))), ((int)(((byte)(69)))));
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Location = new System.Drawing.Point(385, 289);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(100, 23);
            this.btnCancelar.TabIndex = 72;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(196)))), ((int)(((byte)(69)))));
            this.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Location = new System.Drawing.Point(385, 222);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(100, 23);
            this.btnAgregar.TabIndex = 67;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(385, 138);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(37, 13);
            this.lblPrecio.TabIndex = 62;
            this.lblPrecio.Text = "Precio";
            // 
            // tboxNombreProducto
            // 
            this.tboxNombreProducto.Location = new System.Drawing.Point(385, 94);
            this.tboxNombreProducto.Name = "tboxNombreProducto";
            this.tboxNombreProducto.Size = new System.Drawing.Size(100, 20);
            this.tboxNombreProducto.TabIndex = 58;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(385, 78);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 57;
            this.lblNombre.Text = "Nombre";
            // 
            // dGridViewProductos
            // 
            this.dGridViewProductos.AllowUserToAddRows = false;
            this.dGridViewProductos.AllowUserToDeleteRows = false;
            this.dGridViewProductos.AllowUserToResizeColumns = false;
            this.dGridViewProductos.AllowUserToResizeRows = false;
            this.dGridViewProductos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(121)))), ((int)(((byte)(85)))));
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dGridViewProductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dGridViewProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGridViewProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductoID,
            this.Producto,
            this.Precio});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dGridViewProductos.DefaultCellStyle = dataGridViewCellStyle4;
            this.dGridViewProductos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dGridViewProductos.Location = new System.Drawing.Point(35, 94);
            this.dGridViewProductos.Name = "dGridViewProductos";
            this.dGridViewProductos.ReadOnly = true;
            this.dGridViewProductos.RowHeadersVisible = false;
            this.dGridViewProductos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dGridViewProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dGridViewProductos.Size = new System.Drawing.Size(305, 345);
            this.dGridViewProductos.TabIndex = 73;
            // 
            // ProductoID
            // 
            this.ProductoID.HeaderText = "ID";
            this.ProductoID.Name = "ProductoID";
            this.ProductoID.ReadOnly = true;
            this.ProductoID.Width = 30;
            // 
            // Producto
            // 
            this.Producto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Producto.DataPropertyName = "Producto";
            this.Producto.HeaderText = "Producto";
            this.Producto.Name = "Producto";
            this.Producto.ReadOnly = true;
            // 
            // Precio
            // 
            this.Precio.DataPropertyName = "Precio";
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            this.Precio.Width = 60;
            // 
            // nUDPrecioProducto
            // 
            this.nUDPrecioProducto.DecimalPlaces = 2;
            this.nUDPrecioProducto.Location = new System.Drawing.Point(385, 178);
            this.nUDPrecioProducto.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nUDPrecioProducto.Name = "nUDPrecioProducto";
            this.nUDPrecioProducto.Size = new System.Drawing.Size(100, 20);
            this.nUDPrecioProducto.TabIndex = 74;
            // 
            // lblAgregarProducto
            // 
            this.lblAgregarProducto.AutoSize = true;
            this.lblAgregarProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgregarProducto.Location = new System.Drawing.Point(3, 0);
            this.lblAgregarProducto.Name = "lblAgregarProducto";
            this.lblAgregarProducto.Size = new System.Drawing.Size(174, 24);
            this.lblAgregarProducto.TabIndex = 84;
            this.lblAgregarProducto.Text = "Agregar producto";
            // 
            // btnLimpiarBusqueda
            // 
            this.btnLimpiarBusqueda.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLimpiarBusqueda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(196)))), ((int)(((byte)(69)))));
            this.btnLimpiarBusqueda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpiarBusqueda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiarBusqueda.Location = new System.Drawing.Point(320, 68);
            this.btnLimpiarBusqueda.Name = "btnLimpiarBusqueda";
            this.btnLimpiarBusqueda.Size = new System.Drawing.Size(20, 20);
            this.btnLimpiarBusqueda.TabIndex = 87;
            this.btnLimpiarBusqueda.Text = "X";
            this.btnLimpiarBusqueda.UseVisualStyleBackColor = false;
            this.btnLimpiarBusqueda.Click += new System.EventHandler(this.btnLimpiarBusqueda_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 86;
            this.label1.Text = "Buscar producto";
            // 
            // tBoxBuscarProducto
            // 
            this.tBoxBuscarProducto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tBoxBuscarProducto.ForeColor = System.Drawing.Color.Gray;
            this.tBoxBuscarProducto.Location = new System.Drawing.Point(35, 68);
            this.tBoxBuscarProducto.Name = "tBoxBuscarProducto";
            this.tBoxBuscarProducto.Size = new System.Drawing.Size(279, 20);
            this.tBoxBuscarProducto.TabIndex = 85;
            this.tBoxBuscarProducto.Text = "Buscar por \"Nombre\"";
            this.tBoxBuscarProducto.TextChanged += new System.EventHandler(this.tBoxBuscarProducto_TextChanged);
            this.tBoxBuscarProducto.Enter += new System.EventHandler(this.tBoxBuscarProducto_Enter);
            this.tBoxBuscarProducto.Leave += new System.EventHandler(this.tBoxBuscarProducto_Leave);
            // 
            // UC_AgregarProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(121)))), ((int)(((byte)(85)))));
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
            this.Name = "UC_AgregarProductos";
            this.Size = new System.Drawing.Size(600, 450);
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
