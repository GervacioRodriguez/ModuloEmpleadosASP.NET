<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Menu Horizontal.aspx.cs" Inherits="modulosASP.Menu_Horizontal" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Menu ID="Menu1" runat="server" Orientation="Horizontal">
                <Items>
                    <asp:MenuItem NavigateUrl="~/reportesmensuales" Text="Menu1" value="1"></asp:MenuItem>
                    <asp:MenuItem NavigateUrl="~/reportes_uno_dos" Text="Menu2" Value="2"></asp:MenuItem>
                    <asp:MenuItem NavigateUrl="~/reporte3" Text="menu3" Value="3"></asp:MenuItem>
                </Items>
            </asp:Menu>
        </div>
    </form>
</body>
</html>
