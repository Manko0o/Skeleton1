<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StockList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:ListBox ID="lstStocks" runat="server" Height="173px" Width="190px"></asp:ListBox>
        </div>
        <asp:Button ID="btnAdd" runat="server" Text="Add" />
    </form>
</body>
</html>
