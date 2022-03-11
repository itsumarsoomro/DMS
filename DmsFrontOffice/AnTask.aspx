<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AnTask.aspx.cs" Inherits="AnTask" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <p>
            <asp:ListBox ID="ListBoxTask" runat="server" Height="153px" Width="256px"></asp:ListBox>
        </p>
        <p>
            <asp:TextBox ID="TextBoxTaskName" runat="server" style="z-index: 1; left: 96px; top: 217px; position: absolute"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="LabelTaskName" runat="server" style="z-index: 1; left: 13px; top: 218px; position: absolute; height: 22px; width: 85px" Text="Task Name"></asp:Label>
            <asp:TextBox ID="TextBoxTaskID" runat="server" style="z-index: 1; top: 255px; position: absolute; left: 94px"></asp:TextBox>
        </p>
        <asp:Label ID="LabelTaskID" runat="server" style="z-index: 1; left: 18px; top: 257px; position: absolute; width: 61px" Text="TaskID"></asp:Label>
        <p>
            <asp:Button ID="ButtonOk" runat="server" OnClick="ButtonOk_Click" style="z-index: 1; left: 17px; top: 292px; position: absolute; height: 25px; width: 31px; right: 569px" Text="Ok" />
        </p>
        <asp:Button ID="ButtonCncel" runat="server" style="z-index: 1; left: 80px; top: 293px; position: absolute" Text="Cancel" />
    </form>
</body>
</html>
