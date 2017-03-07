<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Products.aspx.cs" Inherits="TacoSuccess.Products" %>

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
        <asp:DataList ID="dtlProducts" runat="server">
            <ItemTemplate>
                <asp:ImageButton ID="ibtnProduct" runat="server" ImageUrl='<%# Eval("imagePath","~/Images/{0}") %>' PostBackUrl='<%# Eval("entreeID","~/Ingredients.aspx?entree={0}") %>' Width="200px" />
                <asp:HyperLink ID="lnkProduct" runat="server" NavigateUrl='<%# Eval("entreeID","~/Ingredients.aspx?entree={0}") %>'><%# Eval("entreeName") %></asp:HyperLink>
            </ItemTemplate>
        </asp:DataList>  
        <%--<asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:TacoSuccessDb %>" ProviderName="<%$ ConnectionStrings:TacoSuccessDb.ProviderName %>" SelectCommand="SELECT entreeName FROM entree WHERE categoryID = ?">
            <SelectParameters>
                <asp:QueryStringParameter Name="categoryID" QueryStringField="category" Type="Int32" />
            </SelectParameters>
        </asp:SqlDataSource>--%>
        <!--<asp:Button ID="btnCart" runat="server" OnClick="btnCart_Click" Text="Cart" Visible="False" />-->
    
    </div>
    </form>
</body>
</html>
