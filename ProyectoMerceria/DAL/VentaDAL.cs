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
    public class VentaDAL
    {
        conexion Conexion = new conexion();
        public int RegistrarVenta(VentaBE venta)
        {
            
            SqlParameter[] parametros = new SqlParameter[] {
                new SqlParameter("@Metodo_pago", venta.MetodoPagoTexto),
                new SqlParameter("@Fecha_venta", venta.FechaVenta),
                new SqlParameter("@Total", venta.Total),
                new SqlParameter("@Venta_ID", SqlDbType.Int)
                {Direction = ParameterDirection.Output}
            };
           
            Conexion.EscribirPorStoreProcedure("SP_RegistrarVenta", parametros);
            int venta_ID = Convert.ToInt32(parametros[3].Value);
            return venta_ID;
        }

        public DataTable ObtenerVentaPorFecha(DateTime Fecha) 
        {
            SqlParameter[] parametros = new SqlParameter[]
            {
                new SqlParameter ("@Fecha", Fecha)
            };
         return Conexion.LeerPorStoreProcedure("SP_VerVentasPorFecha", parametros);
         
        }
    }
}
