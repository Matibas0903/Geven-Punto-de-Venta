using BE;
using System;
using System.Data;

using System.Data.SQLite;



namespace DAL
{
    public class ProductoDAL
    {
        conexion Conexion = new conexion();

        public DataTable ObtenerProductos()
        {
            DataTable tabla = new DataTable();

            using (SQLiteConnection conn = Conexion.Conectar())
            {
                string sql = "SELECT * FROM PRODUCTO";

                using (SQLiteCommand cmd = new SQLiteCommand(sql, conn))
                using (SQLiteDataReader reader = cmd.ExecuteReader())
                {
                    tabla.Load(reader);
                }
            }

            return tabla;
        }

        public int AgregarProducto(ProductoBE unProducto)
        {
            using (SQLiteConnection conn = Conexion.Conectar())
            {
                string sql = @"
            INSERT INTO PRODUCTO (NOMBRE, PRECIO)
            VALUES (@Nombre, @Precio);
            SELECT last_insert_rowid();";

                using (SQLiteCommand cmd = new SQLiteCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@Nombre", unProducto.Nombre);
                    cmd.Parameters.AddWithValue("@Precio", unProducto.Precio);

                    int idGenerado = Convert.ToInt32(cmd.ExecuteScalar());
                    unProducto.ProductoID = idGenerado;

                    return idGenerado;
                }
            }
        }

        public void ActualizarProducto(ProductoBE unProducto)
        {
            using (SQLiteConnection conn = Conexion.Conectar())
            {
                string sql = @"
            UPDATE PRODUCTO
            SET NOMBRE = @Nombre,
                PRECIO = @Precio
            WHERE IDPRODUCTO = @IdProducto
        ";

                using (SQLiteCommand cmd = new SQLiteCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@Nombre", unProducto.Nombre);
                    cmd.Parameters.AddWithValue("@Precio", unProducto.Precio);
                    cmd.Parameters.AddWithValue("@IdProducto", unProducto.ProductoID);

                    cmd.ExecuteNonQuery();
                }
            }
        }


        public void EliminarProducto(int idProducto)
        {
            using (SQLiteConnection conn = Conexion.Conectar())
            {
                string sql = "DELETE FROM PRODUCTO WHERE IDPRODUCTO = @IdProducto";

                using (SQLiteCommand cmd = new SQLiteCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@IdProducto", idProducto);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public ProductoBE ObtenerProductoPorID(int idProducto)
        {
            using (SQLiteConnection conn = Conexion.Conectar())
            {
                string sql = "SELECT * FROM PRODUCTO WHERE IDPRODUCTO = @IdProducto";

                using (SQLiteCommand cmd = new SQLiteCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@IdProducto", idProducto);

                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new ProductoBE
                            {
                                ProductoID = Convert.ToInt32(reader["IDPRODUCTO"]),
                                Nombre = reader["NOMBRE"].ToString(),
                                Precio = Convert.ToSingle(reader["PRECIO"])
                            };
                        }
                    }
                }
            }
            return null;
        }


    }
}