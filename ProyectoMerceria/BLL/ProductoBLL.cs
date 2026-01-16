using BE;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ProductoBLL
    {
        DAL.ProductoDAL unProductoDAL = new DAL.ProductoDAL();

        public List<BE.ProductoBE> ObtenerProductos() 
        {
            List<BE.ProductoBE> productos = new List<BE.ProductoBE>();

            DataTable tabla = unProductoDAL.ObtenerProductos();

            foreach (DataRow Fila in tabla.Rows) 
            {
                productos.Add(new BE.ProductoBE
                {
                    ProductoID = Convert.ToInt32(Fila["IDPRODUCTO"]),
                    Nombre = Fila["NOMBRE"].ToString(),
                    Precio = float.Parse(Fila["PRECIO"].ToString()),
                });
            }
            return productos;
        }

        public void AgregarProducto(BE.ProductoBE unProducto) 
        {
            unProductoDAL.AgregarProducto(unProducto);
        }

        public void ActualizarProducto(BE.ProductoBE unProducto, int idProducto)
        {
            unProductoDAL.ActualizarProducto(unProducto);
        }
        public void EliminarProducto(int idProducto)
        {
            unProductoDAL.EliminarProducto(idProducto);
        }

        public ProductoBE ObtenerProductoPorID(int idProducto) 
        {
            return unProductoDAL.ObtenerProductoPorID(idProducto);
        }

    }
}
