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
        <%-- change "checkout" button to "add to cart" and add a "view cart" button --%>
        <asp:Button ID="btnCheckout" runat="server" OnClick="btnCheckout_Click" Text="Checkout" />
        <br />
        <asp:DataList ID="DataList1" runat="server" DataSourceID="SqlDataSource1">
            <ItemTemplate>
                <asp:TextBox ID="txtBxIngredientQuantity" runat="server" MaxLength="2" Width="25px" TextMode="Number"></asp:TextBox>
                <asp:Image ID="imgIngredient" runat="server" /><%-- img source will come from ingredient table --%>
                <asp:Label ID="lblName" runat="server" Text='<%# Eval("ingredientsName") %>'></asp:Label>
                <asp:RangeValidator ID="rangeValidatorIngredientQuantity" runat="server" ErrorMessage="Quantity must be between 0 and [max]" CssClass="text-danger" Display="Dynamic" MaximumValue="30" MinimumValue="0" Type="Integer"></asp:RangeValidator>
            </ItemTemplate>
        </asp:DataList>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:TacoSuccessDb %>" ProviderName="<%$ ConnectionStrings:TacoSuccessDb.ProviderName %>" SelectCommand="SELECT ingredientsName from ingredients"></asp:SqlDataSource>
    </div>
    </form>
</body>
</html>
