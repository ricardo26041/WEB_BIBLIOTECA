using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace web.Prestamos
{
    public class cls_AgreUsuario
    {
        private string str_Nombre;
        private string str_msn;

        SqlCommand con; SqlDataReader lectura;
        cls_Conexion objConexion = new cls_Conexion();

        public void fnt_Consultar(string id)
        {

            {
                con = new SqlCommand("SP_ConsultarDocumento", objConexion.connection);
                con.CommandType = CommandType.StoredProcedure;
                con.Parameters.AddWithValue("@Id", id);
                objConexion.connection.Open();
                lectura = con.ExecuteReader();
                if (lectura.Read() == true)
                {
                    str_Nombre = Convert.ToString(lectura[0]);
                    objConexion.connection.Close();
                    str_msn = "El usuario ya se encuentra registrado";

                }

            }
        }
        public string getNombre() { return this.str_Nombre; }
        public string getmensaje() { return this.str_msn; }
    }
}