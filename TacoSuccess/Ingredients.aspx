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
        <asp:Label ID="lblEntreeNameHeader" runat="server" Text="" CssClass="h2"></asp:Label>
        <asp:Button ID="btnBack" runat="server" OnClick="btnBack_Click" Text="Prev" />
        <asp:Button ID="btnCart" runat="server" Text="Cart" OnClick="btnCart_Click" />
    </div>
    <div class="main">
        <div class="ingredient-build">
            <asp:Image ID="imgEntree" runat="server" Width="250px" />
            <asp:Label ID="lblEntreeName" runat="server" Text="" CssClass="h2"></asp:Label>
            <h3>Ingredients</h3>
            <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
            <asp:UpdatePanel ID="upIngredients" runat="server">
                <ContentTemplate>
                    <asp:DataList ID="dlIngredientsBuild" runat="server">

                        <ItemTemplate>
                            <asp:TextBox ID="txtBxQuantity" runat="server" Width="40" Text='<%# Eval("quantity") %>'></asp:TextBox>
                            <asp:Label ID="lblIngredientName" runat="server" Text='<%# Eval("ingredientsName") %>'></asp:Label>
                        </ItemTemplate>

                    </asp:DataList>
                </ContentTemplate>
            </asp:UpdatePanel>
        </div>

        <div class="add-ingredients">
            <h2>Add Additional Items</h2>
            <asp:UpdatePanel ID="upAdd" runat="server">
                <ContentTemplate>
                    <asp:DataList ID="dlIngredientsAdd" runat="server" RepeatColumns="2">

                        <ItemTemplate>
                            <asp:Button ID="btnAddIngredient" runat="server" Text="+" OnClick="btnAddIngredient_Click" CausesValidation="False" CommandArgument='<%# Eval("ingredientsID") %>' />
                            <asp:Label ID="lblIngredientName" runat="server" Text='<%# Eval("ingredientsName") %>'></asp:Label>
                        </ItemTemplate>

                    </asp:DataList>
                </ContentTemplate>
            </asp:UpdatePanel>
            <asp:Button ID="btnCancel" runat="server" Text="Cancel Item" OnClick="btnCancel_Click" CssClass="btn btn-default"/>
            <asp:Button ID="btnAddToCart" runat="server" Text="Add To Cart" OnClick="btnAddToCart_Click" CssClass="btn btn-primary" />
        </div>
    </div>
    </form>
</body>
</html>