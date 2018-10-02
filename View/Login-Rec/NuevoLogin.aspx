<%@ Page Language="C#" AutoEventWireup="true" CodeFile="~/Controller/Login-Rec/NuevoLogin.aspx.cs" Inherits="View_NuevoLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Ingrese Cedula:<asp:TextBox ID="TB_Cedula" runat="server"></asp:TextBox>
            <br />
            Ingrese Contraseña:<asp:TextBox ID="TB_Clave" runat="server"></asp:TextBox>
            <br />
            <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click">Olvide la contraseña</asp:LinkButton>
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="B_Login_Click" Text="Ingresar" />
            <br />
            <asp:Label ID="L_Aviso" runat="server" Text="..."></asp:Label>
        </div>
    </form>
</body>
</html>
