<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            position: absolute;
            top: 6px;
            left: 182px;
            z-index: 1;
            width: 160px;
            height: 40px;
        }
        .auto-style2 {
            position: absolute;
            top: 86px;
            left: 9px;
            z-index: 1;
            width: 400px;
            height: 92px;
        }
        .auto-style3 {
            position: absolute;
            top: 2px;
            left: 374px;
            z-index: 1;
            width: 153px;
            height: 42px;
            margin-top: 3px;
        }
    </style>
    </head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="btnHoliday" runat="server" Height="40px" Text="Holidays" Width="148px" OnClick="btnHoliday_Click" />
        </div>
        <asp:Button ID="btnExpenses" runat="server" CssClass="auto-style1" OnClick="btnExpenses_Click" Text="Expenses" />
        <asp:Label ID="lblDMS" runat="server" CssClass="auto-style2" Font-Bold="True" Font-Italic="True" Font-Names="Akzidenz-Grotesk Pro ExtraBold" Font-Overline="False" Font-Size="XX-Large" Font-Strikeout="False" Text="Database Management System"></asp:Label>
        <asp:Button ID="btnTask" runat="server" CssClass="auto-style3" OnClick="btnTask_Click" Text="Task" />
    </form>
</body>
</html>
