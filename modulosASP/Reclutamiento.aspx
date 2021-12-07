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
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Agregar elemento" Width="161px" />
            <br />
            <br />
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
                <asp:RadioButton ID="apto" runat="server" Text="El candidato es apto"/>
                <br />
                <asp:Label ID="lb_apto" Text="Razones por las que es apto" runat="server" /><br <br />
                <asp:RadioButton ID="rbArmado" Text="Armado" runat="server"/><br />
                <asp:RadioButton ID="rbDesarmado" Text="Desarmado" runat="server"/><br />
                <asp:RadioButton ID="rbAmbos" Text="Ambos"  runat="server"/>

            </asp:Panel>

            <asp:Panel ID="vacantes" runat="server">
                

                <%--este sección del codigo jalara desde el catalogo de estados y se llenara un dropdown-lis 
                    entre lazado para porder ir jalando la informacion osea 
                    selecionara el
                    Estado
                        |--> municipio
                                |-->proyecto
                                        |-->Antiguedad
                                                |-->vacante
                    --%>
                <asp:Label ID="lb_vacantes" runat="server" Text="Vacantes"></asp:Label>
                <br />
                <asp:Label ID="Lb_Estado" runat="server" Text="Estado"></asp:Label>
                <br />
                <asp:DropDownList ID="estado" runat="server" Width="230px" AutoPostBack="True" DataSourceID="estadosql" DataTextField="Estado" DataValueField="Estado"></asp:DropDownList>
                <asp:SqlDataSource ID="estadosql" runat="server" ConnectionString="<%$ ConnectionStrings:conexiondeEstado %>" SelectCommand="SELECT [Estado] FROM [C_Estado]"></asp:SqlDataSource>
                <br />
                <asp:Label ID="lbMunicipio" runat="server" Text="Municipio"></asp:Label><br />
                <asp:DropDownList ID="Municipio" runat="server" Width="230px" DataSourceID="combodependiente"></asp:DropDownList>
                <asp:SqlDataSource ID="combodependiente" runat="server" ConnectionString="Data Source=192.168.11.75;Initial Catalog=Seic;User ID=sa;Password=Seicsa123" ProviderName="System.Data.SqlClient" SelectCommand="SELECT [Municipio] FROM [C_Municipios]"></asp:SqlDataSource>
                <br />
                <asp:Label ID="lbproyecto" runat="server" Text="Proyecto"></asp:Label><br />
                <asp:DropDownList ID="Proyecto" runat="server" Width="230px"></asp:DropDownList><br />
                <asp:Label ID="lbtipo" runat="server" Text="Tipo"></asp:Label><br />
                <asp:DropDownList ID="Antiguedad" runat="server" Width="230px"></asp:DropDownList>

            </asp:Panel>
            <br />
        </div>
    </form>
</body>
</html>
