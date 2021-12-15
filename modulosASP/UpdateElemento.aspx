<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UpdateElemento.aspx.cs" Inherits="modulosASP.UpdateElemento" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            Id Elemento<br />
            <asp:Label ID="lb_NumElemento" runat="server"></asp:Label>
            <br />
            Nombre del Elemento<br />
            <asp:Label ID="lb_nombre" runat="server"></asp:Label>
            <br />
            <br />
            Nombres:
            <asp:TextBox ID="TextBox3" runat="server" Width="238px"></asp:TextBox>
            <br />
            <br />
            Apellido Paterno:<asp:TextBox ID="TextBox4" runat="server" Width="195px"></asp:TextBox>
            <br />
            <br />
            Apellido Materno:<asp:TextBox ID="TextBox5" runat="server" Width="195px"></asp:TextBox>
            <br />
            <br />
            Fecha de alta<br />
            <asp:TextBox ID="TextBox2" runat="server" Width="192px"></asp:TextBox>
            <br />
            <br />
            Fecha baja:<br />
            <asp:TextBox ID="TextBox1" runat="server" Width="192px"></asp:TextBox>
            <br />
            <br />
            Cambiar ejecutivo:<br />
            <br />
            Nombre del ejecutivo:<asp:DropDownList ID="DropDownList1" runat="server" Height="23px" Width="250px">
            </asp:DropDownList>
            <br />

        </div>
    </form>
</body>
</html>
