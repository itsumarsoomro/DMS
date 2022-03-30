<%@ Page Language="C#" AutoEventWireup="true" CodeFile="TaskDelete.aspx.cs" Inherits="TaskDelete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 14px; top: 49px; position: absolute; width: 273px" Text="Are you sure you want to delete this Task?"></asp:Label>
        <asp:Button ID="ButtonNo" runat="server" style="z-index: 1; left: 82px; top: 92px; position: absolute; width: 35px" Text="No" />
        <asp:Button ID="ButtonYes" runat="server" style="z-index: 1; top: 88px; position: absolute; left: 17px" Text="Yes" OnClick="Button2_Click" />
    </form>
</body>
</html>
