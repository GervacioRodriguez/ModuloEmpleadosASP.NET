<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ModuloDenisse.aspx.cs" Inherits="modulosASP.ModuloDenisse" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <script src="js/alertas_usuarios.js"></script>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <br />
            Ingrese el numero de empleado consta de seis digitos<br />
            <br />
            <asp:TextBox ID="txteliminar" runat="server" Width="180px"></asp:TextBox>
            <asp:Button ID="btnborrar" runat="server" OnClick="btnborrar_Click" Text="borrar elemento" OnClientClick="return confirm('El Expediente fue eliminado con exito  ʕ•ᴥ•ʔ');" />
            <br />
            <br />
        </div>
    </form>
</body>
</html>
