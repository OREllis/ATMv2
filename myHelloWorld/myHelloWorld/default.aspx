<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="myHelloWorld._default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>My Hello World</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        
        <asp:Button ID="btnClickMe" runat="server" OnClick="btnClickMe_Click" Text="Click Me" />
&nbsp;
        <asp:Label ID="lblOutput" runat="server" Text="Display output"></asp:Label>
        
    </div>
    </form>
</body>
</html>
