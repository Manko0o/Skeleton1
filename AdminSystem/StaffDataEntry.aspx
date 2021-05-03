<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="height: 378px">
            <asp:Label ID="lblStaffID" runat="server" Text="StaffID" width="92px"></asp:Label>
&nbsp;<asp:TextBox ID="txtStaffID" runat="server" Height="22px" TextMode="Number" OnTextChanged="txtStaffID_TextChanged"></asp:TextBox>
            <asp:Button ID="btnFind" runat="server" OnClick="btnFind_Click" Text="Find" />
            <br />
            <br />
            <asp:Label ID="lblName" runat="server" Text="Name" width="92px"></asp:Label>
&nbsp;<asp:TextBox ID="txtName" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="lblSurname" runat="server" Text="Surname" width="92px"></asp:Label>
&nbsp;<asp:TextBox ID="txtSurname" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="lblDob" runat="server" Text="Date of birth" width="92px"></asp:Label>
&nbsp;<asp:TextBox ID="txtDob" runat="server" TextMode="DateTime" OnTextChanged="txtDob_TextChanged"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="lblPhoneNumber" runat="server" Text="Phone Number"></asp:Label>
&nbsp;<asp:TextBox ID="txtPhoneNumber" runat="server"></asp:TextBox>
            <br />
            <br />
&nbsp;<asp:CheckBox ID="chkAvailability" runat="server" Text="Available" />
            <br />
            <br />
            <asp:Label ID="lblError" runat="server"></asp:Label>
            <br />
            <br />
            <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" Text="OK" />
&nbsp;<asp:Button ID="btnCancel" runat="server" Text="Cancel" />
        </div>
    </form>
</body>
</html>
