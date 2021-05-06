<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StockList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:ListBox ID="lstStocks" runat="server" Height="335px" Width="392px" OnSelectedIndexChanged="lstStocks_SelectedIndexChanged"></asp:ListBox>
        </div>
        <asp:Button ID="btnAdd" runat="server" Text="Add" OnClick="btnAdd_Click1" />
        <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" Text="Edit" />
        <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" Text="Delete" />
        <br />
        Enter Book Name <asp:TextBox ID="txtFilter" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="btnApply" runat="server" OnClick="btnApply_Click" Text="Apply" />
&nbsp;
        <asp:Button ID="btnClear" runat="server" OnClick="btnClear_Click" Text="Clear" />
        <p>
            <asp:Label ID="lblError" runat="server" Text="lblError"></asp:Label>
        </p>
    </form>
</body>
</html>
