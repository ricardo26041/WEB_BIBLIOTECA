using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;

namespace web.Usuarios
{
    public class cls_ActualizarUsuario
    {
        private string str_mensaje;
        cls_Conexion objConexion = new cls_Conexion();
        public void fnt_Crear(string Id, string Nombre, string Apellido, string Contacto, string Direccion, string Correo,string estado)
        {
            if (Id == "" || Nombre == "" || Apellido == "" || Contacto == "" || Direccion == "" || Correo == ""|| estado=="")
            {
                str_mensaje = "Debe ingresar todos los datos";
            }
            else
            {
                //try
                //  {
                SqlCommand con = new SqlCommand("SP_ActualizarUsuario", objConexion.connection);
                con.CommandType = CommandType.StoredProcedure;
                con.Parameters.AddWithValue("@Id", Id);
                con.Parameters.AddWithValue("@Nombre", Nombre);
                con.Parameters.AddWithValue("@Apellido", Apellido);
                con.Parameters.AddWithValue("@Contacto", Contacto);
                con.Parameters.AddWithValue("@Direccion", Direccion);
                con.Parameters.AddWithValue("@Correo", Correo);
                con.Parameters.AddWithValue("@estado", estado);
                objConexion.connection.Open();
                con.ExecuteNonQuery();
                objConexion.connection.Close();
                str_mensaje = "El Usuario " + Id + " " + Nombre + " ha sido actualizado con éxito";
                // }
                //catch (Exception) { str_mensaje = "Este Libro  ya se encuentra / Error al registrar"; }
            }
        }
        public string getMensaje() { return this.str_mensaje; }
    }
}