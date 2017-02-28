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
    <div class="header">
        <asp:Button ID="btnBack" runat="server" OnClick="btnBack_Click" Text="Prev" />
        <asp:Button ID="btnCart" runat="server" Text="Cart" OnClick="btnCart_Click" />
    </div>
    <div class="main">
        <div class="ingredient-build">
            <asp:Image ID="imgEntree" runat="server" /><%-- image source will come from entree table --%>
            <asp:Label ID="lblEntreeName" runat="server" Text="" CssClass="h2"></asp:Label>
            <h3>Ingredients</h3>
            <asp:DataList ID="dlIngredientsBuild" runat="server">
                <ItemTemplate>
                    <asp:TextBox ID="txtBxIngredientQuantity" runat="server" TextMode="Number" Width="40px" Text='<%# Eval("quantity") %>'></asp:TextBox>
                    <%# Eval("ingredientsName") %>
                </ItemTemplate>
            </asp:DataList>
        </div>

        <div class="add-ingredients">
            <h2>Add Additional Items</h2>
            <asp:DataList ID="dlIngredientsAdd" runat="server" RepeatColumns="2">
                <ItemTemplate>
                    <asp:Button ID="btnAddIngredient" runat="server" Text="+" OnClick="btnAddIngredient_Click" />
                    <%# Eval("ingredientsName") %>
                </ItemTemplate>
            </asp:DataList>
            <asp:Button ID="btnCancel" runat="server" Text="Cancel Item" OnClick="btnCancel_Click" CssClass="btn btn-default"/>
            <asp:Button ID="btnAddToCart" runat="server" Text="Add To Cart" OnClick="btnAddToCart_Click" CssClass="btn btn-primary" />
        </div>
    </div>
    </form>
</body>
</html>
