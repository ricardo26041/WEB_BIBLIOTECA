using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace web
{
    public class cls_Conexion
    {
        public SqlConnection connection = new SqlConnection("Data Source=MABAPRRATFSD004\\ROLONG;Initial Catalog=dbs_BibliotecaR;Integrated Security=True");
    }
}