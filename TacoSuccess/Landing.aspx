<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Landing.aspx.cs" Inherits="TacoSuccess.Landing" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <header>
        <asp:ImageButton ID="ibtnCart" runat="server" />
    <form id="formSignIn" runat="server">
        <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
        <asp:TextBox ID="txtPassword" runat="server"></asp:TextBox>
        <asp:Button ID="btnSignIn" runat="server" Text="Sign In" />
        <asp:LinkButton ID="lbtnSignUp" runat="server" OnClick="lbtnSignUp_Click">Sign Up</asp:LinkButton>
        <asp:LinkButton ID="lbtnForgotPassword" runat="server">Forgot Password</asp:LinkButton>
        </form>
    </header>
    <form id="form1" runat="server">
    <div>
        <asp:LinkButton ID="lbtnMainMenu" runat="server" OnClick="Button_Click"><img src="Images/1-CARNE-ASADA-WET-BURRITO-PLATO.png" height="100" width="150"/></asp:LinkButton>
        <p>Main Menu</p>
        <asp:LinkButton ID="lbtnSides" runat="server" OnClick="Button_Click"><img src="Images/Freshly%20Fried%20Tortilla%20Chips.jpg" height="100" width="150"/></asp:LinkButton>
        <p>Sides</p>
        <asp:LinkButton ID="lbtnKidsMenu" runat="server" OnClick="Button_Click"><img src="Images/kidsregulartaco.png" height="100" width="150"/></asp:LinkButton>
        <p>Kid's Menu</p>
        <asp:LinkButton ID="lbtnBeverages" runat="server" OnClick="Button_Click"><img src="Images/fountaindrinks.png" alt="Beverages" height="100" width="150"/></asp:LinkButton>
        <p>Beverages</p>
        <asp:LinkButton ID="lbtnDesserts" runat="server" OnClick="Button_Click"><img src="Images/cinnamonchurros.png" alt="Desserts" height="100" width="150"/></asp:LinkButton>
        <p>Desserts</p>
        
    </div>
    </form>
</body>
</html>
