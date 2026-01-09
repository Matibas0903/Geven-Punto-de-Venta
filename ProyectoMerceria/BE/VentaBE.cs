using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class VentaBE
    {
        private int _ventaID;

        public int VentaID
        {
            get { return _ventaID; }
            set { _ventaID = value; }
        }

        private DateTime _fechaVenta;

        public DateTime FechaVenta
        {
            get { return _fechaVenta; }
            set { _fechaVenta = value; }
        }

        private bool _metodoPago;

        public bool MetodoPago
        {
            get { return _metodoPago; }
            set { _metodoPago = value; }
        }

        public string MetodoPagoTexto => MetodoPago ? "Efectivo" : "Transferencia";

        private float _total;

        public float Total
        {
            get { return _total; }
            set { _total = value; }
        }

        private List<DetalleVentaBE> _detalleVenta;

        public List<DetalleVentaBE> DetalleVenta
        {
            get { return _detalleVenta; }
            set { _detalleVenta = value; }
        }


    }


}
