<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:ListBox ID="lstCustomer" runat="server" Height="326px" OnSelectedIndexChanged="ListBox1_SelectedIndexChanged" Width="377px"></asp:ListBox>
        </div>
    </form>
</body>
</html>
