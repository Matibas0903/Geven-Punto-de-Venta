using BE;
using System;
using System.Data;
using System.Data.SQLite;


namespace DAL
{
    public class VentaDAL
    {
        conexion Conexion = new conexion();

        // ============================
        // REGISTRAR VENTA
        // ============================
        public int RegistrarVenta(VentaBE venta)
        {
            using (SQLiteConnection conn = Conexion.Conectar())
            {
                string sql = @"
                    INSERT INTO VENTA (FECHAVENTA, METODO_PAGO, TOTAL)
                    VALUES (@FechaVenta, @MetodoPago, @Total);
                    SELECT last_insert_rowid();
                ";

                using (SQLiteCommand cmd = new SQLiteCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@FechaVenta", venta.FechaVenta.ToString("yyyy-MM-dd"));
                    cmd.Parameters.AddWithValue("@MetodoPago", venta.MetodoPagoTexto);
                    cmd.Parameters.AddWithValue("@Total", venta.Total);

                    int ventaID = Convert.ToInt32(cmd.ExecuteScalar());
                    return ventaID;
                }
            }
        }

        // ============================
        // OBTENER VENTAS POR FECHA
        // ============================
        public DataTable ObtenerVentaPorFecha(DateTime fecha)
        {
            DataTable tabla = new DataTable();

            using (SQLiteConnection conn = Conexion.Conectar())
            {
                string sql = @"
                    SELECT IDVENTA, FECHAVENTA, METODO_PAGO, TOTAL
                    FROM VENTA
                    WHERE FECHAVENTA = @Fecha
                ";

                using (SQLiteCommand cmd = new SQLiteCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@Fecha", fecha.ToString("yyyy-MM-dd"));

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
