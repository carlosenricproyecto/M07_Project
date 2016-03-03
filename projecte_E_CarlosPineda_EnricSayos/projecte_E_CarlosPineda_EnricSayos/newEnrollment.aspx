<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="newEnrollment.aspx.vb" Inherits="projecte_E_CarlosPineda_EnricSayos.newEnrollment" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        DO AN ENROLLMENT<br />
        <br />
        Worker:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        Course:&nbsp;&nbsp;&nbsp;
        <asp:DropDownList ID="DropDownList1" runat="server">
        </asp:DropDownList>
        <br />
        &nbsp;<asp:ListBox ID="ListBox1" runat="server" Height="141px" SelectionMode="Multiple" Width="151px"></asp:ListBox>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button2" runat="server" Text="Add" />
&nbsp;
        <asp:Button ID="Button3" runat="server" Text="Remove" />
&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;
        <asp:ListBox ID="ListBox2" runat="server" Height="134px" SelectionMode="Multiple" Width="152px"></asp:ListBox>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" Text="ENROLL" />
    
    &nbsp;&nbsp;
        <asp:Button ID="Button4" runat="server" Text="Menu" />
    
    </div>
    </form>
</body>
</html>
