using BE;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ProdutoDAL
    {
        private conexion Conexion = new conexion();

        public DataTable ObtenerProductos() 
        {
            return Conexion.LeerPorComando("SELECT * FROM Vista_Productos");
        }
        public int AgregarProducto(BE.ProductoBE unProducto)
        {   // escribe en base de datos un nuevo medicamento

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@nombreProducto", unProducto.Nombre),
                new SqlParameter("@precioProducto", unProducto.Precio),
                new SqlParameter("@idProducto", SqlDbType.Int)
                    {
                        Direction = ParameterDirection.Output
                    }
            };
            Conexion.EscribirPorStoreProcedure("SP_AgregarProducto", parameters);
            int idGenerado = Convert.ToInt32(parameters[2].Value);
            unProducto.ProductoID = idGenerado;

            return idGenerado;
        }

        public void ActualizarProducto(BE.ProductoBE unProducto, int idProducto)
        {  
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@IdProducto", idProducto),
                new SqlParameter("@Nombre", unProducto.Nombre),
                new SqlParameter("@Precio", unProducto.Precio)      
            };
            Conexion.EscribirPorStoreProcedure("SP_ActualizarProducto", parameters);
        }
        public void EliminarProducto(int idProducto)
        {
            SqlParameter[] parametros = new SqlParameter[]
            {
                new SqlParameter("@Producto_Id", idProducto)
            };
            Conexion.EscribirPorStoreProcedure("SP_EliminarProducto", parametros);

        }
        public ProductoBE ObtenerProductoPorID(int idProducto) 
        {
            SqlParameter[] parametros = new SqlParameter[]
               {
                    new SqlParameter("@IdProducto", idProducto)
               };

            var tabla = Conexion.LeerPorStoreProcedure("SP_ObtenerProductoPorID", parametros);//llama al metodo leer por storeprocedure

            if (tabla != null && tabla.Rows.Count > 0)
            {
                var fila = tabla.Rows[0];


                return new ProductoBE
                {
                    ProductoID = Convert.ToInt32(fila["IDPRODUCTO"]),
                    Nombre = fila["NOMBRE"].ToString(),
                    Precio = float.Parse(fila["PRECIO"].ToString()),
                  

                };
            }//crea un objeto medicamento y lo llena con sus datos
            return null;
        }

    }
}
