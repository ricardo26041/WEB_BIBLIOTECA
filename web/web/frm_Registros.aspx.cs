using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace web
{
    
    public partial class frm_Registros : System.Web.UI.Page
    {
        
        
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack == true) { fnt_CargarEstado(); }
        }
        private void fnt_CargarEstado() 
        {
         cls_CargarEstado objEstado = new cls_CargarEstado();
            objEstado.fnt_CargarEstado();
            cbx_estado.DataSource = objEstado.getEstado();
            cbx_estado.DataValueField = "PKCodigo";
            cbx_estado.DataValueField = "Nombre";
            cbx_estado.DataBind();
        }

        protected void btn_Registrar_Click(object sender, EventArgs e)
        {

        }
        protected void fnt_limpiar() 
        {
            txt_Isbn.Text = "";
            txt_Nombre.Text = "";
            txt_Cant_Ejemplares.Text = "";
            txt_Editorial.Text = "";
            cl_fecha.Text = "";
            txt_N_paginas.Text = "";
            txt_Autor.Text = "";
            cl_fecha.Text = "";
            txt_Genero.Text = "";
            txt_Isbn.Focus();    
        }
        protected void btn_Nuevo_Click1(object sender, EventArgs e)
        {
            fnt_limpiar();
        }

        protected void btn_Guardar_Click(object sender, EventArgs e)
        {
            cls_RegistroLibros objRegistro = new cls_RegistroLibros();
            objRegistro.fnt_Crear(txt_Isbn.Text,txt_Nombre.Text,txt_Autor.Text,txt_Editorial.Text,
                Convert.ToInt16(txt_N_paginas.Text),txt_Genero.Text,cl_fecha.Text,cbx_estado.SelectedIndex +1,Convert.ToInt16(txt_Cant_Ejemplares.Text));
            
        }
        private void fnt_Consultar(string isbn) 
        {
            cls_ConsultarLibro  objConsultar = new cls_ConsultarLibro();
            objConsultar.fnt_ConsultarLi(isbn);
            txt_Nombre.Text = objConsultar.getNombre();
            txt_Autor.Text = objConsultar.getAutor();
            txt_Editorial.Text = objConsultar.getEditorial();
            txt_N_paginas.Text = Convert.ToString(objConsultar.getPaginas());
            txt_Genero.Text = objConsultar.getGenero();
            cbx_estado.SelectedIndex = objConsultar.getEstado() - 1;
            txt_Cant_Ejemplares.Text = Convert.ToString(objConsultar.getCantidadEjem());



        }
        protected void btn_Consultar_Click(object sender, EventArgs e)
        {
            fnt_Consultar(txt_Isbn.Text);
        }

        protected void btn_Actualizar_Click(object sender, EventArgs e)
        {
            cls_ActualizarLibro objActualizar = new cls_ActualizarLibro();
            objActualizar.fnt_Crear(txt_Isbn.Text,txt_Nombre.Text,txt_Autor.Text,
                txt_Editorial.Text,Convert.ToInt16(txt_N_paginas.Text),txt_Genero.Text,cl_fecha.Text,cbx_estado.SelectedIndex +1,
                Convert.ToInt16(txt_Cant_Ejemplares.Text));
        }
    }
}