<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="guestHomePage.aspx.cs" Inherits="Project_PSD.Views.generalHomePage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>HOME PAGE</title>
</head>
<body>
    <form id="guestHomePage" runat="server">
        <div>
            <h1>WELCOME TO RAiso!</h1>
            <div class="navigation-bar">
                <asp:LinkButton ID="homeButton" runat="server" OnClick="homeButton_Click">Home</asp:LinkButton><br />
                <asp:LinkButton ID="loginButton" runat="server" OnClick="loginButton_Click">Log In</asp:LinkButton><br />
                <asp:LinkButton ID="registerButton" runat="server" OnClick="registerButton_Click">Register</asp:LinkButton><br />
            </div>

             <h2>Stationery List</h2>

             <asp:GridView ID="StationeryGridView" runat="server" AutoGenerateColumns="False">
                 <Columns>
                     <asp:BoundField DataField="StationeryName" HeaderText="NAME" SortExpression="StationeryName" />
                     <asp:BoundField DataField="StationeryPrice" HeaderText="PRICE" SortExpression="StationeryPrice" />
                 </Columns>
             </asp:GridView>
        </div>
    </form>
</body>
</html>
