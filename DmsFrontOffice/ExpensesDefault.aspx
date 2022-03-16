<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ExpensesDefault.aspx.cs" Inherits="ExpensesDefault" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            position: absolute;
            top: 84px;
            left: 10px;
            z-index: 1;
            width: 256px;
            height: 200px;
            bottom: 390px;
        }
        .auto-style2 {
            position: absolute;
            top: 310px;
            left: 11px;
            z-index: 1;
            width: 190px;
            height: 20px;
        }
        .auto-style3 {
            position: absolute;
            top: 333px;
            left: 10px;
            z-index: 1;
            width: 163px;
        }
        .auto-style7 {
            position: absolute;
            top: 374px;
            left: 10px;
            z-index: 1;
            width: 112px;
            right: 1388px;
        }
        .auto-style8 {
            position: absolute;
            top: 373px;
            left: 141px;
            z-index: 1;
            width: 109px;
        }
        .auto-style9 {
            position: absolute;
            top: 425px;
            left: 11px;
            z-index: 1;
            width: 56px;
            right: 1443px;
        }
        .auto-style10 {
            position: absolute;
            top: 424px;
            left: 98px;
            z-index: 1;
            width: 62px;
            right: 1350px;
        }
        .auto-style11 {
            position: absolute;
            top: 425px;
            left: 188px;
            z-index: 1;
            width: 60px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:ListBox ID="lstCategory" runat="server" CssClass="auto-style1"></asp:ListBox>
        <asp:Label ID="lblPleaseEnterACategory" runat="server" CssClass="auto-style2" Text="Please Enter a Category"></asp:Label>
        <asp:TextBox ID="txtCategory" runat="server" CssClass="auto-style3"></asp:TextBox>
        <p>
            &nbsp;</p>
        <asp:Button ID="btnApply" runat="server" CssClass="auto-style7" Text="Apply" />
        <asp:Button ID="btnDisplayAll" runat="server" CssClass="auto-style8" Text="Display All" />
        <asp:Button ID="btnAdd" runat="server" CssClass="auto-style9" Text="Add" />
        <asp:Button ID="btnEdit" runat="server" CssClass="auto-style10" Text="Edit" />
        <asp:Button ID="btnDelete" runat="server" CssClass="auto-style11" Text="Delete" />
    </form>
</body>
</html>
