<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdministracionVacantes.aspx.cs" Inherits="modulosASP.AdministracionVacantes" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Panel ID="Vacantes" runat="server">
                    Proyecto<br />
                    <asp:DropDownList ID="DropDownList1" runat="server" Width="200px">
                    </asp:DropDownList>
                    <br />
                    <br />
                    Sub proyecto<br />
                    <asp:DropDownList ID="DropDownList2" runat="server" Width="200px">
                    </asp:DropDownList>
                    <br />
                    <br />
                    Servicio<br />
                    <asp:DropDownList ID="DropDownList3" runat="server" Width="200px">
                    </asp:DropDownList>
                </asp:Panel>
            <br />
            <br />
        </div>
    </form>
</body>
</html>
