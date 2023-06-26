.<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frm_Registros.aspx.cs" Inherits="web.frm_Registros" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Libros de Biblioteca</title>
    <link rel="stylesheet" href="estilos.css" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <center><h1>Registros De Libros
                    </h1></center>
            <br />
           <center>
              <center><img src="https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSEWodPd2y4PrM5PbgRx2OHoahaM3X6R_WStg&usqp=CAU" alt =""  Height ="60" Width="120px"/></center>
                 <br /><br />
               <div class ="div2">
                   <br /><br /> <br />
                   <asp:Label ID="lbl_isbn" runat="server" Text="Isbn" Height ="30" Width="170px"></asp:Label>
                   <asp:TextBox ID="txt_Isbn" runat="server" placeholder="Isbn" CssClass="cajas" Height ="30" Width="220px" ></asp:TextBox>
                   <br /><br />
                   <asp:Label ID="lbl_nombre" runat="server" Text="Nombre" Height ="30" Width="170px"></asp:Label>
                   <asp:TextBox ID="txt_Nombre" runat="server" placeholder="Nombre" CssClass="cajas" Height ="30" Width="220px" ></asp:TextBox>
                   <br /><br />
                   <asp:Label ID="lbl_Autor" runat="server" Text="Autor" Height ="30" Width="170px"></asp:Label>
                   <asp:TextBox ID="txt_Autor" runat="server" placeholder="Autor" CssClass="cajas" Height ="30" Width="220px" ></asp:TextBox>
                   <br /><br />
                   <asp:Label ID="lbl_editorial" runat="server" Text="Editorial" Height ="30" Width="170px"></asp:Label>
                   <asp:TextBox ID="txt_Editorial" runat="server" placeholder="Editorial" CssClass="cajas" Height ="30" Width="220px" ></asp:TextBox>
                    <br /><br />
                   <asp:Label ID="lbl_N_Pagina" runat="server" Text="Paginas" Height ="30" Width="170px"></asp:Label>
                   <asp:TextBox ID="txt_N_paginas" runat="server" placeholder="N_Paginas" CssClass="cajas" Height ="30" Width="220px" ></asp:TextBox>
                   <br /><br />
                   <asp:Label ID="lbl_Genero" runat="server" Text="Genero" Height ="30" Width="170px"></asp:Label>
                   <asp:TextBox ID="txt_Genero" runat="server" placeholder="Genero" CssClass="cajas" Height ="30" Width="220px" ></asp:TextBox>
                   <br /><br />
                   <asp:Label ID="lbl_fecha" runat="server" Text="Fecha" Height ="30" Width="170px"></asp:Label>
                   <asp:TextBox ID="cl_fecha" runat="server" placeholder="Fecha" CssClass="cajas" Height ="30" Width="220px" TextMode="Date" ></asp:TextBox>
                   <br /><br />
                   <asp:Label ID="lbl_estado" runat="server" Text="Estado" Height ="30" Width="170px"></asp:Label>
                   <asp:DropDownList ID="cbx_estado" runat="server"  Height ="30" Width="230px"></asp:DropDownList>
                   <br /><br />
                   <asp:Label ID="lbl_Can_ejemplares" runat="server" Text="Cant_Ejemplares" Height ="30" Width="170px"></asp:Label>
                   <asp:TextBox ID="txt_Cant_Ejemplares" runat="server" placeholder="Cant_Ejemplares" CssClass="cajas" Height ="30" Width="220px" ></asp:TextBox>
                   <br /><br />
                   <asp:Button ID="btn_Nuevo" runat="server" Text="Nuevo" CssClass="botones" Width="100px" Height="35" OnClick="btn_Nuevo_Click1" />
                   <asp:Button ID="btn_Guardar" runat="server" Text="Guardar" CssClass="botones" Width="100px" Height="35" OnClick="btn_Guardar_Click" />
                   <asp:Button ID="btn_Consultar" runat="server" Text="Consultar" CssClass="botones" Width="100px" Height="35" OnClick="btn_Consultar_Click" />
                   <asp:Button ID="btn_Actualizar" runat="server" Text="Actualizar" CssClass="botones" Width="100px" Height="35" OnClick="btn_Actualizar_Click" />
                   <br /><br />
                   <asp:Label ID="lbl_mensaje" runat="server" Text="" CssClass="label"></asp:Label>
                   <br /><br />
                    <br /><br />
               </div>
           </center>
        </div>
    </form>
     
</body>
</html>
