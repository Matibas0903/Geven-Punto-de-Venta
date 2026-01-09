using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class DetalleVentaBE
    {
        private int _detalleID;

        public int DetalleID
        {
            get { return _detalleID; }
            set { _detalleID = value; }
        }

        private int _ventaID;

        public int VentaID
        {
            get { return _ventaID; }
            set { _ventaID = value; }
        }


        private ProductoBE _producto;

        public ProductoBE Producto
        {
            get { return _producto; }
            set { _producto = value; }
        }

        private string _nombreProducto;

        public string NombreProducto
        {
            get { return _nombreProducto; }
            set { _nombreProducto = value; }
        }

        

        private float _subTotal;

        public float SubTotal
        {
            get { return _subTotal; }
            set { _subTotal = value; }
        }

        private int _cantidad;

        public int Cantidad
        {
            get { return _cantidad; }
            set { _cantidad = value; }
        }


    }
}
