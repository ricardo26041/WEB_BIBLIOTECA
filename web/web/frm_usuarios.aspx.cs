using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using web.Usuarios;

namespace web
{
    public partial class frm_usuarios : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
          
        }

        private void fnt_CargarEstado12()
        {
            cls_CargarEstado12 objEstado = new cls_CargarEstado12();
            objEstado.fnt_CargarEstado12();
            cbx_estado.DataSource = objEstado.getEstado();
            cbx_estado.DataValueField = "PKCodigo";
            cbx_estado.DataValueField = "Nombre";
            cbx_estado.DataBind();
        }
        private void fnt_Limpiar() 
        {
            txt_Id.Text = "";
            txt_Nombre.Text = "";
            txt_Apellidos.Text = "";
            txt_Direccion.Text = "";
            txt_Contacto.Text = "";
            txt_Gmail.Text = "";
            cbx_estado.SelectedValue = "";
            txt_Id.Focus();

        }
       

        protected void btn_Guardar_Click(object sender, EventArgs e)
        {
            Usuarios.cls_GuardarUsuario objRegistro = new cls_GuardarUsuario();
            objRegistro.fnt_Crear(txt_Id.Text,txt_Nombre.Text,txt_Apellidos.Text,txt_Contacto.Text,txt_Direccion.Text,txt_Gmail.Text,cbx_estado.SelectedValue +1);
        }

        private void fnt_Consultar(string id) 
        {
            Usuarios.cls_ConsultarUsuario objConsultar = new cls_ConsultarUsuario();
            objConsultar.fnt_ConsultarUser(id);
            txt_Nombre.Text = objConsultar.getNombre();
            txt_Apellidos.Text = objConsultar.getApellido();
            txt_Contacto.Text = objConsultar.getContacto();
            txt_Direccion.Text = objConsultar.getDireccion();
            txt_Gmail.Text = objConsultar.getCorreo();
            cbx_estado.SelectedValue = Convert.ToString(objConsultar.getEstado());
        }
       

        protected void btn_Consultar_Click1(object sender, EventArgs e)
        {
            fnt_Consultar(txt_Id.Text);
        }

        protected void btn_Actualizar_Click(object sender, EventArgs e)
        {
            Usuarios.cls_ActualizarUsuario objActualizar = new cls_ActualizarUsuario();
            objActualizar.fnt_Crear(txt_Id.Text,txt_Nombre.Text,txt_Apellidos.Text,txt_Contacto.Text,txt_Direccion.Text,txt_Gmail.Text,cbx_estado.SelectedValue);
        }

        protected void btn_Nuevo_Click1(object sender, EventArgs e)
        {
            fnt_Limpiar();
        }
    }
}