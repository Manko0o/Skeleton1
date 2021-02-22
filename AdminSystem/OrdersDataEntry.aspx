<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrdersDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    This is the order entry page
        <p>
            <asp:Label ID="lblOrderNo" runat="server" Text="Order No."></asp:Label>
            <asp:TextBox ID="txtOrderNo" runat="server" OnTextChanged="txtOrderNo_TextChanged"></asp:TextBox>
        </p>
        <asp:Label ID="lblBookName" runat="server" Text="Book Name" width="81px"></asp:Label>
        <asp:TextBox ID="txtBookName" runat="server"></asp:TextBox>
        <p>
            <asp:Label ID="lblQuantity" runat="server" Text="Quantity" width="81px"></asp:Label>
            <asp:TextBox ID="txtQuantity" runat="server"></asp:TextBox>
        </p>
        <asp:Label ID="lblOrderDate" runat="server" Text="Order Date" width="81px"></asp:Label>
        <asp:TextBox ID="txtOrderDate" runat="server"></asp:TextBox>
        <p>
            <asp:Label ID="lblPrice" runat="server" Text="Price" width="81px"></asp:Label>
            <asp:TextBox ID="txtPrice" runat="server"></asp:TextBox>
        </p>
        <asp:CheckBox ID="chkDispatched" runat="server" Text="Dispatched" />
        <p>
            <asp:Label ID="lblError" runat="server"></asp:Label>
        </p>
        <asp:Button ID="btnOk" runat="server" OnClick="btnOk_Click" Text="OK" />
        <asp:Button ID="btnCancel" runat="server" Text="Cancel" />
    </form>
</body>
</html>
