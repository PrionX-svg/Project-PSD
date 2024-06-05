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
            <asp:GridView ID="StaioneryDetailGridView" runat="server" AutoGenerateColumns="False">
                <Columns>
                    <asp:BoundField HeaderText="Name" />
                    <asp:BoundField HeaderText="Price" />
                </Columns>
            </asp:GridView>
             <asp:Label ID="qtyLbl" runat="server" Text="Quantity = "></asp:Label>
             <asp:TextBox ID="qtyBox" runat="server"></asp:TextBox>   
        </div>
        <asp:Button ID="addToCartButton" runat="server" Text="ADD TO CART" OnClick="addToCartButton_Click"/><br />
    </form>
</body>
</html>
