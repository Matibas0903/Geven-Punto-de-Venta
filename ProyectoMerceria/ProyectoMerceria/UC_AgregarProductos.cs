using BE;
using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoMerceria
{
    public partial class UC_AgregarProductos : UserControl
    {
        List<BE.ProductoBE> productos = new List<BE.ProductoBE>();
        private List<ProductoBE> listaOriginalProductos;
        BLL.ProductoBLL unProductoBLL = new BLL.ProductoBLL();
        public UC_AgregarProductos()
        {
            InitializeComponent();
            LlenarListaProductos();
            listaOriginalProductos = unProductoBLL.ObtenerProductos();
            dGridViewProductos.DataSource = listaOriginalProductos;
          
        }

        public void LlenarListaProductos()
        {

            productos = unProductoBLL.ObtenerProductos();

            dGridViewProductos.AutoGenerateColumns = false;

            dGridViewProductos.Columns["ProductoID"].DataPropertyName = "ProductoID";
            dGridViewProductos.Columns["Producto"].DataPropertyName = "Nombre";
            dGridViewProductos.Columns["Precio"].DefaultCellStyle.Format = "C2";
            dGridViewProductos.Columns["Precio"].DataPropertyName = "Precio";

            dGridViewProductos.DataSource = productos;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            decimal precio = nUDPrecioProducto.Value;
            float precioProducto = (float)precio;
            string nombreProducto;
            if (string.IsNullOrWhiteSpace(tboxNombreProducto.Text) ||
                string.IsNullOrWhiteSpace(nUDPrecioProducto.Text)) 
            {
                MessageBox.Show("Por favor, completá todos los campos obligatorios.", "CamposFaltantes!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            BE.ProductoBE unProductoBE = new ProductoBE()
            {
                Nombre = tboxNombreProducto.Text,
                Precio = precioProducto,
            };

            try
            {
                unProductoBLL.AgregarProducto(unProductoBE);
                MessageBox.Show("Producto agregado correctamente!");
                LlenarListaProductos();
            }
            catch (Exception ex) 
            {
                MessageBox.Show("Error al agregar el producto" + ex.Message);
            }

            tboxNombreProducto.Clear();
            nUDPrecioProducto.Value = 0;

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

            tboxNombreProducto.Clear();
            nUDPrecioProducto.Value = 0;
        }

        private void tBoxBuscarProducto_TextChanged(object sender, EventArgs e)
        {
            string filtro = tBoxBuscarProducto.Text.Trim().ToLower();

            // Filtrás la lista original por ID (como string) o por nombre
            var filtrados = listaOriginalProductos
                .Where(p => p.Nombre.ToLower().Contains(filtro) || p.ProductoID.ToString().Contains(filtro))
                .ToList();

            dGridViewProductos.DataSource = null;
            dGridViewProductos.DataSource = filtrados;
        }
        private void btnLimpiarBusqueda_Click_1(object sender, EventArgs e)
        {
            //borra todo lo que esta en la barra de busqueda y pone un texto por defecto
            tBoxBuscarProducto.Clear();
            tBoxBuscarProducto.Text = "Buscar por \"Nombre\"";
            tBoxBuscarProducto.ForeColor = Color.Gray;

            LlenarListaProductos();
        }

        private void tBoxBuscarProducto_Enter(object sender, EventArgs e)
        {
            if (tBoxBuscarProducto.Text == "Buscar por \"Nombre\"")
            {
                tBoxBuscarProducto.Text = "";
                tBoxBuscarProducto.ForeColor = Color.Black;//borra el texto por defecto y pone la fuente en negra
            }
            LlenarListaProductos();
        }

        private void tBoxBuscarProducto_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tBoxBuscarProducto.Text))
            {
                tBoxBuscarProducto.Text = "Buscar por \"Nombre\"";
                tBoxBuscarProducto.ForeColor = Color.Gray;//pone el texto por defecto y pone la fuente gris
            }
            LlenarListaProductos();
        }


    }
}
