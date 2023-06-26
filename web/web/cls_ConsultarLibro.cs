using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace web
{
    public class cls_ConsultarLibro
    {

        private string str_Nombre;
        private string str_Autor;
        private string str_Editorial;
        private int int_N_Paginas;
        private string str_Genero;
        private string str_fecha;
        private int int_estado;
        private int int_Cantidad_EJEM;
        private string str_msn;

        SqlCommand con; SqlDataReader lectura;
        cls_Conexion objConexion = new cls_Conexion();

        public void fnt_ConsultarLi(string ISBN)
        {
            
            {
                con = new SqlCommand("SP_ConsultarLibto",objConexion.connection);
                con.CommandType = CommandType.StoredProcedure;
                con.Parameters.AddWithValue("@Isbn", ISBN);
                objConexion.connection.Open();
                lectura = con.ExecuteReader();
                if(lectura.Read()==true) 
                {
                    str_Nombre = Convert.ToString(lectura[0]);
                    str_Autor = Convert.ToString(lectura[1]);
                    str_Editorial = Convert.ToString(lectura[2]);
                    int_N_Paginas = Convert.ToInt16(lectura[3]);
                    str_Genero = Convert.ToString(lectura[4]);
                    str_fecha = Convert.ToString(lectura[5]);
                    int_estado = Convert.ToInt16(lectura[6]);
                    int_Cantidad_EJEM = Convert.ToInt16(lectura[7]);    

                    objConexion.connection.Close();
                    str_msn = "";

                }
                
            }
        }
        public string getNombre() { return this.str_Nombre; }
        public string getAutor() { return this.str_Autor; }
        public string getEditorial() { return this.str_Editorial; }
        public int getPaginas() { return this.int_N_Paginas; }
        public string  getFecha() { return this.str_fecha; }
        public string getGenero() { return this.str_Genero; }
        public int getEstado() { return this.int_estado; }
        public int getCantidadEjem() { return this.int_Cantidad_EJEM; }
        public string getmensaje() { return this.str_msn; }
    }
}