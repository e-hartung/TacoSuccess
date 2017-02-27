<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Landing.aspx.cs" Inherits="TacoSuccess.Landing" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    
    <form id="form1" runat="server">
    <div>
        <asp:LinkButton ID="lbtnMainMenu" runat="server" PostBackUrl="~/Products.aspx?category=1"><img src="Images/1-CARNE-ASADA-WET-BURRITO-PLATO.png" height="100" width="150"/></asp:LinkButton>
        <p>Main Menu</p>
        <asp:LinkButton ID="lbtnSides" runat="server" ><img src="Images/Freshly%20Fried%20Tortilla%20Chips.jpg" height="100" width="150"/></asp:LinkButton>
        <p>Sides</p>
        <asp:LinkButton ID="lbtnKidsMenu" runat="server" PostBackUrl="~/Products.aspx?category=4"><img src="Images/kidsregulartaco.png" height="100" width="150"/></asp:LinkButton>
        <p>Kid's Menu</p>
        <asp:LinkButton ID="lbtnBeverages" runat="server" PostBackUrl="~/Products.aspx?category=2"><img src="Images/fountaindrinks.png" alt="Beverages" height="100" width="150"/></asp:LinkButton>
        <p>Beverages</p>
        <asp:LinkButton ID="lbtnDesserts" runat="server" PostBackUrl="~/Products.aspx?category=3"><img src="Images/cinnamonchurros.png" alt="Desserts" height="100" width="150"/></asp:LinkButton>
        <p>Desserts</p>
        
    </div>
    </form>
</body>
</html>
