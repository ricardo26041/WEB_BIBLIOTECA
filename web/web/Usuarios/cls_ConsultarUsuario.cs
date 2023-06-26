using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;

namespace web.Usuarios
{
    public class cls_ConsultarUsuario
    {
        private string str_Nombre;
        private string str_Apellido;
        private string str_Contacto;
        private string str_Direccion;
        private string str_Correo;
        private int int_Estado;
        private string str_msn;

        SqlCommand con; SqlDataReader lectura;
        cls_Conexion objConexion = new cls_Conexion();

        public void fnt_ConsultarUser(string Id)
        {

            {
                con = new SqlCommand("SP_ConsultarUsuario", objConexion.connection);
                con.CommandType = CommandType.StoredProcedure;
                con.Parameters.AddWithValue("@Id", Id);
                objConexion.connection.Open();
                lectura = con.ExecuteReader();
                if (lectura.Read() == true)
                {
                    str_Nombre = Convert.ToString(lectura[0]);
                    str_Apellido = Convert.ToString(lectura[1]);
                    str_Contacto = Convert.ToString(lectura[2]);
                    str_Direccion = Convert.ToString(lectura[3]);
                    str_Correo = Convert.ToString(lectura[4]);
                    objConexion.connection.Close();
                    str_msn = "";

                }

            }
        }
        public string getNombre() { return this.str_Nombre; }
        public string getApellido() { return this.str_Apellido; }
        public string getContacto() { return this.str_Contacto; }
        public string getDireccion() { return this.str_Direccion; }
        public string getCorreo() { return this.str_Correo; }
        public int getEstado() { return this.int_Estado; }
        public string getmensaje() { return this.str_msn; }
    }
}