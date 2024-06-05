<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CartPage.aspx.cs" Inherits="Project_PSD.Views.Customer.CartPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>CART</title>
</head>
<body>
    <form id="cartForm" runat="server">
        <div>
            <h1>This Is Your Cart</h1>

            <asp:GridView ID="CartGridView" runat="server" AutoGenerateColumns="False" OnSelectedIndexChanged="CartGridView_SelectedIndexChanged">
                <Columns>
                    <asp:BoundField HeaderText="Name" />
                    <asp:BoundField HeaderText="Price" />
                    <asp:BoundField HeaderText="Quantity" />
                    <asp:ButtonField ButtonType="Button" CommandName="Update" Text="UPDATE" />
                    <asp:ButtonField ButtonType="Button" CommandName="Delete" Text="REMOVE" />
                </Columns>
            </asp:GridView>
            <br />
            <asp:Button ID="coButotn" runat="server" Text="CHECKOUT" />

        </div>
    </form>
</body>
</html>
