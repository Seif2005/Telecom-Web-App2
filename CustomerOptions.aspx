<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CustomerOptions.aspx.cs" Inherits="Telecom_Web_App.CustomerOptions" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="viewBenefits" runat="server" Text="View Active Benefits" OnClick="viewBenefitsClick" />
            <br /><br />

            <asp:Button ID="ticketsNotResolved" runat="server" Text="Tickets Not Resolved" OnClick="ticketsNotResolvedClick" />
            <br /><br />

            <asp:Button ID="highestVoucher" runat="server" Text="Highest Voucher" OnClick="highestVoucherClick" />
            <br /><br />
        </div>
    </form>
</body>
</html>
