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
    
    public partial class UC_VentasDiarias : UserControl
    {
        UC_DetalleDeVenta detalleDeVenta;
        List<BE.VentaBE> Ventas = new List<BE.VentaBE>();
        private List<VentaBE> listaOriginalVentas;
        BLL.VentaBLL unaVentaBLL = new BLL.VentaBLL();
        public UC_VentasDiarias()
        {
            InitializeComponent();

            detalleDeVenta = new UC_DetalleDeVenta(this);
            DateTime Fecha = dTPDia.Value.Date;
            LlenarListaVentas(Fecha);
       
        }
        //verificar porque no se actualizan las ventas
        private void ObtenerTotalVenta()
        {
            float total = 0;

            foreach (DataGridViewRow fila in dGridViewVentasDiarias.Rows)
            {
                if (fila.Cells["Total"].Value != null && float.TryParse(fila.Cells["Total"].Value.ToString(), out float valor))
                {
                    total += valor;
                }
            }
            tBoxTotalDiario.Text = total.ToString("0.00");
        }
        public void ResetearFecha() 
        {
            dTPDia.Value = DateTime.Today;
        }
        public void LlenarListaVentas(DateTime Fecha)
        {
         
            Ventas = unaVentaBLL.ObtenerVentaPorFecha(Fecha);

            dGridViewVentasDiarias.AutoGenerateColumns = false;

            dGridViewVentasDiarias.Columns["IDVenta"].DataPropertyName = "VentaID";
            dGridViewVentasDiarias.Columns["fecha"].DataPropertyName = "FechaVenta";
            dGridViewVentasDiarias.Columns["MetodoPago"].DataPropertyName = "MetodoPagoTexto";
            dGridViewVentasDiarias.Columns["Total"].DefaultCellStyle.Format = "C2";
            dGridViewVentasDiarias.Columns["Total"].DataPropertyName = "Total";

            dGridViewVentasDiarias.DataSource = Ventas;
            ObtenerTotalVenta();
        }

        private void dTPDia_ValueChanged(object sender, EventArgs e)
        {
            DateTime Fecha = dTPDia.Value.Date;
            LlenarListaVentas(Fecha);
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

        private void dGridViewVentasDiarias_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!EsFilaValida(e.RowIndex))
            { return; }
            if (!EsBoton(dGridViewVentasDiarias, e))
            {
                MessageBox.Show("la columna no es una boton");
                return;
            }

            DataGridViewRow fila = dGridViewVentasDiarias.Rows[e.RowIndex];

            int idVenta = 0;

            object objIDVenta = fila.Cells["IDVenta"].Value;
            if (objIDVenta == null) return;

            idVenta = int.Parse(objIDVenta.ToString());


            detalleDeVenta.LlenarListaDetalles(idVenta);

            var principal = this.FindForm() as Form1;
            if (principal != null)
            {   //pasa el id como parametro para encontrar el producto
                principal.MostrarDetalleVentas(idVenta);
                return;
            }
            else
            {
                MessageBox.Show("No se encontro el form");
            }

        }

    }
}
