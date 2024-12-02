<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Result.aspx.cs" Inherits="Telecom_Web_App.Result" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Query Result</title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:GridView ID="customerGridView" runat="server" AutoGenerateColumns="True">
        </asp:GridView>
    </form>
</body>
</html>
