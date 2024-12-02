<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminOptions.aspx.cs" Inherits="Telecom_Web_App.AdminOptions" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        <asp:Button ID="Button1" runat="server" OnClick="All_customers_wallets" Text="All customers Wallets" Height="36px" Width="358px" />
        <br />
        <asp:Button ID="Button2" runat="server" OnClick="Customer_Profile_Active_Account" Text="Customer Profiles Active Accounts" Height="36px" Width="358px" />
        </div>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
