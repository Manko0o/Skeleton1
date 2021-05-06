<%@ Page Language="C#" AutoEventWireup="true" CodeFile="DeleteStaff.aspx.cs" Inherits="DeleteStaff" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblDelete" runat="server" Text="Are you sure you want to delete this record?"></asp:Label>
            <br />
            <br />
            <br />
            <asp:Button ID="btnDeleteYes" runat="server" OnClick="btnDeleteYes_Click" Text="Yes" />
&nbsp;
            <asp:Button ID="btnDeleteNo" runat="server" OnClick="btnDeleteNo_Click" Text="No" />
        </div>
    </form>
</body>
</html>
