<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AnExpenses.aspx.cs" Inherits="AnExpenses" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            position: absolute;
            top: 48px;
            left: 11px;
            z-index: 1;
            width: 46px;
            height: 21px;
            right: 1453px;
            margin-top: 3px;
        }
        .auto-style2 {
            position: absolute;
            top: 75px;
            left: 10px;
            z-index: 1;
        }
        .auto-style3 {
            position: absolute;
            top: 100px;
            left: 12px;
            z-index: 1;
        }
        .auto-style4 {
            position: absolute;
            top: 52px;
            left: 90px;
            z-index: 1;
        }
        .auto-style6 {
            position: absolute;
            top: 102px;
            left: 90px;
            z-index: 1;
        }
        .auto-style7 {
            position: absolute;
            top: 76px;
            left: 90px;
            z-index: 1;
            width: 128px;
            height: 17px;
        }
        .auto-style8 {
            position: absolute;
            top: 225px;
            left: 10px;
            z-index: 1;
            width: 61px;
        }
        .auto-style9 {
            position: absolute;
            top: 225px;
            z-index: 1;
            left: 99px;
        }
        .auto-style10 {
            position: absolute;
            top: 176px;
            left: 11px;
            z-index: 1;
            height: 19px;
            margin-bottom: 1px;
        }
        .auto-style11 {
            position: absolute;
            top: 136px;
            left: 8px;
            z-index: 1;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblName" runat="server" CssClass="auto-style1" Text="Name"></asp:Label>
        <asp:Label ID="lblCategory" runat="server" CssClass="auto-style2" Text="Category"></asp:Label>
        <asp:Label ID="lblExpenses" runat="server" CssClass="auto-style3" Text="Expenses"></asp:Label>
        <asp:TextBox ID="txtName" runat="server" CssClass="auto-style4"></asp:TextBox>
        <asp:TextBox ID="txtExpenses" runat="server" CssClass="auto-style6"></asp:TextBox>
        <asp:DropDownList ID="ddlCategory" runat="server" CssClass="auto-style7">
        </asp:DropDownList>
        <asp:Button ID="btnOk" runat="server" CssClass="auto-style8" OnClick="btnOk_Click" Text="Ok" />
        <asp:Button ID="btnCancel" runat="server" CssClass="auto-style9" Text="Cancel" />
        <asp:Label ID="lblError" runat="server" CssClass="auto-style10"></asp:Label>
        <asp:CheckBox ID="chkActive" runat="server" CssClass="auto-style11" Text="Active" />
    </form>
</body>
</html>
