<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ExpensesViewer.aspx.cs" Inherits="ExpensesViewer" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            position: absolute;
            top: 113px;
            left: 9px;
            z-index: 1;
            width: 61px;
            height: 31px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Button ID="btnBack" runat="server" CssClass="auto-style1" OnClick="btnBack_Click" Text="Back" />
    </form>
</body>
</html>
