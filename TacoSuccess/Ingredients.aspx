<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ingredients.aspx.cs" Inherits="TacoSuccess.Ingredients" %>

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
    
        <asp:Button ID="btnBack" runat="server" OnClick="btnBack_Click" Text="Back" />
        <%-- change "checkout" button to say "cart" instead? --%>
        <asp:Button ID="btnCheckout" runat="server" OnClick="btnCheckout_Click" Text="Checkout" />
        <br />
    
    </div>
    </form>
</body>
</html>
