<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Cart.aspx.cs" Inherits="TacoSuccess.Cart" %>

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
        <asp:DataList ID="DataList1" runat="server">
            <ItemTemplate>
                <asp:Image ID="imgProduct" runat="server" />
                <asp:Label ID="lblProduct" runat="server"></asp:Label>
                <asp:BulletedList ID="bltLstExtras" runat="server"></asp:BulletedList>
                <asp:Button ID="btnEdit" runat="server" Text="Edit" />
                <asp:Button ID="btnDelete" runat="server" Text="Delete" />
            </ItemTemplate>
        </asp:DataList>
        <asp:Button ID="btnPlaceOrder" runat="server" Text="Place Order" OnClick="btnPlaceOrder_Click" />
        <asp:Button ID="btnStartOver" runat="server" Text="Start Over" OnClick="btnStartOver_Click" />
    </div>
    </form>
</body>
</html>
