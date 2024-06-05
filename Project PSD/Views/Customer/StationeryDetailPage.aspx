<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StationeryDetailPage.aspx.cs" Inherits="Project_PSD.Views.Customer.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>STATIONERY DETAIL</title>
</head>
<body>
    <form id="stationeryDetail" runat="server">
        <h1>Stationery's Detail</h1>
        <div>
            <asp:Label ID="Label1" runat="server" Text="Name: "></asp:Label>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox><br />

            <asp:Label ID="Label2" runat="server" Text="Price: "></asp:Label>
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>            
        </div>
        <asp:Button ID="addToCartButton" runat="server" Text="ADD TO CART" />
    </form>
</body>
</html>
