using BE;
using System;
using System.Data;

using System.Data.SQLite;

namespace DAL
{
    public class DetalleVentaDAL
    {
        conexion Conexion = new conexion();

        // ============================
        // REGISTRAR DETALLE DE VENTA
        // ============================
        public void RegistrarDetalleVenta(DetalleVentaBE detalleVenta)
        {
            using (SQLiteConnection conn = Conexion.Conectar())
            {
                string sql = @"
                    INSERT INTO DETALLE_VENTA
                    (IDVENTA, IDPRODUCTO, CANTIDAD, SUBTOTAL)
                    VALUES
                    (@VentaID, @ProductoID, @Cantidad, @SubTotal)
                ";

                using (SQLiteCommand cmd = new SQLiteCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@VentaID", detalleVenta.VentaID);
                    cmd.Parameters.AddWithValue("@ProductoID", detalleVenta.Producto.ProductoID);
                    cmd.Parameters.AddWithValue("@Cantidad", detalleVenta.Cantidad);
                    cmd.Parameters.AddWithValue("@SubTotal", detalleVenta.SubTotal);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        // ============================
        // OBTENER DETALLE DE UNA VENTA
        // ============================
        public DataTable ObtenerDetalleDeVenta(int idVenta)
        {
            DataTable tabla = new DataTable();

            using (SQLiteConnection conn = Conexion.Conectar())
            {
                string sql = @"
                    SELECT 
                        DV.IDVENTA,
                        DV.CANTIDAD,
                        P.NOMBRE AS NOMBRE_PRODUCTO,
                        DV.SUBTOTAL
                    FROM DETALLE_VENTA DV
                    INNER JOIN PRODUCTO P 
                        ON P.IDPRODUCTO = DV.IDPRODUCTO
                    WHERE DV.IDVENTA = @VentaID
                ";

                using (SQLiteCommand cmd = new SQLiteCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@VentaID", idVenta);

                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        tabla.Load(reader);
                    }
                }
            }

            return tabla;
        }
    }
}
