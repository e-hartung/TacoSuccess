<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Checkout.aspx.cs" Inherits="TacoSuccess.Checkout" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <link href="Content/site.css" rel="stylesheet" />
    <script src="Scripts/jquery-1.9.1.min.js"></script>
    <script src="Scripts/bootstrap.min.js"></script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="lblCardholder" runat="server" Text="Cardholder Name"></asp:Label><asp:TextBox ID="txtBxCardholder" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lblCardNumber" runat="server" Text="Card Number"></asp:Label><asp:TextBox ID="txtBxCardNumber" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lblExpirationDate" runat="server" Text="Exp Date"></asp:Label><asp:DropDownList ID="ddlMonth" runat="server"></asp:DropDownList><asp:DropDownList ID="ddlYear" runat="server"></asp:DropDownList>
        <br />
        <asp:Label ID="lblCVV2" runat="server" Text="CVV2"></asp:Label><asp:TextBox ID="txtBxCVV2" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="btnSubmit" runat="server" Text="Submit Order" OnClick="btnSubmit_Click" /><asp:Button ID="btnCart" runat="server" Text="Back to Cart" OnClick="btnCart_Click" />
    </div>
    </form>
</body>
</html>
