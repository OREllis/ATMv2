<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="searchTrack.aspx.cs" Inherits="tracksRecord.searchTrack" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        Enter the Track&#39;s Name&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Enter the album to search<br />
        <br />
        <asp:TextBox ID="txtTrackName" runat="server"></asp:TextBox>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtAlbum" runat="server"></asp:TextBox>
        <br />
        <br />
        <br />
        <asp:Button ID="btnTrackSearch" runat="server" OnClick="Button1_Click" Text="Search for Track" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnBackToMain" runat="server" OnClick="btnToMain_Click" Text="Back To Main" />
        <br />
        <br />
        <asp:Label ID="lblResult" runat="server" Text="Label"></asp:Label>
        <br />
        <br />
    
    </div>
    </form>
</body>
</html>
