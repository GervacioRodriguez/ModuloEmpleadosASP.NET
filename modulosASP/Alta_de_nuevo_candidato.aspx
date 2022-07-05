<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Alta_de_nuevo_candidato.aspx.cs" Inherits="modulosASP.Alta_de_nuevo_candidato" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        Ingrese nuevo empleado<br />
        <br />
        Nombre(s):
        <asp:TextBox ID="TextBox1" runat="server" Width="212px"></asp:TextBox>
        <br />
        Apellido Paterno
        <asp:TextBox ID="TextBox2" runat="server" Width="181px"></asp:TextBox>
        <br />
        Apellido Materno<asp:TextBox ID="TextBox3" runat="server" Width="176px"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" Text="Guardar" />
    </form>
</body>
</html>
