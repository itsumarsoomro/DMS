<%@ Page Language="C#" AutoEventWireup="true" CodeFile="HolidaysDelete.aspx.cs" Inherits="HolidaysDelete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Delete Confirmation</title>
     <link  rel="stylesheet" type="text/css" href="HolidaysDeleteStyleSheet.css" />
<style>
      .auto-style3 {
            position: absolute;
            top: 819px;
            left: 691px;
            z-index: 1;
            width: 74px;
            height: 36px;
            border-radius: 16px;
        }
    .auto-style4 {
        position: absolute;
        top: 860px;
        left: 641px;
        z-index: 1;
        width: 172px;
        height: 19px;
        border-radius: 16px;
    }
    </style>
</head>
<body>
    <%-- Layout of the page --%>

    <form id="form1" runat="server">
        
     <div class="head">

         <br />
         <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label1" runat="server" BackColor="#3C424F" Font-Bold="True" Font-Size="XX-Large" ForeColor="#51EC60" Text="DMS "></asp:Label>

    </div>
    <br /> <br /> <br/> <br/>  <br/>  <br/>  <br/>
    <div class="mb">
    <div class="body">

        <br />
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="lblDelete" runat="server" BackColor="Silver" Font-Bold="True" Font-Size="Larger" Text="Delete"></asp:Label>
        <br />
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="lblMsgDelete" runat="server" BackColor="Silver" Font-Bold="True" Font-Size="Large" Text="Are you sure you want to delete this Holiday?"></asp:Label>
        <br />
        <br />
        <br />
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnCancel" runat="server" Font-Bold="True" Font-Size="Medium" Height="35px" OnClick="btnCancel_Click" Text="Cancel" Width="90px" />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Button ID="btnDelete" runat="server" Font-Bold="True" Font-Size="Medium" Height="35px" OnClick="btnDelete_Click" Text="Delete" Width="90px" />

    </div>
    </div>
    
<br/> <br/> <br/> <br/>  <br/>  <br/> <br/>   
        <br />
        <br/>    
    
    
<div class="foot">

        <asp:Label ID="Label2" runat="server" BackColor="#3C424F" Font-Bold="True" Font-Size="XX-Large" ForeColor="#51EC60" Text="DMS " CssClass="auto-style3"></asp:Label>

    <br />
            <asp:Label ID="Label3" runat="server" BackColor="#3C424F" BorderColor="#3C424F" CssClass="auto-style4" Font-Bold="True" ForeColor="White" Text="Copyright © 2022 DMS"></asp:Label>

</div>

    </form>
</body>
</html>
