<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="protoTP4.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 160px;
        }
        .auto-style3 {
            width: 160px;
            height: 24px;
        }
        .auto-style4 {
            height: 24px;
            width: 471px;
        }
        .auto-style5 {
            width: 471px;
        }
        .auto-style6 {
            width: 160px;
            height: 23px;
        }
        .auto-style7 {
            width: 471px;
            height: 23px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style1">
                <tr>
                    <td class="auto-style2">DESTINO INICIO</td>
                    <td class="auto-style5">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style3"></td>
                    <td class="auto-style4"></td>
                </tr>
                <tr>
                    <td class="auto-style2">Provincia:</td>
                    <td class="auto-style5">
                        <asp:DropDownList ID="ddlProvInicio" runat="server" OnSelectedIndexChanged="ddlProvInicio_SelectedIndexChanged">
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">Localidad:</td>
                    <td class="auto-style5">
                        <asp:DropDownList ID="ddlLocInicio" runat="server">
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style5">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style6">DESTINO FINAL:</td>
                    <td class="auto-style7"></td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style5">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">Provincia:</td>
                    <td class="auto-style5">
                        <asp:DropDownList ID="ddlProvFinal" runat="server">
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">Localidad:</td>
                    <td class="auto-style5">
                        <asp:DropDownList ID="ddlLocFinal" runat="server">
                        </asp:DropDownList>
                    </td>
                </tr>
            </table>
            <br />
            <br />
            <br />
            <br />
            <br />
        </div>
    </form>
</body>
</html>
