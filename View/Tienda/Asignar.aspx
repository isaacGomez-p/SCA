<%@ Page Title="" Language="C#" MasterPageFile="~/View/Tienda/MasterSuperAdmin.master" AutoEventWireup="true" CodeFile="~/Controller/Tienda/Asignar.aspx.cs" Inherits="View_Tienda_Asignar" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style10 {
            width: 206px;
        }
        .auto-style11 {
            height: 23px;
        }
        .auto-style12 {
            width: 206px;
            height: 23px;
        }
        .auto-style13 {
            width: 152px;
        }
        .auto-style14 {
            height: 23px;
            width: 152px;
        }
        .auto-style15 {
            height: 24px;
        }
        .auto-style16 {
            width: 206px;
            height: 24px;
        }
        .auto-style17 {
            width: 152px;
            height: 24px;
            text-align: center;
        }
        .auto-style18 {
            width: 152px;
            text-align: center;
        height: 30px;
            margin-left: 40px;
        }
        .auto-style19 {
            height: 23px;
            width: 152px;
            text-align: center;
        }
    .auto-style20 {
        height: 26px;
    }
    .auto-style21 {
        width: 206px;
        height: 26px;
    }
    .auto-style22 {
        width: 152px;
        text-align: center;
        height: 26px;
    }
    .auto-style23 {
        height: 30px;
    }
    .auto-style24 {
        width: 206px;
        height: 30px;
    }
        .auto-style25 {
            height: 264px;
        }
        .auto-style26 {
            width: 206px;
            height: 264px;
        }
        .auto-style27 {
            width: 152px;
            height: 264px;
        }
        .auto-style28 {
            width: 206px;
            height: 23px;
            text-align: center;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">

    <table class="auto-style1">
        <tr>
            <td>&nbsp;</td>
            <td class="auto-style10">
                <asp:Label ID="Label9" runat="server" Text="Productos en bodega."></asp:Label>
            </td>
            <td class="auto-style13">
                <asp:Label ID="Label10" runat="server" Text="Asignaciones pendientes."></asp:Label>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td class="auto-style10">
                <asp:GridView ID="GV_ProductosBodega" runat="server" AutoGenerateColumns="False" DataSourceID="ObjectDataSource4">
                    <Columns>
                        <asp:BoundField DataField="ReferenciaProducto" HeaderText="ReferenciaProducto" SortExpression="ReferenciaProducto" />
                        <asp:BoundField DataField="Cantidad" HeaderText="Cantidad" SortExpression="Cantidad" />
                        <asp:BoundField DataField="Talla" HeaderText="Talla" SortExpression="Talla" />
                        <asp:BoundField DataField="Precio" HeaderText="Precio" SortExpression="Precio" />
                        <asp:BoundField DataField="Idproducto" HeaderText="Idproducto" SortExpression="Idproducto" />
                        <asp:BoundField DataField="Entregado" HeaderText="Entregado" SortExpression="Entregado" />
                    </Columns>
                </asp:GridView>
                <asp:ObjectDataSource ID="ObjectDataSource4" runat="server" SelectMethod="Productos" TypeName="DAOUsuario"></asp:ObjectDataSource>
            </td>
            <td class="auto-style13">
                <asp:GridView ID="GV_Pendiente" runat="server">
                </asp:GridView>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style11"></td>
            <td class="auto-style28">
                <asp:Label ID="Label11" runat="server" Text="Asignar Productos"></asp:Label>
            </td>
            <td class="auto-style14"></td>
            <td class="auto-style11"></td>
        </tr>
        <tr>
            <td class="auto-style11"></td>
            <td class="auto-style12">
                <asp:Label ID="Label4" runat="server" Text="Referencia"></asp:Label>
            </td>
            <td class="auto-style19">
                <asp:DropDownList ID="DL_ReferenciaProducto" runat="server" DataSourceID="ObjectDataSource2" DataTextField="ReferenciaProducto" DataValueField="Idproducto">
                </asp:DropDownList>
                <asp:ObjectDataSource ID="ObjectDataSource2" runat="server" SelectMethod="Productos" TypeName="DAOUsuario"></asp:ObjectDataSource>
            </td>
            <td class="auto-style11"></td>
        </tr>
        <tr>
            <td class="auto-style15"></td>
            <td class="auto-style16">
                <asp:Label ID="Label5" runat="server" Text="Cantidad"></asp:Label>
            </td>
            <td class="auto-style17">
                <asp:TextBox ID="TB_Cantidad" runat="server" TextMode="Number"></asp:TextBox>
            </td>
            <td class="auto-style15"></td>
        </tr>
        <tr>
            <td class="auto-style20"></td>
            <td class="auto-style21">
                <asp:Label ID="Label6" runat="server" Text="Talla"></asp:Label>
            </td>
            <td class="auto-style22">
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
            <td class="auto-style20"></td>
        </tr>
        <tr>
            <td class="auto-style11"></td>
            <td class="auto-style12">
                <asp:Label ID="Label7" runat="server" Text="Sede"></asp:Label>
            </td>
            <td class="auto-style19">
                <asp:DropDownList ID="DL_Sedes" runat="server" DataSourceID="ObjectDataSource1" DataTextField="NombreSede" DataValueField="IdSede">
                </asp:DropDownList>
                <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="Sedes" TypeName="DAOUsuario"></asp:ObjectDataSource>
            </td>
            <td class="auto-style11"></td>
        </tr>
        <tr>
            <td class="auto-style23"></td>
            <td class="auto-style24">&nbsp;</td>
            <td class="auto-style18">
                <asp:Button ID="B_Asignar" runat="server" Text="Asignar" OnClick="B_Asignar_Click" />
            </td>
            <td class="auto-style23"></td>
        </tr>
        <tr>
            <td class="auto-style11"></td>
            <td class="auto-style12">
                <asp:Label ID="Label8" runat="server" Text="Asignaciones"></asp:Label>
            </td>
            <td class="auto-style14"></td>
            <td class="auto-style11"></td>
        </tr>
        <tr>
            <td class="auto-style25">&nbsp;</td>
            <td class="auto-style26">
                <asp:ObjectDataSource ID="ObjectDataSource3" runat="server" SelectMethod="verAsignaciones" TypeName="DAOUsuario"></asp:ObjectDataSource>
                <asp:GridView ID="GV_Asignaciones" runat="server" AllowPaging="True" AutoGenerateColumns="False" BackColor="White" BorderColor="#3366CC" BorderStyle="None" BorderWidth="1px" CellPadding="4" DataSourceID="ObjectDataSource3" OnSelectedIndexChanged="GV_Asignaciones_SelectedIndexChanged" PageSize="5" OnRowCommand="GV_Asignaciones_RowCommand" EmptyDataText="No hay asignaciones.">
                    <Columns>
                        <asp:TemplateField HeaderText="Eliminar" ShowHeader="False">
                            <ItemTemplate>
                                <asp:LinkButton ID="LinkButton1" runat="server" CausesValidation="False" CommandName="Delete" CommandArgument='<%# Bind("idasignacion") %>' Text="Eliminar"></asp:LinkButton>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Referencia">
                            <EditItemTemplate>
                                <asp:TextBox ID="TextBox1" runat="server" Text='<%# Bind("referencia") %>'></asp:TextBox>
                            </EditItemTemplate>
                            <ItemTemplate>
                                <asp:Label ID="Label1" runat="server" Text='<%# Bind("referencia") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Cantidad">
                            <EditItemTemplate>
                                <asp:TextBox ID="TextBox2" runat="server" Text='<%# Bind("cantidad") %>'></asp:TextBox>
                            </EditItemTemplate>
                            <ItemTemplate>
                                <asp:Label ID="Label2" runat="server" Text='<%# Bind("cantidad") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Talla">
                            <EditItemTemplate>
                                <asp:TextBox ID="TextBox3" runat="server" Text='<%# Bind("talla") %>'></asp:TextBox>
                            </EditItemTemplate>
                            <ItemTemplate>
                                <asp:Label ID="Label3" runat="server" Text='<%# Bind("talla") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Sede">
                            <EditItemTemplate>
                                <asp:TextBox ID="TextBox4" runat="server" Text='<%# Bind("sede") %>'></asp:TextBox>
                            </EditItemTemplate>
                            <ItemTemplate>
                                <asp:Label ID="Label4" runat="server" Text='<%# Bind("sede") %>'></asp:Label>
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
            <td class="auto-style27"></td>
            <td class="auto-style25"></td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td class="auto-style10">&nbsp;</td>
            <td class="auto-style13">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td class="auto-style10">&nbsp;</td>
            <td class="auto-style13">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>

</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
</asp:Content>

