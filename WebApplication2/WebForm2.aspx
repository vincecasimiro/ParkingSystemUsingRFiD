<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="WebForm2.aspx.vb" Inherits="WebApplication2.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="width: 428px">
            <asp:TextBox ID="TextBox2" runat="server" Height="279px" TextMode="MultiLine" Width="421px">Username: sample1
Billing Statement

Time in: &quot;0000&quot;
Time Out: &quot;2400&quot;
Total hours: &quot;24hrs&quot;
Total amount: &quot;240.00&quot;

</asp:TextBox>
        </div>
        <p>
            Scan the image below to pay thru paymaya</p>
        <p>
            <asp:Image ID="Image1" runat="server" Height="216px" ImageUrl="~/Image/89722164_1690485734433784_592661162785505280_n.jpg" Width="240px" />
        </p>
    </form>
</body>
</html>
