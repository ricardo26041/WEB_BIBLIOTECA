using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;

namespace web
{
    public class cls_ActualizarLibro
    {
        private string str_mensaje;
        cls_Conexion objConexion = new cls_Conexion();
        public void fnt_Crear(string Isbn, string Nombre, string Autor, string Editorial, int N_Pagina, string Genero, string fecha_Publi, int estado, int cant_ejemplares)
        {
            if (Isbn == "" || Nombre == "" || Autor == "" || Editorial == "" || fecha_Publi == "" || Genero == "")
            {
                str_mensaje = "Debe ingresar todos los datos";
            }
            else
            {
                //try
              //  {
                    SqlCommand con = new SqlCommand("SP_ActualizarLibro",objConexion.connection);
                    con.CommandType = CommandType.StoredProcedure;
                    con.Parameters.AddWithValue("@Isbn",Isbn);
                    con.Parameters.AddWithValue("@Nombre",Nombre);
                    con.Parameters.AddWithValue("@Autor",Autor);
                    con.Parameters.AddWithValue("@Editorial",Editorial);
                    con.Parameters.AddWithValue("@N_Pagina",N_Pagina);
                    con.Parameters.AddWithValue("@Genero", Genero);
                    con.Parameters.AddWithValue("@Fecha_publicacion",fecha_Publi);
                    con.Parameters.AddWithValue("@estado",estado);
                    con.Parameters.AddWithValue("@Cant_ejemplares",cant_ejemplares);
                    objConexion.connection.Open();
                    con.ExecuteNonQuery();
                    objConexion.connection.Close();
                    str_mensaje = "El Libro " + Isbn + " " + Nombre + " ha sido registrado con éxito";
               // }
                //catch (Exception) { str_mensaje = "Este Libro  ya se encuentra / Error al registrar"; }
            }
        }
        public string getMensaje() { return this.str_mensaje; }
    }
}