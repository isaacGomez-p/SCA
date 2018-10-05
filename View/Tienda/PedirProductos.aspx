<%@ Page Title="" Language="C#" MasterPageFile="~/View/Tienda/MasterAdmin.master" AutoEventWireup="true" CodeFile="PedirProductos.aspx.cs" Inherits="View_Tienda_PedirProductos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">

    <style type="text/css">
        .auto-style16 {
            width: 100%;
        }
        .auto-style17 {
            width: 165px;
        }
        .auto-style18 {
            width: 93px;
        }
        .auto-style19 {
            width: 165px;
            text-align: center;
        }
    </style>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="auto-style16">
        <tr>
            <td class="auto-style18">&nbsp;</td>
            <td class="auto-style17">&nbsp;</td>
            <td class="auto-style17">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style18">&nbsp;</td>
            <td class="auto-style17">
                <asp:GridView ID="GV_Pedir" runat="server" EmptyDataText="No hay pedidos realizados.">
                </asp:GridView>
            </td>
            <td class="auto-style17">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style18">&nbsp;</td>
            <td class="auto-style17">&nbsp;</td>
            <td class="auto-style17">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style18">&nbsp;</td>
            <td class="auto-style19">
                <asp:Label ID="Label4" runat="server" Text="Referencia"></asp:Label>
            </td>
            <td class="auto-style19">
                <asp:DropDownList ID="DL_Referencia" runat="server">
                </asp:DropDownList>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style18">&nbsp;</td>
            <td class="auto-style19">
                <asp:Label ID="Label5" runat="server" Text="Talla"></asp:Label>
            </td>
            <td class="auto-style19">
                    <asp:DropDownList ID="DL_Tallas" runat="server" EnableTheming="False">
                        <asp:ListItem>Seleccione una talla</asp:ListItem>
                        <asp:ListItem>1</asp:ListItem>
                        <asp:ListItem>1.5</asp:ListItem>
                        <asp:ListItem>2</asp:ListItem>
                        <asp:ListItem>2.5</asp:ListItem>
                        <asp:ListItem>3</asp:ListItem>
                        <asp:ListItem>3.5</asp:ListItem>
                        <asp:ListItem>4</asp:ListItem>
                        <asp:ListItem>4.5</asp:ListItem>
                        <asp:ListItem>5</asp:ListItem>
                        <asp:ListItem>5.5</asp:ListItem>
                        <asp:ListItem>6</asp:ListItem>
                        <asp:ListItem>6.5</asp:ListItem>
                        <asp:ListItem>7</asp:ListItem>
                        <asp:ListItem>7.5</asp:ListItem>
                        <asp:ListItem>8</asp:ListItem>
                        <asp:ListItem>8.5</asp:ListItem>
                        <asp:ListItem>9</asp:ListItem>
                        <asp:ListItem>9.5</asp:ListItem>
                        <asp:ListItem>10</asp:ListItem>
                        <asp:ListItem>10.5</asp:ListItem>
                        <asp:ListItem>11</asp:ListItem>
                        <asp:ListItem>11.5</asp:ListItem>
                        <asp:ListItem>12</asp:ListItem>
                    </asp:DropDownList>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style18">&nbsp;</td>
            <td class="auto-style19">
                <asp:Label ID="Label6" runat="server" Text="Cantidad"></asp:Label>
            </td>
            <td class="auto-style19">
                <asp:TextBox ID="TB_Cantidad" runat="server" TextMode="Number"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style18">&nbsp;</td>
            <td class="auto-style17">&nbsp;</td>
            <td class="auto-style17">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style18">&nbsp;</td>
            <td class="auto-style17">&nbsp;</td>
            <td class="auto-style17">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style18">&nbsp;</td>
            <td class="auto-style17">&nbsp;</td>
            <td class="auto-style17">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style18">&nbsp;</td>
            <td class="auto-style17">&nbsp;</td>
            <td class="auto-style17">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style18">&nbsp;</td>
            <td class="auto-style17">&nbsp;</td>
            <td class="auto-style17">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
       
    </table>
</asp:Content>

