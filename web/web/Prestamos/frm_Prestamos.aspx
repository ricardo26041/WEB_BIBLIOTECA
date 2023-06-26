<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frm_Prestamos.aspx.cs" Inherits="web.Prestamos.frm_Prestamos" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Prestamos</title>
       <link rel="stylesheet" href="estilos.css" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <center><h1>Solicita Tu Prestamo</h1></center>
            <br />
           <center>
               <center><img src="https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRPK3A8AiNHCUQp47SbeBXqskYyHsRGkQFcYtQciEN_v8pyLYmRS5BNCrW5ll2A_PKOZgY&usqp=CAU" alt ="" style="height: 70px; width: 100px"></center>
                <div class ="div2">
                    <div class="div2">
                <br /><br /> 
                <center><h2>Consulta De Usuarios</h2></center>
                <asp:TextBox ID="txt_Id" runat="server" placeholder="Documento" CssClass="cajas" Height ="30" Width="220px" ></asp:TextBox><right>
                <asp:TextBox ID="txt_Nombre" runat="server" placeholder="Nombre De Usuario" CssClass="cajas" Height ="30" Width="220px" ></asp:TextBox></right>
                <br /><br /> <br />
                 <asp:Button ID="btn_Limpiar" runat="server" Text="Nuevo" CssClass="botones" Width="100px" Height="35" OnClick="btn_Limpiar_Click" />
                 <asp:Button ID="btn_Consultar" runat="server" Text="Consultar" CssClass="botones" Width="100px" Height="35" OnClick="btn_Consultar_Click"/>
                 <br /><br /> 
                 <center><h2>Consulta De Libros</h2></center>
                 <asp:TextBox ID="txt_Isbn" runat="server" placeholder="ISBN" CssClass="cajas" Height ="30" Width="220px" ></asp:TextBox><right>
                 <asp:TextBox ID="txt_Nombrelibro" runat="server" placeholder="Nombre Del Libro " CssClass="cajas" Height ="30" Width="220px" ></asp:TextBox></right>
                 <br /><br /> <br />
                 <asp:TextBox ID="txt_Autor" runat="server" placeholder="Autor Del Libro" CssClass="cajas" Height ="30" Width="220px" ></asp:TextBox><right>
                 <asp:TextBox ID="txt_ejemplares" runat="server" placeholder="Cantidad Ejemplares " CssClass="cajas" Height ="30" Width="220px" ></asp:TextBox></right>
                 <br /><br /> <br />
                 <asp:Button ID="btn_Clear" runat="server" Text="Clear" CssClass="botones" Width="100px" Height="35" OnClick="btn_Clear_Click" />
                 <asp:Button ID="btn_Registrar" runat="server" Text="Registrar" CssClass="botones" Width="100px" Height="35" OnClick="btn_Registrar_Click" />
                 <asp:Button ID="btn_Buscar" runat="server" Text="Buscar" CssClass="botones" Width="100px" Height="35" OnClick="btn_Buscar_Click" />
                 <br /><br /> 
                 <asp:TextBox ID="txt_Cantidad" runat="server" placeholder="Cantidad" CssClass="cajas" Height ="30" Width="220px"></asp:TextBox>
                 <br /><br /> 
                 <asp:Button ID="btn_GurdarInfo" runat="server" Text="Guadar Informacion" OnClick="btn_GurdarInfo_Click"/>
                         <br /><br /> 
                 <asp:GridView ID="dtg_Prestamos" runat="server" Width="350px" CellPadding="4" ForeColor="#333333" GridLines="None">
                     <AlternatingRowStyle BackColor="White" />
                     <EditRowStyle BackColor="#2461BF" />
                     <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                     <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                     <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                     <RowStyle BackColor="#EFF3FB" />
                     <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                     <SortedAscendingCellStyle BackColor="#F5F7FB" />
                     <SortedAscendingHeaderStyle BackColor="#6D95E1" />
                     <SortedDescendingCellStyle BackColor="#E9EBEF" />
                     <SortedDescendingHeaderStyle BackColor="#4870BE" />
                        </asp:GridView>
        </div>
         
    </form>
</body>
</html>
