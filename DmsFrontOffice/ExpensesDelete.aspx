<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ExpensesDelete.aspx.cs" Inherits="ExpensesDelete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            position: absolute;
            top: 34px;
            left: 10px;
            z-index: 1;
            width: 289px;
        }
        .auto-style2 {
            position: absolute;
            top: 82px;
            left: 8px;
            z-index: 1;
            width: 69px;
            height: 31px;
        }
        .auto-style3 {
            position: absolute;
            top: 82px;
            left: 96px;
            z-index: 1;
            width: 66px;
            height: 33px;
            margin-top: 0px;
        }
        .auto-style4 {
            position: absolute;
            top: 122px;
            left: 9px;
            z-index: 1;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblDeleteExpenses" runat="server" CssClass="auto-style1" Text="Are you sure you want to delete this expenses?"></asp:Label>
        <asp:Button ID="btnYes" runat="server" CssClass="auto-style2" OnClick="btnYes_Click" Text="Yes" />
        <asp:Button ID="btnNo" runat="server" CssClass="auto-style3" Text="No" OnClick="btnNo_Click" />
        <asp:Label ID="lblError" runat="server" CssClass="auto-style4"></asp:Label>
    </form>
</body>
</html>
