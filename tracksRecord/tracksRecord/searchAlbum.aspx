<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="searchAlbum.aspx.cs" Inherits="tracksRecord.searchAlbum" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        Enter the Album&#39;s Name<br />
        <br />
        <asp:TextBox ID="txtAlbumName" runat="server"></asp:TextBox>
        <br />
        <br />
        <br />
        <asp:Button ID="btnAlbumSearch" runat="server" OnClick="Button1_Click" Text="Search for Album" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnToMain" runat="server" OnClick="btnToMain_Click" Text="Back To Main" />
        <br />
        <br />
        <br />
        <br />
        Album Name&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Album Tracks<br />
        <asp:Label ID="lblAlbumName" runat="server" Text="______"></asp:Label>
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:ListBox ID="lstAlbumTracks" runat="server" Height="98px" OnSelectedIndexChanged="lstAlbumTracks_SelectedIndexChanged" Width="147px"></asp:ListBox>
    
    </div>
    </form>
</body>
</html>
