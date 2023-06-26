using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;

namespace web.Usuarios
{
    public class cls_CargarEstado12
    {
        private DataTable dt;
        cls_Conexion objConexion = new cls_Conexion();
        public void fnt_CargarEstado12()
        {
            SqlDataAdapter da = new SqlDataAdapter("SP_CargarEsta12", objConexion.connection);
            dt = new DataTable();
            objConexion.connection.Open();
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.Fill(dt);
            objConexion.connection.Close();
        }
        public DataTable getEstado() { return dt; }
    }
}