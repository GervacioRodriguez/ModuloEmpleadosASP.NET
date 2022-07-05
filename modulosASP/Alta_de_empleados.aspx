<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Alta_de_empleados.aspx.cs" Inherits="modulosASP.Alta_de_nuevo_candidato" %>

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
        Fecha de nacimiento<br />
        <br />
        <asp:Button ID="idCalendario" runat="server" OnClick="idCalendario_Click" Text="Calendario" />
        <asp:Calendar ID="CalendarFecha" runat="server" BackColor="White" BorderColor="#999999" CellPadding="4" DayNameFormat="Shortest" Font-Names="Verdana" Font-Size="8pt" ForeColor="Black" Height="180px" OnSelectionChanged="CalendarFecha_SelectionChanged" Width="200px">
            <DayHeaderStyle BackColor="#CCCCCC" Font-Bold="True" Font-Size="7pt" />
            <NextPrevStyle VerticalAlign="Bottom" />
            <OtherMonthDayStyle ForeColor="#808080" />
            <SelectedDayStyle BackColor="#666666" Font-Bold="True" ForeColor="White" />
            <SelectorStyle BackColor="#CCCCCC" />
            <TitleStyle BackColor="#999999" BorderColor="Black" Font-Bold="True" />
            <TodayDayStyle BackColor="#CCCCCC" ForeColor="Black" />
            <WeekendDayStyle BackColor="#FFFFCC" />
        </asp:Calendar>
        <asp:TextBox ID="txtFechaNacimiento" runat="server" ReadOnly="True" Width="191px"></asp:TextBox>
        <br />
        <br />
        Nombre(s): <asp:TextBox ID="TextBox1" runat="server" Width="212px"></asp:TextBox>
        <br />
        Apellido Paterno
        <asp:TextBox ID="TextBox2" runat="server" Width="181px"></asp:TextBox>
        <br />
        Apellido Materno<asp:TextBox ID="TextBox3" runat="server" Width="176px"></asp:TextBox>
        <br />
        Edad
        <asp:TextBox ID="txtedad" runat="server" ReadOnly="True" Width="141px"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" Text="Guardar" />
    </form>
</body>
</html>
