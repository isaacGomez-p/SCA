<%@ Page Language="C#" AutoEventWireup="true" CodeFile="~/Controller/Login-Rec/GenerarToken.aspx.cs" Inherits="View_GenerarToken" %>

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
                    <td>
                        <asp:Label ID="L_User_Name" runat="server" Text="Digite su User Name: "></asp:Label>
                        <asp:TextBox ID="TB_User_Name" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Button ID="B_Recuperar" runat="server" OnClick="B_Recuperar_Click" Text="Recuperar" />
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="L_Mensaje" runat="server"></asp:Label>
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
