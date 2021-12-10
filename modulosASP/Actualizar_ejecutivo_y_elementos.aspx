<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Actualizar_ejecutivo_y_elementos.aspx.cs" Inherits="modulosASP.Actualizar_ejecutivo_y_elementos" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Panel ID="P_ejecutivo" runat="server">
                Ejecutivo:<br />
                <asp:Label ID="lbEjecutivo" runat="server"></asp:Label><br />
                <asp:DataGrid ID="Elementos" runat="server" AutoGenerateColumns="false">
                    <Columns>
                        <asp:BoundField />
                    </Columns>
                </asp:DataGrid>
            </asp:Panel>
        </div>
    </form>
</body>
</html>
