<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UpdateElemento.aspx.cs" Inherits="modulosASP.UpdateElemento" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            Id Elemento<br />
            <asp:Label ID="lb_NumElemento" runat="server"></asp:Label>
            <br />
            Nombre del Elemento<br />
            <asp:Label ID="lb_nombre" runat="server"></asp:Label>
            <br />
            <br />
            Nombres:
            <asp:TextBox ID="txtnombres" runat="server" Width="238px"></asp:TextBox>
            <br />
            <br />
            Apellido Paterno:<asp:TextBox ID="txtApaterno" runat="server" Width="195px"></asp:TextBox>
            <br />
            <br />
            Apellido Materno:<asp:TextBox ID="txtAmaterno" runat="server" Width="189px"></asp:TextBox>
            <br />
            <br />
            Fecha de alta<br />
            <asp:TextBox ID="txtFecha_alta" runat="server" Width="192px"></asp:TextBox>
            <br />
            <br />
            Fecha baja:<br />
            <asp:TextBox ID="txtfecha_baja" runat="server" Width="192px"></asp:TextBox>
            <br />
            <br />
            <br />
            <asp:Button ID="btnActualizar" runat="server" Height="25px" OnClick="btnActualizar_Click" Text="Actualizar" Width="119px" />

            <br />
            <br />
            <br />
            <asp:RadioButton ID="RbEjecutivo" runat="server" OnCheckedChanged="RdEjecutivo_CheckedChanged" Text="Cambiar Ejecutivo" />
            <br />
            <br />
            Cambiar ejecutivo:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Num ejecutivo<br />
            <asp:TextBox ID="txtejecutivo" runat="server"  Width="195px"></asp:TextBox>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtNumEjecutivo" runat="server"></asp:TextBox>
            <br />

        </div>
    </form>
</body>
</html>
