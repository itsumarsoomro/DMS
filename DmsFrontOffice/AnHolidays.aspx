<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AnHolidays.aspx.cs" Inherits="AnHolidays" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 357px;
            position: absolute;
            top: 234px;
            left: 532px;
            z-index: 1;
            width: 432px;
            
        }
        .auto-style2 {
            margin-top: 0px;
             position: absolute;
            top: 147px;
            left: 193px;
            z-index: 1;
        }
        .auto-style3 {
        position: absolute;
        top: 825px;
        left: 704px;
        z-index: 1;
        width: 74px;
        height: 39px;
        border-radius: 16px;
        }
        .auto-style10 {
            position: absolute;
            top: 251px;
            left: 27px;
            z-index: 1;
            height: 19px;
            margin-bottom: 1px;
        }
        .auto-style11 {
            height: 16px;
            position: absolute;
            top: 113px;
            left: 193px;
            z-index: 1;
        }
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
        .auto-style12 {
            margin-top: 0px;
            position: absolute;
            top: 293px;
            left: 28px;
            z-index: 1;
            height: 30px;
        }
        .auto-style13 {
            margin-top: 0px;
            position: absolute;
            top: 293px;
            left: 294px;
            z-index: 1;
            height: 30px;
        }
        .auto-style14 {
            margin-top: 0px;
            position: absolute;
            top: 214px;
            left: 192px;
            z-index: 1;
            width: 189px;
            height: 24px;
            bottom: 115px;
        }
        .auto-style15 {
            margin-top: 0px;
            position: absolute;
            top: 181px;
            left: 193px;
            z-index: 1;
        }
        .auto-style16 {
            margin-top: 0px;
            position: absolute;
            top: 79px;
            left: 193px;
            z-index: 1;
            width: 179px;
        }
        .auto-style17 {
            margin-top: 0px;
            position: absolute;
            top: 220px;
            left: 24px;
            z-index: 1;
        }
        .auto-style18 {
            margin-top: 0px;
            position: absolute;
            top: 187px;
            left: 25px;
            z-index: 1;
        }
        .auto-style19 {
            margin-top: 0px;
            position: absolute;
            top: 152px;
            left: 26px;
            z-index: 1;
        }
        .auto-style20 {
            margin-top: 0px;
            position: absolute;
            top: 119px;
            left: 25px;
            z-index: 1;
        }
        .auto-style21 {
            margin-top: 0px;
            position: absolute;
            top: 85px;
            left: 26px;
            z-index: 1;
        }
        .auto-style22 {
            margin-top: 0px;
            position: absolute;
            top: 51px;
            left: 27px;
            z-index: 1;
        }
        .auto-style23 {
            margin-top: 0px;
            position: absolute;
            top: 45px;
            left: 301px;
            z-index: 1;
            height: 29px;
        }
        .auto-style24 {
            margin-top: 0px;
            position: absolute;
            top: 45px;
            left: 193px;
            z-index: 1;
            width: 101px;
            right: 134px;
            height: 25px;
        }
        .auto-style25 {
            position: absolute;
            top: 863px;
            left: 655px;
            z-index: 1;
            width: 172px;
            height: 24px;
            border-radius: 16px;
        }
        </style>
        </head>
        <body>

        <form id="form1" runat="server" >

            <div class="head">

                <br />
                <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label1" runat="server" BackColor="#3C424F" Font-Bold="True" Font-Size="XX-Large" ForeColor="#51EC60" Text="DMS"> </asp:Label>

            </div>
            <br/> <br/> <br/> <br/>   
    
            <div class="mb">
            <div class="body">

            </div>
            </div>
    
        <br/> <br/> 
            <br />
            <br/> 
            <br />
            <br/>
        <div class="foot">

        <asp:Label ID="Label2" runat="server" BackColor="#3C424F" Font-Bold="True" Font-Size="XX-Large" ForeColor="#51EC60" Text="DMS" CssClass="auto-style3"></asp:Label>

            <br />
            <asp:Label ID="Label3" runat="server" BackColor="#3C424F" BorderColor="#3C424F" CssClass="auto-style25" Font-Bold="True" ForeColor="White" Text="Copyright © 2022 DMS"></asp:Label>

        </div>

        <div class="auto-style1" style="background-color: silver;">
            <br />
            <asp:Label ID="lblId" runat="server" Text="Employee ID" CssClass="auto-style22" BackColor="Silver"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtId" runat="server" BorderStyle="Solid" CssClass="auto-style24"></asp:TextBox>
            &nbsp;&nbsp;
            <asp:Button ID="btnFind" runat="server" OnClick="Button1_Click" Text="Find" Width="82px" CssClass="auto-style23" />
            <br />
            <asp:Label ID="lblName" runat="server" Text="Employee Name" CssClass="auto-style21" BackColor="Silver"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtName" runat="server" CssClass="auto-style11" BorderStyle="Solid" Height="24px" Width="189px"></asp:TextBox>
            <br />
            <asp:Label ID="lblDepartment" runat="server" Text="Employee Department " CssClass="auto-style20" BackColor="Silver"></asp:Label>
            <asp:TextBox ID="txtDepartment" runat="server" BorderStyle="Solid" CssClass="auto-style16" Height="24px" Width="189px"></asp:TextBox>
            <br />
            <asp:Label ID="lblReason" runat="server" Text="Holiday Reason" CssClass="auto-style19" BackColor="Silver"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtReason" runat="server" CssClass="auto-style2" BorderStyle="Solid" Height="24px" Width="189px"></asp:TextBox>
            <br />
            <asp:Label ID="lblStartdate" runat="server" Text="Holiday Start Date" CssClass="auto-style18" BackColor="Silver"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtStartdate" runat="server" BorderStyle="Solid" CssClass="auto-style15" Height="24px" Width="189px"></asp:TextBox>
            <br />
            <asp:Label ID="lblEndate" runat="server" Text="Holiday End Date " CssClass="auto-style17" BackColor="Silver"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtEndate" runat="server" CssClass="auto-style14" BorderStyle="Solid"></asp:TextBox>
            <br />
            <br />
        <asp:Label ID="lblError" runat="server" CssClass="auto-style10" BackColor="Silver"></asp:Label>
            <br />
            <br />
            <br />
            <asp:Button ID="btnOk" runat="server" Text="Ok" Width="94px" OnClick="btnOk_Click" CssClass="auto-style13" />
&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnCancel" runat="server" Text="Cancel" Width="96px" OnClick="btnCancel_Click" CssClass="auto-style12" />
        </div>
       
    </form>
    </body>
</html>
