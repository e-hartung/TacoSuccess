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
            <asp:Label ID="lblEntree" runat="server" Text="" CssClass="h2"></asp:Label>
            <h3>Ingredients</h3>
            <asp:DataList ID="DataList2" runat="server" DataSourceID="SqlDataSource3">
                <ItemTemplate>
                    <%-- may need to do this differently so that additional ingredients can be added --%>
                    <asp:TextBox ID="txtBxSelectedIngredientQuantity" runat="server" MaxLength="2" Width="40px" TextMode="Number"></asp:TextBox>
                    <asp:Image ID="imgSelectedIngredient" runat="server" /><%-- img source will come from ingredient table --%>
                    <asp:Label ID="lblSelectedName" runat="server" Text='<%# Eval("ingredientsName") %>'></asp:Label>
                    <asp:RangeValidator ID="rangeValidatorIngredientQuantity" runat="server" ErrorMessage="Quantity must be between 0 and [max]" CssClass="text-danger" Display="Dynamic" MaximumValue="30" MinimumValue="0" Type="Integer" ControlToValidate="txtBxSelectedIngredientQuantity"></asp:RangeValidator>
                </ItemTemplate>
            </asp:DataList>

            <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString='<%$ ConnectionStrings:TacoSuccessDb %>' ProviderName='<%$ ConnectionStrings:TacoSuccessDb.ProviderName %>'></asp:SqlDataSource>
            <asp:SqlDataSource ID="SqlDataSource3" runat="server" ConnectionString="<%$ ConnectionStrings:TacoSuccessDb %>" ProviderName="<%$ ConnectionStrings:TacoSuccessDb.ProviderName %>"></asp:SqlDataSource>
        </div>

        <div class="add-ingredients">
            <h2>Add Additional Items</h2>
            <asp:DataList ID="DataList1" runat="server" DataSourceID="SqlDataSource1" RepeatColumns="2">
            <ItemTemplate>
                <asp:Button ID="btnAddIngredient" runat="server" Text="+" />
                <asp:Image ID="imgIngredient" runat="server" /><%-- img source will come from ingredient table --%>
                <asp:Label ID="lblName" runat="server" Text='<%# Eval("ingredientsName") %>'></asp:Label>
            </ItemTemplate>
            </asp:DataList>
            <asp:Button ID="btnCancel" runat="server" Text="Cancel Item" OnClick="btnCancel_Click" CssClass="btn btn-default"/>
            <asp:Button ID="btnAddToCart" runat="server" Text="Add To Cart" OnClick="btnAddToCart_Click" CssClass="btn btn-primary" />
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:TacoSuccessDb %>" ProviderName="<%$ ConnectionStrings:TacoSuccessDb.ProviderName %>"></asp:SqlDataSource>
        </div>
    </div>
    </form>
</body>
</html>
