<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegisterPage.aspx.cs" Inherits="Project_PSD.Views.RegisterPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>REGISTER</title>
</head>
<body>
    <form id="registerForm" runat="server">
        <div class="register-section">
            <div class="name-properties">
                <asp:Label ID="nameLabel" runat="server" Text="Name"></asp:Label><br />
                <asp:TextBox ID="nameBox" runat="server"></asp:TextBox>
            </div>

            <div class="dob-properties">
                <asp:Label ID="dobLabel" runat="server" Text="Date of Birth"></asp:Label><br />
                <asp:Calendar ID="Calendar1" runat="server"></asp:Calendar>
            </div>

            <div class="gender-properties">
                <asp:Label ID="genderLabel" runat="server" Text="Gender"></asp:Label><br />
                <asp:RadioButtonList ID="RadioButtonList1" runat="server">
                    <asp:ListItem>Male</asp:ListItem>
                    <asp:ListItem>Female</asp:ListItem>
                </asp:RadioButtonList>
            </div>

            <div class="address-properties">
                <asp:Label ID="addressLabel" runat="server" Text="Address"></asp:Label><br />
                <asp:TextBox ID="addressBox" runat="server"></asp:TextBox>
            </div>

            <div class="createpassword-properties">
                <asp:Label ID="passwordLabel" runat="server" Text="Password"></asp:Label><br />
                <asp:TextBox ID="passBox" runat="server" TextMode="Password"></asp:TextBox>
                <asp:Label ID="ValidationLabel" runat="server" Text="" ForeColor="Red"></asp:Label>
            </div>

            <div class="phone-properties">
                <asp:Label ID="phoneLabel" runat="server" Text="Phone Number"></asp:Label><br />
                <asp:TextBox ID="phoneBox" runat="server"></asp:TextBox>
            </div>

            <div>
                <asp:DropDownList ID="RoleList" runat="server">
                    <asp:ListItem>Admin</asp:ListItem>
                    <asp:ListItem>Customer</asp:ListItem>
                    <asp:ListItem>Guest</asp:ListItem>
                </asp:DropDownList>

            </div>

            <asp:Label ID="haveaccLbl" runat="server" Text="Have an account?"></asp:Label>
            <asp:LinkButton ID="loginLinkButton" runat="server" OnClick="loginLinkButton_Click">Log In</asp:LinkButton><br />
            <asp:Button ID="registerButton" runat="server" Text="REGISTER" OnClick="registerButton_Click" />

            </div>
       
    </form>
</body>
</html>
