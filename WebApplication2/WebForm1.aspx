<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="WebForm1.aspx.vb" Inherits="WebApplication2.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <p>
            <asp:TextBox ID="TextBox2" runat="server">Enter Username</asp:TextBox>
        </p>
        <asp:TextBox ID="TextBox1" runat="server" TextMode="Password">Enter Password</asp:TextBox>
        <p>
            <asp:Button ID="Button1" runat="server" Text="View my Bill" />
        </p>
    </form>
</body>
</html>
