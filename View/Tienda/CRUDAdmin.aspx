<%@ Page Title="" Language="C#" MasterPageFile="~/View/Tienda/MasterSuperAdmin.master" AutoEventWireup="true" CodeFile="~/Controller/Tienda/CRUDAdmin.aspx.cs" Inherits="View_Tienda_CRUDAdmin" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style11 {
            width: 78px;
        }
        .auto-style12 {
            width: 35px;
        }
        .auto-style13 {
            width: 546px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
    <table class="auto-style1">
        <tr>
            <td class="auto-style11">Cedula:</td>
            <td class="auto-style13">
                <asp:TextBox ID="TB_Cedula" runat="server"></asp:TextBox>
            </td>
            <td class="auto-style12">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style11">Nombre:</td>
            <td class="auto-style13">
                <asp:TextBox ID="TB_Nombre" runat="server"></asp:TextBox>
            </td>
            <td class="auto-style12">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style11">Clave:</td>
            <td class="auto-style13">
                <asp:TextBox ID="TB_Clave" runat="server"></asp:TextBox>
            </td>
            <td class="auto-style12">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style11">Direccion:</td>
            <td class="auto-style13">
                <asp:TextBox ID="TB_Direccion" runat="server"></asp:TextBox>
            </td>
            <td class="auto-style12">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style11">Telefono:</td>
            <td class="auto-style13">
                <asp:TextBox ID="TB_Telefono" runat="server"></asp:TextBox>
            </td>
            <td class="auto-style12">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style11">Sexo:</td>
            <td class="auto-style13">
                <asp:DropDownList ID="D_Sexo" runat="server">
                        <asp:ListItem>Hombre</asp:ListItem>
                        <asp:ListItem>Mujer</asp:ListItem>
                </asp:DropDownList>
            </td>
            <td class="auto-style12">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style11">Sede:</td>
            <td class="auto-style13">
                <asp:DropDownList ID="D_Sedes" runat="server">
                </asp:DropDownList>
            </td>
            <td class="auto-style12">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style11">Correo:</td>
            <td class="auto-style13">
                <asp:TextBox ID="TB_Correo" runat="server"></asp:TextBox>
            </td>
            <td class="auto-style12">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style11">Rol:</td>
            <td class="auto-style13">
                <asp:TextBox ID="TB_Rol" runat="server" Enabled="False"></asp:TextBox>
            </td>
            <td class="auto-style12">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style11">&nbsp;</td>
            <td class="auto-style13">
                <asp:Button ID="B_Agregar" runat="server" OnClick="B_Agregar_Click" Text="Agregar" />
            </td>
            <td class="auto-style12">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style11">&nbsp;</td>
            <td class="auto-style13">
                    &nbsp;</td>
            <td class="auto-style12">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style11">&nbsp;</td>
            <td class="auto-style13">
                    <asp:GridView ID="GV_Productos" runat="server" AllowPaging="false" AutoGenerateColumns="False" BackColor="White" BorderColor="#3366CC" BorderStyle="None" BorderWidth="1px" CellPadding="4" EmptyDataText="No hay productos ingresados." CssClass="auto-style10">
                        <Columns>
                            <asp:TemplateField HeaderText="Cedula">
                                <EditItemTemplate>
                                    <asp:TextBox ID="TextBox1" runat="server" Text='<%# Bind("cedula") %>'></asp:TextBox>
                                </EditItemTemplate>
                                <ItemTemplate>
                                    <asp:Label ID="Label1" runat="server" Text='<%# Bind("cedula") %>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Nombre">
                                <EditItemTemplate>
                                    <asp:TextBox ID="TextBox2" runat="server" Text='<%# Bind("nombre") %>'></asp:TextBox>
                                </EditItemTemplate>
                                <ItemTemplate>
                                    <asp:Label ID="Label2" runat="server" Text='<%# Bind("nombre") %>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Clave">
                                <EditItemTemplate>
                                    <asp:TextBox ID="TextBox3" runat="server" Text='<%# Bind("clave") %>'></asp:TextBox>
                                </EditItemTemplate>
                                <ItemTemplate>
                                    <asp:Label ID="Label3" runat="server" Text='<%# Bind("clave") %>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Direccion">
                                <EditItemTemplate>
                                    <asp:TextBox ID="TextBox4" runat="server" Text='<%# Bind("direccion") %>'></asp:TextBox>
                                </EditItemTemplate>
                                <ItemTemplate>
                                    <asp:Label ID="Label4" runat="server" Text='<%# Bind("direccion") %>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Telefono">
                                <EditItemTemplate>
                                    <asp:TextBox ID="TextBox5" runat="server" Text='<%# Bind("telefono") %>'></asp:TextBox>
                                </EditItemTemplate>
                                <ItemTemplate>
                                    <asp:Label ID="Label5" runat="server" Text='<%# Bind("telefono") %>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Sexo">
                                <EditItemTemplate>
                                    <asp:TextBox ID="TextBox6" runat="server" Text='<%# Bind("sexo") %>'></asp:TextBox>
                                </EditItemTemplate>
                                <ItemTemplate>
                                    <asp:Label ID="Label6" runat="server" Text='<%# Bind("sexo") %>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Sede">
                                <EditItemTemplate>
                                    <asp:TextBox ID="TextBox7" runat="server" Text='<%# Bind("sede") %>'></asp:TextBox>
                                </EditItemTemplate>
                                <ItemTemplate>
                                    <asp:Label ID="Label7" runat="server" Text='<%# Bind("sede") %>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Correo">
                                <EditItemTemplate>
                                    <asp:TextBox ID="TextBox8" runat="server" Text='<%# Bind("correo") %>'></asp:TextBox>
                                </EditItemTemplate>
                                <ItemTemplate>
                                    <asp:Label ID="Label8" runat="server" Text='<%# Bind("correo") %>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Rol">
                                <EditItemTemplate>
                                    <asp:TextBox ID="TextBox9" runat="server" Text='<%# Bind("rol_id") %>'></asp:TextBox>
                                </EditItemTemplate>
                                <ItemTemplate>
                                    <asp:Label ID="Label9" runat="server" Text='<%# Bind("rol_id") %>'></asp:Label>
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
                    <br />
                <asp:ObjectDataSource ID="ObjectDataSource1" runat="server"></asp:ObjectDataSource>
            </td>
            <td class="auto-style12">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style11">&nbsp;</td>
            <td class="auto-style13">&nbsp;</td>
            <td class="auto-style12">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style11">&nbsp;</td>
            <td class="auto-style13">Seleccione una cedula:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:DropDownList ID="DropDownList1" runat="server">
                </asp:DropDownList>
                <br />
                <asp:ObjectDataSource ID="ObjectDataSource2" runat="server"></asp:ObjectDataSource>
            </td>
            <td class="auto-style12">
                <asp:Button ID="B_Seleccionar" runat="server" OnClick="B_Seleccionar_Click" Text="Seleccionar" />
                <br />
                <asp:Button ID="B_Eliminar" runat="server" OnClick="B_Eliminar_Click" Text="Eliminar" />
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style11">Cedula:</td>
            <td class="auto-style13">
                <asp:TextBox ID="TB_Cedula0" runat="server" Enabled="False"></asp:TextBox>
            </td>
            <td class="auto-style12">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style11">Nombre:</td>
            <td class="auto-style13">
                <asp:TextBox ID="TB_Nombre0" runat="server"></asp:TextBox>
            </td>
            <td class="auto-style12">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style11">Clave:</td>
            <td class="auto-style13">
                <asp:TextBox ID="TB_Clave0" runat="server"></asp:TextBox>
            </td>
            <td class="auto-style12">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style11">Direccion</td>
            <td class="auto-style13">
                <asp:TextBox ID="TB_Direccion0" runat="server"></asp:TextBox>
            </td>
            <td class="auto-style12">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style11">Telefono:</td>
            <td class="auto-style13">
                <asp:TextBox ID="TB_Telefono0" runat="server"></asp:TextBox>
            </td>
            <td class="auto-style12">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style11">Sexo</td>
            <td class="auto-style13">
                <asp:DropDownList ID="D_Sexo0" runat="server">
                        <asp:ListItem>Hombre</asp:ListItem>
                        <asp:ListItem>Mujer</asp:ListItem>
                </asp:DropDownList>
            </td>
            <td class="auto-style12">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style11">Sede:</td>
            <td class="auto-style13">
                <asp:DropDownList ID="D_Sedes0" runat="server">
                </asp:DropDownList>
            </td>
            <td class="auto-style12"></td>
            <td></td>
        </tr>
        <tr>
            <td class="auto-style11">Correo</td>
            <td class="auto-style13">
                <asp:TextBox ID="TB_Correo0" runat="server"></asp:TextBox>
            </td>
            <td class="auto-style12">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style11">Rol</td>
            <td class="auto-style13">
                <asp:TextBox ID="TB_Rol0" runat="server" Enabled="False"></asp:TextBox>
            </td>
            <td class="auto-style12">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style11">&nbsp;</td>
            <td class="auto-style13">&nbsp;</td>
            <td class="auto-style12">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style11">&nbsp;</td>
            <td class="auto-style13">
                <asp:Button ID="B_Actualizar" runat="server" Text="Actualizar" OnClick="B_Actualizar_Click" />
            </td>
            <td class="auto-style12">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style11">&nbsp;</td>
            <td class="auto-style13">&nbsp;</td>
            <td class="auto-style12">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style11">
                <asp:Label ID="L_Vendedor" runat="server" Text="Vendedor"></asp:Label>
            </td>
            <td class="auto-style13">&nbsp;</td>
            <td class="auto-style12">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style11">
                <asp:Label ID="L_Sede" runat="server" Text="Sede"></asp:Label>
                <br />
                <asp:Label ID="L_Rol" runat="server" Text="Rol"></asp:Label>
            </td>
            <td class="auto-style13">&nbsp;</td>
            <td class="auto-style12">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
</asp:Content>

