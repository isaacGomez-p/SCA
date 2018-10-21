<%@ Page Title="" Language="C#" MasterPageFile="~/View/Tienda/MasterVendedor.master" AutoEventWireup="true" CodeFile="~/Controller/Tienda/NuevaVenta.aspx.cs" Inherits="View_Tienda_NuevaVenta" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style16 {
            width: 100%;
        }
        .auto-style17 {
            height: 23px;
        }
        .auto-style18 {
            height: 23px;
            width: 171px;
        }
        .auto-style19 {
            text-align: center;
            width: 171px;
        }
        .auto-style20 {
            width: 171px;
        }
        .auto-style21 {
            height: 23px;
            width: 139px;
        }
        .auto-style22 {
            text-align: center;
            width: 139px;
        }
        .auto-style23 {
            width: 139px;
        }
        .auto-style34 {
            margin-right: 0px;
        }
        .auto-style35 {
            margin-bottom: 17px;
        }
        .auto-style36 {
            height: 104px;
        }
        .auto-style37 {
            width: 171px;
            height: 104px;
        }
        .auto-style38 {
            width: 139px;
            height: 104px;
            text-align: center;
        }
        .auto-style39 {
            height: 16px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="auto-style16">
        <tr>
            <td class="auto-style17"></td>
            <td class="auto-style18"></td>
            <td class="auto-style21"></td>
            <td class="auto-style17"></td>
        </tr>
        <tr>
            <td class="auto-style10">
                <asp:Label ID="L_Cliente" runat="server" Text="Cliente"></asp:Label>
            </td>
            <td class="auto-style19">
                <asp:TextBox ID="TB_Cliente" runat="server"></asp:TextBox>
            </td>
            <td class="auto-style22">
                <asp:Button ID="B_BuscarCliente" runat="server" Text="Buscar" />
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style10">
                <asp:Label ID="Label4" runat="server" Text="Productos"></asp:Label>
            </td>
            <td class="auto-style19">
                <asp:GridView ID="GV_AsignarSinPedido" runat="server" AllowPaging="True" AutoGenerateColumns="False" BackColor="White" BorderColor="#3366CC" BorderStyle="None" BorderWidth="1px" CellPadding="4" CssClass="auto-style34" DataSourceID="ObjectDataSource1" PageSize="5" OnSelectedIndexChanged="GV_AsignarSinPedido_SelectedIndexChanged">
                    <Columns>
                        <asp:TemplateField HeaderText="Referencia">
                            <EditItemTemplate>
                                <asp:TextBox ID="TextBox2" runat="server" Text='<%# Bind("ReferenciaProducto") %>'></asp:TextBox>
                            </EditItemTemplate>
                            <ItemTemplate>
                                <asp:Label ID="L_Referencia" runat="server" Text='<%# Bind("ReferenciaProducto") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Talla">
                            <EditItemTemplate>
                                <asp:TextBox ID="TextBox3" runat="server" Text='<%# Bind("Talla") %>'></asp:TextBox>
                            </EditItemTemplate>
                            <ItemTemplate>
                                <asp:Label ID="L_Talla" runat="server" Text='<%# Bind("Talla") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Cantidad">
                            <EditItemTemplate>
                                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                            </EditItemTemplate>
                            <ItemTemplate>
                                <asp:TextBox ID="TB_Cantidad" runat="server" TextMode="Number">0</asp:TextBox>
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
                <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="Productos" TypeName="DAOUsuario"></asp:ObjectDataSource>
            </td>
            <td class="auto-style23">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style10">&nbsp;</td>
            <td class="auto-style19">
                <asp:Button ID="Button1" runat="server" Text="Agregar a la venta" />
            </td>
            <td class="auto-style23">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td colspan="4" class="auto-style39"></td>
        </tr>
        <tr>
            <td class="auto-style36"></td>
            <td class="auto-style37">
                <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#3366CC" BorderStyle="None" BorderWidth="1px" CellPadding="4" CssClass="auto-style35" Height="151px" ShowFooter="True" Width="255px">
                    <Columns>
                        <asp:TemplateField HeaderText="Referencia">
                            <EditItemTemplate>
                                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                            </EditItemTemplate>
                            <ItemTemplate>
                                <asp:Label ID="Label1" runat="server"></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Talla">
                            <EditItemTemplate>
                                <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                            </EditItemTemplate>
                            <ItemTemplate>
                                <asp:Label ID="Label3" runat="server"></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Cantidad">
                            <EditItemTemplate>
                                <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
                            </EditItemTemplate>
                            <FooterTemplate>
                                <asp:Label ID="Label5" runat="server" Text="Total"></asp:Label>
                            </FooterTemplate>
                            <ItemTemplate>
                                <asp:Label ID="Label4" runat="server"></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Valor">
                            <EditItemTemplate>
                                <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                            </EditItemTemplate>
                            <FooterTemplate>
                                <asp:TextBox ID="TB_ValorVenta" runat="server">$00000</asp:TextBox>
                            </FooterTemplate>
                            <ItemTemplate>
                                <asp:Label ID="Label2" runat="server"></asp:Label>
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
            </td>
            <td class="auto-style38">
                <asp:Button ID="B_Facturar" runat="server" Text="Facturar" />
            </td>
            <td class="auto-style36"></td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td class="auto-style19">&nbsp;</td>
            <td class="auto-style22">
                <asp:Button ID="B_Cancelar" runat="server" Text="Cancelar" />
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td class="auto-style20">&nbsp;</td>
            <td class="auto-style23">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>
</asp:Content>

