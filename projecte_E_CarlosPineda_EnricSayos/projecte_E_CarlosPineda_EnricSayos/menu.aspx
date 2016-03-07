<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="menu.aspx.vb" Inherits="projecte_E_CarlosPineda_EnricSayos.menu" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Button ID="Button1" runat="server" Text="New Worker" />
        <br />
        <br />
        <asp:Button ID="Button2" runat="server" Text="New Course" />
        <br />
        <br />
        <asp:Button ID="Button3" runat="server" Text="New Enrollment" Width="105px" />
        <br />
        <br />
        <asp:Button ID="Button4" runat="server" Text="All Workers" Width="106px" />
        <br />
        <br />
        <asp:Button ID="Button5" runat="server" Text="All Courses" Width="106px" />
    
        <br />
        <br />
        <asp:Button ID="Button6" runat="server" Text="All Enrollments" Width="105px" />
    
    </div>
    </form>
</body>
</html>
