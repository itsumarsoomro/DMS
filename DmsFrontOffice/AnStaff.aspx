<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AnStaff.aspx.cs" Inherits="Staff" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="Name" runat="server" style="z-index: 1; left: 85px; top: 221px; position: absolute; width: 80px; height: 22px;" Text="Staff Name"></asp:Label>
        <asp:TextBox ID="txtStaffName" runat="server" style="z-index: 1; left: 200px; top: 218px; position: absolute; width: 119px; height: 17px;"></asp:TextBox>
        <asp:Label ID="lblAddress" runat="server" style="z-index: 1; left: 81px; top: 255px; position: absolute; height: 17px; width: 76px" Text="Address"></asp:Label>
        <asp:Label ID="Label2" runat="server" style="z-index: 1; left: 95px; top: 286px; position: absolute; right: 1349px; height: 20px;" Text="StaffID"></asp:Label>
        <asp:Label ID="lblPassword" runat="server" style="z-index: 1; left: 80px; top: 317px; position: absolute; height: 24px" Text="Password"></asp:Label>
        <p>
            <asp:TextBox ID="txtAddress" runat="server" style="z-index: 1; left: 201px; top: 255px; position: absolute; height: 18px;"></asp:TextBox>
        </p>
        <asp:TextBox ID="txtStaffID" runat="server" style="z-index: 1; left: 200px; top: 287px; position: absolute; height: 19px;"></asp:TextBox>
        <asp:TextBox ID="txtPassword" runat="server" style="z-index: 1; left: 201px; top: 324px; position: absolute; height: 15px;"></asp:TextBox>
        <asp:CheckBox ID="Active" runat="server" style="z-index: 1; left: 56px; top: 343px; position: absolute" />
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 62px; top: 379px; position: absolute; height: 18px; width: 55px" Text="lblError"></asp:Label>
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 208px; top: 414px; position: absolute" Text="Cancel" OnClick="btnCancel_Click" />
        <p>
        <asp:Button ID="btnOK" runat="server" style="z-index: 1; left: 125px; top: 415px; position: absolute; height: 24px; width: 41px;" Text="OK" OnClick="btnOK_Click" />
        </p>
        <p>
            <asp:Label ID="lblStaffNumber" runat="server" style="z-index: 1; left: 70px; top: 195px; position: absolute; width: 111px" Text="Staff Number"></asp:Label>
        </p>
        <p>
            &nbsp;</p>
        <asp:Button ID="btnFind" runat="server" OnClick="btnFind_Click" style="z-index: 1; left: 382px; top: 201px; position: absolute; height: 27px" Text="Find" />
        <asp:TextBox ID="txtStaffNo" runat="server" style="z-index: 1; left: 204px; top: 189px; position: absolute"></asp:TextBox>
    </form>
</body>
</html>
