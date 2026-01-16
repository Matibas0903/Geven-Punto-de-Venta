using BE;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoMerceria
{
    public partial class UC_DetalleDeVenta : UserControl
    {
        List<BE.DetalleVentaBE> Detalles = new List<BE.DetalleVentaBE>();
        private List<DetalleVentaBE> listaOriginalDetalles;
        BLL.DetalleVentaBLL unDetalleBLL = new BLL.DetalleVentaBLL();
        public UC_DetalleDeVenta(UC_VentasDiarias ventasDiarias)
        {
            InitializeComponent();
        }

        public void LlenarListaDetalles(int idVenta)
        {

            Detalles = unDetalleBLL.ObtenerDetallesDeVenta(idVenta);

            dGridViewDetalles.AutoGenerateColumns = false;

            dGridViewDetalles.Columns["NombreProducto"].DataPropertyName = "NombreProducto";
       
            dGridViewDetalles.Columns["Cantidad"].DataPropertyName = "Cantidad";
            dGridViewDetalles.Columns["SubTotal"].DefaultCellStyle.Format = "C2";
            dGridViewDetalles.Columns["SubTotal"].DataPropertyName = "SubTotal";

            dGridViewDetalles.DataSource = Detalles;
            ObtenerTotalVenta();
        }

        private void ObtenerTotalVenta()
        {
            float total = 0;

            foreach (DataGridViewRow fila in dGridViewDetalles.Rows)
            {
                if (fila.Cells["SubTotal"].Value != null && float.TryParse(fila.Cells["SubTotal"].Value.ToString(), out float valor))
                {
                    total += valor;
                }
            }
            tBoxTotal.Text = total.ToString("0.00");
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            var principal = this.FindForm() as Form1;
            if (principal != null)
            {   //pasa el id como parametro para encontrar el producto
                principal.MostrarVentasDiarias();
                return;
            }
            else
            {
                MessageBox.Show("No se encontro el form");
            }
        }

        private void UC_DetalleDeVenta_Load(object sender, EventArgs e)
        {

        }
    }
}
