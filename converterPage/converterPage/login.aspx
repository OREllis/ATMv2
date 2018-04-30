<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="converterPage.login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login Screen</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="lblTitle" runat="server" Text="Login Screen"></asp:Label>
        <br />
        <br />
        Username<br />
        <asp:TextBox ID="username_txt" runat="server" Width="199px"></asp:TextBox>
        <br />
        <br />
        Password<br />
        <asp:TextBox ID="password_txt" runat="server" Width="199px"></asp:TextBox>
        <br />
        <br />
        <br />
        <asp:Button ID="login_btn" runat="server" Text="Login" Height="38px" OnClick="login_btn_Click" Width="76px" />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnRegister" runat="server" Text="Register" Height="38px" Width="76px" OnClick="btnRegister_Click" />
        <br />
    
    </div>
    </form>
</body>
</html>
