<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="prototipoTP4.WebForm2" %>

<!DOCTYPE html>
<script runat="server">

    protected void gvProductos_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    protected void gvCategorias_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    protected void btnFiltro_Click(object sender, EventArgs e)
    {

    }
</script>


<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 130px;
        }
        .auto-style3 {
            width: 213px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <br />
            <table class="auto-style1">
                <tr>
                    <td class="auto-style2">Id Producto:</td>
                    <td class="auto-style3">
                        <asp:DropDownList ID="ddlIdProducto" runat="server">
                            <asp:ListItem Value="=">Igual a</asp:ListItem>
                            <asp:ListItem Value=" &gt;">Mayor a</asp:ListItem>
                            <asp:ListItem Value="&lt;">Menor a</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                    <td>
                        <asp:TextBox ID="txtIdProducto" runat="server" Width="137px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">Id Categoria:</td>
                    <td class="auto-style3">
                        <asp:DropDownList ID="ddlIdCategoria" runat="server">
                            <asp:ListItem Value="=">Igual a</asp:ListItem>
                            <asp:ListItem Value="&lt;">Mayor a</asp:ListItem>
                            <asp:ListItem Value="&gt;">Menor a</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                    <td>
                        <asp:TextBox ID="txtIdCategoria" runat="server" Width="137px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style3">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style3">&nbsp;</td>
                    <td>
                        <asp:Button ID="btnFiltro" runat="server" OnClick="btnFiltro_Click" Text="Filtrar" />
&nbsp;<asp:Button ID="btnSacarFiltros" runat="server" Text="Sacar filtros" OnClick="btnSacarFiltros_Click" />
                    </td>
                </tr>
            </table>
            <br />
            <br />
            <asp:GridView ID="gvProductos" runat="server" OnSelectedIndexChanged="gvProductos_SelectedIndexChanged">
            </asp:GridView>
            <br />
        </div>
    </form>
</body>
</html>
