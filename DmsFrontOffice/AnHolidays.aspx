<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AnHolidays.aspx.cs" Inherits="AnHolidays" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 212px;
        }
        .auto-style2 {
            margin-top: 0px;
        }
        .auto-style10 {
            position: absolute;
            top: 206px;
            left: 11px;
            z-index: 1;
            height: 19px;
            margin-bottom: 1px;
        }
        </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="auto-style1">
            <br />
            <asp:Label ID="lblId" runat="server" Text="Employee ID"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtId" runat="server"></asp:TextBox>
            &nbsp;&nbsp;
            <asp:Button ID="btnFind" runat="server" OnClick="Button1_Click" Text="Find" Width="82px" />
            <br />
            <asp:Label ID="lblName" runat="server" Text="Employee Name"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="lblDepartment" runat="server" Text="Employee Department "></asp:Label>
            <asp:TextBox ID="txtDepartment" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="lblReason" runat="server" Text="Holiday Reason"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtReason" runat="server" CssClass="auto-style2"></asp:TextBox>
            <br />
            <asp:Label ID="lblStartdate" runat="server" Text="Holiday Start Date"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtStartdate" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="lblEndate" runat="server" Text="Holiday End Date "></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtEndate" runat="server"></asp:TextBox>
            <br />
            <br />
        <asp:Label ID="lblError" runat="server" CssClass="auto-style10"></asp:Label>
            <br />
            <br />
            <asp:Button ID="btnOk" runat="server" Text="Ok" Width="94px" OnClick="btnOk_Click" />
&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnCancel" runat="server" Text="Cancel" Width="96px" />
        </div>
       
    </form>
    </body>
</html>
