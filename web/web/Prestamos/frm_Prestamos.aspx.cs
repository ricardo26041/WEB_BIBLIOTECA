using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace web.Prestamos
{
    public partial class frm_Prestamos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_Limpiar_Click(object sender, EventArgs e)
        {
            txt_Id.Text = "";
            txt_Nombre.Text = "";
            txt_Id.Focus();
        }
        private void fnt_Consultar(string id) 
        {
          Prestamos.cls_AgreUsuario objConsultar = new cls_AgreUsuario();
            objConsultar.fnt_Consultar(id);
            txt_Nombre.Text =objConsultar.getNombre();
          


        }
        protected void btn_Consultar_Click(object sender, EventArgs e)
        {
            fnt_Consultar(txt_Id.Text);
        }
        private void fnt_Clear() 
        {
            txt_Isbn.Text = "";
            txt_Nombrelibro.Text = "";
            txt_Autor.Text = "";
            txt_Cantidad.Text = "";
            txt_ejemplares.Text = "";
            txt_Isbn.Focus();

        }
        protected void btn_Clear_Click(object sender, EventArgs e)
        {
            fnt_Clear();
        }

        protected void btn_Registrar_Click(object sender, EventArgs e)
        {
            Prestamos.cls_RegistrarLibro1 objRegistrar = new cls_RegistrarLibro1();
            objRegistrar.fnt_Crear(txt_Isbn.Text,txt_Nombrelibro.Text,txt_Autor.Text,Convert.ToInt16(txt_ejemplares.Text));
        }
        private void fnt_consultar(string isbn) 
        {
        Prestamos.cls_ConsultarIsbn objConsulta = new cls_ConsultarIsbn();
            objConsulta.fnt_Consultar1(isbn);
            txt_Nombrelibro.Text = objConsulta.getNombre();
            txt_Autor.Text =objConsulta.getAutor();
            txt_ejemplares.Text = Convert.ToString(objConsulta.getCantidadEjem());
        }
        protected void btn_Buscar_Click(object sender, EventArgs e)
        {
            fnt_consultar(txt_Isbn.Text);
        }

        protected void btn_GurdarInfo_Click(object sender, EventArgs e)
        {

        }
    }
}