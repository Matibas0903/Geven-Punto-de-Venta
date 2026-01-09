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
    public partial class UC_CrearVenta : UserControl
    {
        List<BE.ProductoBE> productos = new List<BE.ProductoBE>();
        private List<ProductoBE> listaOriginalProductos;
        BLL.ProductoBLL unProductoBLL = new BLL.ProductoBLL();
        private VentaBE unaVenta = new VentaBE(); 
        int cantidad;
        public UC_CrearVenta()
        {
            InitializeComponent();
            LlenarListaProductos();
            listaOriginalProductos = unProductoBLL.ObtenerProductos();
            dGridViewProductos.DataSource = listaOriginalProductos;
            ObtenerTotalVenta();
            dGridViewVenta.Columns["Valor"].DefaultCellStyle.Format = "C2";

        }

        private void ObtenerTotalVenta() 
        {
            float total = 0;

            foreach (DataGridViewRow fila in dGridViewVenta.Rows) 
            {
                if (fila.Cells["Valor"].Value != null && float.TryParse(fila.Cells["Valor"].Value.ToString(), out float valor)) 
                {
                    total += valor;
                }
            }
            tBoxTotal.Text = total.ToString("0.00");
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
        private void dGridViewProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           // MessageBox.Show($"Fila: {e.RowIndex}, Columna: {e.ColumnIndex}");
            DataGridViewRow fila = dGridViewProductos.Rows[e.RowIndex];

            if (!EsBoton(dGridViewProductos,e)) { return; }
            if (!EsFilaValida(e.RowIndex)) { return; }
            if (dGridViewProductos.Columns[e.ColumnIndex].Name == "Editar")
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


            if (dGridViewProductos.Rows[e.RowIndex].DataBoundItem is ProductoBE productoSeleccionado)
            {
                AgregarOActualizarProductoEnVenta(productoSeleccionado.Nombre, productoSeleccionado.Precio, productoSeleccionado.ProductoID);
                ObtenerTotalVenta();
            }

           // if (!ObtenerProducto(fila, out string nombre, out float precio, out int id))
            //{ return; }

            //AgregarOActualizarProductoEnVenta(nombre, precio, id);
            ObtenerTotalVenta();
            DeseleccionarFila(dGridViewProductos, e.ColumnIndex);
        }

        private bool EsBoton(DataGridView grid,DataGridViewCellEventArgs e) 
        {
            //responde si se toco una columna de botones o no
            return grid.Columns[e.ColumnIndex] is DataGridViewButtonColumn;
        }

        private bool EsFilaValida(int rowIndex) 
        {
            //valida que no haya tocado un encabezado
            return rowIndex >= 0;
        }

        private bool ObtenerProducto(DataGridViewRow fila, out string nombre, out float precio, out int id)//instancio nombre y precio como parametros de salida
        {
            nombre = string.Empty;
            precio = 0;
            id = 0;

            object objID = fila.Cells["ProductoID"].Value;
            object objNombre = fila.Cells["Producto"].Value;
            object objPrecio = fila.Cells["Precio"].Value;

            if (objID == null||objNombre == null || objPrecio == null) 
            {
                return false;
            }

            nombre = objNombre.ToString();
            id = int.Parse(objID.ToString());
            return float.TryParse(objPrecio.ToString(), out precio);//usu try parse(en lugar de parse para que devuelva un valor bool)

        }

        private void AgregarOActualizarProductoEnVenta(string nombre, float precio, int id)
        {
            cantidad = 1;

            foreach (DataGridViewRow filaVenta in dGridViewVenta.Rows)
            {
                if (filaVenta.Cells["NombreProducto"].Value.ToString() == nombre)
                {
                    if (filaVenta.Cells["CantidadProducto"].Value != null &&
                        int.TryParse(filaVenta.Cells["CantidadProducto"].Value.ToString(), out int valor))
                        //verifica que la celda no sea null e intenta convertir el contenido en int y guardarlo en la variable valor
                    {
                        cantidad = valor + 1;
                    }

                    filaVenta.Cells["CantidadProducto"].Value = cantidad;
                    filaVenta.Cells["Valor"].Value = precio * cantidad;
                    filaVenta.Cells["ID"].Value = id;
                    filaVenta.Cells["precioUnitario"].Value = precio;
                    return;
                }
            }
            float subtotal = precio * cantidad;

            dGridViewVenta.Rows.Add(null, cantidad, nombre, subtotal, null, id, precioUnitario);
        }

        private void DeseleccionarFila(DataGridView grid, int rowIndex)
        {
            grid.Rows[rowIndex].Selected = false;
        }


        private void dGridViewVenta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!EsFilaValida(e.RowIndex)) 
            { return; }
            if (!EsBoton(dGridViewVenta, e)) 
            {
                MessageBox.Show("la columna no es una boton");
                return;}

            DataGridViewRow fila = dGridViewVenta.Rows[e.RowIndex];

            /*if (!ObtenerProducto(fila, out string nombre, out float precio))
            { return; }*/

            string nombre = string.Empty;
            float precio = 0;
            int id = 0;

            object objID = fila.Cells["ID"].Value;
            object objNombre = fila.Cells["NombreProducto"].Value;
            object objPrecio = fila.Cells["Valor"].Value;

            if (objID == null ||objNombre == null || objPrecio == null)
            {
                return;
            }

            id = int.Parse(objID.ToString());
            nombre = objNombre.ToString();
            precio = float.Parse(objPrecio.ToString());

            if (!ProcesarAccionEnFila(e, precio))
            { return; }
            LlenarListaProductos();
                

        }

        private bool ProcesarAccionEnFila(DataGridViewCellEventArgs e, float precio) 
        {
            int indiceColumna = e.ColumnIndex;
            int indiceFila = e.RowIndex;

            DataGridViewRow fila = dGridViewVenta.Rows[e.RowIndex];

            if (!EsBoton(dGridViewVenta,e)) { return false; }
            

                string nombreColumna = dGridViewVenta.Columns[e.ColumnIndex].Name;
                int cantidad = 0;
                float precioUnitario = precio;
                float subTotal;
                if (int.Parse(fila.Cells["CantidadProducto"].Value.ToString()) > 0)
                {
                    cantidad = int.Parse(fila.Cells["CantidadProducto"].Value.ToString());
                }
                if (float.Parse(fila.Cells["Valor"].Value.ToString()) > 0)
                {
                    precio = float.Parse(fila.Cells["Valor"].Value.ToString());
                    precioUnitario = precio / cantidad;

                }
                switch (nombreColumna)
                {
                    case "Sumar":
                        cantidad++;
                        fila.Cells["CantidadProducto"].Value = cantidad;
                        ObtenerTotalVenta();
                        break;

                    case "Restar":
                        cantidad--;
                        if (cantidad <= 0)
                        {
                            dGridViewVenta.Rows.RemoveAt(e.RowIndex);
                            ObtenerTotalVenta();
                            return false;
                            
                        }
                        else
                        {
                            fila.Cells["CantidadProducto"].Value = cantidad;
                           
                            fila.Cells["Valor"].Value = precioUnitario;
                            ObtenerTotalVenta();
                        }
                        break;
                    default:
                        ObtenerTotalVenta();
                        return false;
                }
                subTotal = cantidad * precioUnitario;

                fila.Cells["CantidadProducto"].Value = cantidad;
                fila.Cells["Valor"].Value = subTotal;
                ObtenerTotalVenta();

            return true;
            
        }

        private void tBoxBuscarProducto_TextChanged(object sender, EventArgs e)
        {
            string filtro = tBoxBuscarProducto.Text.Trim().ToLower();

            // Filtrás la lista original por ID (como string) o por nombre
            var filtrados = listaOriginalProductos
                .Where(p => p.Nombre.ToLower().Contains(filtro) || p.ProductoID.ToString().Contains(filtro))
                .ToList();

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
            
        }

        private void tBoxBuscarProducto_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tBoxBuscarProducto.Text))
            {
                tBoxBuscarProducto.Text = "Buscar por \"Nombre\"";
                tBoxBuscarProducto.ForeColor = Color.Gray;//pone el texto por defecto y pone la fuente gris
            }
            
        }

        private void btnCrearVenta_Click(object sender, EventArgs e)
        {
            if (dGridViewVenta.Rows.Count == 0)
            {
                MessageBox.Show("Agregue un producto para crear una venta!");
                return;
            }

            if (cBoxMetodoPago.Text == "") 
            {
                MessageBox.Show("Seleccione un metodo de pago!");
                return;
            }
          

            bool metodoPago;
            if(cBoxMetodoPago.Text == "Efectivo") metodoPago = true;
            else metodoPago = false;
           
            VentaBE nuevaVenta = new VentaBE()
            {
                MetodoPago = metodoPago,
                FechaVenta = DateTime.Today,
                Total = float.Parse(tBoxTotal.Text),
                DetalleVenta = new List<DetalleVentaBE>()
            };

            foreach (DataGridViewRow fila in dGridViewVenta.Rows) 
            {
                int cantidad = int.Parse(fila.Cells["CantidadProducto"].Value.ToString());
                float subtotal = float.Parse(fila.Cells["Valor"].Value.ToString());
                float precioUnitario = subtotal / cantidad;

                ProductoBE producto = new ProductoBE()
                {
                    ProductoID = int.Parse(fila.Cells["ID"].Value.ToString()),
                    Nombre = fila.Cells["NombreProducto"].Value.ToString(),
                    Precio = precioUnitario
                };
       

                //creamos una venta y la llenamos, lueo la agregamos a la lista de detalles de venta
                DetalleVentaBE detalle = new DetalleVentaBE()
                {
                    Producto = producto,
                    Cantidad = cantidad,

                };

                DetalleVentaBLL detalleBLL = new DetalleVentaBLL();
                detalle.SubTotal = detalleBLL.CalcularSubtotal(detalle);
                nuevaVenta.DetalleVenta.Add(detalle);
            }

            VentaBLL ventaBLL = new VentaBLL();
            nuevaVenta.Total = ventaBLL.CalcularTotal(nuevaVenta);

            int ventaID = ventaBLL.RegistrarVenta(nuevaVenta);
            
            MessageBox.Show($"Venta registrada con éxito. ID: {ventaID}");
            dGridViewVenta.Rows.Clear();
            cBoxMetodoPago.SelectedIndex = -1;
            tBoxTotal.Text = "0.00";
        }

        private void btnProductoLibre_Click(object sender, EventArgs e)
        {
            var formLibre = new FormProductoLibre();
            if (formLibre.ShowDialog() == DialogResult.OK)
            {
                // Generás un ID negativo para que no se choque con los productos reales de BD
                int idTemporal = -1 * (dGridViewVenta.Rows.Count + 1);

                float subtotal = formLibre.Precio * formLibre.Cantidad;

                dGridViewVenta.Rows.Add(
                    null,
                    formLibre.Cantidad,
                    formLibre.NombreProducto,
                    subtotal,
                    null,
                    idTemporal,
                    formLibre.Precio

                );

                ObtenerTotalVenta(); // O lo que uses para recalcular el total
            }
        }
    }
}
