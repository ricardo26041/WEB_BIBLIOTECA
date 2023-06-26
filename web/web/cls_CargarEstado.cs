using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace web
{
    
    public class cls_CargarEstado
    {
        private DataTable dt;
        cls_Conexion objConexion = new cls_Conexion();
        public void fnt_CargarEstado() 
        {
         SqlDataAdapter da = new SqlDataAdapter("SP_CargarEstado", objConexion.connection);
            dt = new DataTable();
            objConexion.connection.Open();
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.Fill(dt);
            objConexion.connection.Close();
        }
        public DataTable getEstado() { return dt; }
    }
}