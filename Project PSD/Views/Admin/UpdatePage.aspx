<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UpdatePage.aspx.cs" Inherits="Project_PSD.Views.Admin.UpdatePage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>UPDATE SATIONERY</title>
</head>
<body>
    <form id="updateForm" runat="server">
        <h1>Update Stationery</h1>

        <div>
            <asp:Label ID="nameLbl" runat="server" Text="Name:"></asp:Label>
            <asp:TextBox ID="nameBox" runat="server"></asp:TextBox>
        </div>

        <div>
            <asp:Label ID="priceLbl" runat="server" Text="Price"></asp:Label>
            <asp:TextBox ID="priceBox" runat="server"></asp:TextBox>
        </div>

        <asp:Button ID="updateButton" runat="server" Text="UPDATE" OnClick="updateButton_Click" />
    </form>
</body>
</html>
