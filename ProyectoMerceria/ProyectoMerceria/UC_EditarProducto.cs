using BE;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProyectoMerceria
{
    
    public partial class UC_EditarProducto : UserControl
    {
        List<BE.ProductoBE> productos = new List<BE.ProductoBE>();
        BLL.ProductoBLL unProductoBLL = new BLL.ProductoBLL();
        private List<ProductoBE> listaOriginalProductos;
        int id_Producto;
        public UC_EditarProducto(int Producto_ID)
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

        public void CargarProducto(int idProducto)
        {

            //llena los campos con la info del producto ya sea vacuna o medicamento

            ProductoBE producto = unProductoBLL.ObtenerProductoPorID(idProducto);

                if (producto != null)
                {
                    //MessageBox.Show($"Nombre que llega: {producto.Nombre}");
                    tboxNombreProducto.Text = producto.Nombre;
                    nUDPrecioProducto.Text = producto.Precio.ToString();
                    LlenarListaProductos();

            }
                else
                {
                    MessageBox.Show("No se encontró el producto.");
                }
            id_Producto = idProducto;
        }


        private void btnEditar_Click(object sender, EventArgs e)
        {
            decimal precio = nUDPrecioProducto.Value;
            float precioProducto = (float)precio;
            if (nUDPrecioProducto.Value < 0) 
            {
                MessageBox.Show("No se permite numeros negativos.");
                return;
            }
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
                unProductoBLL.ActualizarProducto(unProductoBE, id_Producto);
                MessageBox.Show("Producto actualizado correctamente!");
                LlenarListaProductos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al editar el producto" + ex.Message);
            }

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            // verificamos que no se elimine ninguna ficha con mascota sin querer
            if (MessageBox.Show("¿Seguro que desea eliminar este producto?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            { 
                try
                {
                    unProductoBLL.EliminarProducto(id_Producto);

                    MessageBox.Show("Producto eliminado correctamente.");

                    var inicio = this.FindForm() as Form1;
                    if (inicio != null)
                    {
                        inicio.MostrarCrearVenta();
                        

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar el producto: " + ex.Message);
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            var inicio = this.FindForm() as Form1;
            if (inicio != null)
            {
                LlenarListaProductos();
                inicio.MostrarCrearVenta();

            }
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
