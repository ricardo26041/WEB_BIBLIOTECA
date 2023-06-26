using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;

namespace web.Prestamos
{
    public class cls_RegistrarLibro1
    {
        private string str_mensaje;
        cls_Conexion objConexion = new cls_Conexion();
        public void fnt_Crear(string Isbn, string Nombre ,string Autor, int cant_ejemplares)
        {
            if (Isbn == "" ||Nombre ==""||Autor =="")
            {
                str_mensaje = "Debe ingresar todos los datos";
            }
            else
            {
                try
                {
                    SqlCommand con = new SqlCommand("SP_RegistroIsbn1", objConexion.connection);
                    con.CommandType = CommandType.StoredProcedure;
                    con.Parameters.AddWithValue("@Isbn", Isbn);
                    con.Parameters.AddWithValue("@Nombre", Nombre);
                    con.Parameters.AddWithValue("@Autor", Autor);
                    con.Parameters.AddWithValue("@Cant_ejemplares", cant_ejemplares);
                    objConexion.connection.Open();
                    con.ExecuteNonQuery();
                    objConexion.connection.Close();
                    str_mensaje = "El Libro " + Isbn + " " + Nombre + " ha sido registrado con éxito";
                }
                catch (Exception) { str_mensaje = "Este Libro  ya se encuentra / Error al registrar"; }
            }
        }
        public string getMensaje() { return this.str_mensaje; }
    }
}