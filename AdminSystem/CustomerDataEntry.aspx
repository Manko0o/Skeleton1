<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblCustomerNo" runat="server" Text="Customer Number"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtCustomerNo" runat="server"></asp:TextBox>
        <asp:Button ID="btnFind" runat="server" OnClick="btnFind_Click" Text="Find" />
        <p>
            <asp:Label ID="lblName" runat="server" Text="Name" width="113px"></asp:Label>
&nbsp;<asp:TextBox ID="txtName" runat="server"></asp:TextBox>
        </p>
        <asp:Label ID="lblEmail" runat="server" Text="Email" width="113px"></asp:Label>
        &nbsp;<asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
        <p>
            <asp:Label ID="lblDOB" runat="server" Text="Date Of Birth" width="113px"></asp:Label>
&nbsp;<asp:TextBox ID="txtDOB" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="lblAddress" runat="server" Text="Address" width="113px"></asp:Label>
&nbsp;<asp:TextBox ID="txtAddress" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:CheckBox ID="chkRegistered" runat="server" Text="Registered" width="113px" />
        </p>
        <asp:Label ID="lblerror" runat="server"></asp:Label>
        <p>
            <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" Text="OK" />
&nbsp;&nbsp;
            <asp:Button ID="btnCancel" runat="server" Text="Cancel" />
        </p>
    </form>
</body>
</html>
