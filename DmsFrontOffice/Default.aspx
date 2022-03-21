<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>DMS</title>
    <style type="text/css">
        .auto-style1 {
            position: absolute;
            top: 334px;
            left: 478px;
            z-index: 1;
            width: 202px;
            height: 47px;
            border-radius: 16px;
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
            top: 331px;
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
            top: 434px;
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
        <br />
        <br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
        <br />
        <br />
    
    <br /> 
        <br />
        <asp:Button ID="btnTask" runat="server" CssClass="auto-style3" OnClick="btnTask_Click" Text="Task" BorderStyle="Solid" Font-Bold="True" Font-Size="Large" Height="47px" />

        <asp:Button ID="btnExpenses" runat="server" CssClass="auto-style1" OnClick="btnExpenses_Click" Text="Expenses" BorderStyle="Solid" Font-Bold="True" Font-Size="Large" />
        <asp:Button ID="btnHolidays" runat="server" Text="Holidays" BorderColor="Black" BorderStyle="Solid" CssClass="auto-style4" Font-Bold="True" OnClick="Button1_Click" Font-Size="Large" Height="47px" />
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

    </div>

    </form>
</body>
</html>
