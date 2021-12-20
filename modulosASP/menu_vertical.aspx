<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="menu_vertical.aspx.cs" Inherits="modulosASP.menu_vertical" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <asp:LinkButton ID="lblikn_inicio" runat="server" BorderStyle="Outset" Height="30px" OnClick="LinkButton1_Click" Width="90px">inicio</asp:LinkButton>
            <br />
            <asp:LinkButton ID="lbl_boton1" runat="server" BorderStyle="Outset" Height="30px" OnClick="LinkButton1_Click" Width="90px">casa</asp:LinkButton>
            <br />
            <asp:LinkButton ID="lblikn_inicio1" runat="server" BorderStyle="Outset" Height="30px" OnClick="LinkButton1_Click" Width="90px">elemento</asp:LinkButton>
            <br />
            <asp:LinkButton ID="lblikn_enmarcha" runat="server" BorderStyle="Outset" Height="30px" OnClick="LinkButton1_Click" Width="90px">puesto en marcha</asp:LinkButton>

        </div>
    </form>

    <form id="form2">
        <div>   
            <p>panel donde apareceran las paguinas seleccionadas del botto link

            </p>

        </div>
    </form>
</body>
</html>
