namespace ProyectoMerceria
{
    partial class Form1
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.panelLateral = new System.Windows.Forms.Panel();
            this.PictureLaPuntada = new System.Windows.Forms.PictureBox();
            this.btnAgregarProducto = new System.Windows.Forms.Button();
            this.btnVentasDiarias = new System.Windows.Forms.Button();
            this.btnCrearVenta = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panelLateral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureLaPuntada)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelContenedor
            // 
            this.panelContenedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(248)))));
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(304, 6);
            this.panelContenedor.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(892, 785);
            this.panelContenedor.TabIndex = 1;
            this.panelContenedor.Resize += new System.EventHandler(this.panelContenedor_Resize);
            // 
            // panelLateral
            // 
            this.panelLateral.BackColor = System.Drawing.Color.White;
            this.panelLateral.Controls.Add(this.PictureLaPuntada);
            this.panelLateral.Controls.Add(this.btnAgregarProducto);
            this.panelLateral.Controls.Add(this.btnVentasDiarias);
            this.panelLateral.Controls.Add(this.btnCrearVenta);
            this.panelLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLateral.Location = new System.Drawing.Point(4, 6);
            this.panelLateral.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.panelLateral.Name = "panelLateral";
            this.panelLateral.Size = new System.Drawing.Size(291, 785);
            this.panelLateral.TabIndex = 0;
            this.panelLateral.Resize += new System.EventHandler(this.panelLateral_Resize);
            // 
            // PictureLaPuntada
            // 
            this.PictureLaPuntada.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PictureLaPuntada.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PictureLaPuntada.Image = global::ProyectoMerceria.Properties.Resources.LaPuntadaSinHiloLogo;
            this.PictureLaPuntada.Location = new System.Drawing.Point(40, 6);
            this.PictureLaPuntada.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.PictureLaPuntada.Name = "PictureLaPuntada";
            this.PictureLaPuntada.Size = new System.Drawing.Size(189, 185);
            this.PictureLaPuntada.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureLaPuntada.TabIndex = 3;
            this.PictureLaPuntada.TabStop = false;
            // 
            // btnAgregarProducto
            // 
            this.btnAgregarProducto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAgregarProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(158)))), ((int)(((byte)(11)))));
            this.btnAgregarProducto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarProducto.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarProducto.Location = new System.Drawing.Point(40, 551);
            this.btnAgregarProducto.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAgregarProducto.Name = "btnAgregarProducto";
            this.btnAgregarProducto.Size = new System.Drawing.Size(192, 102);
            this.btnAgregarProducto.TabIndex = 2;
            this.btnAgregarProducto.Text = "Agregar producto";
            this.btnAgregarProducto.UseVisualStyleBackColor = false;
            this.btnAgregarProducto.Click += new System.EventHandler(this.btnAgregarProducto_Click);
            // 
            // btnVentasDiarias
            // 
            this.btnVentasDiarias.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnVentasDiarias.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(158)))), ((int)(((byte)(11)))));
            this.btnVentasDiarias.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVentasDiarias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVentasDiarias.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVentasDiarias.Location = new System.Drawing.Point(40, 358);
            this.btnVentasDiarias.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnVentasDiarias.Name = "btnVentasDiarias";
            this.btnVentasDiarias.Size = new System.Drawing.Size(192, 102);
            this.btnVentasDiarias.TabIndex = 1;
            this.btnVentasDiarias.Text = "Ver ventas diarias";
            this.btnVentasDiarias.UseVisualStyleBackColor = false;
            this.btnVentasDiarias.Click += new System.EventHandler(this.btnVentasDiarias_Click);
            // 
            // btnCrearVenta
            // 
            this.btnCrearVenta.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCrearVenta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(158)))), ((int)(((byte)(11)))));
            this.btnCrearVenta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCrearVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrearVenta.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearVenta.Location = new System.Drawing.Point(40, 155);
            this.btnCrearVenta.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCrearVenta.Name = "btnCrearVenta";
            this.btnCrearVenta.Size = new System.Drawing.Size(192, 102);
            this.btnCrearVenta.TabIndex = 0;
            this.btnCrearVenta.Text = "Crear Venta";
            this.btnCrearVenta.UseVisualStyleBackColor = false;
            this.btnCrearVenta.Click += new System.EventHandler(this.btnCrearVenta_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 300F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panelContenedor, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panelLateral, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1200, 797);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(196)))), ((int)(((byte)(69)))));
            this.ClientSize = new System.Drawing.Size(1200, 797);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelLateral.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PictureLaPuntada)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.Panel panelLateral;
        private System.Windows.Forms.Button btnAgregarProducto;
        private System.Windows.Forms.Button btnVentasDiarias;
        private System.Windows.Forms.Button btnCrearVenta;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox PictureLaPuntada;
    }
}

