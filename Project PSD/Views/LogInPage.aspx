<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LogInPage.aspx.cs" Inherits="Project_PSD.Views.LogInPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>LOG IN PAGE</title>
</head>
<body>
    <form id="LoginForm" runat="server">
        <div class="login-section">
            <h1>LOG IN</h1>
            <div class="name-properties">
                <asp:Label ID="nameLabel" runat="server" Text="Name"></asp:Label>
                <asp:TextBox ID="nameBox" runat="server"></asp:TextBox>
            </div> 
            <div class="password-properties">
                 <asp:Label ID="passwordLabel" runat="server" Text="Password"></asp:Label>
                 <asp:TextBox ID="passwordBox" runat="server" TextMode="Password"></asp:TextBox>
            </div>
            <div class="remember-me-checkbox">
                <asp:CheckBox ID="rememberCheckBox" runat="server" Text="Remember Me" /><br/>
            </div>
            <div>
                <asp:Label ID="ErrorLabel" runat="server" Text="" ForeColor="DarkRed"></asp:Label>
            </div>
            <div class="login-button">
                <asp:Button ID="loginButton" runat="server" Text="LOG IN" OnClick="loginButton_Click"/>
            </div>
            
            Dont't have an account?<asp:LinkButton ID="toRegisterPage" runat="server" OnClick="toRegisterPage_Click">Register here!</asp:LinkButton>
            
        </div>
    </form>
</body>
</html>
