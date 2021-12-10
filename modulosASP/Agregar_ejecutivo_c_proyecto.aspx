<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Agregar_ejecutivo_c_proyecto.aspx.cs" Inherits="modulosASP.Agregar_ejecutivo_c_proyecto" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="txtNum_empleado" runat="server" Width="132px" AutoPostBack="True"></asp:TextBox>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Buscar" Width="157px" />
            <br />
            Num Empleado:
            <br />
            <asp:Label ID="LBTBusuarios" runat="server"></asp:Label>
            <br />
            Login:
            <br />
            <asp:Label ID="LBLOGIN" runat="server"></asp:Label>
            <br />
            <asp:Label ID="Label1" runat="server" Text="PassWord: "></asp:Label>
            <br />
            <asp:Label ID="LBPASSWORD" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
