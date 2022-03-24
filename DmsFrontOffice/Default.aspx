<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>DMS-Home</title>
    <style type="text/css">
        .auto-style1 {
            position: absolute;
            top: 359px;
            left: 478px;
            z-index: 1;
            width: 202px;
            height: 47px;
            border-radius: 16px;
            right: 871px;
        }
        .auto-style1:hover{
        color: white;
        background-color: #255BC7;
        border-radius: 22px;
        border-color: white;
        border-style: none;
            
        }
        .auto-style3 {
            position: absolute;
            top: 358px;
            left: 826px;
            z-index: 1;
            width: 195px;
            height: 42px;
            margin-top: 3px;
            border-radius: 16px;
        }
        .auto-style3:hover{
            color: white;
            background-color: #255BC7;
            border-radius: 22px;
            border-color: white;
            border-style: none;
            
        }
        .auto-style4 {
            position: absolute;
            top: 452px;
            left: 651px;
            z-index: 1;
            width: 202px;
            height: 50px;
            border-radius: 16px;
        }
        .auto-style4:hover{
            color: white;
            background-color: #255BC7;
            border-radius: 22px;
            border-color: white;
            border-style: none;            
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
     /*   .body{
        width: 500px;
        height: 400px;
        background-color: black;
        border-radius: 15px;
    
        }*/

        .foot{
        width: 100%;
        height: 200px;
        background-color:#3C424F;
      
        }
        .auto-style5 {
            width: 100%;
            height: 206px;
            background-color: #3C424F;
        }
        .auto-style6 {
            position: absolute;
            top: 823px;
            left: 211px;
            z-index: 1;
            width: 74px;
            height: 39px;
            border-radius: 16px;
        }
        .auto-style7 {
            position: absolute;
            top: 868px;
            left: 212px;
            z-index: 1;
            width: 176px;
            height: 24px;
            border-radius: 16px;
        }
        .auto-style8 {
            position: absolute;
            top: 898px;
            left: 213px;
            z-index: 1;
            width: 62px;
            height: 21px;
            border-radius: 16px;
        }
        .auto-style9 {
            position: absolute;
            top: 898px;
            left: 308px;
            z-index: 1;
            width: 38px;
            height: 21px;
            border-radius: 16px;
        }
        .auto-style10 {
            position: absolute;
            top: 899px;
            left: 373px;
            z-index: 1;
            width: 62px;
            height: 21px;
            border-radius: 16px;
        }
        .auto-style11 {
            position: absolute;
            top: 275px;
            left: 477px;
            z-index: 1;
            width: 202px;
            height: 47px;
            border-radius: 16px;
            right: 872px;
        }
        .auto-style11:hover{
            color: white;
            background-color: #255BC7;
            border-radius: 22px;
            border-color: white;
            border-style: none;            
        }
        .auto-style12 {
            position: absolute;
            top: 276px;
            left: 822px;
            z-index: 1;
            width: 202px;
            height: 47px;
            border-radius: 16px;
        }
        .auto-style12:hover{
            color: white;
            background-color: #255BC7;
            border-radius: 22px;
            border-color: white;
            border-style: none;            
        }
    </style>
    </head>
<body>
    
    <form id="form1" runat="server">
    
        
    
    <div class="head">

        <br />
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label1" runat="server" BackColor="#3C424F" Font-Bold="True" Font-Size="XX-Large" ForeColor="#51EC60" Text="DMS"></asp:Label>

    </div>
    <br/> <br/> <br/> 
        <br />
        <br/>   
    
        
    
        <br />
      
        <br />
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" BorderColor="Black" CssClass="auto-style11" Font-Bold="True" Font-Size="Large" Text="News" />
        <br />
        <asp:Button ID="Button2" runat="server" BorderColor="Black" CssClass="auto-style12" Font-Bold="True" Font-Size="Large" Text="Staff" />
        <br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
        <br />
        <br />
    
    <br /> 
        <br />
        <asp:Button ID="btnTask" runat="server" CssClass="auto-style3" OnClick="btnTask_Click" Text="Task" Font-Bold="True" Font-Size="Large" Height="47px" BorderColor="Black" />

        <asp:Button ID="btnExpenses" runat="server" CssClass="auto-style1" OnClick="btnExpenses_Click" Text="Expenses" Font-Bold="True" Font-Size="Large" BorderColor="Black" />
        <asp:Button ID="btnHolidays" runat="server" Text="Holidays" BorderColor="Black" CssClass="auto-style4" Font-Bold="True" OnClick="Button1_Click" Font-Size="Large" Height="47px" />
        <br />
        <br />
        <br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
        <br />
        <br/> 
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br/> 
        <br />
        <br/>
    <div class="auto-style5">

        <asp:Label ID="Label2" runat="server" BackColor="#3C424F" Font-Bold="True" Font-Size="XX-Large" ForeColor="#51EC60" Text="DMS" BorderColor="#3C424F" CssClass="auto-style6"></asp:Label>

        <asp:Label ID="Label3" runat="server" BackColor="#3C424F" BorderColor="#3C424F" CssClass="auto-style7" Font-Bold="True" ForeColor="White" Text="Copyright © 2022 DMS"></asp:Label>
        <asp:HyperLink ID="hlinkHolidays" runat="server" BackColor="#3C424F" CssClass="auto-style8" Font-Bold="True" ForeColor="White" NavigateUrl="~/HolidaysDefault.aspx">Holidays</asp:HyperLink>
        <asp:HyperLink ID="hlnkExpenses" runat="server" BackColor="#3C424F" CssClass="auto-style10" Font-Bold="True" ForeColor="White" NavigateUrl="~/ExpensesDefault.aspx">Expenses</asp:HyperLink>
        <asp:HyperLink ID="HyperLink2" runat="server" BackColor="#3C424F" CssClass="auto-style9" Font-Bold="True" ForeColor="White" NavigateUrl="~/AnTask.aspx">Task</asp:HyperLink>

    </div>

    </form>
</body>
</html>
