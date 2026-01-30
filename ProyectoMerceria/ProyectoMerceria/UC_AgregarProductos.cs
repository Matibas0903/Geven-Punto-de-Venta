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
      
        private List<ProductoBE> listaOriginalProductos;
        BLL.ProductoBLL unProductoBLL = new BLL.ProductoBLL();
        public UC_AgregarProductos()
        {
            InitializeComponent();
            LlenarListaProductos();
            
          
        }

        public void LlenarListaProductos()
        {
            listaOriginalProductos = unProductoBLL.ObtenerProductos();

            dGridViewProductos.AutoGenerateColumns = false;

            dGridViewProductos.Columns["ProductoID"].DataPropertyName = "ProductoID";
            dGridViewProductos.Columns["Producto"].DataPropertyName = "Nombre";
            dGridViewProductos.Columns["Precio"].DefaultCellStyle.Format = "C2";
            dGridViewProductos.Columns["Precio"].DataPropertyName = "Precio";
            dGridViewProductos.Columns["stock"].DataPropertyName = "Cantidad";

            dGridViewProductos.DataSource = listaOriginalProductos;
        }


        private void btnAgregar_Click(object sender, EventArgs e)
        {
          
            
            if (string.IsNullOrWhiteSpace(tboxNombreProducto.Text) ||
                nUDPrecioProducto.Value <= 0 || nUDStock.Value <= 0) 
            {
                MessageBox.Show("Por favor, completá todos los campos obligatorios.", "Campos faltantes!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
              decimal precio = nUDPrecioProducto.Value;
            float precioProducto = (float)precio;
            int stock =  Convert.ToInt32(nUDStock.Value);
            BE.ProductoBE unProductoBE = new ProductoBE()
            {
                Nombre = tboxNombreProducto.Text,
                Precio = precioProducto,
                Cantidad = stock
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

            dGridViewProductos.DataSource = listaOriginalProductos;
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

        private void btnExcel_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "Excel (*.xlsx)|*.xlsx";
            save.FileName = "Productos.xlsx";
            try
            {
                if (save.ShowDialog() == DialogResult.OK)
                {
                    unProductoBLL.ExportarExcel(save.FileName);
                    MessageBox.Show("Exportación realizada con éxito");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al exportar: " + ex.Message);
            }
        }

        private void btnImportar_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Archivos Excel (*.xlsx)|*.xlsx";

            if (open.ShowDialog() != DialogResult.OK)
                return;

            try
            {
                unProductoBLL.ImportarProductosDesdeExcel(open.FileName);

                MessageBox.Show(
                    "Importación realizada correctamente",
                    "Éxito",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Error al importar",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
            }
            LlenarListaProductos();
        }

        private void btnBorrarProductos_Click(object sender, EventArgs e)
        {
            var formLibre = new FormBorrarProductos();
            if (formLibre.ShowDialog() == DialogResult.OK) 
            {
               LlenarListaProductos();
            }
        }
        private bool EsBoton(DataGridView grid, DataGridViewCellEventArgs e)
        {
            //responde si se toco una columna de botones o no
            return grid.Columns[e.ColumnIndex] is DataGridViewButtonColumn;
        }

        private bool EsFilaValida(int rowIndex)
        {
            //valida que no haya tocado un encabezado
            return rowIndex >= 0;
        }

        private void dGridViewProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!EsBoton(dGridViewProductos, e)) { return; }
            if (!EsFilaValida(e.RowIndex)) { return; }
            DataGridViewRow fila = dGridViewProductos.Rows[e.RowIndex];

            if (dGridViewProductos.Columns[e.ColumnIndex].Name == "editar")
            {
                int idProducto = Convert.ToInt32(dGridViewProductos.Rows[e.RowIndex].Cells["ProductoID"].Value);
                var principal = this.FindForm() as Form1;
                if (principal != null)
                {   //pasa el id como parametro para encontrar el producto
                    principal.MostrarEditarProducto(idProducto);
                    return;
                }
                else
                {
                    MessageBox.Show("No se encontro el form");
                }

            }
        }
    }
}
