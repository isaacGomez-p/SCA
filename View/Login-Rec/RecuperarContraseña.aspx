<%@ Page Language="C#" AutoEventWireup="true" CodeFile="~/Controller/Login-Rec/RecuperarContraseña.aspx.cs" Inherits="View_RecuperarContraseña" %>

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
                        <asp:Label ID="L_Contraseña" runat="server" Text="Digite su nueva contaseña: "></asp:Label>
                        <asp:TextBox ID="Tb_Contraseña" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="L_Repetir" runat="server" Text="Repita su nueva contraseña: "></asp:Label>
                        <asp:TextBox ID="TB_Repetir" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Button ID="B_Cambiar" runat="server" OnClick="B_Cambiar_Click" Text="Cambiar" />
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
