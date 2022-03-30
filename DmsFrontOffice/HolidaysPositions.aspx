<%@ Page Language="C#" AutoEventWireup="true" CodeFile="HolidaysPositions.aspx.cs" Inherits="HolidaysRole" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>DMS-Roles</title>
    <style>
        * 
        {  
            margin: 0;  
            padding: 0;  
            background-color:#f1f2f4;  
            font-family: 'Arial';  
        }  
        .head{
            height: 100px;
            width: 100%;
            background-color: #3C424F;
        }
        .mb{
            padding: 40px 500px;
        }
        .body{
            width: 500px;
            height: 400px;
            background-color: silver;
            border-radius: 15px;    
        }
        .foot{
            width: 100%;
            height: 200px;
            background-color:#3C424F;
            padding-left: 150px;
            padding-right: 150px;   
        }
        .auto-style1 {
            width: 512px;
            height: 287px;
            background-color: silver;
            border-radius: 15px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <%--Layout of page --%>
    
    <%-- Header Div --%>
    <div class="head" id="  ">

        <br />
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label1" runat="server" BackColor="#3C424F" Font-Bold="True" Font-Size="XX-Large" ForeColor="#51EC60" Text="DMS" CssClass="auto-style1"></asp:Label>

    </div>
    <br/> <br/> 
        <br />
        <br />
        <br />
        <br />
        <br/> <br/>   
    <div class="mb">
    <%-- body Div --%>
    <div class="auto-style1">
        <br />
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label4" runat="server" BackColor="Silver" Font-Bold="True" Font-Size="X-Large" Text="Position"></asp:Label>
        <br />
        <br />
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label5" runat="server" BackColor="Silver" Font-Bold="True" Text="Select your position in the firm from the followoing:"></asp:Label>
        <br />
        <br />
        <br />
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button1" runat="server" Font-Bold="True" Height="36px" OnClick="Button1_Click" Text="Admin" Width="102px" BorderColor="#51EC60" style="border-radius: 16px;" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button2" runat="server" Font-Bold="True" Height="36px" OnClick="Button2_Click" Text="Employee's" Width="102px" BorderColor="#51EC60" style="border-radius: 16px;" />
        </div>
    </div>
    
    <br/> <br/> 
        <br />
        <br />
        <br />
        <br/> 
        <br />
        <br/>
    <%-- Footer Div --%>
    <div class="foot">
        <br />
        <br />
        <br />
        <br />

        <asp:Label ID="Label2" runat="server" BackColor="#3C424F" Font-Bold="True" Font-Size="XX-Large" ForeColor="#51EC60" Text="DMS" CssClass="auto-style3"></asp:Label>

            <br />
            <asp:Label ID="Label3" runat="server" BackColor="#3C424F" BorderColor="#3C424F" CssClass="auto-style25" Font-Bold="True" ForeColor="White" Text="Copyright © 2022 DMS"></asp:Label>

        </div>

    </form>

</body>
</html>
