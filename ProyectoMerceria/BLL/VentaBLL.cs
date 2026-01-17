using BE;
using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class VentaBLL
    {
        VentaDAL unaVentaDAL = new VentaDAL();
        public float CalcularTotal(VentaBE venta)
        {
            float total = 0f;
            foreach (var detalle in venta.DetalleVenta)
            {
                total += detalle.SubTotal;
            }

            return total;
        }

        public int RegistrarVenta(VentaBE unaVenta)
        {
           
            DetalleVentaDAL unDetalleVentaDAL = new DetalleVentaDAL();
            int venta_ID = unaVentaDAL.RegistrarVenta(unaVenta);

            foreach (var detalle in unaVenta.DetalleVenta)
            {
                detalle.VentaID = venta_ID;
                unDetalleVentaDAL.RegistrarDetalleVenta(detalle);
                DescontarStockVenta(unaVenta);
            }

            return venta_ID;
        }

        public List<VentaBE> ObtenerVentaPorFecha(DateTime Fecha) 
        {
            List<VentaBE> Ventas = new List<VentaBE>();

            DataTable tabla = unaVentaDAL.ObtenerVentaPorFecha(Fecha);

            if (tabla != null && tabla.Rows.Count > 0)
            {

                foreach (DataRow fila in tabla.Rows)
                {
                    string metodoPagoTexto = fila["METODO_PAGO"].ToString();
                    bool metodo;
                    if (metodoPagoTexto == "Efectivo") metodo = true;
                    else metodo = false;

                    Ventas.Add(new VentaBE
                    {
                        VentaID = Convert.ToInt32(fila["IDVENTA"]),
                        FechaVenta = Convert.ToDateTime(fila["FECHAVENTA"]),
                        MetodoPago = metodo,
                        Total = float.Parse(fila["TOTAL"].ToString())
                    });
                }
            }
            return Ventas;
        }

        private void DescontarStockVenta(VentaBE venta)
        {
            ProductoBLL productoBLL = new ProductoBLL();

            foreach (var detalle in venta.DetalleVenta)
            {
                productoBLL.DescontarStock(
                    detalle.Producto,
                    detalle.Cantidad
                );
            }
        }


    }
}
