<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="addAlbum.aspx.cs" Inherits="tracksRecord.addAlbum" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form2" runat="server">
    <div>
    
        Enter Album Name<br />
        <br />
        <asp:TextBox ID="txtTrackAlbum" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="btnAddAlbum" runat="server" OnClick="btnAddTrack_Click" Text="Add Album" />
    
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnToMain" runat="server" OnClick="btnToMain_Click" Text="Back To Main" />
    
    </div>
    </form>
</body>
</html>
