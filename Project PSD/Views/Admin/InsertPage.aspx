<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="InsertPage.aspx.cs" Inherits="Project_PSD.Views.Admin.InsertPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>INSERT STATIONERY</title>
</head>
<body>
    <form id="insertForm" runat="server">
        <h1>Insert The Stationery Here!</h1>
        <div>
            <asp:Label ID="nameLbl" runat="server" Text="Name:"></asp:Label>
            <asp:TextBox ID="nameBox" runat="server"></asp:TextBox>
        </div>

        <div>
            <asp:Label ID="priceLbl" runat="server" Text="Price:"></asp:Label>
            <asp:TextBox ID="priceBox" runat="server"></asp:TextBox>
        </div><br />

        <asp:Button ID="addButton" runat="server" Text="ADD" OnClick="addButton_Click" />
    </form>
</body>
</html>
