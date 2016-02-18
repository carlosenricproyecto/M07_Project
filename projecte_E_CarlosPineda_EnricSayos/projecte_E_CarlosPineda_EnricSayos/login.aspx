<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="login.aspx.vb" Inherits="projecte_E_CarlosPineda_EnricSayos.login1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Overline="True" Font-Underline="True" Text="Login Page"></asp:Label>
    
    </div>
        <asp:Label ID="Label2" runat="server" Text="User:"></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <p>
            <asp:Label ID="Label3" runat="server" Text="Password:"></asp:Label>
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        </p>
        <asp:CheckBox ID="CheckBox1" runat="server" Text="Remember user" />
        <p>
            <asp:Button ID="Button1" runat="server" Text="Button" />
        </p>
    </form>
</body>
</html>
