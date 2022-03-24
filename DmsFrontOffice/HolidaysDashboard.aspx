<%@ Page Language="C#" AutoEventWireup="true" CodeFile="HolidaysDashboard.aspx.cs" Inherits="HolidaysDefault" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">

    <title>Holidays Dashboard</title>

     <link  rel="stylesheet" type="text/css" href="HolidaysDefaultStyleSheet.css" />
    <style type="text/css">
        .auto-style1 {
            width: 500px;
            height: 436px;
            background-color: silver;
            border-radius: 15px;
        }
        .auto-style2{
             position: absolute;
            top: 833px;
            left: 211px;
            z-index: 1;
            width: 74px;
            height: 39px;
            border-radius: 16px;
        }
        .auto-style3 {
            position: absolute;
            top: 869px;
            left: 210px;
            z-index: 1;
            width: 179px;
            height: 19px;
            border-radius: 16px;
        }
        .auto-style4 {
            position: absolute;
            top: 43px;
            left: 1261px;
            z-index: 1;
            width: 100px;
            height: 29px;
            border-radius: 16px;
        }
    </style>
</head>
<body>

    <form id="form1" runat="server">
        <%-- layout of the  page --%>
    <div class="head">
        <br />
        <asp:Button ID="Button1" runat="server" CssClass="auto-style4" OnClick="Button1_Click" Text="Logout" BorderColor="#CC3300" Font-Bold="True" />
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label1" runat="server" BackColor="#3C424F" Font-Bold="True" Font-Size="XX-Large" ForeColor="#51EC60" Text="DMS"></asp:Label>
    </div>
   
     <br /> <br /> <br />

    <div class="mb">
    <div class="auto-style1">

    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:ListBox ID="lstHolidays" runat="server" Height="185px" Width="310px" BackColor="White" Font-Bold="True" ForeColor="Black" style=" overflow: scroll;"></asp:ListBox>
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
        <asp:Button ID="btnApplyAll" runat="server" BorderColor="Black" BorderStyle="Solid" Font-Bold="True" Height="28px" Text="Apply All" Width="95px" style="border-radius: 16px;" OnClick="btnApplyAll_Click"/>
&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnDisplayAll" runat="server" BorderColor="Black" BorderStyle="Solid" Font-Bold="True" Height="28px" Text="Display All" Width="95px" style="border-radius: 16px;" OnClick="btnDisplayAll_Click" />
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnAdd" runat="server" BorderColor="#51EC60" BorderStyle="Solid" Font-Bold="True" Height="30px" OnClick="btnAdd_Click" Text="Add +" Width="67px" style="border-radius: 16px;" />
&nbsp;&nbsp;
        <asp:Button ID="btnEdit" runat="server" BorderColor="#FFCC00" BorderStyle="Solid" Font-Bold="True" Height="30px" Text="Edit" Width="67px" OnClick="btnEdit_Click" style="border-radius: 16px;" />
&nbsp;&nbsp;
        <asp:Button ID="btnDelete" runat="server" BorderColor="Red" BorderStyle="Solid" Font-Bold="True" Height="30px" Text="Delete x" Width="67px" OnClick="btnDelete_Click" style="border-radius: 16px;" />

    &nbsp;&nbsp;
        <asp:Button ID="btnHome" runat="server" Font-Bold="True" Height="30px" OnClick="btnHome_Click" Text="Home" Width="72px" style="border-radius: 16px;" BorderColor="#51EC60" />

    </div>
    </div>
    
  <br /> <br /> <br /> 
        <br />
        <br />

<div class="foot">

    <br />
    <asp:Label ID="Label3" runat="server" BackColor="#3C424F" BorderColor="#3C424F" CssClass="auto-style3" Font-Bold="True" ForeColor="White" Text="Copyright © 2022 DMS"></asp:Label>
        <asp:Label ID="Label2" runat="server" BackColor="#3C424F" Font-Bold="True" Font-Size="XX-Large" ForeColor="#51EC60" Text="DMS" BorderColor="#3C424F" CssClass="auto-style2"></asp:Label>

</div>


    </form>


</body>
</html>
