<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Actualizar_ejecutivo_y_elementos.aspx.cs" Inherits="modulosASP.Actualizar_ejecutivo_y_elementos" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Panel ID="Panel1" runat="server">
            Datos del ejecutivo<br />
            <br />
            Numero de ejecutivo:<br />
            <asp:TextBox ID="txtEjecutivo" runat="server"></asp:TextBox>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Buscar ejecutivo" Width="113px" />
            <br />
            <br />
            Numero:&nbsp;
            <asp:Label ID="LBEJECUTIVO" runat="server"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <br />
            Ejecutivo:
            <asp:Label ID="LBNUMEJECUTIVO" runat="server"></asp:Label>
            <br />
            Nombre:
            <asp:Label ID="LBNOMBRE" runat="server"></asp:Label>
            <br />
            Area :
            <asp:Label ID="LBAREA" runat="server"></asp:Label>
        </asp:Panel>
    </form>
</body>
</html>
