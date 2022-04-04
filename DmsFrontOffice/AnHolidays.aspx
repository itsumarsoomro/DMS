<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AnHolidays.aspx.cs" Inherits="AnHolidays" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        ::placeholder{
            color: black;
        }
        .auto-style1 {
            height: 357px;
            position: absolute;
            top: 238px;
            left: 515px;
            z-index: 1;
            width: 432px;
            text-align: center;
        }
        .auto-style2 {
            margin-top: 0px;
             position: absolute;
            top: 164px;
            left: 74px;
            z-index: 1;
            width: 280px;
        }
        .auto-style3 {
            position: absolute;
            top: 830px;
            left: 163px;
            z-index: 1;
            width: 74px;
            height: 39px;
            border-radius: 16px;
        }
         .auto-style4 {
            height: 16px;
            position: absolute;
          
            z-index: 1;
            width: 280px;
            left: 73px;
            top: 200px;
        }
        .auto-style10 {
            position: absolute;
            top: 110px;
            left: 471px;
            z-index: 1;
            height: 110px;
            margin-bottom: 1px;
            width: 398px;
        }
        .auto-style11 {
            height: 16px;
            position: absolute;
            top: 93px;
            left: 73px;
            z-index: 1;
            width: 280px;
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
            top: 310px;
            left: 73px;
            z-index: 1;
            height: 30px;
            border-radius: 16px;
        }
        .auto-style13 {
            margin-top: 0px;
            position: absolute;
            top: 310px;
            left: 255px;
            z-index: 1;
            height: 30px;
            border-radius: 16px;
        }
        .auto-style16 {
            margin-top: 0px;
            position: absolute;
            top: 129px;
            left: 73px;
            z-index: 1;
            width: 280px;
        }
        .auto-style23 {
            margin-top: 0px;
            position: absolute;
            top: 59px;
            left: 286px;
            z-index: 1;
            height: 29px;
            width: 74px;
        }
        .auto-style24 {
            margin-top: 0px;
            position: absolute;
            top: 57px;
            left: 73px;
            z-index: 1;
            width: 206px;
            height: 25px;
        }
        .auto-style25 {
            position: absolute;
            top: 868px;
            left: 165px;
            z-index: 1;
            width: 172px;
            height: 24px;
            border-radius: 16px;
        }
        .auto-style26 {
            position: absolute;
            top: 35px;
            left: 163px;
            z-index: 1;
            width: 74px;
            height: 39px;
            border-radius: 16px;
        }
        .auto-style27 {
            margin-top: 0px;
            position: absolute;
            top: -24px;
            left: -13px;
            z-index: 1;
            width: 461px;
            height: 60px;
            border-top-left-radius: 15px;
            border-top-right-radius: 15px;
        }
        .auto-style29 {
            width: 463px;
            height: 400px;
            background-color: silver;
            border-radius: 15px;
            /*margin-left: 39;*/
        }
        .auto-style30 {
            margin-top: 0px;
            position: absolute;
            top: 270px;
            left: 190px;
            z-index: 1;
            width: 164px;
            height: 13px;
            right: 78px;
        }
        .auto-style31 {
            height: 16px;
            position: absolute;
            z-index: 1;
            width: 280px;
            left: 73px;
            top: 236px;
        }
        </style>
        </head>
        <body>

        <form id="form1" runat="server" >

            <div class="head">

                <br />
                <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label1" runat="server" BackColor="#3C424F" Font-Bold="True" Font-Size="XX-Large" ForeColor="#51EC60" Text="DMS" CssClass="auto-style26"></asp:Label>

            </div>
            <br/> <br/> <br/> <br/>   
    
            <div class="mb">
            <div class="auto-style29">

                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;

                <br />

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
            <asp:Label ID="Label4" runat="server" BackColor="#51EC60" BorderColor="#51EC60" CssClass="auto-style27" Font-Bold="True" Font-Size="45px" Text="Holidays Form" ForeColor="White"></asp:Label>
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtId" runat="server" BorderStyle="Solid" CssClass="auto-style24" placeholder="Please enter your ID#" Height="28px" BorderColor="Black" ForeColor="Black" ></asp:TextBox>
            &nbsp;&nbsp;
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtName" runat="server" CssClass="auto-style11" BorderStyle="Solid" Height="28px" placeholder="Please enter your Name" BorderColor="Black" ForeColor="Black"></asp:TextBox>
            <br />
            <asp:TextBox ID="txtDepartment" runat="server" BorderStyle="Solid" CssClass="auto-style16" Height="28px" placeholder="Please enter your department" BorderColor="Black" ForeColor="Black"></asp:TextBox>
            <asp:Button ID="btnFind" runat="server" OnClick="Button1_Click" Text="Find" CssClass="auto-style23" BorderColor="#51EC60" Font-Bold="True" style="border-radius: 16px;"/>
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtReason" runat="server" CssClass="auto-style2" BorderStyle="Solid" Height="28px" placeholder="Please enter holiday reason " BorderColor="Black" ForeColor="Black" ></asp:TextBox>
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <br />
            <br />
        <asp:Label ID="lblError" runat="server" CssClass="auto-style10" BackColor="Silver" Visible="False" style ="border-radius: 10px; " BorderColor="Red" BorderStyle="Solid" ForeColor="Black"></asp:Label>
            <br />
            <br />
            <br />
            <asp:Button ID="btnOk" runat="server" Text="Ok" Width="94px" OnClick="btnOk_Click" CssClass="auto-style13" BorderColor="#51EC60" Font-Bold="True" />
&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnCancel" runat="server" Text="Cancel" Width="96px" OnClick="btnCancel_Click" CssClass="auto-style12" BorderColor="Red" Font-Bold="True" />
            <asp:Label ID="Label5" runat="server" BackColor="Silver" CssClass="auto-style30" Font-Size="Small" Text="i.e 1/1/0001 12:00:00 AM"></asp:Label>
            <asp:TextBox ID="txtStartdate" runat="server" required BorderColor="Black" BorderStyle="Solid" placeholder="Please enter Start Date" CssClass="auto-style4" Height="28px"></asp:TextBox>
            <asp:TextBox ID="txtEndate" runat="server" required BorderColor="Black" BorderStyle="Solid" placeholder="Please enter End Date" CssClass="auto-style31" Height="28px"></asp:TextBox>
        </div>
       
    </form>
    </body>
</html>
