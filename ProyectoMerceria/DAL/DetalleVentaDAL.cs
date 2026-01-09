using BE;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DetalleVentaDAL
    {
        conexion Conexion = new conexion();

        public void RegistrarDetalleVenta(DetalleVentaBE detalleVenta)
        {
            
            SqlParameter[] parametros = new SqlParameter[] {
                new SqlParameter("@VENTA_ID", detalleVenta.VentaID),
                new SqlParameter("@PRODUCTO_ID", detalleVenta.Producto.ProductoID),
                new SqlParameter("@Cantidad", detalleVenta.Cantidad),
                new SqlParameter("@Subtotal", detalleVenta.SubTotal)
            };

            Conexion.EscribirPorStoreProcedure("SP_RegistrarDetalleVenta", parametros);
        }

        public DataTable ObtenerDetalleDeVenta(int idVenta)
        {
            SqlParameter[] parametros = new SqlParameter[]
            {
                new SqlParameter ("@VentaID", idVenta)
            };
            return Conexion.LeerPorStoreProcedure("SP_VerDetalleVenta", parametros);

        }
    }
}
