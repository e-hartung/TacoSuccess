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
        <div class="header">
            <asp:Label ID="lblCheckoutHeader" runat="server" Text="Payment Info" CssClass="h2"></asp:Label>
            <asp:Button ID="btnBack" runat="server" OnClick="btnBack_Click" Text="Prev" CausesValidation="False" />
            <asp:Button ID="btnCart" runat="server" Text="Cart" OnClick="btnCart_Click" CausesValidation="False" />
        </div>
        <div>
            <asp:Label ID="lblFirstName" runat="server" Text="First Name:"></asp:Label><asp:TextBox ID="txtBxFirstName" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="requiredValidatorFirstName" runat="server" ErrorMessage="Required" ControlToValidate="txtBxFirstName" Display="Dynamic" CssClass="text-danger"></asp:RequiredFieldValidator>
            <br />
            <asp:Label ID="lblMiddleName" runat="server" Text="Middle Name:"></asp:Label><asp:TextBox ID="txtBxMiddleName" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="lblLastName" runat="server" Text="Last Name:"></asp:Label><asp:TextBox ID="txtBxLastName" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="requiredValidatorLastName" runat="server" ErrorMessage="Required" ControlToValidate="txtBxLastName" Display="Dynamic" CssClass="text-danger"></asp:RequiredFieldValidator>
            <br />
        </div>
        <div>
            <asp:Label ID="lblCardNumber" runat="server" Text="Card Number:"></asp:Label><asp:TextBox ID="txtBxCardNumber" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="requiredValidatorCardNumber" runat="server" ErrorMessage="Required" ControlToValidate="txtBxCardNumber" Display="Dynamic" CssClass="text-danger"></asp:RequiredFieldValidator>
            <br />
            <asp:Label ID="lblExpirationDate" runat="server" Text="Exp Date:"></asp:Label><asp:DropDownList ID="ddlMonth" runat="server"></asp:DropDownList><asp:DropDownList ID="ddlYear" runat="server"></asp:DropDownList>
            <asp:Label ID="lblExpiredMessage" runat="server" CssClass="text-danger"></asp:Label>
            <br />
            <asp:Label ID="lblCVV2" runat="server" Text="CVV2:"></asp:Label><asp:TextBox ID="txtBxCVV2" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="requiredValidatorCVV2" runat="server" ErrorMessage="Required" ControlToValidate="txtBxCVV2" Display="Dynamic" CssClass="text-danger"></asp:RequiredFieldValidator>
        </div>
        <div>
            <asp:Label ID="lblAddressLine1" runat="server" Text="Address Line 1:"></asp:Label><asp:TextBox ID="txtBxAddressLine1" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="requiredValidatorAddressLine1" runat="server" ErrorMessage="Required" ControlToValidate="txtBxAddressLine1" Display="Dynamic" CssClass="text-danger"></asp:RequiredFieldValidator>
            <br />
            <asp:Label ID="lblAddressLine2" runat="server" Text="Address Line 2:"></asp:Label><asp:TextBox ID="txtBxAddressLine2" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="lblCity" runat="server" Text="City:"></asp:Label><asp:TextBox ID="txtBxCity" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="lblState" runat="server" Text="State:"></asp:Label><asp:TextBox ID="txtBxState" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="lblZip" runat="server" Text="Zip Code:"></asp:Label><asp:TextBox ID="txtBxZip" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="lblPhone" runat="server" Text="Phone Number:"></asp:Label><asp:TextBox ID="txtBxPhone" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="requiredValidatorPhone" runat="server" ErrorMessage="Required" ControlToValidate="txtBxPhone" Display="Dynamic" CssClass="text-danger"></asp:RequiredFieldValidator>
        </div>
        <div>
            <asp:Button ID="btnCancel" runat="server" Text="Cancel Order" OnClick="btnCancel_Click" CausesValidation="False" />
            <asp:Button ID="btnSubmit" runat="server" Text="Process Payment" OnClick="btnSubmit_Click" />
        </div>
    </form>
</body>
</html>
