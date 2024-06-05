<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="customerHomePage.aspx.cs" Inherits="Project_PSD.Views.Customer.customerHomePage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>CUSTOMER PAGE</title>
</head>
<body>
    <form id="form1" runat="server">
        <h1>WELCOME TO RAiso!</h1>
        <div class="navigation-bar">
            <asp:LinkButton ID="homeButton" runat="server" OnClick="homeButton_Click">Home</asp:LinkButton><br />
            <asp:LinkButton ID="cartButton" runat="server" OnClick="cartButton_Click">Cart</asp:LinkButton><br />
            <asp:LinkButton ID="transactionButton" runat="server" OnClick="transactionButton_Click">Transaction</asp:LinkButton><br />
            <asp:LinkButton ID="profileButton" runat="server" OnClick="profileButton_Click">Profile</asp:LinkButton><br />
            <asp:LinkButton ID="logoutButton" runat="server" OnClick="logoutButton_Click">Log Out</asp:LinkButton><br />
        </div>

        <asp:GridView ID="StationeryGridView" runat="server" AutoGenerateColumns="False" OnSelectedIndexChanged="StationeryGridView_SelectedIndexChanged">
            <Columns>
                <asp:BoundField DataField="StationeryName" HeaderText="NAME" SortExpression="StationeryName" />
                <asp:BoundField DataField="StationeryPrice" HeaderText="PRICE" SortExpression="StationeryPrice" />
                <asp:ButtonField ButtonType="Button" CommandName="Select" Text="SELECT" />
            </Columns>
        </asp:GridView>
      
    </form>
</body>
</html>
