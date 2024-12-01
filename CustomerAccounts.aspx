<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CustomerAccounts.aspx.cs" Inherits="Telecom_Web_App.CustomerAccounts" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <title>Customer Accounts Preview</title>
</head>
<body>
    <form id="form2" runat="server">
        <h1>Customer Accounts Preview</h1>
        <asp:GridView ID="customerGridView" runat="server" AutoGenerateColumns="True">
        </asp:GridView>
    </form>
</body>
</html>