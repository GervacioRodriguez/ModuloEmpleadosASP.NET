<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ModificarEstatusElemento.aspx.cs" Inherits="modulosASP.ModificarEstatusElemento" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:LinkButton ID="lbt_ejecutivo" runat="server" OnClick="lbt_ejecutivo_Click">Buecar ejecutivo</asp:LinkButton>
            <br />
            <br />
            <br />
            <asp:Label ID="Label1" runat="server" Text="# Elemento"></asp:Label>
            <asp:TextBox ID="txtelemento" runat="server" Width="204px"></asp:TextBox>
            <asp:Button ID="Button1" runat="server" OnClick="btnBuscar" Text="Buscar" Width="159px" />
            <br />
            Ejecutivo Actual: <asp:Label ID="lb_ejecutivo" runat="server"></asp:Label>
            <br />
            <br />
            <br />
            <br />
            <br />
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="editar" />
            <br />
            <asp:GridView ID="dtelemento" runat="server" BorderStyle="Ridge" OnRowDataBound="dtelemento_RowDataBound" >
                <Columns>
                    <asp:ButtonField ButtonType="Button" Text="Editar">
                    <ControlStyle BackColor="Yellow" BorderColor="#FF9900" />
                    </asp:ButtonField>
                </Columns>
            </asp:GridView>
            <br />
            <br />
            <br />
            <br />
            <br />
        </div>
    </form>
</body>
</html>
