<%@ Page Language="C#" AutoEventWireup="true" CodeFile="DeleteStock.aspx.cs" Inherits="DeleteStock" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
            Are you sure about deleting this record?<br />
        <br />
&nbsp;<asp:Button ID="btnYes" runat="server" OnClick="btnYes_Click" Text="Yes" />
            &nbsp;
            <asp:Button ID="btnNo" runat="server" Text="No" Width="36px" />
    </form>
</body>
</html>
