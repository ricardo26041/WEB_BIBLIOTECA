<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frm_usuarios.aspx.cs" Inherits="web.frm_usuarios" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Registros de usuarios</title>
     <link rel="stylesheet" href="estilos.css" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
             <center><h1>Registros De Usuarios</h1></center>
        </div>
         <center><img src="https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSYcwc-vZE3ffRDEsJlbZgjE6NlhDEqedx_5w&usqp=CAU" alt ="" Width="100px" style="height: 60px"/></center>
            <br />
            <center>
            <div class="div2">
                <br /><br /> 
                <asp:Label ID="lbl_Id" runat="server" Text="Documento" Height ="25" Width="170px"></asp:Label>
                <asp:TextBox ID="txt_Id" runat="server" placeholder="Identificacion" CssClass="cajas" Height ="20" Width="220px" ></asp:TextBox>
                <br /><br /> <br />
                <asp:Label ID="lbl_Nombre" runat="server" Text="Nombres" Height ="25" Width="170px"></asp:Label>
                <asp:TextBox ID="txt_Nombre" runat="server" placeholder="Nombres" CssClass="cajas" Height ="20" Width="220px" ></asp:TextBox>
                <br /><br /> <br />
                <asp:Label ID="lbl_Apellido" runat="server" Text="Apellidos" Height ="25" Width="170px"></asp:Label>
                <asp:TextBox ID="txt_Apellidos" runat="server" placeholder="Apellidos" CssClass="cajas" Height ="20" Width="220px" ></asp:TextBox>
                <br /><br /> <br />
                <asp:Label ID="lbl_Contacto" runat="server" Text="Contacto" Height ="25" Width="170px"></asp:Label>
                <asp:TextBox ID="txt_Contacto" runat="server" placeholder="Contacto" CssClass="cajas" Height ="20" Width="220px" ></asp:TextBox>
                <br /><br /> <br />
                <asp:Label ID="lbl_Direccion" runat="server" Text="Direccion" Height ="25" Width="170px"></asp:Label>
                <asp:TextBox ID="txt_Direccion" runat="server" placeholder="Direccion" CssClass="cajas" Height ="20" Width="220px" ></asp:TextBox>
                <br /><br /> <br />
                <asp:Label ID="lbl_Correo" runat="server" Text="Correo" Height ="25" Width="170px"></asp:Label>
                <asp:TextBox ID="txt_Gmail" runat="server" placeholder="Correo" CssClass="cajas" Height ="20" Width="220px" ></asp:TextBox>
                <br /><br /> <br />
                <asp:Label ID="lbl_estado" runat="server" Text="Estado" Height ="22" Width="170px"></asp:Label>
                <asp:DropDownList ID="cbx_estado" runat="server"  Height ="22" Width="230px"></asp:DropDownList>
                <br /><br /> <br />
                <asp:Button ID="btn_Nuevo" runat="server" Text="Nuevo"  CssClass="botones" Width="100px" Height="35" OnClick="btn_Nuevo_Click1" />
                <asp:Button ID="btn_Guardar" runat="server" Text="Guardar" CssClass="botones" Width="100px" Height="35"/>
                <asp:Button ID="btn_Consultar" runat="server" Text="Consultar" CssClass="botones" Width="100px" Height="35" OnClick="btn_Consultar_Click1" />
                <asp:Button ID="btn_Actualizar" runat="server" Text="Actualizar" CssClass="botones" Width="100px" Height="35" OnClick="btn_Actualizar_Click" />
                <br /><br />
                 <asp:Label ID="lbl_mensaje" runat="server" Text="" CssClass="label"></asp:Label>
                 <br /><br />
                </form> 
</body>
</html>
