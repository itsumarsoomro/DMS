<%@ Page Language="C#" AutoEventWireup="true" CodeFile="HolidaysDefault.aspx.cs" Inherits="HolidaysDefault" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">

    <title></title>

     <link  rel="stylesheet" type="text/css" href="HolidaysDefaultStyleSheet.css" />
    <style type="text/css">
        .auto-style1 {
            width: 500px;
            height: 436px;
            background-color: silver;
            border-radius: 15px;
        }
    </style>
</head>
<body>

    <form id="form1" runat="server">
    <%-- layout of the  page --%>
    <div class="head">
    </div>
   
     <br /> <br /> <br />

    <div class="mb">
    <div class="auto-style1">

    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:ListBox ID="ListBoxHolidays" runat="server" Height="185px" Width="310px"></asp:ListBox>
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="lblError" runat="server" BackColor="Silver" Text="[lblError]"></asp:Label>
        <br />
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="lblEmpID" runat="server" BackColor="Silver" Font-Bold="True" Text="Please Enter Employee ID#"></asp:Label>
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtboxEmpID" runat="server" Height="24px" Width="181px"></asp:TextBox>
        <br />
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnApplyAll" runat="server" BorderColor="Black" BorderStyle="Solid" Font-Bold="True" Height="28px" Text="Apply All" Width="95px" />
&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnDisplayAll" runat="server" BorderColor="Black" BorderStyle="Solid" Font-Bold="True" Height="28px" Text="Display All" Width="95px" />
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnAdd" runat="server" BorderColor="Black" BorderStyle="Solid" Font-Bold="True" Height="30px" OnClick="btnAdd_Click" Text="Add +" Width="67px" />
&nbsp;&nbsp;
        <asp:Button ID="btnEdit" runat="server" BorderColor="Black" BorderStyle="Solid" Font-Bold="True" Height="30px" Text="Edit" Width="67px" />
&nbsp;&nbsp;
        <asp:Button ID="btnDelete" runat="server" BorderColor="Black" BorderStyle="Solid" Font-Bold="True" Height="30px" Text="Delete x" Width="67px" />

    </div>
    </div>
    
  <br /> <br /> <br /> <br /> <br /> <br />

<div class="foot">

</div>


    </form>


</body>
</html>
