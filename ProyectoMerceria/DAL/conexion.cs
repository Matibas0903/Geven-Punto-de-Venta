using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Configuration;

namespace DAL
{
    public class conexion
    {
   

     

 private string ConnectionString
        {
            get
            {
                var cs = ConfigurationManager.ConnectionStrings["VentasMerceriaDB"];
                if (cs == null)
                    throw new Exception("No se encontró la cadena VentasMerceriaDB en App.config");

                return cs.ConnectionString;
            }
        }

        public SQLiteConnection Conectar()
        {
            var conn = new SQLiteConnection(ConnectionString);
            conn.Open();
            return conn;

        }

        /* private void Conectar() 
         {


                 strCadenaDeConexion = @"Data Source=VentasMerceria.db;";


                 objConexion = new SqlConnection();
                 objConexion.ConnectionString = strCadenaDeConexion;
                 objConexion.Open();


         }

         private void Desconectar()
         {
             objConexion.Close();
             objConexion.Dispose();
         }

         public DataTable LeerPorStoreProcedure(string pNombreStoreProcedure, SqlParameter[] pParametrosSql = null)
         {
             //Instancio un objeto del tipo DataTable
             var unaTabla = new DataTable();

             //Instancio un objeto del tipo SqlCommand
             var objComando = new SqlCommand();

             //Me conecto...
             this.Conectar();


             try
             {
                 objComando.CommandText = pNombreStoreProcedure;
                 objComando.CommandType = CommandType.StoredProcedure;
                 objComando.Connection = this.objConexion;

                 if (pParametrosSql != null)
                 {
                     //Lleno los SqlParameters a la lista de parametros
                     objComando.Parameters.AddRange(pParametrosSql);
                 }

                 //Instancio un adaptador con el parametro SqlCommand
                 var objAdaptador = new SqlDataAdapter(objComando);

                 //Lleno la tabla, el objeto unaTabla con el adaptador
                 objAdaptador.Fill(unaTabla);
             }
             catch (Exception)
             {
                 //Como hay error... por el motivo que sea asigno el resultado a null
                 unaTabla = null;

                 throw;
             }
             finally
             {

                 //Pase lo que pase me desconecto
                 this.Desconectar();
             }


             return unaTabla;
         }

         public DataTable LeerPorComando(string pComando)
         {
             //Instancio un objeto del tipo DataTable
             var unaTabla = new DataTable();

             //Instancio un objeto del tipo SqlCommand
             var objComando = new SqlCommand();

             //Me conecto...
             this.Conectar();

             try
             {


                 //Parametrizo el objeto SqlCommand con sus valores respectivos
                 objComando.CommandType = CommandType.Text;
                 objComando.Connection = this.objConexion;
                 objComando.CommandText = pComando;

                 //Instancio un adaptador con el parametro SqlCommand
                 var objAdaptador = new SqlDataAdapter(objComando);

                 //Lleno la tabla, el objeto unaTabla con el adaptador
                 objAdaptador.Fill(unaTabla);

             }
             catch
             {
                 //Como hay error... por el motivo que sea asigno el resultado a null
                 unaTabla = null;

                 throw;
             }
             finally
             {
                 //Siempre, por más que salga bien o mal el llenado, me desconecto
                 this.Desconectar();
             }

             return unaTabla;
         }

         public int EscribirPorComando(string pTexto)
         {
             //Instanció una variable filasAfectadas que va a terminar devolviendo la cantidad de filas afectadas.
             int filasAfectadas = 0;

             //Instancio un objeto del tipo SqlCommand
             var objComando = new SqlCommand();

             //Me conecto...
             this.Conectar();

             try
             {
                 objComando.CommandText = pTexto;
                 objComando.CommandType = CommandType.Text;
                 objComando.Connection = this.objConexion;

                 //El método ExecuteNonQuery() me devuelve la cantidad de filas afectadas.
                 filasAfectadas = objComando.ExecuteNonQuery();


             }
             catch (Exception)
             {
                 filasAfectadas = -1;
                 throw;
             }
             finally
             {
                 //Me desconecto
                 this.Desconectar();
             }


             return filasAfectadas;
         }


         public int EscribirPorStoreProcedure(string pTexto, SqlParameter[] pParametrosSql)
         {
             //Instanció una variable filasAfectadas que va a terminar devolviendo la cantidad de filas afectadas.
             int filasAfectadas = 0;

             //Instancio un objeto del tipo SqlCommand
             var objComando = new SqlCommand();

             //Me conecto...
             this.Conectar();

             try
             {
                 objComando.CommandText = pTexto;
                 objComando.CommandType = CommandType.StoredProcedure;
                 objComando.Connection = this.objConexion;

                 if (pParametrosSql.Length > 0)
                 {
                     objComando.Parameters.AddRange(pParametrosSql);
                     //El método ExecuteNonQuery() me devuelve la cantidad de filas afectadas.
                     filasAfectadas = objComando.ExecuteNonQuery();
                 }
                 else
                 {
                     //retorno -1 porque la lista de parametros Sql tiene 0 ítems...
                     filasAfectadas = -1;
                 }



             }
             catch (Exception)
             {
                 filasAfectadas = -1;
                 throw;
             }
             finally
             {
                 //Me desconecto
                 this.Desconectar();
             }


             return filasAfectadas;
         }
         */


    }
}
