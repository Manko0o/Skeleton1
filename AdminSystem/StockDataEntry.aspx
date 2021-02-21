<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StockDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblProductID" runat="server" Text="Product ID" width="83px"></asp:Label>
&nbsp;&nbsp;
            <asp:TextBox ID="txtProductID" runat="server" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
            <br />
            <asp:Label ID="lblBookName" runat="server" Text="Book Name" width="83px"></asp:Label>
&nbsp;&nbsp;
            <asp:TextBox ID="txtBookName" runat="server" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
            <br />
            <asp:Label ID="lblAutorName" runat="server" Text="Author Name"></asp:Label>
&nbsp;&nbsp;
            <asp:TextBox ID="txtAuthorName" runat="server" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
            <br />
            <asp:Label ID="lblPrice" runat="server" Text="Price" width="83px"></asp:Label>
&nbsp;&nbsp;
            <asp:TextBox ID="txtPrice" runat="server" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
            <br />
            <asp:Label ID="lblType" runat="server" Text="Type" width="83px"></asp:Label>
&nbsp;&nbsp;
            <asp:TextBox ID="txtType" runat="server" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
            <br />
            <br />
            <asp:CheckBox ID="chkAvailable" runat="server" Text="Availabe" />
            <br />
            <br />
            <asp:Label ID="lblError" runat="server"></asp:Label>
        </div>
        <p>
            <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" Text="OK" />
&nbsp;
            <asp:Button ID="btnCancel" runat="server" Text="Cancel" />
        </p>
    </form>
</body>
</html>
