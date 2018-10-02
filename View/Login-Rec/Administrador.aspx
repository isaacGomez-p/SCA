<%@ Page Language="C#" AutoEventWireup="true" CodeFile="~/Controller/Login-Rec/Administrador.aspx.cs" Inherits="View_Administrador" %>

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
            text-align: right;
        }
        .auto-style3 {
            height: 17px;
        }
        .auto-style4 {
            text-align: right;
            height: 17px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style1">
                <tr>
                    <td>
                        <asp:Label ID="L_Nombre" runat="server"></asp:Label>
                        <asp:Calendar ID="C_dia" runat="server"></asp:Calendar>
                    </td>
                    <td class="auto-style2">
                        <asp:Button ID="B_Cierre" runat="server" OnClick="B_Cierre_Click" Text="Cerrar Session" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3" colspan="2">
                        <asp:TextBox ID="TB_Consultar" runat="server" AutoPostBack="True"></asp:TextBox>
                        <asp:Button ID="B_Consultar" runat="server" OnClick="B_Consultar_Click" Text="Consultar" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3" colspan="2">
                        <asp:GridView ID="GV_Usuarios" runat="server" AllowSorting="True" CellPadding="4" DataKeyNames="id" DataSourceID="ODS_ObtenerUsuarios" EmptyDataText="No hay Registros" ForeColor="#333333" GridLines="None" OnRowEditing="GV_Usuarios_RowEditing" OnRowUpdating="GV_Usuarios_RowUpdating" OnSelectedIndexChanged="GV_Usuarios_SelectedIndexChanged">
                            <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                            <Columns>
                                <asp:CommandField ShowEditButton="True" />
                            </Columns>
                            <EditRowStyle BackColor="#999999" />
                            <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                            <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                            <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                            <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                            <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                            <SortedAscendingCellStyle BackColor="#E9E7E2" />
                            <SortedAscendingHeaderStyle BackColor="#506C8C" />
                            <SortedDescendingCellStyle BackColor="#FFFDF8" />
                            <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
                        </asp:GridView>
                        <asp:ObjectDataSource ID="ODS_ObtenerUsuarios" runat="server" SelectMethod="obtenerUsuarios" TypeName="DAOUsuario">
                            <SelectParameters>
                                <asp:ControlParameter ControlID="TB_Consultar" DefaultValue="" Name="filtro" PropertyName="Text" Type="String" />
                            </SelectParameters>
                        </asp:ObjectDataSource>
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
