using BE;
using DAL;
using System;
using System.Collections.Generic;
using System.Data;

namespace BLL
{
    public class DetalleVentaBLL
    {
        DetalleVentaDAL unDetalleDal = new DetalleVentaDAL();   
        public float CalcularSubtotal(DetalleVentaBE detalleVenta)
        {
            float subtotal = 0f;
            subtotal = detalleVenta.Producto.Precio * detalleVenta.Cantidad;
            return subtotal;
        }

        public List<DetalleVentaBE> ObtenerDetallesDeVenta(int idVenta)
        {
            List<DetalleVentaBE> Detalles = new List<DetalleVentaBE>();

            DataTable tabla = unDetalleDal.ObtenerDetalleDeVenta(idVenta);
            

            if (tabla != null && tabla.Rows.Count > 0)
            {

                foreach (DataRow fila in tabla.Rows)
                {
                    ProductoBE producto = new ProductoBE
                    {
                        Nombre = fila["NOMBRE_PRODUCTO"].ToString()
                    };

                    Detalles.Add(new DetalleVentaBE
                    {
                       SubTotal = float.Parse(fila["SUBTOTAL"].ToString()),
                       Cantidad = Convert.ToInt32(fila["CANTIDAD"].ToString()),
                       NombreProducto = producto.Nombre
                       
                    });
                }
            }
            return Detalles;
        }

    }
}
