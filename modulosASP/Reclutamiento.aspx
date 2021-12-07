<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Reclutamiento.aspx.cs" Inherits="modulosASP.Reclutamiento" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Nombre"></asp:Label>
            <asp:TextBox ID="txtnombre" runat="server" Width="294px"></asp:TextBox>
            <br />
            <asp:Label ID="Label2" runat="server" Text="Edad"></asp:Label>
            <asp:TextBox ID="txtedad" runat="server" Width="294px"></asp:TextBox>
            <br />
            <asp:Label ID="Label3" runat="server" Text="RFC"></asp:Label>
            <asp:TextBox ID="txtrfc" runat="server" Width="294px"></asp:TextBox>
            <br />
            <asp:Label ID="label4" runat="server" Text="NSS"></asp:Label>
            <br />
            <br />

            <asp:Label ID="label5" runat="server" Text="Fuente de Reclutamiento"></asp:Label>
            <asp:Panel ID="redessociales" runat="server">
                <asp:RadioButton ID="facebook" runat="server" Text="Facebook"/>
                    <asp:RadioButton ID="volanteo" runat="server" Text="Volanteo"/>
                    <br />
                    <asp:RadioButton ID="linkedin" runat="server" Text="Linkedin"/>
                    <asp:RadioButton ID="posteo" runat="server" Text="Posteo"/>
                    <br />
                    <asp:RadioButton ID="recomendado" runat="server" Text="Recomendado"/>
                    <asp:RadioButton ID="otros" runat="server" Text="Otros"/>
                    <asp:TextBox ID="txtotro" runat="server" width="290px"></asp:TextBox>
                    &nbsp;&nbsp;
            </asp:Panel>


            <asp:Panel ID="estatus" runat="server">
                <asp:Label ID="lb_estatus" runat="server" Text=""></asp:Label>
                <br />
                <asp:RadioButton ID="Etado" runat="server" Text="Rechasado"/>
                <br />
                <asp:Label ID="lb_motivos" runat="server" Text="Motivos"></asp:Label>
                <asp:TextBox ID="txtmotivo" runat="server" Width="290px"></asp:TextBox>
            </asp:Panel>
            <asp:Panel ID="aprobado" runat="server">
                <asp:Label ID="lb_aprobado" runat="server" Text="El candidato "></asp:Label>
                <br />

            </asp:Panel>
            <br />
        </div>
    </form>
</body>
</html>
