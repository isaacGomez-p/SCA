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
            text-align: center;
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
            text-align: left;
        }
        .auto-style39 {
            height: 16px;
        }
        .auto-style40 {
            text-align: left;
            width: 171px;
            height: 49px;
        }
        .auto-style41 {
            text-align: center;
            height: 49px;
        }
        .auto-style42 {
            width: 139px;
            height: 49px;
        }
        .auto-style43 {
            height: 49px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="auto-style16">
        <tr>
            <td class="auto-style17"></td>
            <td class="auto-style18">Seleccione la cedula del cliente<br />
                <asp:DropDownList ID="D_Clientes" runat="server">
                </asp:DropDownList>
            </td>
            <td class="auto-style21">
                <asp:Button ID="B_BuscarCliente" runat="server" Text="Buscar" OnClick="B_BuscarCliente_Click" style="width: 61px" />
            </td>
            <td class="auto-style17"></td>
        </tr>
        <tr>
            <td class="auto-style10">
                <asp:Label ID="L_Cliente" runat="server" Text="Cliente"></asp:Label>
            </td>
            <td class="auto-style19">
                <br />
                <asp:TextBox ID="TB_Nombre" runat="server" Enabled="False"></asp:TextBox>
                <br />
                <asp:TextBox ID="TB_Apellido" runat="server" Enabled="False"></asp:TextBox>
            </td>
            <td class="auto-style22">
                &nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style10">
                <asp:Label ID="Label4" runat="server" Text="Productos"></asp:Label>
            </td>
            <td class="auto-style19">
                    <asp:GridView ID="GV_Productos" runat="server" AllowPaging="True" AutoGenerateColumns="False" BackColor="White" BorderColor="#3366CC" BorderStyle="None" BorderWidth="1px" CellPadding="4" EmptyDataText="No hay productos ingresados." CssClass="auto-style10" PageSize="4" OnPageIndexChanging="GV_Productos_PageIndexChanging">
                        <Columns>
                            
                            <asp:TemplateField HeaderText="Id">
                                <EditItemTemplate>
                                    <asp:TextBox ID="TextBox5" runat="server" Text='<%# Bind("idasignaciones") %>'></asp:TextBox>
                                </EditItemTemplate>
                                <ItemTemplate>
                                    <asp:Label ID="Label6" runat="server" Text='<%# Bind("idasignaciones") %>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Referencia">
                                <EditItemTemplate>
                                    <asp:TextBox ID="TextBox6" runat="server" Text='<%# Bind("referencia") %>'></asp:TextBox>
                                </EditItemTemplate>
                                <ItemTemplate>
                                    <asp:Label ID="Label7" runat="server" Text='<%# Bind("referencia") %>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Talla">
                                <EditItemTemplate>
                                    <asp:TextBox ID="TextBox7" runat="server" Text='<%# Bind("talla") %>'></asp:TextBox>
                                </EditItemTemplate>
                                <ItemTemplate>
                                    <asp:Label ID="Label8" runat="server" Text='<%# Bind("talla") %>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Cantidad">
                                <EditItemTemplate>
                                    <asp:TextBox ID="TextBox8" runat="server" Text='<%# Bind("cantidad") %>'></asp:TextBox>
                                </EditItemTemplate>
                                <ItemTemplate>
                                    <asp:Label ID="Label9" runat="server" Text='<%# Bind("cantidad") %>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Precio">
                                <EditItemTemplate>
                                    <asp:TextBox ID="TextBox9" runat="server" Text='<%# Bind("precio") %>'></asp:TextBox>
                                </EditItemTemplate>
                                <ItemTemplate>
                                    <asp:Label ID="Label10" runat="server" Text='<%# Bind("precio") %>'></asp:Label>
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
            <td class="auto-style23">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style41"></td>
            <td class="auto-style40">
                Seleccione un
                id:&nbsp;&nbsp;
                <asp:DropDownList ID="D_IdAsig" runat="server">
                </asp:DropDownList>
&nbsp;</td>
            <td class="auto-style42">
                <asp:Button ID="B_Seleccionar" runat="server" OnClick="B_Seleccionar_Click" Text="Seleccionar" />
            </td>
            <td class="auto-style43"></td>
        </tr>
        <tr>
            <td colspan="4" class="auto-style39">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style36">
                <asp:Label ID="L_Precio" runat="server" Text="Cantidad"></asp:Label>
            </td>
            <td class="auto-style37">
                <asp:TextBox ID="TB_refe" runat="server" Enabled="False"></asp:TextBox>
                <asp:TextBox ID="TB_Talla" runat="server" Enabled="False"></asp:TextBox>
                <asp:TextBox ID="TB_Cantidad" runat="server"></asp:TextBox>
                <asp:TextBox ID="TB_Precio" runat="server" Enabled="False"></asp:TextBox>
            </td>
            <td class="auto-style38">
                <asp:Button ID="B_AgregarProducto" runat="server" OnClick="B_AgregarProducto_Click" Text="Agregar Producto" />
            </td>
            <td class="auto-style36"></td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td class="auto-style19">
                <asp:GridView ID="GV_Venta" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#3366CC" BorderStyle="None" BorderWidth="1px" CellPadding="4" CssClass="auto-style35" Height="151px" ShowFooter="True" Width="255px" >
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
            <td class="auto-style22">
                <asp:Button ID="B_Facturar" runat="server" Text="Facturar" OnClick="B_Facturar_Click" />
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="L_Vendedor" runat="server" Text="Vendedor"></asp:Label>
                <asp:Label ID="L_Sede" runat="server" Text="Sede"></asp:Label>
                <br />
                <asp:Label ID="L_Rol" runat="server" Text="Rol"></asp:Label>
            </td>
            <td class="auto-style20">&nbsp;</td>
            <td class="auto-style23">
                <asp:Button ID="B_Cancelar" runat="server" Text="Cancelar" />
            </td>
            <td>&nbsp;</td>
        </tr>
    </table>
</asp:Content>

