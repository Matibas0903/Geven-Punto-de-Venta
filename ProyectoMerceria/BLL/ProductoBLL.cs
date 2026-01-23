using BE;
using ClosedXML.Excel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


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
                    Cantidad = Convert.ToInt32(Fila["CANTIDAD"])
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
            unProductoDAL.ActualizarProducto(unProducto, idProducto);
        }
        public void EliminarProducto(int idProducto)
        {
            unProductoDAL.EliminarProducto(idProducto);
        }

        public ProductoBE ObtenerProductoPorID(int idProducto) 
        {
            return unProductoDAL.ObtenerProductoPorID(idProducto);
        }

        public void DescontarStock(ProductoBE producto, int cantidadVendida)
        {
            unProductoDAL.DescontarStock(producto.ProductoID, cantidadVendida);
        }

        public void AgregarProductoConValidacion(ProductoBE producto)
        {
            producto.Nombre = producto.Nombre.Trim().ToUpper();
            if (string.IsNullOrWhiteSpace(producto.Nombre))
                throw new Exception("Nombre inválido");

            if (producto.Precio <= 0)
                throw new Exception("Precio inválido");

            if (producto.Cantidad < 0)
                throw new Exception("Cantidad inválida");

            if (unProductoDAL.ExisteProductoPorNombre(producto.Nombre))
            {
                unProductoDAL.ActualizarProducto(producto, producto.ProductoID);
            }
            else
            {
                unProductoDAL.AgregarProducto(producto);
            }
        }
        private bool ArchivoEstaAbierto(string ruta)
        {
            try
            {
                using (FileStream fs = new FileStream(
                    ruta,
                    FileMode.Open,
                    FileAccess.Read,
                    FileShare.None))
                {
                    
                }
                return false;
            }
            catch (IOException)
            {
                return true; 
            }
        }

        public void ImportarProductosDesdeExcel(string rutaExcel)
        {
            if (Path.GetExtension(rutaExcel).ToLower() != ".xlsx")
                throw new Exception("El archivo seleccionado no es un Excel (.xlsx)");

            
            if (!File.Exists(rutaExcel))
                throw new Exception("El archivo no existe");

            if (ArchivoEstaAbierto(rutaExcel))
                throw new Exception("El archivo Excel está abierto. Cerralo e intentá de nuevo.");


            using (var wb = new XLWorkbook(rutaExcel))
            {
                var ws = wb.Worksheet(1);
                var filas = ws.RangeUsed().RowsUsed().Skip(1);

                foreach (var fila in filas)
                {
                    
                    if (fila.Cell(2).IsEmpty())
                        continue;

                    
                    ProductoBE producto = new ProductoBE
                    {
                        Nombre = fila.Cell(2).GetValue<string>().Trim(),
                        Precio = fila.Cell(3).GetValue<float>(),
                        Cantidad = fila.Cell(4).GetValue<int>()
                    };

                    
                    if (producto.Precio <= 0 || producto.Cantidad < 0)
                        continue;

                  
                    int idExistente = unProductoDAL.ObtenerIdProductoPorNombre(producto.Nombre);

                   
                    if (idExistente == -1)
                    {
                        // INSERT
                        unProductoDAL.AgregarProducto(producto);
                    }
                    else
                    {
                        // UPDATE
                        unProductoDAL.ActualizarProducto(producto, idExistente);
                    }
                }
            }
        }

        public void ExportarExcel(string ruta)
        {
            if (string.IsNullOrWhiteSpace(ruta))
                throw new Exception("La ruta no es válida.");

            string rutaArchivo;

            
            if (File.Exists(ruta) && Path.GetExtension(ruta).ToLower() == ".xlsx")
            {
                rutaArchivo = ruta;
            }

            else if (Directory.Exists(ruta))
            {
                rutaArchivo = Path.Combine(
                    ruta,
                    $"backup_productos_{DateTime.Now:yyyyMMdd_HHmmss}.xlsx"
                );
            }
            else
            {
                throw new Exception("La ruta seleccionada no existe.");
            }

            List<BE.ProductoBE> productos = ObtenerProductos();

            using (var wb = new XLWorkbook())
            {
                var ws = wb.Worksheets.Add("Productos");

                ws.Cell(1, 1).Value = "ID";
                ws.Cell(1, 2).Value = "Nombre";
                ws.Cell(1, 3).Value = "Precio";
                ws.Cell(1, 4).Value = "Cantidad";

                int fila = 2;
                foreach (var p in productos)
                {
                    ws.Cell(fila, 1).Value = p.ProductoID;
                    ws.Cell(fila, 2).Value = p.Nombre;
                    ws.Cell(fila, 3).Value = p.Precio;
                    ws.Cell(fila, 4).Value = p.Cantidad;
                    fila++;
                }

                ws.Columns().AdjustToContents();
                ws.Row(1).Style.Font.Bold = true;

                wb.SaveAs(rutaArchivo);
            }
        }

        public int EliminarTodosLosProductos(bool hacerBackup, string rutaBackup)
        {
            if (hacerBackup)
            {
                if (string.IsNullOrWhiteSpace(rutaBackup))
                    throw new Exception("La ruta del backup no es válida.");

                ExportarExcel(rutaBackup);
            }

            return unProductoDAL.EliminarTodosLosProductos();
        }

    }


}

