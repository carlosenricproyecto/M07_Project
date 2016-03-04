<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="newCourse.aspx.vb" Inherits="projecte_E_CarlosPineda_EnricSayos.newCourse" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        ENLIST COURSE&nbsp;&nbsp;&nbsp;
        <br />
        <br />
        Name:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <br />
        <br />
        Duration(Hours):&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <br />
        <br />
        Theme:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:DropDownList ID="DropDownList1" runat="server">
            <asp:ListItem>Computer Science</asp:ListItem>
            <asp:ListItem>Manual</asp:ListItem>
            <asp:ListItem>Others</asp:ListItem>
        </asp:DropDownList>
        <br />
        <br />
        Type:<br />
        <br />
        <asp:RadioButtonList ID="RadioButtonList1" runat="server">
            <asp:ListItem>extension</asp:ListItem>
            <asp:ListItem>retraining</asp:ListItem>
        </asp:RadioButtonList>
        <br />
        <br />
        Start date:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<br />
        &nbsp;<asp:Calendar ID="Calendar1" runat="server"></asp:Calendar>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
        <br />
        End date:&nbsp;<br />
        <asp:Calendar ID="Calendar2" runat="server"></asp:Calendar>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" Text="INSERT" />
    
    &nbsp;&nbsp;
        <asp:Button ID="Button2" runat="server" Text="Menu" />
    
    </div>
    </form>
</body>
</html>
