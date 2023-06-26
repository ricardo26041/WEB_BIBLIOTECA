using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace web.Prestamos
{
    public class cls_ConsultarIsbn
    {
        private string str_Isbn;
        private string str_Nombre;
        private string str_Autor;
        private int int_CantidadEjmp;
        private string str_msn;
       
        SqlCommand con; SqlDataReader lectura;
        cls_Conexion objConexion = new cls_Conexion();

        public void fnt_Consultar1(string isbn)
        {

            {
                con = new SqlCommand("SP_Consulisbn", objConexion.connection);
                con.CommandType = CommandType.StoredProcedure;
                con.Parameters.AddWithValue("@isbn", isbn);
                objConexion.connection.Open();
                lectura = con.ExecuteReader();
                if (lectura.Read() == true)
                {
                    str_Nombre = Convert.ToString(lectura[1]);
                    str_Autor = Convert.ToString(lectura[2]);
                    int_CantidadEjmp = Convert.ToInt32(lectura[3]);
                    objConexion.connection.Close();
                    str_msn = "El libro ya se encuentra registrado";

                }

            }
        }
        public string getNombre() { return this.str_Nombre; }
        public string getAutor() { return this.str_Autor; }
        public int getCantidadEjem() { return this.int_CantidadEjmp; }
        public string getmensaje() { return this.str_msn; }
    }
 }