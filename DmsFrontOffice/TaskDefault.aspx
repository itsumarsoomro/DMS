<%@ Page Language="C#" AutoEventWireup="true" CodeFile="TaskDefault.aspx.cs" Inherits="TaskDefault" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:ListBox ID="ListBoxTask" runat="server" style="z-index: 1; left: 7px; top: 71px; position: absolute; height: 157px; width: 183px"></asp:ListBox>
        <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 11px; top: 243px; position: absolute; height: 18px; width: 142px" Text="Please Enter Task ID"></asp:Label>
        <asp:Button ID="ButtonApply" runat="server" style="z-index: 1; left: 12px; top: 319px; position: absolute" Text="Apply " />
        <asp:TextBox ID="TextBoxTaskID" runat="server" style="z-index: 1; left: 15px; top: 269px; position: absolute"></asp:TextBox>
        <asp:Button ID="ButtonDisplayALL" runat="server" style="z-index: 1; left: 115px; top: 317px; position: absolute" Text="Display All" />
        <asp:Button ID="ButtonAdd" runat="server" OnClick="ButtonAdd_Click" style="z-index: 1; left: 16px; top: 368px; position: absolute; height: 26px; width: 37px;" Text="Add" />
        <asp:Button ID="ButtonEdit" runat="server" style="z-index: 1; left: 75px; top: 367px; position: absolute" Text="Edit" OnClick="ButtonEdit_Click" />
        <asp:Button ID="ButtonDelete" runat="server" style="z-index: 1; left: 134px; top: 367px; position: absolute" Text="Delete" OnClick="ButtonDelete_Click" />
        <asp:Label ID="LabelError" runat="server" style="z-index: 1; left: 28px; top: 424px; position: absolute" Text="lblError"></asp:Label>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
