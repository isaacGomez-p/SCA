<%@ Page Language="C#" AutoEventWireup="true" CodeFile="~/Controller/Tienda/Producto.aspx.cs" Inherits="View_Tienda_Producto" %>

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
            height: 23px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <table class="auto-style1">
            <tr>
                <td>&nbsp;</td>
                <td>
                    <asp:Label ID="Label1" runat="server" Text="Nombre Producto"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="TB_NombreProducto" runat="server"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>
                    <asp:Label ID="Label2" runat="server" Text="Precio"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="TB_Precio" runat="server" TextMode="Number"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>
                    <asp:Label ID="Label3" runat="server" Text="Sede"></asp:Label>
                </td>
                <td>
                    <asp:DropDownList ID="DL_Sedes" runat="server" DataSourceID="ObjectDataSource1" DataTextField="NombreSede" DataValueField="IdSede">
                    </asp:DropDownList>
                    <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="Sedes" TypeName="DAOUsuario"></asp:ObjectDataSource>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>
                    <asp:Button ID="B_AgregarProducto" runat="server" OnClick="B_AgregarProducto_Click" style="margin-bottom: 0px" Text="Agregar" Width="66px" />
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2"></td>
                <td class="auto-style2"></td>
                <td class="auto-style2">
                    <asp:GridView ID="GV_Productos" runat="server" AllowPaging="True" AutoGenerateColumns="False" BackColor="White" BorderColor="#3366CC" BorderStyle="None" BorderWidth="1px" CellPadding="4" DataSourceID="ObjectDataSource2" EmptyDataText="No hay productos ingresados." OnSelectedIndexChanged="GridView1_SelectedIndexChanged" OnRowCommand="GV_Productos_RowCommand">
                        <Columns>
                            <asp:TemplateField HeaderText="Eliminar" ShowHeader="False">
                                <ItemTemplate>
                                    <asp:LinkButton ID="LinkButton1" runat="server" CausesValidation="False" CommandName="Delete" Text="Eliminar" CommandArgument='<%# Bind("idproducto") %>'></asp:LinkButton>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Nombre Producto">
                                <EditItemTemplate>
                                    <asp:TextBox ID="TextBox2" runat="server" Text='<%# Bind("nombreproducto") %>'></asp:TextBox>
                                </EditItemTemplate>
                                <ItemTemplate>
                                    <asp:Label ID="Label2" runat="server" Text='<%# Bind("nombreproducto") %>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Precio">
                                <EditItemTemplate>
                                    <asp:TextBox ID="TextBox1" runat="server" Text='<%# Bind("precio") %>'></asp:TextBox>
                                </EditItemTemplate>
                                <ItemTemplate>
                                    <asp:Label ID="Label1" runat="server" Text='<%# Bind("precio") %>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Id Sede">
                                <EditItemTemplate>
                                    <asp:TextBox ID="TextBox3" runat="server" Text='<%# Bind("idsede") %>'></asp:TextBox>
                                </EditItemTemplate>
                                <ItemTemplate>
                                    <asp:Label ID="Label3" runat="server" Text='<%# Bind("idsede") %>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                        </Columns>
                        <FooterStyle BackColor="#99CCCC" ForeColor="#003399" />
                        <HeaderStyle BackColor="#003399" Font-Bold="True" ForeColor="#CCCCFF" />
                        <PagerStyle BackColor="#99CCCC" ForeColor="#003399" HorizontalAlign="Left" />
                        <RowStyle BackColor="White" ForeColor="#003399" />
                        <SelectedRowStyle BackColor="#009999" Font-Bold="True" ForeColor="#CCFF99" />
                        <SortedAscendingCellStyle BackColor="#EDF6F6" />
                        <SortedAscendingHeaderStyle BackColor="#0D4AC4" />
                        <SortedDescendingCellStyle BackColor="#D6DFDF" />
                        <SortedDescendingHeaderStyle BackColor="#002876" />
                    </asp:GridView>
                    <asp:ObjectDataSource ID="ObjectDataSource2" runat="server" DeleteMethod="eliminarProducto" SelectMethod="verProductos" TypeName="DAOUsuario">
                        <DeleteParameters>
                            <asp:Parameter Name="idproducto" Type="Int32" />
                        </DeleteParameters>
                    </asp:ObjectDataSource>
                </td>
                <td class="auto-style2"></td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
    </form>
</body>
</html>
