<%@ Page Language="C#" AutoEventWireup="true" CodeFile="~/Controller/Tienda/Sede.aspx.cs" Inherits="View_Inventario_AgregarSede" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style1">
                <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>
                        <asp:Label ID="Label2" runat="server" Text="Nombre sede:"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="TB_NombreSede" runat="server"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>
                        <asp:Label ID="Ciudad" runat="server" Text="Ciudad:"></asp:Label>
                    </td>
                    <td>
                        <asp:DropDownList ID="DL_Ciudad" runat="server">
                            <asp:ListItem Selected="True" Value="0">Seleccione un elemento</asp:ListItem>
                            <asp:ListItem Value="1">Bogotá</asp:ListItem>
                            <asp:ListItem Value="2">Medellín</asp:ListItem>
                            <asp:ListItem Value="3">Boyacá</asp:ListItem>
                            <asp:ListItem Value="4">Barranquilla</asp:ListItem>
                            <asp:ListItem Value="5">Cartagena</asp:ListItem>
                            <asp:ListItem Value="6">San Andrés</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>
                        <asp:Label ID="Label1" runat="server" Text="Direccion:"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="TB_Direccion" runat="server"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>
                        <asp:Button ID="B_AgregarSede" runat="server" OnClick="B_AgregarSede_Click" Text="Agregar" />
                    </td>
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
                    <td>
                        <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AutoGenerateColumns="False" BackColor="White" BorderColor="#3366CC" BorderStyle="None" BorderWidth="1px" CellPadding="4" DataSourceID="ObjectDataSource1" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" OnRowCommand="GridView1_RowCommand">
                            <Columns>
                                <asp:TemplateField ShowHeader="False" HeaderText="Eliminar">
                                    <ItemTemplate>
                                        <asp:LinkButton ID="LinkButton1" runat="server" CausesValidation="False" CommandName="Delete" Text="Eliminar" CommandArgument='<%# Bind("idsede") %>'></asp:LinkButton>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="ID">
                                    <EditItemTemplate>
                                        <asp:TextBox ID="TextBox2" runat="server" Text='<%# Bind("idsede") %>'></asp:TextBox>
                                    </EditItemTemplate>
                                    <ItemTemplate>
                                        <asp:Label ID="Label2" runat="server" Text='<%# Bind("idsede") %>'></asp:Label>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:BoundField DataField="nombresede" HeaderText="Nombre Sede" />
                                <asp:BoundField DataField="ciudad" HeaderText="Ciudad" />
                                <asp:TemplateField HeaderText="Direccion">
                                    <EditItemTemplate>
                                        <asp:TextBox ID="TextBox1" runat="server" Text='<%# Bind("direccion") %>'></asp:TextBox>
                                    </EditItemTemplate>
                                    <ItemTemplate>
                                        <asp:Label ID="Label1" runat="server" Text='<%# Bind("direccion") %>'></asp:Label>
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
                        <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="verSedes" TypeName="DAOUsuario" DeleteMethod="eliminarSede">
                            <DeleteParameters>
                                <asp:Parameter Name="idsede" Type="Int32" />
                            </DeleteParameters>
                        </asp:ObjectDataSource>
                    </td>
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
        </div>
    </form>
</body>
</html>
